using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.TimeSheet.TimeSheetSave
{
    public interface ITimesheetCreateService
    {
        void Save(int computerId, DateTime date, bool isDone);
    }
}
