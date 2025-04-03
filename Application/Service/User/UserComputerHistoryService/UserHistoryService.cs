using ApplicationIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.User.UserComputerHistoryService
{
    public class UserHistoryService : IUserHistoryService
    {
        private readonly IDatabaseContext _context;
        public UserHistoryService(IDatabaseContext context)
        {
            _context = context;
        }

        public int CountUserComputerHistory(int computerId)
        {
            return _context.UserComputers
                .Where(x => x.ComputerID == computerId && x.IsDeactive)
                .Count();
        }

        public List<UserComputerHistoryGridDto> GetUserComputerHistory(int computerId)
        {
            return _context.UserComputers
                .Include(x => x.User)
                .Where(x => x.ComputerID == computerId)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new UserComputerHistoryGridDto
                {
                    FullName = x.User.Name + " " + x.User.LastName,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    IsDeactive = x.IsDeactive
                })
                .ToList();
        }

    }

}
