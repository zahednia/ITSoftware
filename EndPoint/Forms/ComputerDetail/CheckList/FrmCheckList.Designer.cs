namespace EndPoint.Forms.ComputerDetail.CheckList
{
    partial class FrmCheckList
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
            dataGridView1 = new DataGridView();
            btnAddItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(786, 381);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(612, 21);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(136, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add ITEM";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // FrmCheckList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 459);
            Controls.Add(btnAddItem);
            Controls.Add(dataGridView1);
            Name = "FrmCheckList";
            Text = "FrmCheckList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddItem;
    }
}