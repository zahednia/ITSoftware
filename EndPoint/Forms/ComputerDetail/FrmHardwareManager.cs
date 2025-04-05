using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmHardwareManager : Form
    {
        private readonly IDatabaseContext _db;

        public FrmHardwareManager(IDatabaseContext db)
        {
            InitializeComponent();
            _db = db;
            LoadHardwareTypes();
            DGHardwareList.CellContentClick += DGHardwareList_CellContentClick;
            cmbHardwareType.SelectedIndexChanged += cmbHardwareType_SelectedIndexChanged;


        }
        private void FrmHardwareManager_Load(object sender, EventArgs e)
        {
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            LoadHardwareList();
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
            {
                LoadBrands(selectedTypeId);
            }
        }

        private void LoadHardwareTypes()
        {
            var types = _db.HardwareTypes.ToList();
            cmbHardwareType.DisplayMember = "Type";
            cmbHardwareType.ValueMember = "Id";
            cmbHardwareType.DataSource = types;
        }
        private void LoadHardwareList()
        {
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

            DGHardwareList.DataSource = data;
            DGHardwareList.Columns["Id"].Visible = false;
            if (!DGHardwareList.Columns.Contains("Edit"))
            {
                var editBtn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "ویرایش",
                    UseColumnTextForButtonValue = true
                };
                DGHardwareList.Columns.Add(editBtn);
            }

            if (!DGHardwareList.Columns.Contains("Delete"))
            {
                var deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "حذف",
                    UseColumnTextForButtonValue = true
                };
                DGHardwareList.Columns.Add(deleteBtn);
            }

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

            // گرفتن یا ساختن برند
            var brand = _db.HardwareBrands
                .FirstOrDefault(x => x.HardwareTypeId == typeId && x.Brand == brandName);

            if (brand == null)
            {
                brand = new HardwareBrand
                {
                    Brand = brandName,
                    HardwareTypeId = typeId,
                    CreatedAt = DateTime.Now,
                };

                _db.HardwareBrands.Add(brand);
                _db.SaveChanges(); // گرفتن آیدی برند
            }

            int brandId = brand.Id;

            // بررسی وجود مشخصه
            bool exists = _db.HardwareDetails.Any(x =>
                x.Detail == detail &&
                x.HardwareTypeId == typeId &&
                x.HardwareBrandId == brandId);

            if (exists)
            {
                MessageBox.Show("این مشخصات برای این برند و نوع از قبل ثبت شده است.");
                return;
            }

            _db.HardwareDetails.Add(new HardwareDetail
            {
                Detail = detail,
                HardwareTypeId = typeId,
                HardwareBrandId = brandId,
                CreatedAt = DateTime.Now,
            });

            _db.SaveChanges();
            MessageBox.Show("برند و مشخصات با موفقیت ذخیره شدند.");

            // پاک کردن فیلدها بعد از موفقیت
            cmbBrand.Text = "";
            txtDetail.Clear();
        }
        private void DGHardwareList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var id = (int)DGHardwareList.Rows[e.RowIndex].Cells["Id"].Value;

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
                        LoadHardwareList();
                    }
                }
            }

            if (DGHardwareList.Columns[e.ColumnIndex].Name == "Edit")
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == id);
                if (item != null)
                {
                    cmbHardwareType.SelectedValue = item.HardwareTypeId;
                    cmbBrand.Text = _db.HardwareBrands.FirstOrDefault(b => b.Id == item.HardwareBrandId)?.Brand;
                    txtDetail.Text = item.Detail;

                    // حذفش کنیم تا وقتی ذخیره کرد دوباره ساخته شه (ویرایش به روش ساده)
                    _db.HardwareDetails.Remove(item);
                    _db.SaveChanges();
                    LoadHardwareList();
                }
            }
        }

    }
}
