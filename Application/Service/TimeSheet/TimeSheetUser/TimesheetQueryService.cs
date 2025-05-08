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
            var list = _context.Computers
                .Where(c => c.Name.Contains(searchTerm))
                .Select(c => new TimesheetUserDto
                {
                    ComputerId = c.Id,
                    ComputerName = c.Name,

                    // کاربر فعلی
                    AssignedUserName = _context.UserComputers
                        .Where(uc => uc.ComputerID == c.Id && !uc.IsDeactive)
                        .Select(uc => uc.User.Name + " " + uc.User.LastName)
                        .FirstOrDefault(),

                    LastVisitDate = _context.Timesheets
                        .Where(t => t.ComputerId == c.Id)
                        .OrderByDescending(t => t.Date)
                        .Select(t => (DateTime?)t.Date)
                        .FirstOrDefault(),

                    IsDone = _context.Timesheets
                        .Where(t => t.ComputerId == c.Id)
                        .OrderByDescending(t => t.Date)
                        .Select(t => (bool?)t.IsDone)
                        .FirstOrDefault()
                })
                .ToList();

            return list;
        }
    }

}
