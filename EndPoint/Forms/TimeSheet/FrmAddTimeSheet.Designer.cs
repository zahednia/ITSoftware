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
            ((System.ComponentModel.ISupportInitialize)nudMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(123, 254);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(159, 59);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 98);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "lblUser";
            // 
            // nudMonth
            // 
            nudMonth.Location = new Point(132, 141);
            nudMonth.Name = "nudMonth";
            nudMonth.Size = new Size(145, 27);
            nudMonth.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(132, 207);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(150, 27);
            nudDay.TabIndex = 3;
            nudDay.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // FrmAddTimeSheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 452);
            Controls.Add(nudDay);
            Controls.Add(nudMonth);
            Controls.Add(label1);
            Controls.Add(BtnSave);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}