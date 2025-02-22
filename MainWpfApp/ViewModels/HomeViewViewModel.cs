using MainWpfApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MainWpfApp.ViewModels
{
    public class HomeViewViewModel : INotifyPropertyChanged
    {
        private List<DayForecastModel> forecastDays;

        public List<DayForecastModel> ForecastDays
        { 
            get => forecastDays;
            set
            { 
                forecastDays = value;
                OnPropertyChanged();
            }
        }

        //private bool isControlVisible;
        //public bool IsControlVisible
        //{
        //    get { return isControlVisible; }
        //    set
        //    {
        //        isControlVisible = value;
        //        OnPropertyChanged(nameof(IsControlVisible));
        //    }
        //}

        private DayForecastModel selectedDay;

        public DayForecastModel SelectedDay
        {
            get => selectedDay;
            set
            {
                selectedDay = value;
                OnPropertyChanged();
            }
        }

        public HomeViewViewModel()
        { 
            ForecastDays = WeatherDataStorage.GetAll();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
