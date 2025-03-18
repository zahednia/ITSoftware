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
        private readonly int id;

        public FrmComputerDetail(IDatabaseContext database , int id)
        {
            InitializeComponent();
            this.database = database;
            this.id = id;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmComputerDetail_Load(object sender, EventArgs e)
        {
            LoadBrands(1,CBMotherboardBrand);
            LoadBrands(2, CBCpuBrand);
            LoadBrands(3, CBRamBrand);
            LoadBrands(4, CBGpuBrand);
            LoadBrands(5, CBHddBrand);

            // تنظیم رویداد برای تغییر برند و پر کردن مدل‌ها
            CBMotherboardBrand.SelectedIndexChanged += (s , ev) => LoadModels(CBMotherboardBrand, CBMotherboardDetail);
            CBCpuBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBCpuBrand, CBCpuDetail);
            CBRamBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBRamBrand, CBRamDetail);
            CBHddBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBHddBrand, CBHddDetail);
            CBGpuBrand.SelectedIndexChanged += (s, ev) => LoadModels(CBGpuBrand, CBGpuDetail);
           
         }
        private void LoadBrands(int hardwareType, ComboBox comboBox)
        {
                var brands = database.HardwareBrands.Where(b => b.HardwareTypeID == hardwareType).ToList();
                comboBox.DataSource = brands;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";

        }

        private void LoadModels(ComboBox brandComboBox, ComboBox modelComboBox)
        {
            if (brandComboBox.SelectedValue != null)
            {
                int selectedBrandId = (int)brandComboBox.SelectedValue;
                    var models = database.HardwareModels.Where(m => m.HardwareBrandId == selectedBrandId).ToList();
                    modelComboBox.DataSource = models;
                    modelComboBox.DisplayMember = "Name";
                    modelComboBox.ValueMember = "Id";
            }
        }


    }
}

