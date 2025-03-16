using ApplicationIT.Database;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.Computer
{
    public class ComputerService : IComputerService
    {
        private readonly IDatabaseContext database;

        public ComputerService(IDatabaseContext database)
        {
            this.database = database;
        }

        public List<ComputerWithUsersDto> GetAllComputersWithUsers()
        {
            var computers = database.Computers
                .Select(c => new ComputerWithUsersDto
                {
                    ComputerId = c.Id,
                    ComputerCode = c.Code,
                    Users = c.Users.Select(u => new UserDto
                    {
                        UserId = u.Id,
                        FullName = u.Name + " " + u.LastName,
                        IsActive = u.IsActive
                    }).ToList()
                })
                .ToList();

            return computers;
        }

        public bool RegisterOrUpdateComputer(string computerCode, int userId)
        {
            using (var context = new IDatabaseContext()) // جایگزین با کانتکست خودت
            {
                // جستجوی کامپیوتر با ComputerCode
                var computer = context.Computers
                    .Include(c => c.UserComputers)
                    .FirstOrDefault(c => c.Code == computerCode);

                if (computer == null)
                {
                    // اگر کامپیوتر وجود نداشت، یک کامپیوتر جدید می‌سازیم
                    computer = new Computer
                    {
                        Code = computerCode,
                        UserComputers = new List<UserComputer>()
                    };

                    context.Computers.Add(computer);
                }

                // بررسی اینکه آیا این کاربر قبلاً به این کامپیوتر متصل شده است یا نه
                bool userAlreadyExists = computer.UserComputers.Any(uc => uc.UserId == userId);
                if (!userAlreadyExists)
                {
                    // اگر این کاربر قبلاً به این کامپیوتر متصل نشده بود، اضافه‌اش می‌کنیم
                    computer.UserComputers.Add(new UserComputer
                    {
                        UserId = userId,
                        Computer = computer
                    });
                }

                context.SaveChanges();
                return true;
            }
    }
}
