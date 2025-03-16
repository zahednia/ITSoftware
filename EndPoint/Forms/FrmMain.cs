using ApplicationIT.Database;
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
    public partial class FrmMain : Form
    {
        private readonly IDatabaseContext database;

        public FrmMain(ApplicationIT.Service.UserService.IUserShowService? serviceGetList, IDatabaseContext database)
        {

            InitializeComponent();
            this.database = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var serviceAdd = (IUserShowService)Program.ServiceProvider.GetService(typeof(IUserShowService));

            FrmUsers frmUsers = new FrmUsers(serviceAdd);
            frmUsers.ShowDialog();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
