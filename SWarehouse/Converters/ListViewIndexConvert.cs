using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace SWarehouse.Converters
{
    public class ListViewIndexConvert : IValueConverter
    {
        public object Convert(object value, Type TargetType, object parameter, CultureInfo culture)
        {
            try
            {
                ListViewItem item = (ListViewItem)value;
                ListView listView = ItemsControl.ItemsControlFromItemContainer(item) as ListView;
                int index = listView.ItemContainerGenerator.IndexFromContainer(item) + 1;
                return index.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
