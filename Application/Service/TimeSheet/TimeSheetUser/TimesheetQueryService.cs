using ApplicationIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimeSheetUser
{
    public class TimesheetQueryService : ITimesheetQueryService
    {
        private readonly IDatabaseContext _context;

        public TimesheetQueryService(IDatabaseContext context)
        {
            _context = context;
        }

        public List<TimesheetUserDto> GetUsersWithTimesheet(string searchTerm = "")
        {
            var users = _context.Users
                .AsNoTracking()
                .Where(x => x.Name.Contains(searchTerm) || x.LastName.Contains(searchTerm))
                .Select(u => new TimesheetUserDto
                {
                    UserId = u.Id,
                    FullName = u.Name + " " + u.LastName,
                    LastVisitDate = _context.Timesheets
                        .AsNoTracking() // اینم خیلی مهمه 👈
                        .Where(t => t.UserId == u.Id)
                        .OrderByDescending(t => t.Id)
                        .Select(t => (DateTime?)t.Date)
                        .FirstOrDefault(),
                    IsDone = _context.Timesheets
                        .AsNoTracking()
                        .Where(t => t.UserId == u.Id)
                        .OrderByDescending(t => t.Date)
                        .Select(t => (bool?)t.IsDone)
                        .FirstOrDefault()
                })
                .ToList();


            return users;
        }
    }

}
