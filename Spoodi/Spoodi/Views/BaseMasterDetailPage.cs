using Prism.Events;
using Spoodi.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoodi.Views
{
    public class BaseMasterDetailPage : Xamarin.Forms.FlyoutPage
    {
        readonly IEventAggregator EventAggregator;

        public BaseMasterDetailPage(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
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
