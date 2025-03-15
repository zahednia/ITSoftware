namespace EndPoint.Forms
{
    partial class FrmUsers
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
            BtnSearchUsers = new Button();
            txtSearchUsers = new TextBox();
            DGUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGUsers).BeginInit();
            SuspendLayout();
            // 
            // BtnSearchUsers
            // 
            BtnSearchUsers.Location = new Point(640, 48);
            BtnSearchUsers.Name = "BtnSearchUsers";
            BtnSearchUsers.Size = new Size(219, 23);
            BtnSearchUsers.TabIndex = 0;
            BtnSearchUsers.Text = "BtnSearchUsers";
            BtnSearchUsers.UseVisualStyleBackColor = true;
            BtnSearchUsers.Click += BtnSearchUsers_Click;
            // 
            // txtSearchUsers
            // 
            txtSearchUsers.Location = new Point(12, 48);
            txtSearchUsers.Name = "txtSearchUsers";
            txtSearchUsers.Size = new Size(606, 22);
            txtSearchUsers.TabIndex = 1;
            // 
            // DGUsers
            // 
            DGUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUsers.Location = new Point(12, 94);
            DGUsers.Name = "DGUsers";
            DGUsers.Size = new Size(847, 441);
            DGUsers.TabIndex = 2;
            DGUsers.CellContentClick += DGUsers_CellContentClick;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 547);
            Controls.Add(DGUsers);
            Controls.Add(txtSearchUsers);
            Controls.Add(BtnSearchUsers);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmUsers";
            Text = "FrmUsers";
            Load += FrmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DGUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearchUsers;
        private TextBox txtSearchUsers;
        private DataGridView DGUsers;
    }
}