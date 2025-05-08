using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimeSheetUser
{
    public interface ITimesheetQueryService
    {
        List<TimesheetUserDto> GetUsersWithTimesheet(string searchTerm = "");
    }

}
