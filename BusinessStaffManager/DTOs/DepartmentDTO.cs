using BusinessStaffManager.Models;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class DepartmentDTO
    {
        [Key]
        public Guid Id { get; set; }
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public List<PositionReservation> Position { get; set; }
    }
}
