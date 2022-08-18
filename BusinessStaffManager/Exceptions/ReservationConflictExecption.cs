using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Exceptions
{
    public class ReservationConflictExecption:Exception
    {
        public DepartmentReservation ExistingDeapartmentReservation { get; }
        public DepartmentReservation IncomeDeapartmentReservation { get; }
        public PositionReservation ExistingPositionReservation { get; }
        public PositionReservation IncomePositionReservation { get; }
        public StaffReservation ExistingStaffReservation { get; }
        public StaffReservation IncomeStaffReservation { get; }

        public ReservationConflictExecption(
            DepartmentReservation existingDeapartmentReservation = null, 
            DepartmentReservation incomeDeapartmentReservation = null)
        {
            ExistingDeapartmentReservation = existingDeapartmentReservation;
            IncomeDeapartmentReservation = incomeDeapartmentReservation;
        }

        public ReservationConflictExecption(
            PositionReservation existingPositionReservation = null,
            PositionReservation incomePositionReservation = null)
        {
            ExistingPositionReservation = existingPositionReservation;
            IncomePositionReservation = incomePositionReservation;
        }

        public ReservationConflictExecption(
            StaffReservation existingStaffReservation = null,
            StaffReservation incomeStaffReservation = null)
        {
            ExistingStaffReservation = existingStaffReservation;
            IncomeStaffReservation = incomeStaffReservation;
        }

        public ReservationConflictExecption(
            string message,
            DepartmentReservation existingDeapartmentReservation,
            DepartmentReservation incomeDeapartmentReservation):base(message)
        {
            ExistingDeapartmentReservation = existingDeapartmentReservation;
            IncomeDeapartmentReservation = incomeDeapartmentReservation;
        }

        public ReservationConflictExecption(
            string message,
            PositionReservation existingPositionReservation,
            PositionReservation incomePositionReservation) : base(message)
        {
            ExistingPositionReservation = existingPositionReservation;
            IncomePositionReservation = incomePositionReservation;
        }

        public ReservationConflictExecption(
            string message,
            StaffReservation existingStaffReservation,
            StaffReservation incomeStaffReservation) : base(message)
        {
            ExistingStaffReservation = existingStaffReservation;
            IncomeStaffReservation = incomeStaffReservation;
        }

        public ReservationConflictExecption(
            string message,
            Exception innerException,
            DepartmentReservation existingDeapartmentReservation,
            DepartmentReservation incomeDeapartmentReservation) : base(message, innerException)
        {
            ExistingDeapartmentReservation = existingDeapartmentReservation;
            IncomeDeapartmentReservation = incomeDeapartmentReservation;
        }

        public ReservationConflictExecption(
            string message,
            Exception innerException,
            PositionReservation existingPositionReservation,
            PositionReservation incomePositionReservation) : base(message, innerException)
        {
            ExistingPositionReservation = existingPositionReservation;
            IncomePositionReservation = incomePositionReservation;
        }

        public ReservationConflictExecption(
            string message,
            Exception innerException,
            StaffReservation existingStaffReservation,
            StaffReservation incomeStaffReservation) : base(message, innerException)
        {
            ExistingStaffReservation = existingStaffReservation;
            IncomeStaffReservation = incomeStaffReservation;
        }

        public ReservationConflictExecption(SerializationInfo info, StreamingContext context):base(info, context)
        {

        }
    }
}
