using Expenselt.Model;
using Expenselt.Services;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Expenselt
{
    /// <summary>
    /// Interação lógica para ExpenseItContact.xam
    /// </summary>
    public partial class ExpenseItContactPage : Page
    {
        Person _person = new Person();

        public ExpenseItContactPage()
        {
            InitializeComponent();
        }

        public ExpenseItContactPage(object data) :  this()
        {
            _person = data as Person;
            var service = new ContactServices();
            _person.Contacts = service.GetContactsByPerson(_person.Id);

            this.DataContext = _person;
        }

        public void IncluirContatoCommand(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Teste", "Botão clicado");
            var contact = new Contact
            {
                Person = _person,
                Description = "Nome",
                Value = ""
            };
            var service = new ContactServices();
            _person.Contacts = service.GetContactsByPerson(_person.Id);
            _person.Contacts.Add(contact);

            this.DataContext = _person;
            
        }

        private void IncluirContatoCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var contact = new Contact
            {
                Person = _person,
                Description = "Nome",
                Value = ""
            };
            var service = new ContactServices();
            _person.Contacts = service.GetContactsByPerson(_person.Id);
            _person.Contacts.Add(contact);

            this.DataContext = _person;
        }
    }
}
