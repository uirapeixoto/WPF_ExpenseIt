using Expenselt.Model.Abstract;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expenselt.Model
{
    public class Person : AbstractNotificationObject
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
                RaisePropertyChanged("Contacts");
            }
        }
        public ICollection<Estado> Estados { get; set; }
    }
}
