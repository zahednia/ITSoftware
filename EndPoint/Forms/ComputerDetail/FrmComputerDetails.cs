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
        public FrmComputerDetails()
        {
            InitializeComponent();
        }

        private void FrmComputerDetails_Load(object sender, EventArgs e)
        {
            txtCPUBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCPUBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCompleteStringCollection = [.. new string[] { "AMD", "INTEL" }];
            txtCPUBrand.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
        
        private void txtName_Click(object sender, EventArgs e)
        {

        }
    }
}
