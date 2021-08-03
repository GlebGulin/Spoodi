using Prism.Navigation;
using System.Threading.Tasks;
using Spoodi.Views;
using Xamarin.Forms;

namespace Spoodi.Extensions
{
    public static class NavigationExtension
    {
        public static async Task NavigateToAsync<NavigateTo>(this INavigationService navigation)
        {
            await navigation.NavigateAsync(typeof(NavigateTo).Name);
        }

        public static async Task NavigateToAsync<NavigateTo>(this INavigationService navigation, INavigationParameters parameters)
        {
            await navigation.NavigateAsync(typeof(NavigateTo).Name, parameters);
        }

        public static async Task NavigateToHomePage(this INavigationService navigation)
        {
            await navigation.NavigateToAsync<HomePage>();
        }
    }
}
