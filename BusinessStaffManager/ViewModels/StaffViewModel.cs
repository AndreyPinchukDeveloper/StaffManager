using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Models.Reservations;

namespace BusinessStaffManger.ViewModels
{
    public class StaffViewModel:ViewModelBase
    {
        private readonly StaffReservation _staff;

        public string StaffID => _staff.ReservationID.ToString();
        public string Name => _staff.Name.ToString();
        public string SurName => _staff.SurName.ToString();
        public string Phone => _staff.Phone.ToString();
        public string Position => _staff.Position.ToString();

        public StaffViewModel(StaffReservation staff)
        {
            _staff = staff;
        }
    }
}
