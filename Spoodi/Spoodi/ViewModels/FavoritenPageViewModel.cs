using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.ViewModels
{
    public class FavoritenPageViewModel : ViewModelBase
    {
        public ICommand BackCommand => new Command(GoBack);
        public FavoritenPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public async void GoBack()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
