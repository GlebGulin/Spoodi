using Prism;
using Prism.Ioc;
using Spoodi.ViewModels;
using Spoodi.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Spoodi
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }


        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, MainTermPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            
            //Flyot menu pages
            containerRegistry.RegisterForNavigation<BenutzerdatenPage>();
            containerRegistry.RegisterForNavigation<FavoritenPage>();
            containerRegistry.RegisterForNavigation<AuftragshistoriePage>();
            containerRegistry.RegisterForNavigation<KartePage>();
            containerRegistry.RegisterForNavigation<PersonlichePage>();
            containerRegistry.RegisterForNavigation<UnterstutzungsdienstPage>();
            containerRegistry.RegisterForNavigation<ZahlungsmittelPage>();
        }
    }
}
