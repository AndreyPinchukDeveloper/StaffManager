﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
