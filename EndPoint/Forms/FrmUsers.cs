using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationIT.Database;
using ApplicationIT.Service;
using ApplicationIT.Service.ComputerList;
using ApplicationIT.Service.User.ShowUser;

namespace EndPoint.Forms
{
    public partial class FrmUsers : Form
    {
        private readonly IDatabaseContext database;
        private readonly IUserShowService userShowService;
        private IComputerList? serviceAdd;

        public FrmUsers(IUserShowService userShowService)
        {
            InitializeComponent(); ;
            this.userShowService = userShowService;
        }

        public FrmUsers(IComputerList? serviceAdd)
        {
            this.serviceAdd = serviceAdd;
        }

        private void SettingGridview(List<UserShowServiceDTO> userShows)
        {
            DGUsers.DataSource = userShows;
            DGUsers.Columns[0].HeaderText = "ID";
            DGUsers.Columns[1].HeaderText = "نام کامل";
            DGUsers.Columns[2].HeaderText = "تعداد سیستم‌ها";
            DGUsers.Columns[0].Width = 40;
            DGUsers.Columns[1].Width = 229;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var User = userShowService.Execute();
            SettingGridview(User);
            Cursor = Cursors.Default;
        }

        private void DGUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSearchUsers_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var Search = userShowService.Execute(txtSearchUsers.Text);
            SettingGridview(Search);
            Cursor = Cursors.Default;
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var Search = userShowService.Execute(txtSearchUsers.Text);
            SettingGridview(Search);
            Cursor = Cursors.Default;
        }
    }
}
