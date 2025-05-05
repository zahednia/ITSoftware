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
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(61, 188);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(139, 44);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // FrmAddTimeSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 263);
            Controls.Add(BtnSave);
            Name = "FrmAddTimeSheet";
            Text = "FrmAddTimeSheet";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSave;
    }
}