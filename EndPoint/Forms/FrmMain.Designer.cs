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
            TreeNode treeNode1 = new TreeNode("Show List Of User");
            TreeNode treeNode2 = new TreeNode("Users", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Computer List");
            TreeNode treeNode4 = new TreeNode("Computers", new TreeNode[] { treeNode3 });
            treeView1 = new TreeView();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            userListToolStripMenuItem = new ToolStripMenuItem();
            userListsWithComputersToolStripMenuItem = new ToolStripMenuItem();
            computerToolStripMenuItem = new ToolStripMenuItem();
            computerListToolStripMenuItem = new ToolStripMenuItem();
            computerListWithUserToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            treeView1.ItemHeight = 50;
            treeView1.Location = new Point(0, 27);
            treeView1.Name = "treeView1";
            treeNode1.Name = "SNDShowUser";
            treeNode1.Text = "Show List Of User";
            treeNode2.Name = "NDUsers";
            treeNode2.Text = "Users";
            treeNode3.Name = "SNDComputerList";
            treeNode3.Text = "Computer List";
            treeNode4.Name = "NDComputers";
            treeNode4.Text = "Computers";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode4 });
            treeView1.Size = new Size(287, 563);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, computerToolStripMenuItem, helpToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(937, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userListToolStripMenuItem, userListsWithComputersToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.ShortcutKeyDisplayString = "";
            userToolStripMenuItem.Size = new Size(42, 20);
            userToolStripMenuItem.Text = "User";
            // 
            // userListToolStripMenuItem
            // 
            userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            userListToolStripMenuItem.Size = new Size(213, 22);
            userListToolStripMenuItem.Text = "User List";
            userListToolStripMenuItem.Click += userListToolStripMenuItem_Click;
            // 
            // userListsWithComputersToolStripMenuItem
            // 
            userListsWithComputersToolStripMenuItem.Name = "userListsWithComputersToolStripMenuItem";
            userListsWithComputersToolStripMenuItem.Size = new Size(213, 22);
            userListsWithComputersToolStripMenuItem.Text = "User Lists With Computers";
            // 
            // computerToolStripMenuItem
            // 
            computerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computerListToolStripMenuItem, computerListWithUserToolStripMenuItem });
            computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            computerToolStripMenuItem.Size = new Size(73, 20);
            computerToolStripMenuItem.Text = "Computer";
            // 
            // computerListToolStripMenuItem
            // 
            computerListToolStripMenuItem.Name = "computerListToolStripMenuItem";
            computerListToolStripMenuItem.Size = new Size(203, 22);
            computerListToolStripMenuItem.Text = "Computer List";
            computerListToolStripMenuItem.Click += computerListToolStripMenuItem_Click;
            // 
            // computerListWithUserToolStripMenuItem
            // 
            computerListWithUserToolStripMenuItem.Name = "computerListWithUserToolStripMenuItem";
            computerListWithUserToolStripMenuItem.Size = new Size(203, 22);
            computerListWithUserToolStripMenuItem.Text = "Computer List With User";
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblTime });
            statusStrip1.Location = new Point(0, 591);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(937, 22);
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
            timer1.Tick += timer1_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 613);
            Controls.Add(statusStrip1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "FrmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripMenuItem userListsWithComputersToolStripMenuItem;
        private ToolStripMenuItem computerListToolStripMenuItem;
        private ToolStripMenuItem computerListWithUserToolStripMenuItem;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTime;
    }
}