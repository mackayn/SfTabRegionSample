using System;
using Prism.Navigation;
using Prism.Regions;
using Prism.Regions.Navigation;

namespace sfTabRegions.ViewModels
{
    public class RegionPageViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        public RegionPageViewModel(
            INavigationService navigationService,
            IRegionManager regionManager) : base(navigationService)
        {
            _regionManager = regionManager;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            _regionManager.RequestNavigate("OrderRegion", "OrderHistoryView", NavigationCallback, parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Title = "Region in page";
        }

        private void NavigationCallback(IRegionNavigationResult obj)
        {
            Console.WriteLine(obj.Context.NavigatedName() + " Region loaded");
        }
    }
}
