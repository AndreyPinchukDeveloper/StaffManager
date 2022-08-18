using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels.DepartmentViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        private readonly DepartmentReservation _department;
        public string DepartmentID => _department.ReservationID.ToString();
        public string Name => _department.Name;
        public string? Position => _department.Position.ToString();
        public DepartmentViewModel(DepartmentReservation department)
        {
            _department = department;
        }
    }
}
