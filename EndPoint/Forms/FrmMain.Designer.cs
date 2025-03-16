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
            TreeNode treeNode1 = new TreeNode("Show List Of User");
            TreeNode treeNode2 = new TreeNode("Users", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Cumputers");
            button1 = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(553, 167);
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
            treeView1.Location = new Point(12, 44);
            treeView1.Name = "treeView1";
            treeNode1.Name = "SNDShowUser";
            treeNode1.Text = "Show List Of User";
            treeNode2.Name = "NDUsers";
            treeNode2.Text = "Users";
            treeNode3.Name = "NDComputers";
            treeNode3.Text = "Cumputers";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode3 });
            treeView1.Size = new Size(235, 549);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 602);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Name = "FrmMain";
            Text = "FrmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TreeView treeView1;
    }
}