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
                case WeatherCodes.MainlyClear:
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
                case WeatherCodes.PartlyCloudy:
                    resourceName = "cloudly";
                    break;
                case WeatherCodes.Overcast:
                    resourceName = "overcast";
                    break;
                case WeatherCodes.Fog:
                    resourceName = "fog";
                    break;
                case WeatherCodes.DepositingRimeFog:
                    resourceName = "fog";
                    break;
                case WeatherCodes.LightDrizzle:
                    resourceName = "drizzle";
                    break;
                case WeatherCodes.ModerateDrizzle:
                    resourceName = "drizzle";
                    break;
                case WeatherCodes.DenseDrizzle:
                    resourceName = "drizzle";
                    break;
                case WeatherCodes.SlightRain:
                    resourceName = "rain";
                    break;
                case WeatherCodes.HeavyRain:
                    resourceName = "rain";
                    break;
                case WeatherCodes.ModerateRain:
                    resourceName = "rain";
                    break;
                case WeatherCodes.SlightSnowfall:
                    resourceName = "slight-snowfall";
                    break;
                case WeatherCodes.Snowfall:
                    resourceName = "moderate-snowfall";
                    break;
                case WeatherCodes.ModerateSnowfall:
                    resourceName = "moderate-snowfall";
                    break;
                case WeatherCodes.HeavySnowfall:
                    resourceName = "hard-snowfall";
                    break;
                case WeatherCodes.LightFreezingDrizzle:
                    resourceName = "freezing-drizzle";
                    break;
                case WeatherCodes.DenseFreezingDrizzle:
                    resourceName = "freezing-drizzle";
                    break;
                case WeatherCodes.LightFreezingRain:
                    resourceName = "freezing-drizzle";
                    break;
                case WeatherCodes.HeavyFreezingRain:
                    resourceName = "freezing-drizzle";
                    break;
                case WeatherCodes.Thunderstorm:
                    resourceName = "thunderstorm";
                    break;
                case WeatherCodes.ThunderstormWithSlightHail:
                    resourceName = "thunderstorm";
                    break;
                case WeatherCodes.ThunderstormWithHeavyHail:
                    resourceName = "thunderstorm";
                    break;
                case WeatherCodes.SlightSnowShowers:
                    resourceName = "shower";
                    break;
                case WeatherCodes.HeavySnowShowers:
                    resourceName = "shower";
                    break;
            }
            if (resourceName == null)
            {
                return null;
            }

            return App.Current.Resources[resourceName] as ControlTemplate;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
