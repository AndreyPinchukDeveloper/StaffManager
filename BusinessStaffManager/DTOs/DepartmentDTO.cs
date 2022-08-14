using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class DepartmentDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Position> Position { get; set; }
    }
}
