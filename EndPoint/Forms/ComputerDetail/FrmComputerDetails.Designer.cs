


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
            btnSave = new Button();
            lblName = new Label();
            txtName = new TextBox();
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
            txtCode = new TextBox();
            label7 = new Label();
            cmbUsers = new ComboBox();
            lblUserHistoryCount = new Label();
            btnSmallSave = new Button();
            CBMotherBoardBrand = new ComboBox();
            CBMotherBoardDetail = new ComboBox();
            CBCPUBrand = new ComboBox();
            CBRamBrand = new ComboBox();
            CBHDDBrand = new ComboBox();
            CBSSDBrand = new ComboBox();
            CBGPUBrand = new ComboBox();
            CBCPUDetail = new ComboBox();
            CBRamDetail = new ComboBox();
            CBHDDDetail = new ComboBox();
            CBSSDDetail = new ComboBox();
            CBGPUDetail = new ComboBox();
            lblHMotherBoard = new Label();
            lblHCPU = new Label();
            lblHRAM = new Label();
            lblHHDD = new Label();
            lblHSSD = new Label();
            lblHGPU = new Label();
            btnAddHardware = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(657, 77);
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
            label4.Location = new Point(47, 276);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 18;
            label4.Text = "HDD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 342);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 19;
            label5.Text = "SSD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 419);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 20;
            label6.Text = "GPU";
            // 
            // HMotherBoard
            // 
            HMotherBoard.Location = new Point(0, 0);
            HMotherBoard.Name = "HMotherBoard";
            HMotherBoard.Size = new Size(100, 23);
            HMotherBoard.TabIndex = 39;
            // 
            // HCPU
            // 
            HCPU.Location = new Point(0, 0);
            HCPU.Name = "HCPU";
            HCPU.Size = new Size(100, 23);
            HCPU.TabIndex = 38;
            // 
            // HRAM
            // 
            HRAM.Location = new Point(0, 0);
            HRAM.Name = "HRAM";
            HRAM.Size = new Size(100, 23);
            HRAM.TabIndex = 37;
            // 
            // HHDD
            // 
            HHDD.Location = new Point(0, 0);
            HHDD.Name = "HHDD";
            HHDD.Size = new Size(100, 23);
            HHDD.TabIndex = 36;
            // 
            // HSSD
            // 
            HSSD.Location = new Point(0, 0);
            HSSD.Name = "HSSD";
            HSSD.Size = new Size(100, 23);
            HSSD.TabIndex = 35;
            // 
            // HGPU
            // 
            HGPU.Location = new Point(0, 0);
            HGPU.Name = "HGPU";
            HGPU.Size = new Size(100, 23);
            HGPU.TabIndex = 34;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(290, 33);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 40);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 28;
            label7.Text = "CODE";
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(462, 33);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(166, 28);
            cmbUsers.TabIndex = 30;
            // 
            // lblUserHistoryCount
            // 
            lblUserHistoryCount.AutoSize = true;
            lblUserHistoryCount.Location = new Point(634, 40);
            lblUserHistoryCount.Name = "lblUserHistoryCount";
            lblUserHistoryCount.Size = new Size(50, 20);
            lblUserHistoryCount.TabIndex = 31;
            lblUserHistoryCount.Text = "label8";
            lblUserHistoryCount.Click += lblUserHistoryCount_Click;
            // 
            // btnSmallSave
            // 
            btnSmallSave.Location = new Point(657, 128);
            btnSmallSave.Name = "btnSmallSave";
            btnSmallSave.Size = new Size(202, 27);
            btnSmallSave.TabIndex = 29;
            btnSmallSave.Text = "Save Name ,Code , User Only";
            btnSmallSave.UseVisualStyleBackColor = true;
            btnSmallSave.Click += btnSmallSave_Click;
            // 
            // CBMotherBoardBrand
            // 
            CBMotherBoardBrand.FormattingEnabled = true;
            CBMotherBoardBrand.Location = new Point(115, 86);
            CBMotherBoardBrand.Name = "CBMotherBoardBrand";
            CBMotherBoardBrand.Size = new Size(116, 28);
            CBMotherBoardBrand.TabIndex = 32;
            // 
            // CBMotherBoardDetail
            // 
            CBMotherBoardDetail.FormattingEnabled = true;
            CBMotherBoardDetail.Location = new Point(237, 86);
            CBMotherBoardDetail.Name = "CBMotherBoardDetail";
            CBMotherBoardDetail.Size = new Size(178, 28);
            CBMotherBoardDetail.TabIndex = 33;
            // 
            // CBCPUBrand
            // 
            CBCPUBrand.FormattingEnabled = true;
            CBCPUBrand.Location = new Point(115, 146);
            CBCPUBrand.Name = "CBCPUBrand";
            CBCPUBrand.Size = new Size(116, 28);
            CBCPUBrand.TabIndex = 32;
            // 
            // CBRamBrand
            // 
            CBRamBrand.FormattingEnabled = true;
            CBRamBrand.Location = new Point(115, 209);
            CBRamBrand.Name = "CBRamBrand";
            CBRamBrand.Size = new Size(116, 28);
            CBRamBrand.TabIndex = 32;
            // 
            // CBHDDBrand
            // 
            CBHDDBrand.FormattingEnabled = true;
            CBHDDBrand.Location = new Point(115, 273);
            CBHDDBrand.Name = "CBHDDBrand";
            CBHDDBrand.Size = new Size(116, 28);
            CBHDDBrand.TabIndex = 32;
            // 
            // CBSSDBrand
            // 
            CBSSDBrand.FormattingEnabled = true;
            CBSSDBrand.Location = new Point(115, 339);
            CBSSDBrand.Name = "CBSSDBrand";
            CBSSDBrand.Size = new Size(116, 28);
            CBSSDBrand.TabIndex = 32;
            // 
            // CBGPUBrand
            // 
            CBGPUBrand.FormattingEnabled = true;
            CBGPUBrand.Location = new Point(115, 416);
            CBGPUBrand.Name = "CBGPUBrand";
            CBGPUBrand.Size = new Size(116, 28);
            CBGPUBrand.TabIndex = 32;
            // 
            // CBCPUDetail
            // 
            CBCPUDetail.FormattingEnabled = true;
            CBCPUDetail.Location = new Point(237, 146);
            CBCPUDetail.Name = "CBCPUDetail";
            CBCPUDetail.Size = new Size(178, 28);
            CBCPUDetail.TabIndex = 33;
            // 
            // CBRamDetail
            // 
            CBRamDetail.FormattingEnabled = true;
            CBRamDetail.Location = new Point(237, 209);
            CBRamDetail.Name = "CBRamDetail";
            CBRamDetail.Size = new Size(178, 28);
            CBRamDetail.TabIndex = 33;
            // 
            // CBHDDDetail
            // 
            CBHDDDetail.FormattingEnabled = true;
            CBHDDDetail.Location = new Point(237, 273);
            CBHDDDetail.Name = "CBHDDDetail";
            CBHDDDetail.Size = new Size(178, 28);
            CBHDDDetail.TabIndex = 33;
            // 
            // CBSSDDetail
            // 
            CBSSDDetail.FormattingEnabled = true;
            CBSSDDetail.Location = new Point(237, 339);
            CBSSDDetail.Name = "CBSSDDetail";
            CBSSDDetail.Size = new Size(178, 28);
            CBSSDDetail.TabIndex = 33;
            // 
            // CBGPUDetail
            // 
            CBGPUDetail.FormattingEnabled = true;
            CBGPUDetail.Location = new Point(237, 416);
            CBGPUDetail.Name = "CBGPUDetail";
            CBGPUDetail.Size = new Size(178, 28);
            CBGPUDetail.TabIndex = 33;
            // 
            // lblHMotherBoard
            // 
            lblHMotherBoard.AutoSize = true;
            lblHMotherBoard.Location = new Point(421, 89);
            lblHMotherBoard.Name = "lblHMotherBoard";
            lblHMotherBoard.Size = new Size(50, 20);
            lblHMotherBoard.TabIndex = 40;
            lblHMotherBoard.Text = "label8";
            lblHMotherBoard.Click += lblHMotherBoard_Click;
            // 
            // lblHCPU
            // 
            lblHCPU.AutoSize = true;
            lblHCPU.Location = new Point(421, 149);
            lblHCPU.Name = "lblHCPU";
            lblHCPU.Size = new Size(50, 20);
            lblHCPU.TabIndex = 41;
            lblHCPU.Text = "label9";
            lblHCPU.Click += lblHCPU_Click;
            // 
            // lblHRAM
            // 
            lblHRAM.AutoSize = true;
            lblHRAM.Location = new Point(421, 212);
            lblHRAM.Name = "lblHRAM";
            lblHRAM.Size = new Size(50, 20);
            lblHRAM.TabIndex = 41;
            lblHRAM.Text = "label9";
            lblHRAM.Click += lblHRAM_Click;
            // 
            // lblHHDD
            // 
            lblHHDD.AutoSize = true;
            lblHHDD.Location = new Point(421, 276);
            lblHHDD.Name = "lblHHDD";
            lblHHDD.Size = new Size(50, 20);
            lblHHDD.TabIndex = 41;
            lblHHDD.Text = "label9";
            lblHHDD.Click += lblHHDD_Click;
            // 
            // lblHSSD
            // 
            lblHSSD.AutoSize = true;
            lblHSSD.Location = new Point(421, 342);
            lblHSSD.Name = "lblHSSD";
            lblHSSD.Size = new Size(50, 20);
            lblHSSD.TabIndex = 41;
            lblHSSD.Text = "label9";
            lblHSSD.Click += lblHSSD_Click;
            // 
            // lblHGPU
            // 
            lblHGPU.AutoSize = true;
            lblHGPU.Location = new Point(421, 419);
            lblHGPU.Name = "lblHGPU";
            lblHGPU.Size = new Size(50, 20);
            lblHGPU.TabIndex = 41;
            lblHGPU.Text = "label9";
            lblHGPU.Click += lblHGPU_Click;
            // 
            // btnAddHardware
            // 
            btnAddHardware.Location = new Point(657, 161);
            btnAddHardware.Name = "btnAddHardware";
            btnAddHardware.Size = new Size(196, 29);
            btnAddHardware.TabIndex = 42;
            btnAddHardware.Text = "ADD HARDWARE";
            btnAddHardware.UseVisualStyleBackColor = true;
            btnAddHardware.Click += btnAddHardware_Click;
            // 
            // FrmComputerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 503);
            Controls.Add(btnAddHardware);
            Controls.Add(lblHGPU);
            Controls.Add(lblHSSD);
            Controls.Add(lblHHDD);
            Controls.Add(lblHRAM);
            Controls.Add(lblHCPU);
            Controls.Add(lblHMotherBoard);
            Controls.Add(CBGPUDetail);
            Controls.Add(CBSSDDetail);
            Controls.Add(CBHDDDetail);
            Controls.Add(CBRamDetail);
            Controls.Add(CBCPUDetail);
            Controls.Add(CBMotherBoardDetail);
            Controls.Add(CBGPUBrand);
            Controls.Add(CBSSDBrand);
            Controls.Add(CBHDDBrand);
            Controls.Add(CBRamBrand);
            Controls.Add(CBCPUBrand);
            Controls.Add(CBMotherBoardBrand);
            Controls.Add(lblUserHistoryCount);
            Controls.Add(cmbUsers);
            Controls.Add(btnSmallSave);
            Controls.Add(label7);
            Controls.Add(txtCode);
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
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "FrmComputerDetails";
            Text = "FrmComputerDetails";
            Load += FrmComputerDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion
        private Button btnSave;
        private Label lblName;
        private TextBox txtName;
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
        private TextBox txtCode;
        private Label label7;
        private ComboBox cmbUsers;
        private Label lblUserHistoryCount;
        private Button btnSmallSave;
        private ComboBox CBMotherBoardBrand;
        private ComboBox CBMotherBoardDetail;
        private ComboBox CBCPUBrand;
        private ComboBox CBRamBrand;
        private ComboBox CBHDDBrand;
        private ComboBox CBSSDBrand;
        private ComboBox CBGPUBrand;
        private ComboBox CBCPUDetail;
        private ComboBox CBRamDetail;
        private ComboBox CBHDDDetail;
        private ComboBox CBSSDDetail;
        private ComboBox CBGPUDetail;
        private Label lblHMotherBoard;
        private Label lblHCPU;
        private Label lblHRAM;
        private Label lblHHDD;
        private Label lblHSSD;
        private Label lblHGPU;
        private Button btnAddHardware;
    }
}