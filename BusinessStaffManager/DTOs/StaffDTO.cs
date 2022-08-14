using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class StaffDTO
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Phone { get; set; }
        public virtual Position Position { get; set; }
    }
}
