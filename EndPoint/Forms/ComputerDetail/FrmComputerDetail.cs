using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EndPoint.Forms.ComputerDetail
{
    public partial class FrmComputerDetail : Form
    {
        private readonly IDatabaseContext database;
        private readonly int _computerId;

        public FrmComputerDetail(IDatabaseContext database, int computerId = 0)
        {
            InitializeComponent();
            this.database = database;
            _computerId = computerId;
            lblId.Text = _computerId > 0 ? _computerId.ToString() : "New";

            if (_computerId > 0) LoadExistingComputer();
        }

        private void LoadExistingComputer()
        {
            var computer = database.Computers
                .Include(c => c.HardwareComponents)
                .FirstOrDefault(c => c.Id == _computerId);

            if (computer != null)
            {
                txtComputerName.Text = computer.Name;
                LoadExistingComponents(computer.HardwareComponents);
            }
        }

        private void LoadExistingComponents(IEnumerable<ComputerHardware> components)
        {
            foreach (var component in components)
            {
                var hardware = database.HardwareDetails
                    .Include(h => h.Parent) // استفاده از Navigation Property به جای ParentId
                    .FirstOrDefault(h => h.Id == component.HardwareDetailId);

                if (hardware?.Parent != null) // بررسی وجود Parent
                {
                    SetComboSelection(
                        hardware.Parent.HardwareTypeId, // نوع سخت‌افزار از Parent
                        hardware.Parent.Id, // شناسه برند
                        hardware.Id // شناسه مدل
                    );
                }
            }
        }

        private void SetComboSelection(int hardwareTypeId, int brandId, int modelId)
        {
            switch (hardwareTypeId)
            {
                case 1:
                    CBMotherboardBrand.SelectedValue = brandId;
                    CBMotherboardDetail.SelectedValue = modelId;
                    break;
                case 2:
                    CBCpuBrand.SelectedValue = brandId;
                    CBCpuDetail.SelectedValue = modelId;
                    break;
                case 3:
                    CBRamBrand.SelectedValue = brandId;
                    CBRamDetail.SelectedValue = modelId;
                    break;
                case 4:
                    CBGpuBrand.SelectedValue = brandId;
                    CBGpuDetail.SelectedValue = modelId;
                    break;
                case 5:
                    CBHddBrand.SelectedValue = brandId;
                    CBHddDetail.SelectedValue = modelId;
                    break;
            }
        }

        private void FrmComputerDetail_Load(object sender, EventArgs e)
        {
            LoadBrands(1, CBMotherboardBrand);
            LoadBrands(2, CBCpuBrand);
            LoadBrands(3, CBRamBrand);
            LoadBrands(4, CBGpuBrand);
            LoadBrands(5, CBHddBrand);

            CBMotherboardBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBMotherboardBrand, CBMotherboardDetail);
            CBCpuBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBCpuBrand, CBCpuDetail);
            CBRamBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBRamBrand, CBRamDetail);
            CBGpuBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBGpuBrand, CBGpuDetail);
            CBHddBrand.SelectionChangeCommitted += (s, ev) => LoadModels(CBHddBrand, CBHddDetail);
        }

        private void LoadBrands(int hardwareTypeId, ComboBox comboBox)
        {
            comboBox.BeginUpdate();
            comboBox.DataSource = GetBrands(hardwareTypeId);
            comboBox.DisplayMember = "Title";
            comboBox.ValueMember = "Id";
            comboBox.EndUpdate();

            if (comboBox.Items.Count > 0 && comboBox.SelectedIndex == -1)
                comboBox.SelectedIndex = 0;
        }

        private List<HardwareDetail> GetBrands(int hardwareTypeId)
        {
            return database.HardwareDetails
                .Where(h => h.HardwareTypeId == hardwareTypeId && !h.ParentId.HasValue)
                .OrderBy(h => h.Title)
                .ToList();
        }

        private void LoadModels(ComboBox brandComboBox, ComboBox modelComboBox)
        {
            modelComboBox.DataSource = null;
            modelComboBox.Items.Clear();

            if (brandComboBox.SelectedValue is int brandId)
            {
                var models = database.HardwareDetails
                    .Where(h => h.ParentId == brandId)
                    .ToList();

                modelComboBox.DataSource = models;
                modelComboBox.DisplayMember = "Title";
                modelComboBox.ValueMember = "Id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (_computerId > 0)
                UpdateComputer();
            else
                CreateNewComputer();

            Close();
        }

        private void CreateNewComputer()
        {
            var computer = new Computer
            {
                Name = txtComputerName.Text,
                HardwareComponents = GetSelectedComponents()
            };

            database.Computers.Add(computer);
            database.SaveChanges();
        }

        private void UpdateComputer()
        {
            var computer = database.Computers
                .Include(c => c.HardwareComponents)
                .FirstOrDefault(c => c.Id == _computerId);

            if (computer != null)
            {
                computer.Name = txtComputerName.Text;
                computer.HardwareComponents = GetSelectedComponents();
                database.SaveChanges();
            }
        }

        private List<ComputerHardware> GetSelectedComponents()
        {
            var components = new List<ComputerHardware>();
            AddComponent(CBMotherboardDetail, components);
            AddComponent(CBCpuDetail, components);
            AddComponent(CBRamDetail, components);
            AddComponent(CBGpuDetail, components);
            AddComponent(CBHddDetail, components);
            return components;
        }

        private void AddComponent(ComboBox comboBox, List<ComputerHardware> components)
        {
            if (comboBox.SelectedValue is int modelId)
            {
                components.Add(new ComputerHardware
                {
                    HardwareDetailId = modelId
                });
            }
        }

        private bool ValidateForm()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtComputerName.Text))
                errors.Add("نام کامپیوتر الزامی است");

            if (!IsComponentSelected(CBMotherboardDetail))
                errors.Add("مادربرد انتخاب نشده");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "خطا");
                return false;
            }
            return true;
        }

        private bool IsComponentSelected(ComboBox comboBox)
        {
            return comboBox.SelectedValue != null && comboBox.SelectedValue is int;
        }
    }
}