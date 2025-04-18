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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DGComputerList = new DataGridView();
            BtnSearchComputerList = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGComputerList).BeginInit();
            SuspendLayout();
            // 
            // DGComputerList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGComputerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGComputerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGComputerList.DefaultCellStyle = dataGridViewCellStyle2;
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
            BtnSearchComputerList.Location = new Point(494, 16);
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
            textBox1.Size = new Size(474, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(719, 17);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 3;
            button1.Text = "اضافه کردن سیستم جدید";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmComputerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
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
        private Button button1;
    }
}