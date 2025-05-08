using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimesheetReminder
{
    public interface ITimesheetReminderService
    {
        List<string> GetUpcomingReminders(int daysLeft = 10);
    }

}
