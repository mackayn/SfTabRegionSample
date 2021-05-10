using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace sfTabRegions.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand RegionInPageCommand { get; }
        public DelegateCommand RegionInTabCommand { get; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            RegionInPageCommand = new DelegateCommand(async () => await NavigateToRegionInPage());
            RegionInTabCommand = new DelegateCommand(async () => await NavigateToRegionInTab());
        }

        internal async Task NavigateToRegionInPage()
        {
            await NavigationService.NavigateAsync("RegionPage");
        }

        internal async Task NavigateToRegionInTab()
        {
            await NavigationService.NavigateAsync("RegionTabPage");
        }
    }
}
