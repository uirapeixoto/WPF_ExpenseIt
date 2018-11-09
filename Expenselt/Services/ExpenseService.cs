using Expenselt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expenselt.Services
{
    public class ExpenseService
    {
        public IEnumerable<Expense> GetExpenses()
        {
            return new List<Expense> {
                new Expense{Id = 1, Person = new Person{ Id = 1} , ExpenseType="Lunch", ExpenseAmount = 50},
                new Expense{Id = 2, Person = new Person{ Id = 1} , ExpenseType="Transportation", ExpenseAmount = 50},
                new Expense{Id = 3, Person = new Person{ Id = 2} , ExpenseType="Document printing", ExpenseAmount = 50},
                new Expense{Id = 4, Person = new Person{ Id = 2} , ExpenseType="Gift", ExpenseAmount = 125},
                new Expense{Id = 5, Person = new Person{ Id = 3} , ExpenseType="Magazine subscription", ExpenseAmount = 50},
                new Expense{Id = 6, Person = new Person{ Id = 3} , ExpenseType="New machine", ExpenseAmount = 600},
                new Expense{Id = 7, Person = new Person{ Id = 3} , ExpenseType="Software", ExpenseAmount = 500},
                new Expense{Id = 8, Person = new Person{ Id = 4} , ExpenseType="Dinner", ExpenseAmount = 100},
            };
        }

        public IEnumerable<Expense> GetExpensesByPerson(int PersonId)
        {
            var lista = GetExpenses();
            return lista.Where(x => x.Person.Id == PersonId);
        }
    }
}
