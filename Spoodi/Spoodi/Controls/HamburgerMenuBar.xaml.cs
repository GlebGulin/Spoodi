using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoodi.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburgerMenuBar : Grid
    {
        public static readonly BindableProperty MenuCommandProperty = BindableProperty.Create(nameof(MenuCommand), typeof(ICommand), typeof(Toolbar));

        public ICommand MenuCommand
        {
            get => (ICommand)GetValue(MenuCommandProperty);
            set => SetValue(MenuCommandProperty, value);
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(Toolbar));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public HamburgerMenuBar()
        {
            InitializeComponent();
        }
    }
}