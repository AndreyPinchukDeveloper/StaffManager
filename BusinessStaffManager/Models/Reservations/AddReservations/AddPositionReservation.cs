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
    public class AddPositionReservation
    {
        private readonly IReservationProvider _reservationProvider;
        private readonly IReservationCreator _reservationCreator;
        private readonly IReservationConflictValidator _reservationConflictValidator;

        public AddPositionReservation(IReservationProvider reservationProvider, IReservationCreator reservationCreator, IReservationConflictValidator reservationConflictValidator)
        {
            _reservationConflictValidator = reservationConflictValidator;
            _reservationCreator = reservationCreator;
            _reservationProvider = reservationProvider;
        }

        public async Task<IEnumerable<PositionReservation>> GetAllPositionReservations()
        {
            return await _reservationProvider.GetAllPositionReservation();
        }

        public async Task AddReservation(PositionReservation positionReservation)
        {
            PositionReservation conflictReservation = await _reservationConflictValidator.GetConflictReservation(positionReservation);
            if (conflictReservation != null)
            {
                throw new ReservationConflictExecption(conflictReservation, positionReservation);
            }
            await _reservationCreator.CreatePositionReservation(positionReservation);
        }
    }
}
