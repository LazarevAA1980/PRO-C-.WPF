using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWpfApp.Models
{
    public partial class DayForecastModel
    {
        public DateTime Date { get; set; }
        public float? MaxTemperature { get; set; }
        public float? MinTemperature { get; set; }
        public string? Location { get; set; }
        public WeatherCodes Weather { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public float? Pressure { get; set; }
        public float? WindSpeed { get; set; }
        public WindDirectionCodes WindDirection { get; set; }
        public List<HourlyForecastModel> HourlyForecasts { get; set; }
    }
}
