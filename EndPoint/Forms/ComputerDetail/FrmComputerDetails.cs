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

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetails : Form
    {
        private readonly IHardwareBrands hardwareBrands;
        private readonly IHardwareDetails hardwareDetails;
        private readonly Dictionary<System.Windows.Forms.TextBox, int> BrandMap;
        private readonly Dictionary<System.Windows.Forms.TextBox, int> DetailMap;
        public FrmComputerDetails(IHardwareBrands hardwareBrands , IHardwareDetails hardwareDetails)
        {
            InitializeComponent();
            this.hardwareBrands = hardwareBrands;
            this.hardwareDetails = hardwareDetails;

            DetailMap = new Dictionary<System.Windows.Forms.TextBox, int>
        {
            { txtCPUDetail, 2 },       // CPU
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
    }
}
