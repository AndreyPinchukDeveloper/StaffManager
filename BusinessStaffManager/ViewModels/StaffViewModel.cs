using BusinessStaffManager.Models;
using BusinessStaffManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels
{
    public class StaffViewModel:ViewModelBase
    {
        private readonly Staff _staff;

        public string StaffID => _staff.Id.ToString();
        public string Name => _staff.Name.ToString();
        public string SurName => _staff.SurName.ToString();
        public string Phone => _staff.Phone.ToString();
        public string Position => _staff.Position.ToString();

        public StaffViewModel(Staff staff)
        {
            _staff = staff;
        }
    }
}
