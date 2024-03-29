﻿using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationProviders
{
    public interface IReservationProvider
    {
        Task<IEnumerable<DepartmentReservation>> GetAllDepartmentReservation();
        Task<IEnumerable<PositionReservation>> GetAllPositionReservation();
        Task<IEnumerable<StaffReservation>> GetAllStaffReservation();
    }
}
