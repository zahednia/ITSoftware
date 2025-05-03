using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChMain
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }
        public int ComputerId { get; set; }

        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
