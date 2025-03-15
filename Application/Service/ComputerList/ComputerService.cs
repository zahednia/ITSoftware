using ApplicationIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.UserService
{
    public class UserShowService : IComputerService
    {
        private readonly IDatabaseContext database;

        public UserShowService(IDatabaseContext database)
        {
            this.database = database;
        }


        public List<UserShowServiceDTO> Execute(string searchKey = null)
        {
            var ContactQuery = database.Users.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                    p.Name.Contains(searchKey)
                    ||
                    p.LastName.Contains(searchKey));
            }

            var contacts = ContactQuery.Select(p => new UserShowServiceDTO
            {
                Id = p.Id,
                FullName = $"{p.Name} {p.LastName}",
            }).ToList();
            return contacts;
        }
    }
}
