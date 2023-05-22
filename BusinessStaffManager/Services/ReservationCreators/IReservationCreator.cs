using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationCreators
{
    public interface IReservationCreator
    {
        Task CreateDepartmentReservation(DepartmentReservation departmentReservation);
        Task CreatePositionReservation(PositionReservation positionReservation);
        Task CreateStaffReservation(StaffReservation staffReservation);
    }
}
