using ApplicationIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistory
{
    public class UserComputerHistoryService : IUserComputerHistoryService
    {
        private readonly IDatabaseContext _context;

        public UserComputerHistoryService(IDatabaseContext context)
        {
            _context = context;
        }

        public List<UserComputerHistoryDto> GetHistory(int computerId)
        {
            return _context.UserComputers
                .Include(x => x.User)
                .Where(x => x.ComputerID == computerId)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new UserComputerHistoryDto
                {
                    UserFullName = x.User.Name + " " + x.User.LastName,
                    IsDeactive = x.IsDeactive,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt
                })
                .ToList();
        }
    }
}
