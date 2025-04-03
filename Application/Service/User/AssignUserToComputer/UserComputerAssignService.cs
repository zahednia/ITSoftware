using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.AssignUserToComputer
{
    public class UserComputerAssignService : IUserComputerAssignService
    {
        private readonly IDatabaseContext _context;

        public UserComputerAssignService(IDatabaseContext context)
        {
            _context = context;
        }

        public void AssignUserToComputer(AssignUserToComputerDto dto)
        {
            // غیرفعال کردن قبلی‌ها
            var oldRelations = _context.UserComputers
                .Where(uc => uc.ComputerID == dto.ComputerId && !uc.IsDeactive)
                .ToList();

            foreach (var old in oldRelations)
            {
                old.IsDeactive = true;
                old.UpdatedAt = DateTime.UtcNow;
            }

            // افزودن رابطه جدید
            var relation = new UserComputer
            {
                ComputerID = dto.ComputerId,
                UserID = dto.UserId,
                IsDeactive = false,
                CreatedAt = DateTime.UtcNow
            };

            _context.UserComputers.Add(relation);
            _context.SaveChanges();
        }

    }

}
