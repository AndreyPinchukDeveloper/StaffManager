using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.ViewModels.DepartmentViewModels
{
    public class DepartmentReservationListingVM:ViewModelBase
    {
        private readonly ObservableCollection<DepartmentViewModel> _reservations;
        private readonly DepartmentStore _departmentStore;
        public IEnumerable<DepartmentViewModel> Departments => _reservations;
        private string _errorMessage;
        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);//check
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }
        
        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value; OnPropertyChanged(nameof(IsLoading)); }
        }
        //TODO load/make reservation commands
    }
}
