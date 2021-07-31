using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Spoodi.Models.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IList<ProductViewModel> Products { get; set; }

        private ProductViewModel _selectedProduct;

        public ProductViewModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { SetProperty(ref _selectedProduct, value); }
        }

        public ShoppingCartViewModel ShoppingCart { get; set; }

        public ICommand RemoveItemCommand { private set; get; }


        public MainViewModel()
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

            RemoveItemCommand = new Command<ShoppingCartItem>(i => RemoveItem(i));

        }

        private void RemoveItem(ShoppingCartItem i)
        {
            ShoppingCart.RemoveItem(i);
        }
    }
    
}
