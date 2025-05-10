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
            BtnSave.Location = new Point(34, 128);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(191, 45);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(47, 14);
            label1.TabIndex = 1;
            label1.Text = "lblUser";
            // 
            // nudMonth
            // 
            nudMonth.Location = new Point(94, 47);
            nudMonth.Margin = new Padding(3, 2, 3, 2);
            nudMonth.Name = "nudMonth";
            nudMonth.Size = new Size(131, 22);
            nudMonth.TabIndex = 2;
            nudMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(94, 88);
            nudDay.Margin = new Padding(3, 2, 3, 2);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(131, 22);
            nudDay.TabIndex = 3;
            nudDay.TextAlign = HorizontalAlignment.Center;
            nudDay.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 49);
            label2.Name = "label2";
            label2.Size = new Size(48, 14);
            label2.TabIndex = 4;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 90);
            label3.Name = "label3";
            label3.Size = new Size(30, 14);
            label3.TabIndex = 5;
            label3.Text = "Day";
            // 
            // FrmAddTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 192);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudDay);
            Controls.Add(nudMonth);
            Controls.Add(label1);
            Controls.Add(BtnSave);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
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