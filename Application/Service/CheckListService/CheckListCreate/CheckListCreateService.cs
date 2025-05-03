using ApplicationIT.Database;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.CheckListService.CheckListCreate
{
    public class CheckListCreateService : ICheckListCreateService
    {
        private readonly IDatabaseContext _context;

        public CheckListCreateService(IDatabaseContext context)
        {
            _context = context;
        }

        public void Create(CheckListCreateDto dto)
        {
            var main = new ChMain
            {
                ComputerId = dto.ComputerId,
                Detail = dto.Detail,
                CreatedAt = DateTime.Now
            };

            _context.ChMains.Add(main);
            _context.SaveChanges(); // برای گرفتن main.Id

            foreach (var item in dto.Items)
            {
                var checklist = new CheckList
                {
                    ChMainID = main.Id,
                    ChTypeID = item.ChTypeId,
                    ChStatusID = item.ChStatusId
                };

                _context.CheckLists.Add(checklist);
            }

            _context.SaveChanges();
        }
    }

}
