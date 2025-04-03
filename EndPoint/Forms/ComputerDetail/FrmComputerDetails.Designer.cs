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
            lblName = new Label();
            txtName = new TextBox();
            txtMotherBoardBrand = new TextBox();
            txtMotherBoardDetail = new TextBox();
            txtRamBrand = new TextBox();
            txtRamDetail = new TextBox();
            txtHDDBrand = new TextBox();
            txtHDDDetail = new TextBox();
            txtSSDBrand = new TextBox();
            txtSSDDetail = new TextBox();
            txtGPUBrand = new TextBox();
            txtGPUDetail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            HMotherBoard = new Label();
            HCPU = new Label();
            HRAM = new Label();
            HHDD = new Label();
            HSSD = new Label();
            HGPU = new Label();
            SuspendLayout();
            // 
            // txtCPUBrand
            // 
            txtCPUBrand.Location = new Point(113, 146);
            txtCPUBrand.Name = "txtCPUBrand";
            txtCPUBrand.Size = new Size(125, 27);
            txtCPUBrand.TabIndex = 0;
            // 
            // txtCPUDetail
            // 
            txtCPUDetail.Location = new Point(290, 146);
            txtCPUDetail.Name = "txtCPUDetail";
            txtCPUDetail.Size = new Size(125, 27);
            txtCPUDetail.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(638, 77);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(202, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 3;
            lblName.Text = "NAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            txtName.Click += txtName_Click;
            // 
            // txtMotherBoardBrand
            // 
            txtMotherBoardBrand.Location = new Point(113, 86);
            txtMotherBoardBrand.Name = "txtMotherBoardBrand";
            txtMotherBoardBrand.Size = new Size(125, 27);
            txtMotherBoardBrand.TabIndex = 5;
            // 
            // txtMotherBoardDetail
            // 
            txtMotherBoardDetail.Location = new Point(290, 86);
            txtMotherBoardDetail.Name = "txtMotherBoardDetail";
            txtMotherBoardDetail.Size = new Size(125, 27);
            txtMotherBoardDetail.TabIndex = 6;
            // 
            // txtRamBrand
            // 
            txtRamBrand.Location = new Point(113, 210);
            txtRamBrand.Name = "txtRamBrand";
            txtRamBrand.Size = new Size(125, 27);
            txtRamBrand.TabIndex = 7;
            // 
            // txtRamDetail
            // 
            txtRamDetail.Location = new Point(290, 210);
            txtRamDetail.Name = "txtRamDetail";
            txtRamDetail.Size = new Size(125, 27);
            txtRamDetail.TabIndex = 8;
            // 
            // txtHDDBrand
            // 
            txtHDDBrand.Location = new Point(113, 280);
            txtHDDBrand.Name = "txtHDDBrand";
            txtHDDBrand.Size = new Size(125, 27);
            txtHDDBrand.TabIndex = 9;
            // 
            // txtHDDDetail
            // 
            txtHDDDetail.Location = new Point(290, 280);
            txtHDDDetail.Name = "txtHDDDetail";
            txtHDDDetail.Size = new Size(125, 27);
            txtHDDDetail.TabIndex = 10;
            // 
            // txtSSDBrand
            // 
            txtSSDBrand.Location = new Point(113, 346);
            txtSSDBrand.Name = "txtSSDBrand";
            txtSSDBrand.Size = new Size(125, 27);
            txtSSDBrand.TabIndex = 11;
            // 
            // txtSSDDetail
            // 
            txtSSDDetail.Location = new Point(290, 346);
            txtSSDDetail.Name = "txtSSDDetail";
            txtSSDDetail.Size = new Size(125, 27);
            txtSSDDetail.TabIndex = 12;
            // 
            // txtGPUBrand
            // 
            txtGPUBrand.Location = new Point(113, 419);
            txtGPUBrand.Name = "txtGPUBrand";
            txtGPUBrand.Size = new Size(125, 27);
            txtGPUBrand.TabIndex = 13;
            // 
            // txtGPUDetail
            // 
            txtGPUDetail.Location = new Point(290, 419);
            txtGPUDetail.Name = "txtGPUDetail";
            txtGPUDetail.Size = new Size(125, 27);
            txtGPUDetail.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 15;
            label1.Text = "MotherBoard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 149);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 16;
            label2.Text = "CPU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 212);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 17;
            label3.Text = "RAM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 283);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 18;
            label4.Text = "HDD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 349);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 19;
            label5.Text = "SSD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 426);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 20;
            label6.Text = "GPU";
            // 
            // HMotherBoard
            // 
            HMotherBoard.AutoSize = true;
            HMotherBoard.Location = new Point(421, 89);
            HMotherBoard.Name = "HMotherBoard";
            HMotherBoard.Size = new Size(50, 20);
            HMotherBoard.TabIndex = 21;
            HMotherBoard.Text = "label7";
            HMotherBoard.Click += HMotherBoard_Click;
            // 
            // HCPU
            // 
            HCPU.AutoSize = true;
            HCPU.Location = new Point(421, 153);
            HCPU.Name = "HCPU";
            HCPU.Size = new Size(50, 20);
            HCPU.TabIndex = 22;
            HCPU.Text = "label7";
            HCPU.Click += HCPU_Click;
            // 
            // HRAM
            // 
            HRAM.AutoSize = true;
            HRAM.Location = new Point(421, 213);
            HRAM.Name = "HRAM";
            HRAM.Size = new Size(50, 20);
            HRAM.TabIndex = 23;
            HRAM.Text = "label7";
            HRAM.Click += HRAM_Click;
            // 
            // HHDD
            // 
            HHDD.AutoSize = true;
            HHDD.Location = new Point(421, 287);
            HHDD.Name = "HHDD";
            HHDD.Size = new Size(50, 20);
            HHDD.TabIndex = 24;
            HHDD.Text = "label7";
            HHDD.Click += HHDD_Click;
            // 
            // HSSD
            // 
            HSSD.AutoSize = true;
            HSSD.Location = new Point(421, 349);
            HSSD.Name = "HSSD";
            HSSD.Size = new Size(50, 20);
            HSSD.TabIndex = 25;
            HSSD.Text = "label7";
            HSSD.Click += HSSD_Click;
            // 
            // HGPU
            // 
            HGPU.AutoSize = true;
            HGPU.Location = new Point(421, 426);
            HGPU.Name = "HGPU";
            HGPU.Size = new Size(50, 20);
            HGPU.TabIndex = 26;
            HGPU.Text = "label7";
            HGPU.Click += HGPU_Click;
            // 
            // FrmComputerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 503);
            Controls.Add(HGPU);
            Controls.Add(HSSD);
            Controls.Add(HHDD);
            Controls.Add(HRAM);
            Controls.Add(HCPU);
            Controls.Add(HMotherBoard);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGPUDetail);
            Controls.Add(txtGPUBrand);
            Controls.Add(txtSSDDetail);
            Controls.Add(txtSSDBrand);
            Controls.Add(txtHDDDetail);
            Controls.Add(txtHDDBrand);
            Controls.Add(txtRamDetail);
            Controls.Add(txtRamBrand);
            Controls.Add(txtMotherBoardDetail);
            Controls.Add(txtMotherBoardBrand);
            Controls.Add(txtName);
            Controls.Add(lblName);
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
        private Label lblName;
        private TextBox txtName;
        private TextBox txtMotherBoardBrand;
        private TextBox txtMotherBoardDetail;
        private TextBox txtRamBrand;
        private TextBox txtRamDetail;
        private TextBox txtHDDBrand;
        private TextBox txtHDDDetail;
        private TextBox txtSSDBrand;
        private TextBox txtSSDDetail;
        private TextBox txtGPUBrand;
        private TextBox txtGPUDetail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label HMotherBoard;
        private Label HCPU;
        private Label HRAM;
        private Label HHDD;
        private Label HSSD;
        private Label HGPU;
    }
}