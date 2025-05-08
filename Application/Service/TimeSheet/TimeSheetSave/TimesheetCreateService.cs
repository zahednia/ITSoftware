using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimeSheetSave
{
    public class TimesheetCreateService : ITimesheetCreateService
    {
        private readonly IDatabaseContext _context;

        public TimesheetCreateService(IDatabaseContext context)
        {
            _context = context;
        }

        public void Save(int userId, DateTime date, bool isDone)
        {
            var timesheet = new Timesheet
            {
                UserId = userId,
                Date = date,
                IsDone = isDone
            };

            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();
        }
    }
}
