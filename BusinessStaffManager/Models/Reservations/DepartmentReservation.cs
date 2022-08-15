using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Models.Reservations
{
    /// <summary>
    /// Base class for create new DepartmentReservation
    /// </summary>
    public class DepartmentReservation
    {
        public int ReservationID { get; }
        public string Name { get;}
        public List<PositionReservation> Position { get;}

        public DepartmentReservation(int id, string name, List<PositionReservation> position)
        {
            ReservationID = id;
            Name = name;
            Position = position;
        }
    }
}
