using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public void Save(int computerId, DateTime date, bool isDone)
        {
            var activeUserId = _context.UserComputers
                 .Where(x => x.ComputerID == computerId && !x.IsDeactive)
                 .Select(x => x.UserID)
                 .FirstOrDefault();

            DateTime from = date.Date.AddDays(-15);
            DateTime to = date.Date.AddDays(15);

            bool checklistExists = _context.CheckLists
                .Any(x =>
                    x.ChMain.ComputerId == computerId &&
                    x.ChMain.CreatedAt >= from &&
                    x.ChMain.CreatedAt <= to
                );

            var timesheet = new Timesheet
            {
                ComputerId = computerId,
                UserId = activeUserId,
                Date = date,
                IsDone = checklistExists
            };

            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();
        }
    }
}
