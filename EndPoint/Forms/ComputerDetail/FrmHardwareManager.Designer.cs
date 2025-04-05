
namespace EndPoint.Forms.ComputerDetail
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
            btnSave = new Button();
            cmbHardwareType = new ComboBox();
            txtDetail = new TextBox();
            cmbBrand = new ComboBox();
            DGHardwareList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGHardwareList).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(598, 44);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbHardwareType
            // 
            cmbHardwareType.FormattingEnabled = true;
            cmbHardwareType.Location = new Point(24, 45);
            cmbHardwareType.Name = "cmbHardwareType";
            cmbHardwareType.Size = new Size(151, 28);
            cmbHardwareType.TabIndex = 1;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(427, 45);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(163, 27);
            txtDetail.TabIndex = 3;
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(310, 45);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(109, 28);
            cmbBrand.TabIndex = 1;
            // 
            // DGHardwareList
            // 
            DGHardwareList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGHardwareList.Location = new Point(1, 110);
            DGHardwareList.Name = "DGHardwareList";
            DGHardwareList.RowHeadersWidth = 51;
            DGHardwareList.Size = new Size(733, 500);
            DGHardwareList.TabIndex = 5;
            // 
            // FrmHardwareManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 616);
            Controls.Add(DGHardwareList);
            Controls.Add(txtDetail);
            Controls.Add(cmbBrand);
            Controls.Add(cmbHardwareType);
            Controls.Add(btnSave);
            Name = "FrmHardwareManager";
            Text = "FrmHardwareManager";
            Load += FrmHardwareManager_Load;
            ((System.ComponentModel.ISupportInitialize)DGHardwareList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnSave;
        private ComboBox cmbHardwareType;
        private TextBox txtDetail;
        private ComboBox cmbBrand;
        private DataGridView DGHardwareList;
    }
}