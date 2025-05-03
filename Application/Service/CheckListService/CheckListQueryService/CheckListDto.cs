using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.CheckListService.CheckListQueryService
{
    public class CheckListDto
    {
        public string Type { get; set; }
        public string Status { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
