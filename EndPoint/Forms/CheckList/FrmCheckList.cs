using ApplicationIT.Database;
using ApplicationIT.Service.CheckListService.CheckListCreate;
using ApplicationIT.Service.CheckListService.CheckListQueryService;
using ApplicationIT.Service.CheckListService.CheckListView;
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
using Domain.Entities;
using ApplicationIT.Service.CheckListService.ChecklistGrid;

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
            LoadChecklistGrid();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmCheckListItem frmCheckListItem = new FrmCheckListItem(database, computer);
            frmCheckListItem.ShowDialog();
        }

        private void LoadChecklistGrid()
        {
            var service = Program.ServiceProvider.GetService<ICheckListGridService>();
            var data = service.Execute(computer);
            DGItems.DataSource = data;
            StyleDataGridView();
        }
        private void StyleDataGridView()
        {
            var dgv = DGItems;

            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



    }
}
