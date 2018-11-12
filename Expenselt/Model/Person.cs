using Expenselt.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;

namespace Expenselt.Model
{
    public class Person :   INotifyPropertyChanged
    {

        private ObservableCollection<Contact> _contacts;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public ICollection<Expense> Expenses { get; set; }
        public ObservableCollection<Contact> Contacts {
            get{
                return _contacts;
            }
            set {
                _contacts = value;
                this.RaisePropertyChanged("Contacts");
            }
        }

        // Create the OnPropertyChanged method to raise the event
        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
