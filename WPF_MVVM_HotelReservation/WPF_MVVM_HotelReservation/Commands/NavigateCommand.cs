using WPF_MVVM_HotelReservation.Services;

namespace WPF_MVVM_HotelReservation.Commands
{
    public class NavigateCommand : BaseCommand
    {
        private readonly NavigationService _navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
