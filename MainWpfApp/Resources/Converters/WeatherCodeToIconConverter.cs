using MainWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MainWpfApp.Resources.Converters
{
    public class WeatherCodeToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName = null;
            switch ((WeatherCodes)value)
            {
                case WeatherCodes.ClearSky:
                    resourceName = "clear-day";
                    break;
                case WeatherCodes.Windy:
                    resourceName = "wind";
                    break;
                case WeatherCodes.SlightRainShowers:
                    resourceName = "shower";
                    break;
                case WeatherCodes.ModerateRainShowers:
                    resourceName = "shower";
                    break;
                case WeatherCodes.ViolentRainShowers:
                    resourceName = "shower";
                    break;

            }
            
            //Overcast = 2,
            //Fog = 3,
            //SlightRain = 4,
            //HeavyRain = 5,
            //Snowfall = 6,
            //Thunderstorm = 7,
            //DepositingRimeFog = 8,
            //MainlyClear = 9,
            //PartlyCloudy = 10,
            //LightDrizzle = 11,
            //ModerateDrizzle = 12,
            //DenseDrizzle = 13,
            //LightFreezingDrizzle = 14,
            //DenseFreezingDrizzle = 15,
            //LightFreezingRain = 16,
            //HeavyFreezingRain = 17,
            //SlightSnowShowers = 18,
            //HeavySnowShowers = 19,
            //ModerateRain = 20,
            //SlightSnowfall = 21,
            //ModerateSnowfall = 22,
            //SnowGrains = 23,
            //HeavySnowfall = 24,
            //ThunderstormWithSlightHail = 28,
            //ThunderstormWithHeavyHail = 29
            return App.Current.Resources[resourceName] as ControlTemplate;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
