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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        private readonly Dictionary<System.Windows.Forms.TextBox, int> BrandMap;
        private readonly Dictionary<System.Windows.Forms.TextBox, int> DetailMap;
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
            DetailMap = new Dictionary<System.Windows.Forms.TextBox, int>
        {
            { txtCPUDetail, 2},       // CPU
            { txtMotherBoardDetail, 1 }, // Motherboard
            { txtRamDetail, 3 },       // RAM
            { txtGPUDetail, 6 },       // GPU
            { txtHDDDetail, 4 } ,   // HDD/SSD
            { txtSSDDetail, 5 }    // HDD/SSD
        };
            BrandMap = new Dictionary<System.Windows.Forms.TextBox, int>
        {
            { txtCPUBrand, 2},       // CPU
            { txtMotherBoardBrand, 1 }, // Motherboard
            { txtRamBrand, 3 },       // RAM
            { txtGPUBrand, 6 },       // GPU
            { txtHDDBrand, 4 } ,   // HDD/SSD
            { txtSSDBrand, 5 }    // HDD/SSD
        };

            labelMap = new Dictionary<Label, int>
        {
            { HCPU, 2 },
            { HMotherBoard, 1 },
            { HRAM, 3 },
            { HHDD, 4 },
            { HSSD, 5 },
            { HGPU, 6 },
        };
        }

        private void DetailAutoComplete(System.Windows.Forms.TextBox textBox, int hardwareTypeId)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var details = hardwareDetails.GetDetail(hardwareTypeId);
            AutoCompleteStringCollection autoCompleteList = new AutoCompleteStringCollection();
            autoCompleteList.AddRange(details.ToArray());
            textBox.AutoCompleteCustomSource = autoCompleteList;
        }
        private void BrandAutoComplete(System.Windows.Forms.TextBox textBox, int hardwareTypeId)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var brands = hardwareBrands.GetBrands(hardwareTypeId);
            AutoCompleteStringCollection autoCompleteList = new AutoCompleteStringCollection();
            autoCompleteList.AddRange(brands.ToArray());
            textBox.AutoCompleteCustomSource = autoCompleteList;
        }

        private void FrmComputerDetails_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUserHistoryCount();
            foreach (var entry in BrandMap)
            {
                BrandAutoComplete(entry.Key, entry.Value);
            }
            foreach (var entry in DetailMap)
            {
                DetailAutoComplete(entry.Key, entry.Value);
            }

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
            //  گرفتن اطلاعات از دیتابیس
            var hardwareList = hardwareQueryService.GetHardwareListForComputer(_computerId);

            foreach (var hw in hardwareList)
            {
                // پیدا کردن TextBox برند مربوط به این نوع
                var brandTextBox = BrandMap.FirstOrDefault(x => x.Value == hw.HardwareTypeId).Key;
                var detailTextBox = DetailMap.FirstOrDefault(x => x.Value == hw.HardwareTypeId).Key;

                if (brandTextBox != null)
                    brandTextBox.Text = hw.Brand;

                if (detailTextBox != null)
                    detailTextBox.Text = hw.Detail;
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var detailEntry in DetailMap)
            {
                var detailTextBox = detailEntry.Key;
                int typeId = detailEntry.Value;

                // پیدا کردن TextBox مربوط به برند با همون TypeId
                var brandPair = BrandMap.FirstOrDefault(x => x.Value == typeId);
                var brandTextBox = brandPair.Key;

                if (brandTextBox == null)
                {
                    MessageBox.Show($"هیچ TextBox مربوط به HardwareTypeId = {typeId} در BrandMap پیدا نشد.");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(detailTextBox.Text) ||
                    string.IsNullOrWhiteSpace(brandTextBox.Text))
                {
                    MessageBox.Show($"فیلد برند یا دیتیل برای HardwareTypeId = {typeId} خالی است.");
                    continue;
                }


                var hardwareType = database.HardwareTypes.FirstOrDefault(t => t.Id == typeId);
                if (hardwareType == null)
                {
                    MessageBox.Show($"HardwareType با Id {typeId} پیدا نشد.");
                    continue;
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
                }
                SaveComputerName();
                SaveComputerIfNew();
                var dto = new SaveHardwareToComputerDto
                {
                    ComputerId = _computerId,
                    HardwareType = hardwareType.Type,
                    HardwareBrand = brandTextBox.Text,
                    HardwareDetail = detailTextBox.Text
                };

                saveService.SaveHardwareToComputer(dto);
            }

            MessageBox.Show("سخت‌افزارهای وارد شده ذخیره شدند.");
        }

        private void HCPU_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 2); // 2 = CPU TypeId
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
        }

        private void HMotherBoard_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 1);
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
        }

        private void HRAM_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 3);
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
        }

        private void HHDD_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 4);
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
        }

        private void HSSD_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 5);
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
        }

        private void HGPU_Click(object sender, EventArgs e)
        {
            var history = historyService.GetHistory(_computerId, 6);
            var frm = new FrmHardwareHistory(history);
            frm.ShowDialog();
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

                _computerId = computer.Id; // خیلی مهم: برای ذخیره قطعات
            }
            else
            {
                var computer = database.Computers.FirstOrDefault(c => c.Id == _computerId);
                if (computer != null)
                {
                    computer.Name = txtName.Text;
                    database.SaveChanges();
                }
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
            var users = userShowService.Execute(); // خروجی: List<UserShowServiceDTO>

            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Id";
            cmbUsers.DataSource = users;

            cmbUsers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUsers.AutoCompleteSource = AutoCompleteSource.ListItems;

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
    }
}
