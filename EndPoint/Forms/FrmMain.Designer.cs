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
            TreeNode treeNode4 = new TreeNode("Show List Of User");
            TreeNode treeNode5 = new TreeNode("Users", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Cumputers");
            button1 = new Button();
            treeView1 = new TreeView();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            computerToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            userListToolStripMenuItem = new ToolStripMenuItem();
            userListsWithComputersToolStripMenuItem = new ToolStripMenuItem();
            computerListToolStripMenuItem = new ToolStripMenuItem();
            computerListWithUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(302, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            treeView1.ItemHeight = 50;
            treeView1.Location = new Point(0, 27);
            treeView1.Name = "treeView1";
            treeNode4.Name = "SNDShowUser";
            treeNode4.Text = "Show List Of User";
            treeNode5.Name = "NDUsers";
            treeNode5.Text = "Users";
            treeNode6.Name = "NDComputers";
            treeNode6.Text = "Cumputers";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode5, treeNode6 });
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
            // computerToolStripMenuItem
            // 
            computerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computerListToolStripMenuItem, computerListWithUserToolStripMenuItem });
            computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            computerToolStripMenuItem.Size = new Size(73, 20);
            computerToolStripMenuItem.Text = "Computer";
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
            // userListToolStripMenuItem
            // 
            userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            userListToolStripMenuItem.Size = new Size(213, 22);
            userListToolStripMenuItem.Text = "User List";
            // 
            // userListsWithComputersToolStripMenuItem
            // 
            userListsWithComputersToolStripMenuItem.Name = "userListsWithComputersToolStripMenuItem";
            userListsWithComputersToolStripMenuItem.Size = new Size(213, 22);
            userListsWithComputersToolStripMenuItem.Text = "User Lists With Computers";
            // 
            // computerListToolStripMenuItem
            // 
            computerListToolStripMenuItem.Name = "computerListToolStripMenuItem";
            computerListToolStripMenuItem.Size = new Size(203, 22);
            computerListToolStripMenuItem.Text = "Computer List";
            // 
            // computerListWithUserToolStripMenuItem
            // 
            computerListWithUserToolStripMenuItem.Name = "computerListWithUserToolStripMenuItem";
            computerListWithUserToolStripMenuItem.Size = new Size(203, 22);
            computerListWithUserToolStripMenuItem.Text = "Computer List With User";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 602);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "FrmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
    }
}