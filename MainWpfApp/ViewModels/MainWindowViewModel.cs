using System.Windows;
using System.Windows.Input;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MainWpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; set; }
        public ICommand LocationCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        public ICommand CloseCommand { get; set; }


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
            SettingsCommand = new RelayCommand(OpenSettingsView, CanOpenSettingsView);
            CloseCommand = new RelayCommand(OpenCloseView, CanOpenCloseView);
        }

        private bool CanOpenCloseView(object arg)
        {
            return true;
        }

        private void OpenCloseView(object obj)
        {
            Application.Current.MainWindow.Close();
        }

        private bool CanOpenSettingsView(object arg)
        {
            return true;
        }

        private void OpenSettingsView(object obj)
        {
            SelectedContent = new SettingsViewViewModel();
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
