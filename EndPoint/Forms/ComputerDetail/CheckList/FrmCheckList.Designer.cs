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
            DGItems.Location = new Point(7, 88);
            DGItems.Margin = new Padding(3, 4, 3, 4);
            DGItems.Name = "DGItems";
            DGItems.RowHeadersWidth = 51;
            DGItems.Size = new Size(898, 508);
            DGItems.TabIndex = 0;
            DGItems.CellContentClick += DGItems_CellContentClick;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(699, 28);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(155, 31);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add ITEM";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // FrmCheckList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 612);
            Controls.Add(btnAddItem);
            Controls.Add(DGItems);
            Margin = new Padding(3, 4, 3, 4);
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