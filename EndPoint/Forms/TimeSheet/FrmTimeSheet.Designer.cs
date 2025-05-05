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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGTimeSheet).BeginInit();
            SuspendLayout();
            // 
            // DGTimeSheet
            // 
            DGTimeSheet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTimeSheet.Dock = DockStyle.Fill;
            DGTimeSheet.Location = new Point(0, 0);
            DGTimeSheet.Name = "DGTimeSheet";
            DGTimeSheet.Size = new Size(800, 450);
            DGTimeSheet.TabIndex = 0;
            // 
            // FrmTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGTimeSheet);
            Name = "FrmTimeSheet";
            Text = "FrmTimeSheet";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGTimeSheet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView DGTimeSheet;
    }
}