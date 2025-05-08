using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimeSheetUser
{
    public class TimesheetUserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public bool? IsDone { get; set; }
    }

}
