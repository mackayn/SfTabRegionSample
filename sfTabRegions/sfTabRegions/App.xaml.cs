using Prism;
using Prism.Ioc;
using sfTabRegions.Services;
using sfTabRegions.Services.Interfaces;
using sfTabRegions.ViewModels;
using sfTabRegions.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace sfTabRegions
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<RegionPage, RegionPageViewModel>();
            containerRegistry.RegisterForNavigation<RegionTabPage, RegionTabPageViewModel>();

            // Business services
            containerRegistry.Register<IOrderService, OrderService>();

            // Regions
            containerRegistry.RegisterRegionServices();
            containerRegistry.RegisterForRegionNavigation<OrderHistoryView, OrderHistoryViewModel>();
        }
    }
}
