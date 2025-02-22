using MainWpfApp.Views.Home;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MainWpfApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand HomeCommand { get; set; }
        public ICommand LocationCommand { get; set; }

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

        private LocationViewViewModel locationViewViewModel;
        public LocationViewViewModel LocationViewViewModel
        {
            get { return locationViewViewModel; }
            set
            {
                locationViewViewModel = value;
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
             LocationViewViewModel = new LocationViewViewModel();
        }

        private bool CanOpenHomeView(object arg)
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
