using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWpfApp.Models
{
    public class DayForecastModel
    {
        public DateTime Date { get; set; }
        public float? MaxTemperature { get; set; }
        public float? MinTemperature { get; set; }
        public string? Location { get; set; }
        public WeatherCodesEnum? Weather { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public float? Pressure { get; set; }
        public float? WindSpeed { get; set; }
        public WindDirectionEnum? WindDirection { get; set; }
        public List<HourlyForecastModel> HourlyForecasts { get; set; }

        //public DayForecastModel(DateTime date, DayOfWeek dayOfWeek)
        //{
        //    Date = date;
        //    WeekDay = dayOfWeek;
        //    MaxTemperature = null;
        //    MinTemperature = null;
        //    Pressure = null;
        //    WindSpeed = null;
        //    Location = string.Empty;
        //}

        public enum WeatherCodesEnum
        {
            ClearSky = 0,
            Windy = 1,
            Overcast = 2,
            Fog = 3,
            SlightRain = 4,
            HeavyRain = 5,
            Snowfall = 6,
            Thunderstorm = 7
        }

        public enum WindDirectionEnum
        {
            West = 0,
            East = 1,
            Nord = 2,
            Sud = 3
        }
    }
}
