using Prism.Navigation;
using Prism.Regions.Navigation;
using sfTabRegions.Services.Interfaces;

namespace sfTabRegions.ViewModels
{
    public class OrderHistoryViewModel : ViewModelBase, IRegionAware
    {
        private readonly IOrderService _orderService;

        private string _orderTitle;
        public string OrderTitle
        {
            get => _orderTitle;
            set => SetProperty(ref _orderTitle, value);
        }

        public OrderHistoryViewModel(
            INavigationService navigationService,
            IOrderService orderService) : base(navigationService)
        {
            _orderService = orderService;
        }

        public async void OnNavigatedTo(INavigationContext navigationContext)
        {
            // Not been hit
            OrderTitle = await _orderService.GetLastOrderDescription();
            base.OnNavigatedTo(navigationContext.Parameters);
        }

        public bool IsNavigationTarget(INavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(INavigationContext navigationContext)
        {
            //throw new System.NotImplementedException();
        }
    }
}
