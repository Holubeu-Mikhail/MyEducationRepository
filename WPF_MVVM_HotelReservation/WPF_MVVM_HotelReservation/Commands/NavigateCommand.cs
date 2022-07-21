using WPF_MVVM_HotelReservation.Services;
using WPF_MVVM_HotelReservation.ViewModels;

namespace WPF_MVVM_HotelReservation.Commands
{
    public class NavigateCommand<T> : BaseCommand where T : BaseViewModel
    {
        private readonly NavigationService<T> _navigationService;

        public NavigateCommand(NavigationService<T> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
