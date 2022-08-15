using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationCreators
{
    public class DatabaseReservationCreator : IReservationCreator
    {


        public Task CreateReservation(DepartmentReservation departmentReservation)
        {
            throw new NotImplementedException();
        }

        public Task CreateReservation(PositionReservation positionReservation)
        {
            throw new NotImplementedException();
        }

        public Task CreateReservation(StaffReservation staffReservation)
        {
            throw new NotImplementedException();
        }
    }
}
