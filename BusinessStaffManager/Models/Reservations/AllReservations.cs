using BusinessStaffManger.Services.ReservationCreators;
using BusinessStaffManger.Services.ReservationProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Models.Reservations
{
    /// <summary>
    /// This class create and get all reservation of applications 
    /// </summary>
    public class AllReservations
    {
        private readonly IReservationProvider _reservationProvider;
        private readonly IReservationCreator _reservationConnector;
    }
}
