using BusinessStaffManager.Models;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class StaffDTO
    {
        [Key]
        public Guid Id { get; set; }
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Phone { get; set; }
        public virtual PositionReservation Position { get; set; }
    }
}
