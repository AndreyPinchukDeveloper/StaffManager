using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class PositionDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int MaxNumber { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Department> Department { get; set; }
    }
}
