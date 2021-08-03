using Prism.Navigation;
using Spoodi.Extensions;
using Spoodi.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.ViewModels
{
    public class BenutzerdatenPageViewModel : ViewModelBase
    {
        public ICommand BackCommand => new Command(async () => await NavigationService.GoBackAsync());
        public BenutzerdatenPageViewModel(INavigationService navigationService): base(navigationService)
        {

        }
    }
}
