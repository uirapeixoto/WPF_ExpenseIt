using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Expenselt.Model.Abstract
{
    public abstract class NotificationObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        

    }
}
