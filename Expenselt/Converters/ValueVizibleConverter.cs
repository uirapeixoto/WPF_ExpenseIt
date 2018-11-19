using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Expenselt.Converters
{
    public class ValueVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((parameter != null ) ? parameter.ToString().ToLower().Equals("inverter"):false)
            {
                if (value.ToString().ToLower().Equals("estado"))
                    return Visibility.Collapsed;
            }
            else if (value.ToString().ToLower().Equals("estado")) { 
                    return Visibility.Visible;
            }
            
            
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}
