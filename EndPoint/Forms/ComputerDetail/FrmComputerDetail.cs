using ApplicationIT.Database;
using Domain.Entities;
using System.Data;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetail : Form
    {
        private readonly IDatabaseContext database;

        public FrmComputerDetail(IDatabaseContext database, int computerId)
        {
            InitializeComponent();
            this.database = database;
            lblId.Text = computerId.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmComputerDetail_Load(object sender, EventArgs e)
        {
            LoadBrands(1, CBMotherboardBrand); // نوع 1 = Motherboard
            LoadBrands(2, CBCpuBrand);         // نوع 2 = CPU
            LoadBrands(3, CBRamBrand);         // نوع 3 = RAM
            LoadBrands(4, CBGpuBrand);         // نوع 4 = GPU
            LoadBrands(5, CBHddBrand);         // نوع 5 = HDD

            // رویداد تغییر انتخاب برند
            CBMotherboardBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBMotherboardBrand, CBMotherboardDetail);
            CBCpuBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBCpuBrand, CBCpuDetail);
            CBRamBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBRamBrand, CBRamDetail);
            CBGpuBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBGpuBrand, CBGpuDetail);
            CBHddBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBHddBrand, CBHddDetail);
        }
        private void LoadBrands(int hardwareTypeId, ComboBox comboBox)
        {
            // برندها ParentId ندارند (ParentId == null)
            var brands = database.HardwareDetails
                .Where(h => h.HardwareTypeId == hardwareTypeId && h.ParentId == null)
                .ToList();

            comboBox.DataSource = brands;
            comboBox.DisplayMember = "Title";
            comboBox.ValueMember = "Id";
        }

        private void LoadModels(ComboBox brandComboBox, ComboBox modelComboBox)
        {
            if (brandComboBox.SelectedValue != null && int.TryParse(brandComboBox.SelectedValue.ToString(), out int brandId))
            {
                // مدل‌ها ParentId برابر با Id برند دارند
                var models = database.HardwareDetails
                    .Where(h => h.ParentId == brandId)
                    .ToList();

                modelComboBox.DataSource = models;
                modelComboBox.DisplayMember = "Title";
                modelComboBox.ValueMember = "Id";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ۱. ایجاد شیء کامپیوتر
            var computer = new Computer
            {
                Name = "نام کامپیوتر", // یا از TextBox دریافت کنید
                HardwareComponents = new List<ComputerHardware>()
            };

            // ۲. افزودن قطعات سخت‌افزاری
            AddHardwareComponent(CBMotherboardDetail, computer); // مادربرد
            AddHardwareComponent(CBCpuDetail, computer);         // CPU
            AddHardwareComponent(CBRamDetail, computer);         // RAM
            AddHardwareComponent(CBGpuDetail, computer);         // GPU
            AddHardwareComponent(CBHddDetail, computer);         // HDD

            // ۳. ذخیره در دیتابیس

            database.Computers.Add(computer);
            database.SaveChanges();


            MessageBox.Show("اطلاعات با موفقیت ذخیره شد!");

            if (!IsSelectionValid(CBMotherboardDetail) ||
        !IsSelectionValid(CBCpuDetail) ||
        !IsSelectionValid(CBRamDetail) ||
        !IsSelectionValid(CBGpuDetail) ||
        !IsSelectionValid(CBHddDetail))
            {
                MessageBox.Show("لطفاً تمام فیلدهای ضروری را پر کنید!");
                return;
            }
        }

        private void AddHardwareComponent(ComboBox comboBox, Computer computer)
        {
            if (comboBox.SelectedValue != null && int.TryParse(comboBox.SelectedValue.ToString(), out int hardwareDetailId))
            {
                computer.HardwareComponents.Add(new ComputerHardware
                {
                    HardwareDetailId = hardwareDetailId
                });
            }
        }

        private bool IsSelectionValid(ComboBox comboBox)
        {
            return comboBox.SelectedValue != null && comboBox.SelectedValue is int;
        }
    }
}

