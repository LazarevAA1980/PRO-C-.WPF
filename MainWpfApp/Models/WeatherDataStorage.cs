using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWpfApp.Models
{
    public static class WeatherDataStorage
    {
        public static List<DayForecastModel> GetAll()
        {
            var weather = new List<DayForecastModel>();
            var random = new Random();

            for (int i = -3; i <= 3; i++)
            {
                var data = new DayForecastModel()
                {
                    Date = DateTime.Now.AddDays(i),
                    MinTemperature = random.Next(-20, 8),
                    MaxTemperature = random.Next(10, 28),
                    Pressure = random.Next(100, 300),
                    WindSpeed = random.Next(0, 25),
                    WindDirection = DayForecastModel.WindDirectionEnum.West,
                    Weather = DayForecastModel.WeatherCodesEnum.Windy,
                    HourlyForecasts = GetHourlyForecast()
                };

                weather.Add(data);
            }
            return weather;

        }

        public static List<HourlyForecastModel> GetHourlyForecast()
        {
            var random = new Random();
            var hourlyForecast = new List<HourlyForecastModel>();
            for (int i = 0; i < 24; i++)
            {
                var data = new HourlyForecastModel()
                {
                    Time = DateTime.Now.Date.AddHours(i),
                    ApparentTemperature = random.Next(0, 20),
                    Weather = random.Next(0, 25),
                    WindDirection = random.Next(0, 25),
                };

                hourlyForecast.Add(data);
            }

            return hourlyForecast;
        }
    }
}
