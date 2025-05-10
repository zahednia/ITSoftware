using ApplicationIT.Database;
using ApplicationIT.Service.ComputerList;
using ApplicationIT.Service.HardwareService.HardwareBrand;
using ApplicationIT.Service.HardwareService.HardwareDetail;
using ApplicationIT.Service.HardwareService.HardwareHistory;
using ApplicationIT.Service.HardwareService.SaveService;
using ApplicationIT.Service.HardwareService.ShowHardware;
using ApplicationIT.Service.User.AssignUserToComputer;
using ApplicationIT.Service.User.ShowUser;
using ApplicationIT.Service.User.UserComputerHistoryService;
using EndPoint.Forms.ComputerDetail;
using EndPoint.Forms.ComputerDetail.AddHardware;
using EndPoint.Forms.ComputerDetail.TimeSheet;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
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
        private readonly IHardwareBrands hardwareBrands;

        public FrmMain(IUserShowService? serviceGetList, IDatabaseContext database, IComputerList computerList, IHardwareBrands hardwareBrands)
        {

            InitializeComponent();
            this.database = database;
            this.computerList = computerList;
            this.hardwareBrands = hardwareBrands;
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
                case "NDAddHardware":
                    var form = Program.ServiceProvider.GetService<FrmHardwareManager>();
                    form.ShowDialog();
                    break;
                case "SNDTimeSheet":
                    var timeSheet = Program.ServiceProvider.GetService<FrmTimeSheet>();
                    timeSheet.ShowDialog();
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
            //var hardwareDetails = Program.ServiceProvider.GetService<IHardwareDetails>();
            //var hardwareBrands = Program.ServiceProvider.GetService<IHardwareBrands>();
            //FrmComputerDetails frmComputerDetails = new FrmComputerDetails(hardwareBrands , hardwareDetails);
            //frmComputerDetails.ShowDialog();

            //int computerId = 0;
            //if (computerId >= 0)
            //{
            //    var dbContext = new DatabaseContext(); // ایجاد نمونه معتبر
            //    var editForm = new FrmComputerDetail(dbContext, computerId);
            //    editForm.ShowDialog();
            //}
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            var database = Program.ServiceProvider.GetService<IDatabaseContext>();
            var hardwareBrands = Program.ServiceProvider.GetService<IHardwareBrands>();
            var hardwareDetails = Program.ServiceProvider.GetService<IHardwareDetails>();
            var save = Program.ServiceProvider.GetService<IComputerHardwareSaveService>();
            var show = Program.ServiceProvider.GetService<IComputerHardwareQueryService>();
            var history = Program.ServiceProvider.GetService<IComputerHardwareHistoryService>();
            var User = Program.ServiceProvider.GetService<IUserShowService>();
            var Assign = Program.ServiceProvider.GetService<IUserComputerAssignService>();
            var userhistory = Program.ServiceProvider.GetService<IUserHistoryService>();
            var form = new FrmComputerDetails(hardwareBrands, hardwareDetails, 0, save, database, show, history, User, Assign, userhistory);
            form.ShowDialog();
        }

        private void BtnComputerList_Click(object sender, EventArgs e)
        {
            var computerFrm = Program.ServiceProvider.GetService<IComputerList>();
            FrmComputerList frmComputerList = new FrmComputerList(computerFrm);
            frmComputerList.ShowDialog();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            var serviceAdd = (IUserShowService)Program.ServiceProvider.GetService(typeof(IUserShowService));
            FrmUsers frmUsers = new FrmUsers(serviceAdd);
            frmUsers.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddHardware_Click(object sender, EventArgs e)
        {
            var provider = Program.ServiceProvider;
            if (provider == null)
            {
                MessageBox.Show("ServiceProvider نال است!");
                return;
            }

            var form = provider.GetService<FrmHardwareManager>(); // از DI بگیرش نه new کن!
            if (form == null)
            {
                MessageBox.Show("FrmHardwareManager نال است!");
                return;
            }

            form.ShowDialog();
        }

        private void BtnTimeSheet_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetService<FrmTimeSheet>();
            form.ShowDialog();
        }
    }
}
