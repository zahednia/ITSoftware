namespace EndPoint.Forms.ComputerDetail.TimeSheet
{
    partial class FrmAddTimeSheet
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
            BtnSave = new Button();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            nudMonth = new NumericUpDown();
            nudDay = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(192, 255, 192);
            BtnSave.Location = new Point(34, 137);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(191, 48);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "lblUser";
            // 
            // nudMonth
            // 
            nudMonth.Location = new Point(94, 50);
            nudMonth.Margin = new Padding(3, 2, 3, 2);
            nudMonth.Name = "nudMonth";
            nudMonth.Size = new Size(131, 23);
            nudMonth.TabIndex = 2;
            nudMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(94, 94);
            nudDay.Margin = new Padding(3, 2, 3, 2);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(131, 23);
            nudDay.TabIndex = 3;
            nudDay.TextAlign = HorizontalAlignment.Center;
            nudDay.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 96);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "Day";
            // 
            // FrmAddTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 206);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudDay);
            Controls.Add(nudMonth);
            Controls.Add(label1);
            Controls.Add(BtnSave);
            Name = "FrmAddTimeSheet";
            Text = "FrmAddTimeSheet";
            Load += FrmAddTimeSheet_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSave;
        private ColorDialog colorDialog1;
        private Label label1;
        private NumericUpDown nudMonth;
        private NumericUpDown nudDay;
        private Label label2;
        private Label label3;
    }
}