using Expenselt.Model;
using Expenselt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }

        public ExpenseReportPage(object data): this()
        {
            var person = data as Person;
            var service = new ExpenseService();

            person.Expenses = service.GetExpensesByPerson(person.Id).ToList();

            // Bind to expense report data.
            this.DataContext = person;
        }
    }
}
