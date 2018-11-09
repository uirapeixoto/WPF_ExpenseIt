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
using System.Diagnostics;
using Expenselt.Services;
using Expenselt.Model;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();

            var service = new PersonService();
            peopleListBox.ItemsSource = service.GetPerson();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var person = peopleListBox.SelectedItem as Person;
            var resposta = MessageBox.Show(string.Format("O item selecionado foi: {0}", person.Name ), "Mensagem", MessageBoxButton.YesNo);
            if (resposta == MessageBoxResult.Yes)
            {
                // View Expense Report  
                ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
                this.NavigationService.Navigate(expenseReportPage);
            }   
        }
    }
}
