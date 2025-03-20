using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HardwareDetail
    {
        public int Id { get; set; }
        public int HardwareTypeId { get; set; } // نوع سخت‌افزار (مثلاً 1=CPU، 2=Motherboard)
        public string Title { get; set; } // نام برند یا مدل

        // ارتباط با Parent (برند)
        public int? ParentId { get; set; } // Foreign Key
        public HardwareDetail Parent { get; set; } // Navigation Property
    }
}
