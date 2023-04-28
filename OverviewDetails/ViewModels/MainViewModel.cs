using CreateGraphByPoints.ViewModels;

namespace OverviewDetails.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private MenuViewModel menuVM;

        private DetailViewModel detailVM;

        private WindowForDetailViewModel windowForDetailVM;

        public MenuViewModel MenuVM
        {
            get => menuVM;
            set
            {
                menuVM = value;
                OnPropertyChanged();
            }
        }

        public DetailViewModel DetailVM
        {
            get => detailVM;
            set
            {
                detailVM = value;
                OnPropertyChanged();
            }
        }

        public WindowForDetailViewModel WindowForDetailVM
        {
            get => windowForDetailVM;
            set
            {
                windowForDetailVM = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(MenuViewModel menuVM, DetailViewModel detailVM, WindowForDetailViewModel windowForDetailVM)
        {
            this.menuVM = menuVM;
            this.detailVM = detailVM;
            this.windowForDetailVM = windowForDetailVM;
        }
    }
}
