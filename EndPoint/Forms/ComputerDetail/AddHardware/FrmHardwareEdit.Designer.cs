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
            cmbBrand = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbHardwareType
            // 
            cmbHardwareType.FormattingEnabled = true;
            cmbHardwareType.Location = new Point(93, 42);
            cmbHardwareType.Margin = new Padding(3, 2, 3, 2);
            cmbHardwareType.Name = "cmbHardwareType";
            cmbHardwareType.Size = new Size(133, 22);
            cmbHardwareType.TabIndex = 0;
            cmbHardwareType.SelectedIndexChanged += cmbHardwareType_SelectedIndexChanged;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(92, 138);
            txtDetail.Margin = new Padding(3, 2, 3, 2);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(134, 22);
            txtDetail.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(92, 191);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 41);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(93, 90);
            cmbBrand.Margin = new Padding(3, 2, 3, 2);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(133, 22);
            cmbBrand.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 45);
            label1.Name = "label1";
            label1.Size = new Size(36, 14);
            label1.TabIndex = 6;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 92);
            label2.Name = "label2";
            label2.Size = new Size(43, 14);
            label2.TabIndex = 7;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 141);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 8;
            label3.Text = "Detail";
            // 
            // FrmHardwareEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 263);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBrand);
            Controls.Add(btnSave);
            Controls.Add(txtDetail);
            Controls.Add(cmbHardwareType);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHardwareEdit";
            Text = "FrmHardwareEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHardwareType;
        private TextBox txtDetail;
        private Button btnSave;
        private ComboBox cmbBrand;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}