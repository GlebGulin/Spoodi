using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoodi.ResourceDictionaries
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoreResourceDictionary : ResourceDictionary
    {
        public CoreResourceDictionary()
        {
            InitializeComponent();
        }
    }
}