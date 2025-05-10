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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            DGTimeSheet = new DataGridView();
            txtSearch = new TextBox();
            btnGenerateNextYearTimesheets = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGTimeSheet).BeginInit();
            SuspendLayout();
            // 
            // DGTimeSheet
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGTimeSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGTimeSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGTimeSheet.DefaultCellStyle = dataGridViewCellStyle2;
            DGTimeSheet.Location = new Point(0, 53);
            DGTimeSheet.Name = "DGTimeSheet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGTimeSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGTimeSheet.RowHeadersWidth = 51;
            DGTimeSheet.Size = new Size(802, 491);
            DGTimeSheet.TabIndex = 0;
            DGTimeSheet.CellClick += DGTimeSheet_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 11);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(493, 36);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnGenerateNextYearTimesheets
            // 
            btnGenerateNextYearTimesheets.BackColor = Color.FromArgb(255, 192, 192);
            btnGenerateNextYearTimesheets.Location = new Point(657, 11);
            btnGenerateNextYearTimesheets.Name = "btnGenerateNextYearTimesheets";
            btnGenerateNextYearTimesheets.Size = new Size(133, 36);
            btnGenerateNextYearTimesheets.TabIndex = 2;
            btnGenerateNextYearTimesheets.Text = "Update Time";
            btnGenerateNextYearTimesheets.UseVisualStyleBackColor = false;
            btnGenerateNextYearTimesheets.Click += btnGenerateNextYearTimesheets_Click;
            // 
            // FrmTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 543);
            Controls.Add(btnGenerateNextYearTimesheets);
            Controls.Add(txtSearch);
            Controls.Add(DGTimeSheet);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
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
        private Button btnGenerateNextYearTimesheets;
    }
}