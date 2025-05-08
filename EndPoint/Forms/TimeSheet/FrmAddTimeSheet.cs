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
        private readonly int computerId;
        private readonly string _fullName;
        private Button btnSave;

        public FrmAddTimeSheet(int computerId, string fullName)
        {
            InitializeComponent();
            this.computerId = computerId;
            _fullName = fullName;
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
                // گرفتن تاریخ امروز به شمسی
                var today = DateTime.Now;
                int persianYear = persian.GetYear(today);

                // ساخت تاریخ دقیق شمسی از سال فعلی و ماه و روز انتخابی
                DateTime miladi = persian.ToDateTime(persianYear,
                    (int)nudMonth.Value,
                    (int)nudDay.Value,
                    0, 0, 0, 0);

                var service = Program.ServiceProvider.GetService<ITimesheetCreateService>();
                service.Save(computerId, miladi, true);

                MessageBox.Show("✅ تاریخ بازدید با موفقیت ثبت شد.");
                DialogResult = DialogResult.OK;
        }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ثبت تاریخ: " + ex.Message);
            }

}
    }
}

