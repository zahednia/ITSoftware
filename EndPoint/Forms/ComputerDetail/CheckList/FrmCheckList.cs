using ApplicationIT.Database;
using ApplicationIT.Service.CheckListService.CheckListCreate;
using ApplicationIT.Service.CheckListService.CheckListQueryService;
using EndPoint.Forms.ComputerDetail.AddHardware;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail.CheckList
{
    public partial class FrmCheckList : Form
    {
        private readonly IDatabaseContext database;
        private readonly int computer;

        public FrmCheckList(IDatabaseContext database, int computer)
        {
            InitializeComponent();
            this.database = database;
            this.computer = computer;
        }

        private void DGItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCheckList_Load(object sender, EventArgs e)
        {
            var service = Program.ServiceProvider.GetService<ICheckListQueryService>();
            var data = service.GetCheckListsByComputerId(computer); // آیدی کامپیوتر فعلی
            DGItems.DataSource = data;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmCheckListItem frmCheckListItem = new FrmCheckListItem(database, computer);
            frmCheckListItem.ShowDialog();
        }


    }
}
