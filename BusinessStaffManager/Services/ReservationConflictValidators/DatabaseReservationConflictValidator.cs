using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationConflictValidators
{
    public class DatabaseReservationConflictValidator : IReservationConflictValidator
    {


        public Task<DepartmentReservation> GetConflictReservation(DepartmentReservation departmentReservation)
        {
            throw new NotImplementedException();
        }

        public Task<PositionReservation> GetConflictReservation(PositionReservation positionReservation)
        {
            throw new NotImplementedException();
        }

        public Task<StaffReservation> GetConflictReservation(StaffReservation staffReservation)
        {
            throw new NotImplementedException();
        }
    }
}
