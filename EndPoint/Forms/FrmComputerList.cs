using ApplicationIT.Database;
using ApplicationIT.Service.ComputerList;
using ApplicationIT.Service.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint.Forms
{
    public partial class FrmComputerList : Form
    {
        private readonly IComputerList computerlist;

        public FrmComputerList(IComputerList computerlist)
        {
            InitializeComponent();
            this.computerlist = computerlist;
        }

        private void DGComputerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmComputerList_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var Computer = computerlist.ComputerLists();
            SettingGridview(Computer);
            Cursor = Cursors.Default;
        }
        private void SettingGridview(List<ComputerListDTO> computerListDTOs)
        {
            DGComputerList.DataSource = computerListDTOs;
            DGComputerList.Columns[0].HeaderText = "ID";
            DGComputerList.Columns[1].HeaderText = "کد کامپیوتر";
            DGComputerList.Columns[0].Width = 40;
            DGComputerList.Columns[1].Width = 229;
        }

        private void BtnSearchComputerList_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var Search = computerlist.ComputerLists(textBox1.Text);
            SettingGridview(Search);
            Cursor = Cursors.Default;
        }
    }
}
