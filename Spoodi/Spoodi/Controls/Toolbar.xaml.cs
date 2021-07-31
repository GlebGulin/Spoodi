using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoodi.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Toolbar : Grid
    {
        public static readonly BindableProperty BackButtonCommandProperty = BindableProperty.Create(nameof(BackButtonCommand), typeof(ICommand), typeof(Toolbar));

        public ICommand BackButtonCommand
        {
            get => (ICommand)GetValue(BackButtonCommandProperty);
            set => SetValue(BackButtonCommandProperty, value);
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(Toolbar));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public Toolbar()
        {
            InitializeComponent();
        }
    }
}