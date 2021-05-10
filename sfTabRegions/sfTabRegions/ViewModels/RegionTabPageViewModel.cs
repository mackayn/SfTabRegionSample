using System;
using Prism.Navigation;
using Prism.Regions;
using Prism.Regions.Navigation;

namespace sfTabRegions.ViewModels
{
    public class RegionTabPageViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public RegionTabPageViewModel(
            INavigationService navigationService,
            IRegionManager regionManager ) : base(navigationService)
        {
            _regionManager = regionManager;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            _regionManager.RequestNavigate("OrderHistoryRegion", "OrderHistoryView", NavigationCallback, parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Title = "region in SfTab";
        }

        private void NavigationCallback(IRegionNavigationResult obj)
        {
            Console.WriteLine(obj.Context.NavigatedName() + " Region loaded");
        }
    }
}
