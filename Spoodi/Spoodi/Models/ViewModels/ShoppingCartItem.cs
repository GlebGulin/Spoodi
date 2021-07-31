using MvvmHelpers;
using Spoodi.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoodi.Models.ViewModels
{
    public class ShoppingCartItem : ObservableObject, ICartItem
    {
        public ProductViewModel Product { get; set; }

        public int Count { get; set; }

        public decimal Total
        {
            get { return Product.Price * Count; }
        }
    }
}
