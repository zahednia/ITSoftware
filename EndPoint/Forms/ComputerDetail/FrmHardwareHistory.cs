using ApplicationIT.Service.ComputerList;
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
            SettingGridview(history);
        }
        private void SettingGridview(List<HardwareHistoryDto> history)
        {
            dataGridView1.DataSource = history;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
        }
    }
}
