using MainWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MainWpfApp.ViewModels
{
    public class HomeViewViewModel : ViewModelBase
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
    }
}
