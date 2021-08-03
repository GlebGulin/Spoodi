using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.ViewModels
{
    public class ZahlungsmittelPageViewModel : ViewModelBase
    {
        public ICommand BackCommand => new Command(GoBack);
        public ZahlungsmittelPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public async void GoBack()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
