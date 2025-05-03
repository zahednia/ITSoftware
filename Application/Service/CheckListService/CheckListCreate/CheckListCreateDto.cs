using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.CheckListService.CheckListCreate
{
    public class CheckListCreateDto
    {
        public int ComputerId { get; set; }
        public string Detail { get; set; }
        public int InspectorUserId { get; set; } // بازرس
        public List<CheckListItemDto> Items { get; set; }
    }
    public class CheckListItemDto
    {
        public int ChTypeId { get; set; }
        public int ChStatusId { get; set; }
    }
}
