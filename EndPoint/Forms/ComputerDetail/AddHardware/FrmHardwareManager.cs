using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail.AddHardware
{
    public partial class FrmHardwareManager : Form
    {
        private int? editId = null;

        private readonly IDatabaseContext _db;

        public FrmHardwareManager(IDatabaseContext db)
        {
            InitializeComponent();
            _db = db;
            Load += FrmHardwareManager_Load;
        }

        private void FrmHardwareManager_Load(object sender, EventArgs e)
        {
            LoadHardwareList();
            txtSearch.TextChanged += TxtSearch_TextChanged;
            BtnAdd.Click += BtnAdd_Click;
            DGHardwareList.CellContentClick += DGHardwareList_CellContentClick;
            DGHardwareList.CellPainting += DGHardwareList_CellPainting;
            DGHardwareList.MouseMove += (s, e) => DGHardwareList.Invalidate();

        }


        private void LoadHardwareList()
        {
            // گرفتن 18 آیتم آخر بر اساس CreatedAt
            var list = (from d in _db.HardwareDetails
                        join b in _db.HardwareBrands on d.HardwareBrandId equals b.Id
                        join t in _db.HardwareTypes on d.HardwareTypeId equals t.Id
                        orderby d.CreatedAt descending
                        select new
                        {
                            d.Id,
                            Type = t.Type,
                            Brand = b.Brand,
                            Detail = d.Detail
                        })
                        .Take(18)
                        .ToList();

            hardwareBindingSource.DataSource = list;

            DGHardwareList.Columns.Clear();
            DGHardwareList.AutoGenerateColumns = false;

            DGHardwareList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false
            });

            DGHardwareList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                Name = "Type",
                HeaderText = "نوع سخت‌افزار"
            });

            DGHardwareList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Brand",
                Name = "Brand",
                HeaderText = "برند"
            });

            DGHardwareList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Detail",
                Name = "Detail",
                HeaderText = "مشخصات"
            });

            DGHardwareList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "ویرایش",
                UseColumnTextForButtonValue = true
            });

            DGHardwareList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "حذف",
                UseColumnTextForButtonValue = true
            });

            DGHardwareList.DataSource = hardwareBindingSource;
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            var filtered = (from d in _db.HardwareDetails
                            join b in _db.HardwareBrands on d.HardwareBrandId equals b.Id
                            join t in _db.HardwareTypes on d.HardwareTypeId equals t.Id
                            where b.Brand.ToLower().Contains(search) || d.Detail.ToLower().Contains(search) || t.Type.ToLower().Contains(search)
                            select new
                            {
                                d.Id,
                                Type = t.Type,
                                Brand = b.Brand,
                                Detail = d.Detail
                            }).ToList();

            hardwareBindingSource.DataSource = filtered;
        }
        private void DGHardwareList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var column = DGHardwareList.Columns[e.ColumnIndex];
            if (column.Name != "Edit" && column.Name != "Delete")
                return;

            e.Handled = true;

            bool isHovered = DGHardwareList.CurrentCell != null &&
                             DGHardwareList.CurrentCell.RowIndex == e.RowIndex &&
                             DGHardwareList.CurrentCell.ColumnIndex == e.ColumnIndex;

            // رنگ‌های پایه
            Color baseColor = column.Name == "Edit" ? Color.FromArgb(255, 255, 192) : Color.FromArgb(255, 192, 192);
            Color hoverColor = ControlPaint.Light(baseColor);

            // فونت
            var font = isHovered
                ? new Font(e.CellStyle.Font, FontStyle.Bold)
                : e.CellStyle.Font;

            using (Brush b = new SolidBrush(isHovered ? hoverColor : baseColor))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }

            TextRenderer.DrawText(
                e.Graphics,
                column.Name == "Edit" ? "ویرایش" : "حذف",
                font,
                e.CellBounds,
                Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
        }





        private void DGHardwareList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (hardwareBindingSource == null || e.RowIndex >= hardwareBindingSource.Count)
                return;

            var row = (dynamic)hardwareBindingSource[e.RowIndex];
            int id = row.Id;

            string columnName = DGHardwareList.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
        var item = _db.HardwareDetails
        .Include(x => x.HardwareBrand)
        .FirstOrDefault(x => x.Id == id);
                bool isUsed = _db.ComputerHardwares.Any(ch => ch.Hardware.HardwareDetailId == id);
                if (isUsed)
                {
                    MessageBox.Show("این قطعه به یک کامپیوتر متصل است و قابل ویرایش نیست.");
                    return;
                }
                using (var frm = new FrmHardwareEdit(_db, id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var updated = _db.HardwareDetails
                            .Include(x => x.HardwareBrand)
                            .Include(x => x.HardwareType)
                            .FirstOrDefault(x => x.Id == id);

                        if (updated != null)
                        {
                            hardwareBindingSource[e.RowIndex] = new
                            {
                                Id = updated.Id,
                                Type = updated.HardwareType.Type,
                                Brand = updated.HardwareBrand.Brand,
                                Detail = updated.Detail
                            };
                        }
                    }
                }
            }
            else if (columnName == "Delete")
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == id);
                if (item != null)
                {
                    // بررسی اتصال به کامپیوتر
                    bool isUsed = _db.ComputerHardwares.Any(ch => ch.Hardware.HardwareDetailId == id);
                    if (isUsed)
                    {
                        MessageBox.Show("این قطعه به یک کامپیوتر متصل است و نمی‌توان آن را حذف کرد.");
                        return;
                    }

                    var confirm = MessageBox.Show("آیا مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var brandId = item.HardwareBrandId;
                        _db.HardwareDetails.Remove(item);
                        _db.SaveChanges();

                        // اگر برند دیگری با این برند وجود ندارد، برند را هم حذف کن
                        bool hasOther = _db.HardwareDetails.Any(x => x.HardwareBrandId == brandId);
                        if (!hasOther)
                        {
                            var brand = _db.HardwareBrands.FirstOrDefault(x => x.Id == brandId);
                            if (brand != null)
                            {
                                _db.HardwareBrands.Remove(brand);
                                _db.SaveChanges();
                            }
                        }

                        hardwareBindingSource.RemoveAt(e.RowIndex);
                    }
                }
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmHardwareEdit(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var addedItem = _db.HardwareDetails
                        .Include(x => x.HardwareBrand)
                        .Include(x => x.HardwareType)
                        .OrderByDescending(x => x.Id)
                        .FirstOrDefault();

                    if (addedItem != null)
                        hardwareBindingSource.Add(new
                        {
                            Id = addedItem.Id,
                            Type = addedItem.HardwareType.Type,
                            Brand = addedItem.HardwareBrand.Brand,
                            Detail = addedItem.Detail
                        });
                }
            }
        }

        private void FrmHardwareManager_Load_1(object sender, EventArgs e)
        {

        }
    }
}
