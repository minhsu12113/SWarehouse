using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SWarehouse.Converters
{
    public class AvatarAccountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = value as String;
            if (!String.IsNullOrEmpty(path))
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return "pack://application:,,,/Assets/user_default.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
