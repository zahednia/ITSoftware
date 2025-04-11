
using ApplicationIT.Service.HardwareService.History;
using ApplicationIT.Service.User.UserComputerHistoryService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmUserHistory : Form
    {

        private readonly int _computerId;
        private readonly IUserHistoryService historyService;

        public FrmUserHistory(int computerId, IUserHistoryService historyService)
        {
            InitializeComponent();
            this._computerId = computerId;
            this.historyService = historyService;
        }


        private void FrmUserHistory_Load(object sender, EventArgs e)
        {
            SettingGridview();
        }
        private void SettingGridview()
        {
            var data = historyService.GetUserComputerHistory(_computerId);
            DGUserHistory.DataSource = data;
            DGUserHistory.Columns[0].Width = 200;
            DGUserHistory.Columns[1].Width = 150;
            DGUserHistory.Columns[2].Width = 150;
            DGUserHistory.Columns[3].Width = 80;
            DGUserHistory.Columns[4].Width = 150;
        }
    }
}
