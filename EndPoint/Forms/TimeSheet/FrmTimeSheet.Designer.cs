namespace EndPoint.Forms.ComputerDetail.TimeSheet
{
    partial class FrmTimeSheet
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
            bindingSource1 = new BindingSource(components);
            DGTimeSheet = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGTimeSheet).BeginInit();
            SuspendLayout();
            // 
            // DGTimeSheet
            // 
            DGTimeSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTimeSheet.Location = new Point(0, 63);
            DGTimeSheet.Name = "DGTimeSheet";
            DGTimeSheet.Size = new Size(800, 387);
            DGTimeSheet.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(532, 23);
            txtSearch.TabIndex = 1;
            // 
            // FrmTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(DGTimeSheet);
            Name = "FrmTimeSheet";
            Text = "FrmTimeSheet";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGTimeSheet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView DGTimeSheet;
        private TextBox txtSearch;
    }
}