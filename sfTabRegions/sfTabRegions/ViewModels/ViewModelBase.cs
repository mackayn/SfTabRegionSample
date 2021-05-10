using Prism.Mvvm;
using Prism.Navigation;

namespace sfTabRegions.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _busy;
        public bool Busy
        {
            get => _busy;
            set
            {
                SetProperty(ref _busy, value);
                RaisePropertyChanged(nameof(CanExecute));
            }
        }

        public bool CanExecute => !Busy;

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            Busy = true;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
