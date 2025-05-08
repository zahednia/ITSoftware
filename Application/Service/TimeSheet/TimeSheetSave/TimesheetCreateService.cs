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
            DateTime visitDay = date.Date;
            DateTime checklistDeadline = visitDay.AddDays(1); 

            bool checklistIsDone = _context.CheckLists
                .Any(x =>
                    x.ChMain.ComputerId == computerId &&
                    x.ChMain.CreatedAt >= visitDay &&
                    x.ChMain.CreatedAt < checklistDeadline
                );


            var timesheet = new Timesheet
            {
                ComputerId = computerId,
                UserId = activeUserId,
                Date = date,
                IsDone = checklistIsDone
            };

            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();
        }
    }
}
