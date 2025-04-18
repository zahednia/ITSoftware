namespace EndPoint.Forms.ComputerDetail.AddHardware
{
    partial class FrmHardwareEdit
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
            cmbHardwareType = new ComboBox();
            txtDetail = new TextBox();
            btnSave = new Button();
            txtBrand = new TextBox();
            SuspendLayout();
            // 
            // cmbHardwareType
            // 
            cmbHardwareType.FormattingEnabled = true;
            cmbHardwareType.Location = new Point(42, 87);
            cmbHardwareType.Name = "cmbHardwareType";
            cmbHardwareType.Size = new Size(151, 28);
            cmbHardwareType.TabIndex = 0;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(451, 87);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(125, 27);
            txtDetail.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(635, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(278, 87);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(125, 27);
            txtBrand.TabIndex = 2;
            // 
            // FrmHardwareEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 181);
            Controls.Add(btnSave);
            Controls.Add(txtBrand);
            Controls.Add(txtDetail);
            Controls.Add(cmbHardwareType);
            Name = "FrmHardwareEdit";
            Text = "FrmHardwareEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHardwareType;
        private TextBox txtDetail;
        private Button btnSave;
        private TextBox txtBrand;
    }
}