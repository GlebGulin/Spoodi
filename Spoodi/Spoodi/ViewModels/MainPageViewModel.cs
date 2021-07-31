using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Spoodi.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public ICommand TestCommand => new Command(Test);
        public ICommand MenuToggle => new Command(ToggleMenu);
        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
        }
        private void Test()
        {
            return;
        }
        public void ToggleMenu()
        {
            _eventAggregator.GetEvent<ToggleMasterDetailMenuEvent>().Publish();
        }
    }
}
