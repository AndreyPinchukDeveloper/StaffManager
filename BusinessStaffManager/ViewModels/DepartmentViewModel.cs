using BusinessStaffManager.Models;
using BusinessStaffManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels
{
    public class DepartmentViewModel:ViewModelBase
    {
        private readonly Department _department;
        public string DepartmentID => _department.Id.ToString();
        public string Name => _department.Name;
        public string? Position => _department.Position.ToString();
        public DepartmentViewModel(Department department)
        {
            _department = department;
        }
    }
}
