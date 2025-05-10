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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DGHardwareList = new DataGridView();
            hardwareBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            BtnAdd = new Button();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)DGHardwareList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hardwareBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DGHardwareList
            // 
            DGHardwareList.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGHardwareList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGHardwareList.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGHardwareList.DefaultCellStyle = dataGridViewCellStyle2;
            DGHardwareList.Location = new Point(10, 40);
            DGHardwareList.Margin = new Padding(3, 2, 3, 2);
            DGHardwareList.Name = "DGHardwareList";
            DGHardwareList.RowHeadersWidth = 51;
            DGHardwareList.Size = new Size(605, 424);
            DGHardwareList.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 6);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(464, 31);
            txtSearch.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(192, 255, 192);
            BtnAdd.Location = new Point(480, 6);
            BtnAdd.Margin = new Padding(3, 2, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(136, 30);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            // 
            // FrmHardwareManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 466);
            Controls.Add(BtnAdd);
            Controls.Add(txtSearch);
            Controls.Add(DGHardwareList);
            Margin = new Padding(3, 2, 3, 2);
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
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}