using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services
{
    public class MyNavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createVieModel;

        public MyNavigationService(NavigationStore navigationStore, Func<TViewModel> createVieModel)
        {
            _navigationStore = navigationStore;
            _createVieModel = createVieModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createVieModel();
        }
    }
}
