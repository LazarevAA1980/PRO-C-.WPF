using System.Windows.Input;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MainWpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; set; }
        public ICommand LocationCommand { get; set; }

        private ViewModelBase selectedContent;
        public ViewModelBase SelectedContent
        {
            get { return selectedContent; }
            set
            {
                selectedContent = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView, CanOpenHomeView);
            LocationCommand = new RelayCommand(OpenLocationView, CanOpenLocationView);
        }

        private bool CanOpenLocationView(object arg)
        {
            return true;
        }

        private void OpenLocationView(object obj)
        {
            SelectedContent = new LocationViewViewModel();
        }

        private bool CanOpenHomeView(object arg)
        {
            return true;
        }

        private void OpenHomeView(object obj)
        {
            SelectedContent = new HomeViewViewModel();
        }
    }

}
