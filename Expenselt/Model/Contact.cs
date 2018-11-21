using Expenselt.Model.Abstract;

namespace Expenselt.Model
{
    public class Contact : AbstractNotificationObject
    {
        private string _value { get; set; }

        public int Id { get; set; }
        public string Description { get; set; }
        public Person Person { get; set; }

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                RaisePropertyChanged("Nome");
            }
        }

        
    }
}