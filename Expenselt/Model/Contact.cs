using Expenselt.Model.Abstract;

namespace Expenselt.Model
{
    public class Contact : AbstractNotificationObject
    {
        private bool _edit;
        private string _nome { get; set; }

        public int Id { get; set; }
        public string Description { get; set; }
        public Person Person { get; set; }

        public string Value
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                Edit = false;
                RaisePropertyChanged("Nome");
            }
        }

        public bool Edit
        {
            get
            {
                return _edit;
            }
            set
            {
                _edit = value;
                RaisePropertyChanged("Edit");
            }
        }

    }
}