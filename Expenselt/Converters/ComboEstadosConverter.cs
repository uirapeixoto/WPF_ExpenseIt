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
    [ValueConversion(typeof(EstadoService), typeof(Dictionary<string, string>))]
    class ComboEstadosConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Dictionary<string, string> listaItens = new Dictionary<string, string>();
            var service = new EstadoService();
            foreach(var item in service.GetEstados())
            {
                listaItens.Add(item.Nome, item.Nome);
            }

            return listaItens;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
        #endregion
    }
}
