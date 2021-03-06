using MvvmHelpers;
using Spoodi.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoodi.Models.ViewModels
{
    public class FreightItem : ObservableObject, ICartItem
    {
        private decimal freightCharge;

        public decimal FreightCharge 
        { 
            get => freightCharge; 
            set => SetProperty(ref freightCharge, value); 
        }

        public void CalculateFreight(decimal orderTotal)
        {
            if (orderTotal > 80)
                FreightCharge = 0;
            else
                FreightCharge = 15;
        }
    }
}
