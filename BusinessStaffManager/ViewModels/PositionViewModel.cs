using BusinessStaffManager.Models;
using BusinessStaffManager.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels
{
    public class PositionViewModel:ViewModelBase
    {
        private readonly Position _position;

        public string PositionID => _position.Id.ToString();
        public string Name => _position.Name.ToString();
        public string Salary => _position.Salary.ToString();
        public string MaxNumber => _position.MaxNumber.ToString();
        public string Staff => _position.Staff.ToString();
        public string Department => _position.Department.ToString();
        public PositionViewModel(Position position)
        {
            _position = position;
        }
    }
}
