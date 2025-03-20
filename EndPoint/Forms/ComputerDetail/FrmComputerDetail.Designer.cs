
namespace EndPoint.Forms.ComputerDetail
{
    partial class FrmComputerDetail
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
            CBCpuBrand = new ComboBox();
            lblId = new Label();
            CBCpuDetail = new ComboBox();
            CBMotherboardBrand = new ComboBox();
            CBMotherboardDetail = new ComboBox();
            CBRamDetail = new ComboBox();
            CBHddBrand = new ComboBox();
            CBHddDetail = new ComboBox();
            CBGpuBrand = new ComboBox();
            CBGpuDetail = new ComboBox();
            CBRamBrand = new ComboBox();
            CBHardExtra1 = new ComboBox();
            CBHardExtraDetail1 = new ComboBox();
            CBHardExtra2 = new ComboBox();
            CBHardExtraDetail2 = new ComboBox();
            lblcpu = new Label();
            lblMother = new Label();
            lblram = new Label();
            lblHard = new Label();
            lblGpu = new Label();
            txtComputerName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // CBCpuBrand
            // 
            CBCpuBrand.FormattingEnabled = true;
            CBCpuBrand.Location = new Point(228, 194);
            CBCpuBrand.Name = "CBCpuBrand";
            CBCpuBrand.Size = new Size(197, 28);
            CBCpuBrand.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(93, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            lblId.Click += label1_Click;
            // 
            // CBCpuDetail
            // 
            CBCpuDetail.FormattingEnabled = true;
            CBCpuDetail.Location = new Point(471, 194);
            CBCpuDetail.Name = "CBCpuDetail";
            CBCpuDetail.Size = new Size(151, 28);
            CBCpuDetail.TabIndex = 2;
            // 
            // CBMotherboardBrand
            // 
            CBMotherboardBrand.FormattingEnabled = true;
            CBMotherboardBrand.Location = new Point(228, 123);
            CBMotherboardBrand.Name = "CBMotherboardBrand";
            CBMotherboardBrand.Size = new Size(197, 28);
            CBMotherboardBrand.TabIndex = 3;
            // 
            // CBMotherboardDetail
            // 
            CBMotherboardDetail.FormattingEnabled = true;
            CBMotherboardDetail.Location = new Point(471, 123);
            CBMotherboardDetail.Name = "CBMotherboardDetail";
            CBMotherboardDetail.Size = new Size(151, 28);
            CBMotherboardDetail.TabIndex = 4;
            // 
            // CBRamDetail
            // 
            CBRamDetail.FormattingEnabled = true;
            CBRamDetail.Location = new Point(471, 275);
            CBRamDetail.Name = "CBRamDetail";
            CBRamDetail.Size = new Size(151, 28);
            CBRamDetail.TabIndex = 6;
            // 
            // CBHddBrand
            // 
            CBHddBrand.FormattingEnabled = true;
            CBHddBrand.Location = new Point(233, 350);
            CBHddBrand.Name = "CBHddBrand";
            CBHddBrand.Size = new Size(192, 28);
            CBHddBrand.TabIndex = 7;
            // 
            // CBHddDetail
            // 
            CBHddDetail.FormattingEnabled = true;
            CBHddDetail.Location = new Point(471, 350);
            CBHddDetail.Name = "CBHddDetail";
            CBHddDetail.Size = new Size(151, 28);
            CBHddDetail.TabIndex = 8;
            // 
            // CBGpuBrand
            // 
            CBGpuBrand.FormattingEnabled = true;
            CBGpuBrand.Location = new Point(235, 594);
            CBGpuBrand.Name = "CBGpuBrand";
            CBGpuBrand.Size = new Size(197, 28);
            CBGpuBrand.TabIndex = 9;
            // 
            // CBGpuDetail
            // 
            CBGpuDetail.FormattingEnabled = true;
            CBGpuDetail.Location = new Point(489, 594);
            CBGpuDetail.Name = "CBGpuDetail";
            CBGpuDetail.Size = new Size(151, 28);
            CBGpuDetail.TabIndex = 10;
            // 
            // CBRamBrand
            // 
            CBRamBrand.FormattingEnabled = true;
            CBRamBrand.Location = new Point(235, 275);
            CBRamBrand.Name = "CBRamBrand";
            CBRamBrand.Size = new Size(190, 28);
            CBRamBrand.TabIndex = 5;
            // 
            // CBHardExtra1
            // 
            CBHardExtra1.FormattingEnabled = true;
            CBHardExtra1.Location = new Point(233, 431);
            CBHardExtra1.Name = "CBHardExtra1";
            CBHardExtra1.Size = new Size(167, 28);
            CBHardExtra1.TabIndex = 11;
            CBHardExtra1.Visible = false;
            // 
            // CBHardExtraDetail1
            // 
            CBHardExtraDetail1.FormattingEnabled = true;
            CBHardExtraDetail1.Location = new Point(474, 435);
            CBHardExtraDetail1.Name = "CBHardExtraDetail1";
            CBHardExtraDetail1.Size = new Size(151, 28);
            CBHardExtraDetail1.TabIndex = 12;
            CBHardExtraDetail1.Visible = false;
            // 
            // CBHardExtra2
            // 
            CBHardExtra2.FormattingEnabled = true;
            CBHardExtra2.Location = new Point(232, 496);
            CBHardExtra2.Name = "CBHardExtra2";
            CBHardExtra2.Size = new Size(167, 28);
            CBHardExtra2.TabIndex = 13;
            CBHardExtra2.Visible = false;
            // 
            // CBHardExtraDetail2
            // 
            CBHardExtraDetail2.FormattingEnabled = true;
            CBHardExtraDetail2.Location = new Point(471, 496);
            CBHardExtraDetail2.Name = "CBHardExtraDetail2";
            CBHardExtraDetail2.Size = new Size(151, 28);
            CBHardExtraDetail2.TabIndex = 14;
            CBHardExtraDetail2.Visible = false;
            // 
            // lblcpu
            // 
            lblcpu.AutoSize = true;
            lblcpu.Location = new Point(122, 197);
            lblcpu.Name = "lblcpu";
            lblcpu.Size = new Size(36, 20);
            lblcpu.TabIndex = 15;
            lblcpu.Text = "CPU";
            // 
            // lblMother
            // 
            lblMother.AutoSize = true;
            lblMother.Location = new Point(93, 126);
            lblMother.Name = "lblMother";
            lblMother.Size = new Size(97, 20);
            lblMother.TabIndex = 16;
            lblMother.Text = "MotherBoard";
            // 
            // lblram
            // 
            lblram.AutoSize = true;
            lblram.Location = new Point(122, 278);
            lblram.Name = "lblram";
            lblram.Size = new Size(41, 20);
            lblram.TabIndex = 17;
            lblram.Text = "RAM";
            // 
            // lblHard
            // 
            lblHard.AutoSize = true;
            lblHard.Location = new Point(113, 353);
            lblHard.Name = "lblHard";
            lblHard.Size = new Size(50, 20);
            lblHard.TabIndex = 18;
            lblHard.Text = "HARD";
            // 
            // lblGpu
            // 
            lblGpu.AutoSize = true;
            lblGpu.Location = new Point(122, 597);
            lblGpu.Name = "lblGpu";
            lblGpu.Size = new Size(36, 20);
            lblGpu.TabIndex = 19;
            lblGpu.Text = "Gpu";
            // 
            // txtComputerName
            // 
            txtComputerName.Location = new Point(166, 49);
            txtComputerName.Name = "txtComputerName";
            txtComputerName.Size = new Size(125, 27);
            txtComputerName.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(722, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // FrmComputerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 729);
            Controls.Add(btnSave);
            Controls.Add(txtComputerName);
            Controls.Add(lblGpu);
            Controls.Add(lblHard);
            Controls.Add(lblram);
            Controls.Add(lblMother);
            Controls.Add(lblcpu);
            Controls.Add(CBHardExtraDetail2);
            Controls.Add(CBHardExtra2);
            Controls.Add(CBHardExtraDetail1);
            Controls.Add(CBHardExtra1);
            Controls.Add(CBGpuDetail);
            Controls.Add(CBGpuBrand);
            Controls.Add(CBHddDetail);
            Controls.Add(CBHddBrand);
            Controls.Add(CBRamDetail);
            Controls.Add(CBRamBrand);
            Controls.Add(CBMotherboardDetail);
            Controls.Add(CBMotherboardBrand);
            Controls.Add(CBCpuDetail);
            Controls.Add(lblId);
            Controls.Add(CBCpuBrand);
            Name = "FrmComputerDetail";
            Text = "FrmComputerDetail";
            Load += FrmComputerDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox CBCpuBrand;
        private Label lblId;
        private ComboBox CBCpuDetail;
        private ComboBox CBMotherboardBrand;
        private ComboBox CBMotherboardDetail;
        private ComboBox CBRamDetail;
        private ComboBox CBHddBrand;
        private ComboBox CBHddDetail;
        private ComboBox CBGpuBrand;
        private ComboBox CBGpuDetail;
        private ComboBox CBRamBrand;
        private ComboBox CBHardExtra1;
        private ComboBox CBHardExtraDetail1;
        private ComboBox CBHardExtra2;
        private ComboBox CBHardExtraDetail2;
        private Label lblcpu;
        private Label lblMother;
        private Label lblram;
        private Label lblHard;
        private Label lblGpu;
        private TextBox txtComputerName;
        private Button btnSave;
    }
}