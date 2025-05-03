using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.CheckListService.CheckListQueryService
{
    public interface ICheckListQueryService
    {
        List<CheckListDto> GetCheckListsByComputerId(int computerId);
    }

}
