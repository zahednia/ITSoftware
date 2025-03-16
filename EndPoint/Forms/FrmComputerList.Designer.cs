namespace EndPoint.Forms
{
    partial class FrmComputerList
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
            DGComputerList = new DataGridView();
            BtnSearchComputerList = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGComputerList).BeginInit();
            SuspendLayout();
            // 
            // DGComputerList
            // 
            DGComputerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGComputerList.Location = new Point(1, 47);
            DGComputerList.Name = "DGComputerList";
            DGComputerList.Size = new Size(796, 402);
            DGComputerList.TabIndex = 0;
            DGComputerList.CellContentClick += DGComputerList_CellContentClick;
            // 
            // BtnSearchComputerList
            // 
            BtnSearchComputerList.Location = new Point(576, 12);
            BtnSearchComputerList.Name = "BtnSearchComputerList";
            BtnSearchComputerList.Size = new Size(192, 23);
            BtnSearchComputerList.TabIndex = 1;
            BtnSearchComputerList.Text = "BtnSearchComputerList";
            BtnSearchComputerList.UseVisualStyleBackColor = true;
            BtnSearchComputerList.Click += BtnSearchComputerList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(549, 23);
            textBox1.TabIndex = 2;
            // 
            // FrmComputerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(BtnSearchComputerList);
            Controls.Add(DGComputerList);
            Name = "FrmComputerList";
            Text = "FrmComputerList";
            Load += FrmComputerList_Load;
            ((System.ComponentModel.ISupportInitialize)DGComputerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGComputerList;
        private Button BtnSearchComputerList;
        private TextBox textBox1;
    }
}