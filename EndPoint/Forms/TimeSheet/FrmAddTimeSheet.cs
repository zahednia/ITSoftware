using ApplicationIT.Service.TimeSheet.TimeSheetSave;
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
    public partial class FrmAddTimeSheet : Form
    {
        private readonly int _userId;
        private readonly string _fullName;
        private Button btnSave;

        public FrmAddTimeSheet(int userId, string fullName)
        {
            InitializeComponent();
            _userId = userId;
            _fullName = fullName;
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            var persian = new System.Globalization.PersianCalendar();
            try
            {
                DateTime miladi = persian.ToDateTime(DateTime.Now.Year,
                    (int)nudMonth.Value,
                    (int)nudDay.Value,
                    0, 0, 0, 0);

                var service = Program.ServiceProvider.GetService<ITimesheetCreateService>();
                service.Save(_userId, miladi, true);

                MessageBox.Show("تاریخ ثبت شد ✅");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در تاریخ: " + ex.Message);
            }
        }

        private void FrmAddTimeSheet_Load(object sender, EventArgs e)
        {
            label1.Text = _fullName;
            nudMonth.Minimum = 1;
            nudMonth.Maximum = 12;
            nudDay.Minimum = 1;
            nudDay.Maximum = 31;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            var persian = new System.Globalization.PersianCalendar();
            try
            {
                DateTime miladi = persian.ToDateTime(DateTime.Now.Year,
                    (int)nudMonth.Value,
                    (int)nudDay.Value,
                    0, 0, 0, 0);

                var service = Program.ServiceProvider.GetService<ITimesheetCreateService>();
                service.Save(_userId, miladi, true);

                MessageBox.Show("تاریخ ثبت شد ✅");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در تاریخ: " + ex.Message);
            }
        }
    }
}

