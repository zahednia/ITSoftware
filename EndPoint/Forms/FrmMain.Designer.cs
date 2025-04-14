namespace EndPoint.Forms
{
    partial class FrmMain
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
            TreeNode treeNode5 = new TreeNode("Show List Of User");
            TreeNode treeNode6 = new TreeNode("Users", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Computer List");
            TreeNode treeNode8 = new TreeNode("Computers", new TreeNode[] { treeNode7 });
            treeView1 = new TreeView();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            userListToolStripMenuItem = new ToolStripMenuItem();
            computerToolStripMenuItem = new ToolStripMenuItem();
            computerListToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnAddComputer = new Button();
            BtnComputerList = new Button();
            btnUserList = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            treeView1.ItemHeight = 50;
            treeView1.Location = new Point(0, 27);
            treeView1.Name = "treeView1";
            treeNode5.Name = "SNDShowUser";
            treeNode5.Text = "Show List Of User";
            treeNode6.Name = "NDUsers";
            treeNode6.Text = "Users";
            treeNode7.Name = "SNDComputerList";
            treeNode7.Text = "Computer List";
            treeNode8.Name = "NDComputers";
            treeNode8.Text = "Computers";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6, treeNode8 });
            treeView1.Size = new Size(287, 563);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, computerToolStripMenuItem, helpToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userListToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.ShortcutKeyDisplayString = "";
            userToolStripMenuItem.Size = new Size(42, 20);
            userToolStripMenuItem.Text = "User";
            // 
            // userListToolStripMenuItem
            // 
            userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            userListToolStripMenuItem.Size = new Size(118, 22);
            userListToolStripMenuItem.Text = "User List";
            userListToolStripMenuItem.Click += userListToolStripMenuItem_Click;
            // 
            // computerToolStripMenuItem
            // 
            computerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computerListToolStripMenuItem });
            computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            computerToolStripMenuItem.Size = new Size(73, 20);
            computerToolStripMenuItem.Text = "Computer";
            // 
            // computerListToolStripMenuItem
            // 
            computerListToolStripMenuItem.Name = "computerListToolStripMenuItem";
            computerListToolStripMenuItem.Size = new Size(149, 22);
            computerListToolStripMenuItem.Text = "Computer List";
            computerListToolStripMenuItem.Click += computerListToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblTime });
            statusStrip1.Location = new Point(0, 591);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1003, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 17);
            toolStripStatusLabel1.Text = "Time :";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(13, 17);
            lblTime.Text = "0";
            lblTime.Click += lblTime_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnAddComputer
            // 
            btnAddComputer.BackColor = Color.FromArgb(192, 192, 255);
            btnAddComputer.Location = new Point(320, 153);
            btnAddComputer.Margin = new Padding(3, 2, 3, 2);
            btnAddComputer.Name = "btnAddComputer";
            btnAddComputer.Size = new Size(203, 90);
            btnAddComputer.TabIndex = 4;
            btnAddComputer.Text = "Add New Computer";
            btnAddComputer.UseVisualStyleBackColor = false;
            btnAddComputer.Click += btnAddComputer_Click;
            // 
            // BtnComputerList
            // 
            BtnComputerList.BackColor = Color.FromArgb(128, 128, 255);
            BtnComputerList.Location = new Point(528, 153);
            BtnComputerList.Margin = new Padding(3, 2, 3, 2);
            BtnComputerList.Name = "BtnComputerList";
            BtnComputerList.Size = new Size(242, 90);
            BtnComputerList.TabIndex = 5;
            BtnComputerList.Text = "Computer List";
            BtnComputerList.UseVisualStyleBackColor = false;
            BtnComputerList.Click += BtnComputerList_Click;
            // 
            // btnUserList
            // 
            btnUserList.BackColor = Color.FromArgb(192, 192, 255);
            btnUserList.Location = new Point(775, 153);
            btnUserList.Margin = new Padding(3, 2, 3, 2);
            btnUserList.Name = "btnUserList";
            btnUserList.Size = new Size(203, 90);
            btnUserList.TabIndex = 7;
            btnUserList.Text = "User List";
            btnUserList.UseVisualStyleBackColor = false;
            btnUserList.Click += btnUserList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 565);
            label1.Name = "label1";
            label1.Size = new Size(318, 15);
            label1.TabIndex = 8;
            label1.Text = "Copyright © 2025 Kourosh Zahednia . All rights reserved";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Frm.photo_2025_02_13_16_41_28;
            pictureBox1.Location = new Point(320, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 111);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 613);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnUserList);
            Controls.Add(BtnComputerList);
            Controls.Add(btnAddComputer);
            Controls.Add(statusStrip1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TreeView treeView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem computerToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem userListToolStripMenuItem;
        private ToolStripMenuItem computerListToolStripMenuItem;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTime;
        private Button btnAddComputer;
        private Button BtnComputerList;
        private Button btnUserList;
        private Label label1;
        private PictureBox pictureBox1;
    }
}