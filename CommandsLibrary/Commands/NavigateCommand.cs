using BusinessStaffManager.ViewModels.Base;
using BusinessStaffManger.Services;
using CommandsLibrary.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLibrary.Commands
{
    public class NavigateCommand<TViewModel>:CommandBase where TViewModel : ViewModelBase
    {

        private readonly MyNavigationService<TViewModel> _navigationService;
        public NavigateCommand(MyNavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
