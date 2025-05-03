using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CheckList
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ChMainID")]
        public ChMain ChMain { get; set; }
        public int ChMainID { get; set; }

        [ForeignKey("ChTypeID")]
        public ChType ChType { get; set; }
        public int ChTypeID { get; set; }

        [ForeignKey("ChStatusID")]
        public ChStatus ChStatus { get; set; }
        public int ChStatusID { get; set; }
    }
}
