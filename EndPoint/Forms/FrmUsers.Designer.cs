﻿namespace EndPoint.Forms
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
            txtSearchUsers = new TextBox();
            DGUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGUsers).BeginInit();
            SuspendLayout();
            // 
            // txtSearchUsers
            // 
            txtSearchUsers.Location = new Point(12, 22);
            txtSearchUsers.Name = "txtSearchUsers";
            txtSearchUsers.Size = new Size(847, 22);
            txtSearchUsers.TabIndex = 1;
            txtSearchUsers.TextChanged += txtSearchUsers_TextChanged;
            // 
            // DGUsers
            // 
            DGUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUsers.Location = new Point(-2, 65);
            DGUsers.Name = "DGUsers";
            DGUsers.RowHeadersWidth = 51;
            DGUsers.Size = new Size(872, 482);
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
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmUsers";
            Text = "FrmUsers";
            Load += FrmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DGUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearchUsers;
        private DataGridView DGUsers;
    }
}