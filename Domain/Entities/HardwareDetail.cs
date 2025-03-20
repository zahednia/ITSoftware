using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HardwareDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int HardwareTypeId { get; set; }

        // Foreign Key برای Parent
        public int? ParentId { get; set; }

        // Navigation Property برای Parent
        [ForeignKey("ParentId")]
        public virtual HardwareDetail Parent { get; set; }

        // Navigation Property برای مدل‌های زیرمجموعه
        public virtual ICollection<HardwareDetail> Models { get; set; }
    }
}
