using Expenselt.Model;
using Expenselt.Model.Abstract;
using Expenselt.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var contactService = new ContactServices();
            var estadoSevice = new EstadoService();

            _person.Contacts = contactService.GetContactsByPerson(_person.Id);
            _person.Estados = estadoSevice.GetEstados();

            this.DataContext = _person;
        }

        public void IncluirContatoCommand(object sender, RoutedEventArgs e)
        {
            var contact = new List<Contact> {
                new Contact{ Person = _person, Description = "Nome",Value = ""},
                new Contact{ Person = _person, Description = "E-mail",Value = "",},
                new Contact{ Person = _person, Description = "Telefone",Value = "" },
                new Contact{ Person = _person, Description = "Estado",Value = "" }
            };

            var contactService = new ContactServices();
            var estadosService = new EstadoService();

           // _person.Contacts = contactService.GetContactsByPerson(_person.Id);
            _person.Contacts.AddRange(contact);

            this.DataContext = _person;
        }

        private void SalvarContatoCommand(object sender, RoutedEventArgs e)
        {
            var contacts = _person.Contacts.Where(x => x.Value != null);
            var gridContact = GridContacts.DataContext;
            this.DataContext = _person;
        }

    }
}
