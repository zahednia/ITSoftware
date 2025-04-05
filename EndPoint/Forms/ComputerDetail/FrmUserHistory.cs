
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
            var data = historyService.GetUserComputerHistory(_computerId);
            DGUserHistory.DataSource = data;
        }

    }
}
