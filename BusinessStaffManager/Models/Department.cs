﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManager.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Position> Position { get; set; }
    }
}