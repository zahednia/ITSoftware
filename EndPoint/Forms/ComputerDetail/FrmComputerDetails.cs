using ApplicationIT.Service.HardwareService.HardwareDetail;
using ApplicationIT.Service.HardwareService.HardwareBrand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationIT.Service.HardwareService.SaveService;
using Microsoft.EntityFrameworkCore;
using ApplicationIT.Database;
using ApplicationIT.Service.HardwareService.ShowHardware;
using ApplicationIT.Service.HardwareService.HardwareHistory;
using Domain.Entities;
using ApplicationIT.Service.User.AssignUserToComputer;
using ApplicationIT.Service.User.ShowUser;
using ApplicationIT.Service.User.UserComputerHistory;
using ApplicationIT.Service.User.UserComputerHistoryService;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetails : Form
    {
        private readonly IHardwareBrands hardwareBrands;
        private readonly IHardwareDetails hardwareDetails;
        private readonly Dictionary<ComboBox, int> BrandMap;
        private readonly Dictionary<ComboBox, int> DetailMap;
        private readonly Dictionary<Label, int> labelMap;
        private int _computerId;
        private readonly IComputerHardwareSaveService saveService;
        private readonly IDatabaseContext database;
        private readonly IComputerHardwareQueryService hardwareQueryService;
        private readonly IComputerHardwareHistoryService historyService;
        private readonly IUserShowService userShowService;
        private readonly IUserComputerAssignService assignService;
        private readonly IUserHistoryService userHistoryService;

        public FrmComputerDetails(IHardwareBrands hardwareBrands, IHardwareDetails hardwareDetails, int computerId, IComputerHardwareSaveService saveService, IDatabaseContext database, IComputerHardwareQueryService hardwareQueryService, IComputerHardwareHistoryService historyService, IUserShowService userShowService, IUserComputerAssignService assignService, IUserHistoryService userHistoryService)
        {
            InitializeComponent();
            this.hardwareBrands = hardwareBrands;
            this.hardwareDetails = hardwareDetails;
            _computerId = computerId;
            this.saveService = saveService;
            this.database = database;
            this.hardwareQueryService = hardwareQueryService;
            this.historyService = historyService;
            this.userShowService = userShowService;
            this.assignService = assignService;
            this.userHistoryService = userHistoryService;

            BrandMap = new Dictionary<ComboBox, int>
            {
                { CBCPUBrand, 2 },
                { CBMotherBoardBrand, 1 },
                { CBRamBrand, 3 },
                { CBGPUBrand, 6 },
                { CBHDDBrand, 4 },
                { CBSSDBrand, 5 },
            };

            DetailMap = new Dictionary<ComboBox, int>
            {
                { CBCPUDetail, 2 },
                { CBMotherBoardDetail, 1 },
                { CBRamDetail, 3 },
                { CBGPUDetail, 6 },
                { CBHDDDetail, 4 },
                { CBSSDDetail, 5 },
            };

            labelMap = new Dictionary<Label, int>
            {
                { lblHCPU, 2 },
                { lblHMotherBoard, 1 },
                { lblHRAM, 3 },
                { lblHHDD, 4 },
                { lblHSSD, 5 },
                { lblHGPU, 6 },
            };
        }

        private void FrmComputerDetails_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUserHistoryCount();
            LoadComboBoxes();

            foreach (var pair in labelMap)
            {
                var count = historyService.CountHistory(_computerId, pair.Value);
                pair.Key.Text = $"سابقه: {count}";
                pair.Key.Visible = count > 0;
            }

            var computer = database.Computers.FirstOrDefault(c => c.Id == _computerId);
            if (computer != null)
            {
                txtCode.Text = computer.Code;
                txtName.Text = computer.Name;
            }

            var hardwareList = hardwareQueryService.GetHardwareListForComputer(_computerId);

            foreach (var hw in hardwareList)
            {
                var brandCombo = BrandMap.FirstOrDefault(x => x.Value == hw.HardwareTypeId).Key;
                var detailCombo = DetailMap.FirstOrDefault(x => x.Value == hw.HardwareTypeId).Key;

                if (brandCombo != null)
                    brandCombo.SelectedItem = hw.Brand;

                if (detailCombo != null)
                    detailCombo.SelectedItem = hw.Detail;
            }
        }

        private void LoadComboBoxes()
        {
            foreach (var brandEntry in BrandMap)
            {
                int typeId = brandEntry.Value;
                var brands = hardwareBrands.GetBrands(typeId);
                brandEntry.Key.DropDownStyle = ComboBoxStyle.DropDown;
                brandEntry.Key.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                brandEntry.Key.AutoCompleteSource = AutoCompleteSource.ListItems;
                brandEntry.Key.Items.Clear();
                brandEntry.Key.Items.AddRange(brands.ToArray());
            }

            foreach (var detailEntry in DetailMap)
            {
                int typeId = detailEntry.Value;
                var details = hardwareDetails.GetDetail(typeId);
                detailEntry.Key.DropDownStyle = ComboBoxStyle.DropDown;
                detailEntry.Key.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                detailEntry.Key.AutoCompleteSource = AutoCompleteSource.ListItems;
                detailEntry.Key.Items.Clear();
                detailEntry.Key.Items.AddRange(details.ToArray());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveComputerIfNew();

            var existingHardwareList = hardwareQueryService.GetHardwareListForComputer(_computerId);
            bool hardwareSaved = false;
            bool userAssigned = false;
            var errorMessages = new List<string>();

            foreach (var cb in BrandMap.Keys.Concat(DetailMap.Keys))
                cb.BackColor = SystemColors.Window;

            foreach (var detailEntry in DetailMap)
            {
                var detailCombo = detailEntry.Key;
                int typeId = detailEntry.Value;

                var brandCombo = BrandMap.FirstOrDefault(x => x.Value == typeId).Key;

                if (brandCombo == null || string.IsNullOrWhiteSpace(detailCombo.Text) || string.IsNullOrWhiteSpace(brandCombo.Text))
                    continue;

                var hardwareType = database.HardwareTypes.FirstOrDefault(t => t.Id == typeId);
                if (hardwareType == null)
                    continue;

                bool brandValid = brandCombo.Items.Cast<string>().Any(x => x.Equals(brandCombo.Text, StringComparison.OrdinalIgnoreCase));
                bool detailValid = detailCombo.Items.Cast<string>().Any(x => x.Equals(detailCombo.Text, StringComparison.OrdinalIgnoreCase));

                if (!brandValid)
                {
                    brandCombo.BackColor = Color.MistyRose;
                    errorMessages.Add($"مقدار برند وارد شده برای {hardwareType.Type} معتبر نیست.");
                }

                if (!detailValid)
                {
                    detailCombo.BackColor = Color.MistyRose;
                    errorMessages.Add($"مقدار مشخصات وارد شده برای {hardwareType.Type} معتبر نیست.");
                }

                if (!brandValid || !detailValid)
                    continue;

                var currentHardware = existingHardwareList.FirstOrDefault(h => h.HardwareTypeId == typeId);
                bool isChanged = currentHardware == null ||
                                 currentHardware.Brand != brandCombo.Text ||
                                 currentHardware.Detail != detailCombo.Text;

                if (!isChanged)
                    continue;

                var dto = new SaveHardwareToComputerDto
                {
                    ComputerId = _computerId,
                    HardwareType = hardwareType.Type,
                    HardwareBrand = brandCombo.Text,
                    HardwareDetail = detailCombo.Text
                };

                saveService.SaveHardwareToComputer(dto);
                hardwareSaved = true;
            }

            if (errorMessages.Any())
            {
                MessageBox.Show(string.Join("\n", errorMessages), "خطا در اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUsers.SelectedItem != null)
            {
                var selectedUserId = (int)cmbUsers.SelectedValue;
                var dtoo = new AssignUserToComputerDto
                {
                    ComputerId = _computerId,
                    UserId = selectedUserId
                };
                assignService.AssignUserToComputer(dtoo);
                userAssigned = true;
            }

            if (hardwareSaved || userAssigned)
            {
                MessageBox.Show("اطلاعات با موفقیت ذخیره شدند.");
            }
            else
            {
                MessageBox.Show("هیچ اطلاعاتی ذخیره نشد. لطفاً مقادیر صحیح را انتخاب کنید.");
            }
        }



        private void SaveComputerName()
        {
            var computer = database.Computers.FirstOrDefault(c => c.Id == _computerId);
            if (computer != null)
            {
                computer.Name = txtName.Text;
                computer.Code = txtCode.Text;
                database.SaveChanges();
            }
        }

        private void SaveComputerIfNew()
        {
            if (_computerId == 0)
            {
                var computer = new Computer
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    CreatedAt = DateTime.UtcNow
                };
                database.Computers.Add(computer);
                database.SaveChanges();

                _computerId = computer.Id;
            }
        }

        private void btnSmallSave_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem != null)
            {
                var selectedUserId = (int)cmbUsers.SelectedValue;
                var dto = new AssignUserToComputerDto
                {
                    ComputerId = _computerId,
                    UserId = selectedUserId
                };
                assignService.AssignUserToComputer(dto);
            }
            SaveComputerName();
            MessageBox.Show("نام و کد ذخیره شد");
        }

        private void LoadUsers()
        {
            var users = userShowService.Execute();
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Id";
            cmbUsers.DataSource = users;

            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_computerId > 0)
            {
                var userId = database.UserComputers
                    .Where(x => x.ComputerID == _computerId && !x.IsDeactive)
                    .Select(x => x.UserID)
                    .FirstOrDefault();

                if (userId != 0)
                {
                    cmbUsers.SelectedValue = userId;
                }
            }
        }

        private void LoadUserHistoryCount()
        {
            int count = userHistoryService.CountUserComputerHistory(_computerId);
            lblUserHistoryCount.Text = $"سابقه کاربران: {count}";
            lblUserHistoryCount.Visible = count > 0;
        }

        private void lblUserHistoryCount_Click(object sender, EventArgs e)
        {
            var form = new FrmUserHistory(_computerId, userHistoryService);
            form.ShowDialog();
        }

        private void ShowHardwareHistory(int hardwareTypeId)
        {
            var history = historyService.GetHistory(_computerId, hardwareTypeId);

            if (history == null || history.Count == 0)
            {
                MessageBox.Show("هیچ سابقه‌ای برای این قطعه ثبت نشده است.");
                return;
            }

            var form = new FrmHardwareHistory(history);
            form.ShowDialog();
        }

        private void lblHMotherBoard_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(1);
        }

        private void lblHCPU_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(2);
        }

        private void lblHRAM_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(3);
        }

        private void lblHHDD_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(4);
        }

        private void lblHSSD_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(5);
        }

        private void lblHGPU_Click(object sender, EventArgs e)
        {
            ShowHardwareHistory(6);
        }
        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHardware_Click(object sender, EventArgs e)
        {
            FrmHardwareManager frmHardwareManager = new FrmHardwareManager(database);
            frmHardwareManager.ShowDialog();
        }
    }
}
