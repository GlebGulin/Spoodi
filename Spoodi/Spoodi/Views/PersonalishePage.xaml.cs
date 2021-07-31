using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoodi.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PesonalishePage : ContentPage
    {
        public PesonalishePage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.IsVisible = false;
        }
    }
}