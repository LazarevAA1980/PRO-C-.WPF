using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWpfApp
{
    public class DayForecastModel
    {
        public DateTime Date {  get; set; }
        public DayOfWeek WeekDay { get; set; }
        public float? MaxTemperature { get; set; }
        public float? MinTemperature { get; set; }
        public float? Pressure { get; set; }
        public int? WindDirection { get; set; }
        public float? WindSpeed { get; set; }
        public string? Location { get; set; }
        public string? Weather {  get; set; }







        public DayForecastModel(DateTime date, DayOfWeek dayOfWeek)
        {
            Date = date;
            WeekDay = dayOfWeek;
            MaxTemperature = null;
            MinTemperature = null;
            Pressure = null;
            WindDirection = null;
            WindSpeed = null;
            Location = string.Empty;
            Weather = string.Empty;
    }
    }
}
