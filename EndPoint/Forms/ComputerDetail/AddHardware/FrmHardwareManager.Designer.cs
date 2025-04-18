namespace EndPoint.Forms.ComputerDetail.AddHardware
{
    partial class FrmHardwareManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DGHardwareList = new DataGridView();
            hardwareBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            BtnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DGHardwareList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hardwareBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DGHardwareList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGHardwareList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGHardwareList.ColumnHeadersHeight = 29;
            DGHardwareList.Location = new Point(12, 54);
            DGHardwareList.Name = "DGHardwareList";
            DGHardwareList.RowHeadersWidth = 51;
            DGHardwareList.Size = new Size(674, 565);
            DGHardwareList.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 8);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(530, 40);
            txtSearch.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(548, 8);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(155, 40);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            // 
            // FrmHardwareManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 639);
            Controls.Add(BtnAdd);
            Controls.Add(txtSearch);
            Controls.Add(DGHardwareList);
            Name = "FrmHardwareManager";
            Text = "FrmHardwareManager";
            Load += FrmHardwareManager_Load_1;
            ((System.ComponentModel.ISupportInitialize)DGHardwareList).EndInit();
            ((System.ComponentModel.ISupportInitialize)hardwareBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGHardwareList;
        private BindingSource hardwareBindingSource;
        private TextBox txtSearch;
        private Button BtnAdd;
    }
}