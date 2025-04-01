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

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetails : Form
    {
        private readonly IHardwareBrands hardwareBrands;
        private readonly IHardwareDetails hardwareDetails;
        private readonly Dictionary<System.Windows.Forms.TextBox, int> BrandMap;
        private readonly Dictionary<System.Windows.Forms.TextBox, int> DetailMap;
        private readonly int _computerId;
        private readonly IComputerHardwareSaveService saveService;
        private readonly IDatabaseContext database;

        public FrmComputerDetails(IHardwareBrands hardwareBrands, IHardwareDetails hardwareDetails, int computerId , IComputerHardwareSaveService saveService , IDatabaseContext database)
        {
            InitializeComponent();
            this.hardwareBrands = hardwareBrands;
            this.hardwareDetails = hardwareDetails;
            _computerId = computerId;
            this.saveService = saveService;
            this.database = database;
            DetailMap = new Dictionary<System.Windows.Forms.TextBox, int>
        {
            { txtCPUDetail, 2},       // CPU
            //{ txtMotherboardBrand, 1 }, // Motherboard
            //{ txtRAMBrand, 3 },       // RAM
            //{ txtGPUBrand, 4 },       // GPU
            //{ txtStorageBrand, 5 }    // HDD/SSD
        };
            BrandMap = new Dictionary<System.Windows.Forms.TextBox, int>
        {
            { txtCPUBrand, 2 },       // CPU
            //{ txtMotherboardBrand, 1 }, // Motherboard
            //{ txtRAMBrand, 3 },       // RAM
            //{ txtGPUBrand, 4 },       // GPU
            //{ txtStorageBrand, 5 }    // HDD/SSD
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
            foreach (var entry in BrandMap)
            {
                BrandAutoComplete(entry.Key, entry.Value);
            }
            foreach (var entry in DetailMap)
            {
                DetailAutoComplete(entry.Key, entry.Value);
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



    }
}
