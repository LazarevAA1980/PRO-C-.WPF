using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainWpfApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand HomeCommand { get; }

        private HomeViewViewModel homeViewViewModel;
        public HomeViewViewModel HomeViewViewModel
        {
            get { return homeViewViewModel; }
            set
            {
                homeViewViewModel = value;
                OnPropertyChanged();
            }
        }
        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView, CanOpenHomeView);
        }

        private bool CanOpenHomeView( object arg)
        {
            return true;
        }

        private void OpenHomeView(object obj)
        {
            HomeViewViewModel = new HomeViewViewModel();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
