using ApplicationIT.Database;
using ApplicationIT.Service.ComputerList;
using ApplicationIT.Service.UserService;
using EndPoint.Forms.ComputerDetail;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IComputerList computerList;

        public FrmMain(ApplicationIT.Service.UserService.IUserShowService? serviceGetList, IDatabaseContext database, IComputerList computerList)
        {

            InitializeComponent();
            this.database = database;
            this.computerList = computerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "SNDShowUser":
                    RunFrmUser();
                    break;

                case "SNDComputerList":
                    RunFrmComputer();
                    break;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void computerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunFrmComputer();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunFrmUser();
        }

        private void RunFrmUser()
        {
            var serviceAdd = (IUserShowService)Program.ServiceProvider.GetService(typeof(IUserShowService));
            FrmUsers frmUsers = new FrmUsers(serviceAdd);
            frmUsers.ShowDialog();
        }

        private void RunFrmComputer()
        {
            var computerFrm = Program.ServiceProvider.GetService<IComputerList>();
            FrmComputerList frmComputerList = new FrmComputerList(computerFrm);
            frmComputerList.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var computerFrm = Program.ServiceProvider.GetService<IDatabaseContext>();
            FrmComputerDetail frmComputerDetail = new FrmComputerDetail(computerFrm);
            frmComputerDetail.ShowDialog();
        }
    }
}
