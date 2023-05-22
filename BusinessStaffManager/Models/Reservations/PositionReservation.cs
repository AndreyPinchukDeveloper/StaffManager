using BusinessStaffManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Models.Reservations
{
    /// <summary>
    /// Base class for create new PositionReservation
    /// </summary>
    public class PositionReservation
    {
        public int ReservationID { get;}
        public string Name { get;}
        public decimal Salary { get;}
        public int MaxNumber { get;}
        public List<StaffReservation> Staff { get;}
        public List<DepartmentReservation> Department { get;}

        public PositionReservation(int id, string name, decimal salary, int maxNumber, List<StaffReservation> staff, List<DepartmentReservation> department)
        {
            ReservationID = id;
            Name = name;
            Salary = salary;
            MaxNumber = maxNumber;
            Staff = staff;
            Department = department;
        }
    }
}
