using ApplicationIT.Service.TimeSheet.TimeSheetSave;
using ApplicationIT.Service.TimeSheet.TimeSheetUser;
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

namespace EndPoint.Forms.ComputerDetail.TimeSheet
{
    public partial class FrmTimeSheet : Form
    {
        private readonly ITimesheetQueryService timesheet;
        private readonly ITimesheetCreateService timesheetCreate;

        public FrmTimeSheet(ITimesheetQueryService timesheet, ITimesheetCreateService timesheetCreate)
        {
            InitializeComponent();
            this.timesheet = timesheet;
            this.timesheetCreate = timesheetCreate;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void FrmTimeSheet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string search = "")
        {
            var service = Program.ServiceProvider.GetService<ITimesheetQueryService>();
            var list = service.GetUsersWithTimesheet(search);
            DGTimeSheet.DataSource = list;
            AddButtonColumn();
        }
        private void AddButtonColumn()
        {
            if (!DGTimeSheet.Columns.Contains("ثبت"))
            {
                var col = new DataGridViewButtonColumn();
                col.Name = "ثبت";
                col.HeaderText = "ثبت بازدید";
                col.Text = "➕";
                col.UseColumnTextForButtonValue = true;
                DGTimeSheet.Columns.Add(col);
            }
        }


        private void DGTimeSheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGTimeSheet.Columns["ثبت"].Index && e.RowIndex >= 0)
            {
                var computerId = (int)DGTimeSheet.Rows[e.RowIndex].Cells["ComputerId"].Value;
                var fullName = DGTimeSheet.Rows[e.RowIndex].Cells["AssignedUserName"].Value?.ToString();


                var form = new FrmAddTimeSheet(computerId, fullName);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(txtSearch.Text.Trim());
                }
            }
        }
    }
}
