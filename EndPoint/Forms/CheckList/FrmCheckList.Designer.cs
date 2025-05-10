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
            DGItems = new DataGridView();
            btnAddItem = new Button();
            ((System.ComponentModel.ISupportInitialize)DGItems).BeginInit();
            SuspendLayout();
            // 
            // DGItems
            // 
            DGItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGItems.Location = new Point(0, 55);
            DGItems.Name = "DGItems";
            DGItems.RowHeadersWidth = 51;
            DGItems.Size = new Size(804, 404);
            DGItems.TabIndex = 0;
            DGItems.CellContentClick += DGItems_CellContentClick;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(192, 255, 192);
            btnAddItem.Location = new Point(312, 10);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(180, 39);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add ITEM";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // FrmCheckList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 459);
            Controls.Add(btnAddItem);
            Controls.Add(DGItems);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmCheckList";
            Text = "FrmCheckList";
            Load += FrmCheckList_Load;
            ((System.ComponentModel.ISupportInitialize)DGItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGItems;
        private Button btnAddItem;
    }
}