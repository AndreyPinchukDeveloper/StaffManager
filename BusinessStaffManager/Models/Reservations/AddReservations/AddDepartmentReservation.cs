using BusinessStaffManger.Exceptions;
using BusinessStaffManger.Services.ReservationConflictValidators;
using BusinessStaffManger.Services.ReservationCreators;
using BusinessStaffManger.Services.ReservationProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Models.Reservations.AddReservations
{
    public class AddDepartmentReservation
    {
        private readonly IReservationProvider _reservationProvider;
        private readonly IReservationCreator _reservationCreator;
        private readonly IReservationConflictValidator _reservationConflictValidator;

        public AddDepartmentReservation(IReservationProvider reservationProvider, IReservationCreator reservationCreator, IReservationConflictValidator reservationConflictValidator)
        {
            _reservationConflictValidator = reservationConflictValidator;
            _reservationCreator = reservationCreator;
            _reservationProvider = reservationProvider;
        }

        public async Task<IEnumerable<DepartmentReservation>> GetAllDepartmentReservations()
        {
            return await _reservationProvider.GetAllDepartmentReservation();
        }

        public async Task AddReservatiom(DepartmentReservation departmentReservation)
        {
            DepartmentReservation conflictReservation = await _reservationConflictValidator.GetConflictReservation(departmentReservation);
            if (conflictReservation != null)
            {
                throw new ReservationConflictExecption(conflictReservation, departmentReservation);
            }
            await _reservationCreator.CreateDepartmentReservation(departmentReservation);
        }
    }
}
