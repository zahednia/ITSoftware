using ApplicationIT.Database;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetail : Form
    {
        private readonly IDatabaseContext database;

        public FrmComputerDetail(IDatabaseContext database)
        {
            InitializeComponent();
            this.database = database;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmComputerDetail_Load(object sender, EventArgs e)
        {
            LoadBrands("CPU", CBCpuBrand);
            LoadBrands("RAM", CBRamBrand);
            LoadBrands("GPU", CBGpuBrand);
            LoadBrands("HDD", CBHddBrand);

            // تنظیم رویداد برای تغییر برند و پر کردن مدل‌ها
            CBCpuBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBCpuBrand, CBCpuDetail);
            CBRamBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBRamBrand, CBRamDetail);
            CBHddBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBHddBrand, CBHddDetail);
            CBGpuBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBGpuBrand, CBGpuDetail);
           
         }
        private void LoadBrands(string hardwareType, ComboBox comboBox)
        {
            using (var db = new DatabaseContext()) // همون DbContext خودت
            {
                var brands = db.HardwareBrands.Where(b => b.HardwareType == hardwareType).ToList();

                comboBox.DataSource = brands;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";
            }
        }

        private void LoadModels(ComboBox brandComboBox, ComboBox modelComboBox)
        {
            if (brandComboBox.SelectedValue != null)
            {
                int selectedBrandId = (int)brandComboBox.SelectedValue;

                using (var db = new DatabaseContext()) // همون DbContext خودت
                {
                    var models = db.HardwareModels.Where(m => m.HardwareBrandId == selectedBrandId).ToList();

                    modelComboBox.DataSource = models;
                    modelComboBox.DisplayMember = "Name";
                    modelComboBox.ValueMember = "Id";
                }
            }
        }


    }
}

