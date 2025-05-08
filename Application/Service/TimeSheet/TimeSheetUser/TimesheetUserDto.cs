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
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public bool? IsDone { get; set; }
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
    }

}
