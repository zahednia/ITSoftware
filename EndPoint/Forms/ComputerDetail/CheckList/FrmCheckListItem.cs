using ApplicationIT.Database;
using ApplicationIT.Service.CheckListService.CheckListCreate;
using EndPoint.Forms.ComputerDetail.AddHardware;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail.CheckList
{
    public partial class FrmCheckListItem : Form
    {
        private readonly IDatabaseContext database;
        private readonly int currentComputerId;

        public FrmCheckListItem(IDatabaseContext database, int currentComputerId)
        {
            InitializeComponent();
            this.database = database;
            this.currentComputerId = currentComputerId;
        }
        private void LoadStatusOptions()
        {
            var statuses = database.ChStatuses.ToList();
            var statusList = statuses.Select(x => new { x.Id, x.Status }).ToList();

            CBFan.DataSource = new BindingSource(statusList, null);
            CBFan.DisplayMember = "Status";
            CBFan.ValueMember = "Id";

            CBHardDisk.DataSource = new BindingSource(statusList, null);
            CBHardDisk.DisplayMember = "Status";
            CBHardDisk.ValueMember = "Id";

            CBMonitor.DataSource = new BindingSource(statusList, null);
            CBMonitor.DisplayMember = "Status";
            CBMonitor.ValueMember = "Id";

            CBCase.DataSource = new BindingSource(statusList, null);
            CBCase.DisplayMember = "Status";
            CBCase.ValueMember = "Id";

            CBAnti.DataSource = new BindingSource(statusList, null);
            CBAnti.DisplayMember = "Status";
            CBAnti.ValueMember = "Id";

            CBOs.DataSource = new BindingSource(statusList, null);
            CBOs.DisplayMember = "Status";
            CBOs.ValueMember = "Id";

            CBCD.DataSource = new BindingSource(statusList, null);
            CBCD.DisplayMember = "Status";
            CBCD.ValueMember = "Id";
        }
        private void LoadInspectors()
        {
            var inspectors = database.Users.Select(x => new { x.Id, x.Name, x.LastName }).ToList();

            CBSurveyor.DataSource = new BindingSource(inspectors, null);
            CBSurveyor.DisplayMember = "LastName";
            CBSurveyor.ValueMember = "Id";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dto = new CheckListCreateDto
            {
                ComputerId = currentComputerId, // اینو قبلاً به فرم پاس دادی
                Detail = txtDetail.Text.Trim(),
                InspectorUserId = Convert.ToInt32(CBSurveyor.SelectedValue),
                Items = new List<CheckListItemDto>
        {
            new CheckListItemDto
            {
                ChTypeId = 1,
                ChStatusId = Convert.ToInt32(CBFan.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 2,
                ChStatusId = Convert.ToInt32(CBHardDisk.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 3,
                ChStatusId = Convert.ToInt32(CBMonitor.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 4,
                ChStatusId = Convert.ToInt32(CBCase.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 5,
                ChStatusId = Convert.ToInt32(CBAnti.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 6,
                ChStatusId = Convert.ToInt32(CBOs.SelectedValue)
            },
            new CheckListItemDto
            {
                ChTypeId = 7,
                ChStatusId = Convert.ToInt32(CBCD.SelectedValue)
            }

        }
            };

            var service = Program.ServiceProvider.GetService<ICheckListCreateService>();
            service.Create(dto);

            MessageBox.Show("چک‌لیست با موفقیت ذخیره شد.");
        }

        private void FrmCheckListItem_Load(object sender, EventArgs e)
        {
            LoadInspectors();
            LoadStatusOptions();
        }
    }
}
