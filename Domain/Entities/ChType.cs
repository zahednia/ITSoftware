﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        List<CheckList> CheckList { get; set; }
    }
}
