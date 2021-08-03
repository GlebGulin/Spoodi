using MvvmHelpers;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Spoodi.Event;
using Spoodi.Extensions;
using Spoodi.Models.ViewModels;
using Spoodi.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.ViewModels
{
    public class MainTermPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public IList<ProductViewModel> Products { get; set; }

        private ProductViewModel _selectedProduct;
        public ProductViewModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { SetProperty(ref _selectedProduct, value); }
        }

        public ShoppingCartViewModel ShoppingCart { get; set; }
        public ICommand TestCommand => new Command(Test);
        
        public ICommand RemoveItemCommand => new Command<ShoppingCartItem>(RemoveItem);

        public MainTermPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            Products = new ObservableRangeCollection<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="Фитнесс \n меню",
                    Price = 250,
                    ImageUrl = "blue_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FFCA81",
                    Name="Бургерная",
                    Price = 700,
                    ImageUrl = "yellow_moss",
                    IsFeatured = true,
                    Description = "Contained in a yellow glass polygonal florarium",
                    Humidity = "60%",
                    Light = "5k - 15k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "200 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#A2BAD3",
                    Name="Супер бургерная",
                    Price = 500,
                    ImageUrl = "grey_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#F796DD",
                    Name="Десерты",
                    Price = 333,
                    ImageUrl = "pink_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "55%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                 new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="Еда Еда",
                    Price = 456,
                    ImageUrl = "blue_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="Свежак",
                    Price = 723,
                    ImageUrl = "lavender_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#74D69E",
                    Name="Веганская хрень",
                    Price = 140,
                    ImageUrl = "green_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FB8183",
                    Name="Народное \n меню",
                    Price = 210,
                    ImageUrl = "red_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "45%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FB9B64",
                    Name="Рыбное \n меню",
                    Price = 370,
                    ImageUrl = "orange_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "55%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="Суши",
                    Price = 865,
                    ImageUrl = "lavender_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "65%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

            };
            ShoppingCart = new ShoppingCartViewModel();
            ShoppingCart.Items.Add(new FreightItem() { FreightCharge = 15 });
            _eventAggregator = eventAggregator;
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
        public ICommand MenuCommand => new Command(() => _eventAggregator.GetEvent<ToggleMasterDetailMenuEvent>().Publish());
        public ICommand BenutzerdatenCommand => new Command(async () => await NavigationService.NavigateToAsync<BenutzerdatenPage>());
        public ICommand FavoritenCommand => new Command(async () => await NavigationService.NavigateToAsync<FavoritenPage>());
        public ICommand AuftragshistorieCommand => new Command(async () => await NavigationService.NavigateToAsync<AuftragshistoriePage>());
        public ICommand ZahlungsmittelCommand => new Command(async () => await NavigationService.NavigateToAsync<ZahlungsmittelPage>());
        public ICommand KarteCommand => new Command(async () => await NavigationService.NavigateToAsync<KartePage>());

        private void Test()
        {
            return;
        }
        public void ToggleMenu()
        {
            _eventAggregator.GetEvent<ToggleMasterDetailMenuEvent>().Publish();
        }
        public void RemoveItem(ShoppingCartItem i)
        {
            ShoppingCart.RemoveItem(i);
        }
    }
}
