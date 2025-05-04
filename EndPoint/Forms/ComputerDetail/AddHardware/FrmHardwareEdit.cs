using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail.AddHardware
{
    public partial class FrmHardwareEdit : Form
    {
        private readonly IDatabaseContext _db;
        private readonly int? _editId;

        public FrmHardwareEdit(IDatabaseContext db, int? id = null)
        {
            InitializeComponent();
            _db = db;
            _editId = id;
            Load += FrmHardwareEdit_Load;
        }
        private void LoadBrandsByType(int hardwareTypeId)
        {
            var brands = _db.HardwareBrands
                .Where(x => x.HardwareTypeId == hardwareTypeId)
                .Select(x => x.Brand)
                .Distinct()
                .ToList();

            cmbBrand.DataSource = null;
            cmbBrand.Items.Clear();
            cmbBrand.Items.AddRange(brands.ToArray());
        }


        private void FrmHardwareEdit_Load(object sender, EventArgs e)
        {
            LoadHardwareTypes();
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;

            if (_editId.HasValue)
            {
                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == _editId);
                if (item != null)
                {
                    cmbHardwareType.SelectedValue = item.HardwareTypeId;
                    txtDetail.Text = item.Detail;
                    LoadBrandsByType(item.HardwareTypeId);
                    cmbBrand.Text = _db.HardwareBrands.FirstOrDefault(x => x.Id == item.HardwareBrandId)?.Brand;
                }
            }
        }

        private void LoadHardwareTypes()
        {
            cmbHardwareType.DisplayMember = "Type";
            cmbHardwareType.ValueMember = "Id";
            cmbHardwareType.DataSource = _db.HardwareTypes.ToList();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
                    HardwareTypeId = typeId,
                    Brand = brandName,
                    CreatedAt = DateTime.Now
                };
                _db.HardwareBrands.Add(brand);
                _db.SaveChanges();
            }

            if (_editId.HasValue)
            {
                // بررسی اینکه به کامپیوتری وصل نباشه
                var usedHardwareId = _db.Hardwares
                    .Where(h => h.HardwareDetailId == _editId.Value)
                    .Select(h => h.Id)
                    .ToList();

                bool isUsed = _db.ComputerHardwares.Any(ch => usedHardwareId.Contains(ch.HardwareId));
                if (isUsed)
                {
                    MessageBox.Show("این قطعه به یک کامپیوتر متصل است و نمی‌توان آن را ویرایش کرد.");
                    return;
                }

                var item = _db.HardwareDetails.FirstOrDefault(x => x.Id == _editId);
                if (item != null)
                {
                    item.HardwareTypeId = typeId;
                    item.HardwareBrandId = brand.Id;
                    item.Detail = detail;
                    _db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    return;
                }
            }

            // در حالت افزودن جدید
            var exists = _db.HardwareDetails.Any(x => x.HardwareTypeId == typeId && x.HardwareBrandId == brand.Id && x.Detail == detail);
            if (exists)
            {
                MessageBox.Show("این مشخصه قبلاً ثبت شده است.");
                return;
            }

            var newDetail = new HardwareDetail
            {
                HardwareTypeId = typeId,
                HardwareBrandId = brand.Id,
                Detail = detail,
                CreatedAt = DateTime.Now
            };

            _db.HardwareDetails.Add(newDetail);
            _db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void cmbHardwareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHardwareType.SelectedValue is int typeId)
            {
                LoadBrandsByType(typeId);
            }
        }
    }
}
