using ApplicationIT.Service.HardwareService.History;
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
    public partial class FrmHardwareHistory: Form
    {
        public FrmHardwareHistory(List<HardwareHistoryDto> history)
        {
            InitializeComponent();
            dataGridView1.DataSource = history;
        }
    }
}
