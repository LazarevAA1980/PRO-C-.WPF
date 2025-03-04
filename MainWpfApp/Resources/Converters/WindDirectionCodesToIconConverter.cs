using MainWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MainWpfApp.Resources.Converters
{
    class WindDirectionCodesToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName = null;

            switch ((WindDirectionCodes)value)
            {
                case WindDirectionCodes.North: resourceName = "north_icon.png"; break;
                case WindDirectionCodes.South: resourceName = "south_icon.png"; break;
                case WindDirectionCodes.West: resourceName = "west_icon.png"; break;
                case WindDirectionCodes.East: resourceName = "east_icon.png"; break;
                case WindDirectionCodes.Northeast: resourceName = "northeast_icon.png"; break;
                case WindDirectionCodes.Southeast: resourceName = "southeast_icon.png"; break;
                case WindDirectionCodes.Southwest: resourceName = "southwest_icon.png"; break;
                case WindDirectionCodes.Northwest: resourceName = "northwest_icon.png"; break;
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
