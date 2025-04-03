namespace EndPoint.Forms.ComputerDetail
{
    partial class FrmUserHistory
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
            DGUserHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGUserHistory).BeginInit();
            SuspendLayout();
            // 
            // DGUserHistory
            // 
            DGUserHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUserHistory.Dock = DockStyle.Fill;
            DGUserHistory.Location = new Point(0, 0);
            DGUserHistory.Name = "DGUserHistory";
            DGUserHistory.RowHeadersWidth = 51;
            DGUserHistory.Size = new Size(800, 450);
            DGUserHistory.TabIndex = 0;
            // 
            // FrmUserHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGUserHistory);
            Name = "FrmUserHistory";
            Text = "FrmUserHistory";
            Load += FrmUserHistory_Load;
            ((System.ComponentModel.ISupportInitialize)DGUserHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGUserHistory;
    }
}