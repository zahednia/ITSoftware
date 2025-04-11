using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmHardwareManager : Form
    {
        private readonly IDatabaseContext _db;
        private int? editingId = null;

        public FrmHardwareManager(IDatabaseContext db)
        {
            InitializeComponent();
            _db = db;
            DGHardwareList.CellContentClick += DGHardwareList_CellContentClick;
            cmbHardwareType.SelectedIndexChanged += cmbHardwareType_SelectedIndexChanged;
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            LoadHardwareTypes();
            ConfigureGridColumns();
            LoadHardwareList();
            DGHardwareList.AllowUserToAddRows = false;
        }
        private void FrmHardwareManager_Load(object sender, EventArgs e)
        {
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;

            ConfigureGridColumns(); // تنظیم ساختار گرید (فقط یک‌بار اجرا می‌شه)
            LoadHardwareTypes();    // لود کردن لیست نوع سخت‌افزارها

            // لود اولیه لیست سخت‌افزارها
            var data = (from d in _db.HardwareDetails
                        join b in _db.HardwareBrands on d.HardwareBrandId equals b.Id
                        join t in _db.HardwareTypes on d.HardwareTypeId equals t.Id
                        select new
                        {
                            d.Id,
                            Type = t.Type,
                            Brand = b.Brand,
                            Detail = d.Detail
                        }).ToList();

            foreach (var item in data)
            {
                DGHardwareList.Rows.Add(item.Id, item.Type, item.Brand, item.Detail);
            }
        }


        private void LoadHardwareTypes()
        {
            var types = _db.HardwareTypes.ToList();
            cmbHardwareType.DisplayMember = "Type";
            cmbHardwareType.ValueMember = "Id";
            cmbHardwareType.DataSource = types;
        }

        private void LoadBrands(int hardwareTypeId)
        {
            var brands = _db.HardwareBrands
                .Where(x => x.HardwareTypeId == hardwareTypeId)
                .Select(x => x.Brand)
                .Distinct()
                .ToList();

            cmbBrand.Items.Clear();
            cmbBrand.Items.AddRange(brands.ToArray());
        }

        private void cmbHardwareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHardwareType.SelectedValue is int selectedTypeId)
                LoadBrands(selectedTypeId);
        }

        private void LoadHardwareList()
        {
            DGHardwareList.Rows.Clear();

            var data = (from d in _db.HardwareDetails
                        join b in _db.HardwareBrands on d.HardwareBrandId equals b.Id
                        join t in _db.HardwareTypes on d.HardwareTypeId equals t.Id
                        select new
                        {
                            d.Id,
                            Type = t.Type,
                            Brand = b.Brand,
                            Detail = d.Detail
                        }).ToList();

            foreach (var item in data)
            {
                DGHardwareList.Rows.Add(item.Id, item.Type, item.Brand, item.Detail);
            }
        }

        private void ConfigureGridColumns()
        {
            DGHardwareList.Columns.Clear();

            DGHardwareList.Columns.Add("Id", "Id");
            DGHardwareList.Columns["Id"].Visible = false;

            DGHardwareList.Columns.Add("Type", "نوع سخت‌افزار");
            DGHardwareList.Columns.Add("Brand", "برند");
            DGHardwareList.Columns.Add("Detail", "مشخصات");

            var editBtn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "ویرایش",
                UseColumnTextForButtonValue = true
            };
            DGHardwareList.Columns.Add(editBtn);

            var deleteBtn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "حذف",
                UseColumnTextForButtonValue = true
            };
            DGHardwareList.Columns.Add(deleteBtn);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbHardwareType.SelectedItem == null || string.IsNullOrWhiteSpace(cmbBrand.Text) || string.IsNullOrWhiteSpace(txtDetail.Text))
            {
                MessageBox.Show("لطفاً تمام فیلدها را تکمیل کنید.");
                return;
            }

            int typeId = (int)cmbHardwareType.SelectedValue;
            string brandName = cmbBrand.Text.Trim();
            string detail = txtDetail.Text.Trim();

            var brand = _db.HardwareBrands.FirstOrDefault(x => x.HardwareTypeId == typeId && x.Brand == brandName);
            if (brand == null)
            {
                brand = new HardwareBrand
                {
                    Brand = brandName,
                    HardwareTypeId = typeId,
                    CreatedAt = DateTime.Now,
                };
                _db.HardwareBrands.Add(brand);
                _db.SaveChanges();
            }

            int brandId = brand.Id;

            if (editingId.HasValue)
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == editingId.Value);
                if (item != null)
                {
                    item.Detail = detail;
                    item.HardwareTypeId = typeId;
                    item.HardwareBrandId = brandId;
                    _db.SaveChanges();

                    foreach (DataGridViewRow row in DGHardwareList.Rows)
                    {
                        if ((int)row.Cells["Id"].Value == editingId.Value)
                        {
                            row.Cells["Type"].Value = _db.HardwareTypes.FirstOrDefault(t => t.Id == typeId)?.Type;
                            row.Cells["Brand"].Value = brandName;
                            row.Cells["Detail"].Value = detail;
                            break;
                        }
                    }

                    editingId = null;
                    MessageBox.Show("ویرایش با موفقیت انجام شد.");
                    cmbBrand.Text = "";
                    txtDetail.Clear();
                    return;
                }
            }

            bool exists = _db.HardwareDetails.Any(x => x.Detail == detail && x.HardwareTypeId == typeId && x.HardwareBrandId == brandId);
            if (exists)
            {
                MessageBox.Show("این مشخصات برای این برند و نوع از قبل ثبت شده است.");
                return;
            }

            var newDetail = new HardwareDetail
            {
                Detail = detail,
                HardwareTypeId = typeId,
                HardwareBrandId = brandId,
                CreatedAt = DateTime.Now,
            };

            _db.HardwareDetails.Add(newDetail);
            _db.SaveChanges();

            var typeName = _db.HardwareTypes.FirstOrDefault(t => t.Id == typeId)?.Type;
            DGHardwareList.Rows.Add(newDetail.Id, typeName, brandName, detail);

            MessageBox.Show("برند و مشخصات با موفقیت ذخیره شدند.");
            cmbBrand.Text = "";
            txtDetail.Clear();
        }

        private void DGHardwareList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var idCell = DGHardwareList.Rows[e.RowIndex].Cells["Id"];
            if (idCell == null || idCell.Value == null)
                return; // اگر مقدار نداشت یعنی روی ردیف خالی کلیک شده

            int id = (int)idCell.Value;


            if (DGHardwareList.Columns[e.ColumnIndex].Name == "Delete")
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == id);
                if (item != null)
                {
                    var confirm = MessageBox.Show("آیا مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        _db.HardwareDetails.Remove(item);
                        _db.SaveChanges();
                        DGHardwareList.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            else if (DGHardwareList.Columns[e.ColumnIndex].Name == "Edit")
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == id);
                if (item != null)
                {
                    editingId = item.Id;
                    cmbHardwareType.SelectedValue = item.HardwareTypeId;
                    cmbBrand.Text = _db.HardwareBrands.FirstOrDefault(b => b.Id == item.HardwareBrandId)?.Brand;
                    txtDetail.Text = item.Detail;
                }
            }
        }
    }
}