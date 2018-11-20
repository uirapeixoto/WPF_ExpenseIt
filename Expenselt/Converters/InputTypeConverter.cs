using Expenselt.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Expenselt.Converters
{
    public class InputTypeConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            IList<string> listaItens = new List<string>();
            var service = new EstadoService();
            foreach (var item in service.GetEstados())
            {
                listaItens.Add(item.Nome);
            }

            if (value.ToString().ToLower().Equals("estado"))
                return listaItens;
            else
                return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
        #endregion
    }
}
