using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Expenselt.Model.Abstract
{
    public static class ObservableCollectionExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> data, List<T> range)
        {
            if (range == null) throw new ArgumentNullException("range");
            foreach (var i in range) data.Add(i);

            // How can I force ObservableCollection to update?!

        }
    }
}
