using Expenselt.Model;
using Expenselt.Services;
using System.Linq;
using System.Windows.Controls;

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
