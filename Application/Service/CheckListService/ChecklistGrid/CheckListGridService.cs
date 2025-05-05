using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using ApplicationIT.Database;
    using ApplicationIT.Service.CheckListService.CheckListView;
namespace ApplicationIT.Service.CheckListService.ChecklistGrid
{


    public class CheckListGridService : ICheckListGridService
    {
        private readonly IDatabaseContext _context;

        public CheckListGridService(IDatabaseContext context)
        {
            _context = context;
        }

        public List<ChecklistGridDto> Execute(int computerId)
        {
            var mains = _context.ChMains
                .Where(x => x.ComputerId == computerId)
                .ToList();

            var result = new List<ChecklistGridDto>();

            foreach (var main in mains)
            {
                var items = _context.CheckLists
                    .Where(x => x.ChMainID == main.Id)
                    .ToList();

                var view = new ChecklistGridDto
                {
                    date = main.CreatedAt,
                    FAN = GetStatus(items, 1),
                    HARD = GetStatus(items, 2),
                    MONITOR = GetStatus(items, 3),
                    CASE = GetStatus(items, 4),
                    ANTIVIRUS = GetStatus(items, 5),
                    OS = GetStatus(items, 6),
                    CD = GetStatus(items, 7),
                    Detail = main.Detail,
                };

                result.Add(view);
            }

            return result;
        }

        private string GetStatus(List<Domain.Entities.CheckList> items, int chTypeId)
        {
            var item = items.FirstOrDefault(x => x.ChTypeID == chTypeId);
            if (item == null) return "-";

            return _context.ChStatuses.FirstOrDefault(s => s.Id == item.ChStatusID)?.Status ?? "-";
        }
    }

}
