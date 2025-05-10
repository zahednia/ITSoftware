using ApplicationIT.Database;
using ApplicationIT.Service.TimeSheet.TimeSheetSave;
using ApplicationIT.Service.TimeSheet.TimeSheetUser;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly IDatabaseContext database;

        public FrmTimeSheet(ITimesheetQueryService timesheet, ITimesheetCreateService timesheetCreate , IDatabaseContext database)
        {
            InitializeComponent();
            this.timesheet = timesheet;
            this.timesheetCreate = timesheetCreate;
            this.database = database;
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

        private void btnGenerateNextYearTimesheets_Click(object sender, EventArgs e)
        {
            GenerateTimesheetsForNextShamsiYear(1404);
        }
        private void GenerateTimesheetsForNextShamsiYear(int sourceShamsiYear)
        {
            var pc = new System.Globalization.PersianCalendar();

            int approxGregorianYear = new PersianCalendar().ToDateTime(sourceShamsiYear, 1, 1, 0, 0, 0, 0).Year;

            var oldItems = database.Timesheets
                .Where(t => t.Date.Year == approxGregorianYear)
                .AsEnumerable()
                .Where(t => pc.GetYear(t.Date) == sourceShamsiYear)
                .ToList();


            foreach (var old in oldItems)
            {
                // مرحله 2: تاریخ جدید = یک سال میلادی جلوتر
                var newDate = old.Date.AddYears(1);

                // مرحله 3: بررسی وجود چک‌لیست در بازه ±15 روز
                bool checklistExists = database.CheckLists
                    .Any(c =>
                        c.ChMain.ComputerId == old.ComputerId &&
                        c.ChMain.CreatedAt >= newDate.AddDays(-15) &&
                        c.ChMain.CreatedAt <= newDate.AddDays(15)
                    );

                // مرحله 4: ساخت تایم‌شیت جدید
                var newTimesheet = new Timesheet
                {
                    ComputerId = old.ComputerId,
                    UserId = database.UserComputers
    .Where(x => x.ComputerID == old.ComputerId && !x.IsDeactive)
    .Select(x => x.UserID)
    .FirstOrDefault(),

                    Date = newDate,
                    IsDone = checklistExists
                };

                database.Timesheets.Add(newTimesheet);
            }

            database.SaveChanges();

            MessageBox.Show("✅ تایم‌شیت‌های سال 1405 با موفقیت ساخته شدند.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
