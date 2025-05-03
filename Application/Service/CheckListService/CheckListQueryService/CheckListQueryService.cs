using ApplicationIT.Database;
using ApplicationIT.Service.CheckListService.CheckListQueryService;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

public class CheckListQueryService : ICheckListQueryService
{
    private readonly IDatabaseContext _context;

    public CheckListQueryService(IDatabaseContext context)
    {
        _context = context;
    }

    public List<CheckListDto> GetCheckListsByComputerId(int computerId)
    {
        var result = (from checklist in _context.CheckLists
                      join chmain in _context.ChMains on checklist.ChMainID equals chmain.Id
                      join chtype in _context.ChTypes on checklist.ChTypeID equals chtype.Id
                      join chstatus in _context.ChStatuses on checklist.ChStatusID equals chstatus.Id
                      where chmain.ComputerId == computerId
                      select new CheckListDto
                      {
                          Type = chtype.Type,
                          Status = chstatus.Status,
                          Detail = chmain.Detail,
                          CreatedAt = chmain.CreatedAt
                      }).ToList();

        return result;
    }
}

