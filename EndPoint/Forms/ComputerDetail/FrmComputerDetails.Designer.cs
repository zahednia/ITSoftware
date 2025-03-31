namespace EndPoint.Forms.ComputerDetail
{
    partial class FrmComputerDetails
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
            txtCPUBrand = new TextBox();
            txtCPUDetail = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtCPUBrand
            // 
            txtCPUBrand.Location = new Point(105, 86);
            txtCPUBrand.Name = "txtCPUBrand";
            txtCPUBrand.Size = new Size(125, 27);
            txtCPUBrand.TabIndex = 0;
            // 
            // txtCPUDetail
            // 
            txtCPUDetail.Location = new Point(290, 86);
            txtCPUDetail.Name = "txtCPUDetail";
            txtCPUDetail.Size = new Size(125, 27);
            txtCPUDetail.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(525, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            txtName.Click += txtName_Click;
            // 
            // FrmComputerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtCPUDetail);
            Controls.Add(txtCPUBrand);
            Name = "FrmComputerDetails";
            Text = "FrmComputerDetails";
            Load += FrmComputerDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPUBrand;
        private TextBox txtCPUDetail;
        private Button btnSave;
        private Label label1;
        private TextBox txtName;
    }
}