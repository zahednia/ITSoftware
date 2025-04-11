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
    public partial class FrmComputerList : Form
    {
        private readonly IComputerList computerlist;
        private IDatabaseContext database;

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
            DGComputerList.Columns[1].HeaderText = "کامپیوتر";
            DGComputerList.Columns[2].HeaderText = "CODE";
            DGComputerList.Columns[0].Width = 40;
            DGComputerList.Columns[1].Width = 500;
            DGComputerList.Columns[2].Width = 315;
        }

        private void BtnSearchComputerList_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var Search = computerlist.ComputerLists(textBox1.Text);
            SettingGridview(Search);
            Cursor = Cursors.Default;
        }

        private void DGComputerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGComputerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
                int computerId = Convert.ToInt32(DGComputerList.Rows[e.RowIndex].Cells["Id"].Value);
                var form = new FrmComputerDetails(hardwareBrands, hardwareDetails, computerId, save, database, show, history, User, Assign , userhistory);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
