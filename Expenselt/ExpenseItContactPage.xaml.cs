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
            var service = new ContactServices();
            _person.Contacts = service.GetContactsByPerson(_person.Id);

            this.DataContext = _person;
        }

        public void IncluirContatoCommand(object sender, RoutedEventArgs e)
        {
            var contact = new List<Contact> {
                new Contact{ Person = _person, Description = "Nome",Value = "" },
                new Contact{ Person = _person, Description = "E-mail",Value = "" },
                new Contact{ Person = _person, Description = "Telefone",Value = "" }
            };


            var service = new ContactServices();
            _person.Contacts = service.GetContactsByPerson(_person.Id);
            _person.Contacts.AddRange(contact);

            this.DataContext = _person;

        }

    }
}
