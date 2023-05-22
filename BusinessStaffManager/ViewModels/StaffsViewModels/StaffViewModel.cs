using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels.StaffsViewModels
{
    public class StaffViewModel : ViewModelBase
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
