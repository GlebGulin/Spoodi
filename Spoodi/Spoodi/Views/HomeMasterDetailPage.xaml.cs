using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Spoodi.Event;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoodi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMasterDetailPage : MasterDetailPage
    {
        readonly IEventAggregator EventAggregator;

        public HomeMasterDetailPage(IEventAggregator eventAggregator)
        {
            InitializeComponent();

            EventAggregator = eventAggregator;
            IsPresented = true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var e = EventAggregator.GetEvent<ToggleMasterDetailMenuEvent>();
            e.Subscribe(ToggleMenu);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var e = EventAggregator.GetEvent<ToggleMasterDetailMenuEvent>();
            e.Unsubscribe(ToggleMenu);
        }

        private void ToggleMenu()
        {
            IsPresented = !IsPresented;
        }
    }
}