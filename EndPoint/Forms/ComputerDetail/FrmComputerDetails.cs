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

        public FrmComputerDetails(IHardwareBrands hardwareBrands , IHardwareDetails hardwareDetails)
        {
            InitializeComponent();
            this.hardwareBrands = hardwareBrands;
            this.hardwareDetails = hardwareDetails;
        }

        private void FrmComputerDetails_Load(object sender, EventArgs e)
        {
            txtCPUBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCPUBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCompleteList = new AutoCompleteStringCollection();
            autoCompleteList.AddRange(hardwareBrands.GetCpuBrands().ToArray());
            txtCPUBrand.AutoCompleteCustomSource = autoCompleteList;

            txtCPUDetail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCPUDetail.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cpubrandlist = new AutoCompleteStringCollection();
            cpubrandlist.AddRange(hardwareDetails.GetCpuDetail().ToArray());
            txtCPUDetail.AutoCompleteCustomSource = cpubrandlist;
        }
        
        private void txtName_Click(object sender, EventArgs e)
        {

        }
    }
}
