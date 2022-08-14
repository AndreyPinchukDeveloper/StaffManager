using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationConflictValidators
{
    public interface IReservationConflictValidator
    {
        Task<DepartmentReservation> GetConflictReservation(DepartmentReservation departmentReservation);
        Task <PositionReservation> GetConflictReservation(PositionReservation positionReservation);
        Task<StaffReservation> GetConflictReservation(StaffReservation staffReservation);
    }
}
