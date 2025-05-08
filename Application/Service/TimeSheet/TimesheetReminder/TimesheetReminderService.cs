using ApplicationIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimesheetReminder
{
    public class TimesheetReminderService : ITimesheetReminderService
    {
        private readonly IDatabaseContext _context;

        public TimesheetReminderService(IDatabaseContext context)
        {
            _context = context;
        }

        public List<string> GetUpcomingReminders(int daysLeft = 10)
        {
            DateTime now = DateTime.Now;
            DateTime threshold = now.AddDays(daysLeft);

            var reminders = _context.Timesheets
                .Where(x => x.Date >= now && x.Date <= threshold)
                .OrderBy(x => x.Date)
                .Select(x => new
                {
                    x.Date,
                    FullName = x.User.Name + " " + x.User.LastName
                })
                .ToList();

            return reminders.Select(r =>
                $"{r.FullName} → بازدید در {r.Date:yyyy/MM/dd}"
            ).ToList();

        }
    }
}