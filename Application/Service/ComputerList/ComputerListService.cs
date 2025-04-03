using ApplicationIT.Database;
using ApplicationIT.Service.UserService;

namespace ApplicationIT.Service.ComputerList
{
    public class ComputerListService : IComputerList
    {
        private readonly IDatabaseContext database;

        public ComputerListService(IDatabaseContext database)
        {
            this.database = database;
        }

        public List<ComputerListDTO> ComputerLists(string searchKey = null)
        {
            var ContactQuery = database.Computers.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                    p.Code.Contains(searchKey) || p.Name.Contains(searchKey));
            }

            var contacts = ContactQuery.Select(p => new ComputerListDTO
            {
                Id = p.Id,
                Code = p.Code ,
                Name = p.Name,
            }).ToList();
            return contacts;
        }
    }
}
