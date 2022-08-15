using BusinessStaffManager.Models;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessStaffManger.DTOs
{
    public class PositionDTO
    {
        [Key]
        public Guid Id { get; set; }
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int MaxNumber { get; set; }
        public List<StaffReservation> Staff { get; set; }
        public List<DepartmentReservation> Department { get; set; }
    }
}
