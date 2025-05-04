using ApplicationIT.Service.CheckListService.CheckListView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.CheckListService.ChecklistGrid
{
    public interface ICheckListGridService
    {
        List<ChecklistGridDto> Execute(int computerId);
    }
}
