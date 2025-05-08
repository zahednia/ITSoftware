using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ApplicationIT.Service.TimeSheet.TimeSheetUser
{
    public class TimesheetUserDto
    {
        public int ComputerId { get; set; }
        public string ComputerName { get; set; }
        public string AssignedUserName { get; set; } // فقط برای نمایش
        public DateTime? LastVisitDate { get; set; }
        public string ShamsiDate
        {
            get
            {
                if (LastVisitDate.HasValue)
                {
                    var pc = new PersianCalendar();
                    var d = LastVisitDate.Value;
                    return $"{pc.GetYear(d):0000}/{pc.GetMonth(d):00}/{pc.GetDayOfMonth(d):00}";
                }
                return "-";
            }
        }
        public bool? IsDone { get; set; }
    }

}
