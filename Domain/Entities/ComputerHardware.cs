using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ComputerHardware
    {
        [Key]
        public int Id { get; set; }

        // ارتباط با کامپیوتر
        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }
        public int ComputerId { get; set; }

        // ارتباط با سخت‌افزار
        [ForeignKey("HardwareId")]
        public Hardware Hardware { get; set; }
        public int HardwareId { get; set; }

        // وضعیت فعال/غیرفعال
        public bool IsDeactive { get; set; } = false;

        // زمان‌های ایجاد و ویرایش (اختیاری)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
