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
            DGComputerList.Location = new Point(1, 63);
            DGComputerList.Margin = new Padding(3, 4, 3, 4);
            DGComputerList.Name = "DGComputerList";
            DGComputerList.RowHeadersWidth = 51;
            DGComputerList.Size = new Size(910, 536);
            DGComputerList.TabIndex = 0;
            DGComputerList.CellContentClick += DGComputerList_CellContentClick;
            DGComputerList.CellContentDoubleClick += DGComputerList_CellContentDoubleClick;
            DGComputerList.CellDoubleClick += DGComputerList_CellDoubleClick;
            // 
            // BtnSearchComputerList
            // 
            BtnSearchComputerList.Location = new Point(658, 16);
            BtnSearchComputerList.Margin = new Padding(3, 4, 3, 4);
            BtnSearchComputerList.Name = "BtnSearchComputerList";
            BtnSearchComputerList.Size = new Size(219, 31);
            BtnSearchComputerList.TabIndex = 1;
            BtnSearchComputerList.Text = "BtnSearchComputerList";
            BtnSearchComputerList.UseVisualStyleBackColor = true;
            BtnSearchComputerList.Click += BtnSearchComputerList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 16);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(627, 27);
            textBox1.TabIndex = 2;
            // 
            // FrmComputerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(BtnSearchComputerList);
            Controls.Add(DGComputerList);
            Margin = new Padding(3, 4, 3, 4);
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