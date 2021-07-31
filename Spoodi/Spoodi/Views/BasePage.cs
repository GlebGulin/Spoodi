using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Spoodi.Views
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            //var viewModel = (ViewModelBase)BindingContext;
            //viewModel.ExecuteBackCommand();

            return true;
        }
    }
}
