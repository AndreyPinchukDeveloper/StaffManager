using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Models.Reservations;

namespace BusinessStaffManger.ViewModels
{
    public class PositionViewModel:ViewModelBase
    {
        private readonly PositionReservation _position;

        public string PositionID => _position.ReservationID.ToString();
        public string Name => _position.Name.ToString();
        public string Salary => _position.Salary.ToString();
        public string MaxNumber => _position.MaxNumber.ToString();
        public string Staff => _position.Staff.ToString();
        public string Department => _position.Department.ToString();
        public PositionViewModel(PositionReservation position)
        {
            _position = position;
        }
    }
}
