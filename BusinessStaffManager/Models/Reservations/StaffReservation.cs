using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Models.Reservations
{
    /// <summary>
    /// Base class for create new StaffReservation
    /// </summary>
    public class StaffReservation
    {
        public int ReservationID { get;}
        public string Name { get;}
        public string SurName { get;}
        public int Phone { get; }
        public virtual PositionReservation Position { get;}
        public StaffReservation(int id, string name, string surName, int phone, PositionReservation position)
        {
            ReservationID = id;
            Name = name;
            SurName = surName;
            Phone = phone;
            Position = position;
        }
    }
}
