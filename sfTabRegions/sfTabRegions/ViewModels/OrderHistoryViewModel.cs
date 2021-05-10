using Prism.Navigation;
using sfTabRegions.Services.Interfaces;

namespace sfTabRegions.ViewModels
{
    public class OrderHistoryViewModel : ViewModelBase
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

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            // Not been hit
            OrderTitle = await _orderService.GetLastOrderDescription();
            base.OnNavigatedTo(parameters);
        }
    }
}
