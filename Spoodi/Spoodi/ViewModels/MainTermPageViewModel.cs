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
                    Name="XOT LAC \nERDNUSSSOSSE",
                    Price = 250,
                    ImageUrl = "curry_bowl",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#FFCA81",
                    Name="TRIANGOLINI \nVEGETARISCH",
                    Price = 700,
                    ImageUrl = "triangolini",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },

                new ProductViewModel()
                {
                    HeroColor = "#A2BAD3",
                    Name="HAMBURGER \nPINK",
                    Price = 500,
                    ImageUrl = "pink_burger",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },

                new ProductViewModel()
                {
                    HeroColor = "#F796DD",
                    Name="BUN BO \nNAM BO",
                    Price = 333,
                    ImageUrl = "bun_bo",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },

                 new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="XOT LAC \nERDNUSSSOSSE",
                    Price = 456,
                    ImageUrl = "curry_bowl",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },

                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="SWEET-\nPOTATO-FRIES",
                    Price = 723,
                    ImageUrl = "sweet_p",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#74D69E",
                    Name="BACON \nCLASSIC BLACK",
                    Price = 140,
                    ImageUrl = "black_burger",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#FB8183",
                    Name="PHO HANOI",
                    Price = 210,
                    ImageUrl = "curry_bowl",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#FB9B64",
                    Name="XOT LAC \nERDNUSSSOSSE",
                    Price = 370,
                    ImageUrl = "hot_lac",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="SWEET-\nPOTATO-FRIES",
                    Price = 865,
                    ImageUrl = "sweet_p",
                    IsFeatured = false,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },
                new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="XOT LAC \nERDNUSSSOSSE",
                    Price = 250,
                    ImageUrl = "curry_bowl",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

                },

                new ProductViewModel()
                {
                    HeroColor = "#FFCA81",
                    Name="TRIANGOLINI \nVEGETARISCH",
                    Price = 700,
                    ImageUrl = "triangolini",
                    IsFeatured = true,
                    Description = "das leckerste essen der welt ",
                    Size = "150x150 mm",

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
