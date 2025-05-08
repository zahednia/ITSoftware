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
            DGTimeSheet.Location = new Point(0, 84);
            DGTimeSheet.Margin = new Padding(3, 4, 3, 4);
            DGTimeSheet.Name = "DGTimeSheet";
            DGTimeSheet.RowHeadersWidth = 51;
            DGTimeSheet.Size = new Size(914, 516);
            DGTimeSheet.TabIndex = 0;
            DGTimeSheet.CellClick += DGTimeSheet_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 28);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(607, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FrmTimeSheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtSearch);
            Controls.Add(DGTimeSheet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTimeSheet";
            Text = "FrmTimeSheet";
            Load += FrmTimeSheet_Load;
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