using Prism.Navigation;

namespace sfTabRegions.ViewModels
{
    public class RegionTabPageViewModel : ViewModelBase
    {
        public RegionTabPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Title = "region in SfTab";
        }
    }
}
