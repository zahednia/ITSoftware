using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.SaveService
{
    public class ComputerHardwareSaveService : IComputerHardwareSaveService
    {
        private readonly IDatabaseContext _context;

        public ComputerHardwareSaveService(IDatabaseContext context)
        {
            _context = context;
        }

        public void SaveHardwareToComputer(SaveHardwareToComputerDto dto)
        {
            // پیدا یا ساختن HardwareType
            var type = _context.HardwareTypes.FirstOrDefault(t => t.Type == dto.HardwareType);
            if (type == null)
            {
                type = new HardwareType { Type = dto.HardwareType };
                _context.HardwareTypes.Add(type);
                _context.SaveChanges();
            }

            // پیدا یا ساختن HardwareBrand برای اون Type
            var brand = _context.HardwareBrands.FirstOrDefault(b => b.Brand == dto.HardwareBrand && b.HardwareTypeId == type.Id);
            if (brand == null)
            {
                brand = new Domain.Entities.HardwareBrand { Brand = dto.HardwareBrand, HardwareTypeId = type.Id };
                _context.HardwareBrands.Add(brand);
                _context.SaveChanges();
            }

            // پیدا یا ساختن HardwareDetail برای اون Brand و Type
            var detail = _context.HardwareDetails.FirstOrDefault(d =>
                d.Detail == dto.HardwareDetail &&
                d.HardwareTypeId == type.Id &&
                d.HardwareBrandId == brand.Id);

            if (detail == null)
            {
                detail = new Domain.Entities.HardwareDetail
                {
                    Detail = dto.HardwareDetail,
                    HardwareTypeId = type.Id,
                    HardwareBrandId = brand.Id
                };
                _context.HardwareDetails.Add(detail);
                _context.SaveChanges();
            }

            // پیدا یا ساختن Hardware نهایی با IDها
            var hardware = _context.Hardwares.FirstOrDefault(h =>
                h.HardwareTypeId == type.Id &&
                h.HardwareBrandId == brand.Id &&
                h.HardwareDetailId == detail.Id);

            if (hardware == null)
            {
                hardware = new Hardware
                {
                    HardwareTypeId = type.Id,
                    HardwareBrandId = brand.Id,
                    HardwareDetailId = detail.Id
                };
                _context.Hardwares.Add(hardware);
                _context.SaveChanges();
            }

            // ساخت ارتباط با کامپیوتر
            var computerHardware = new ComputerHardware
            {
                ComputerId = dto.ComputerId,
                HardwareId = hardware.Id,
                IsDeactive = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            };
            _context.ComputerHardwares.Add(computerHardware);
            _context.SaveChanges();
        }
    }
}
