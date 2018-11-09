using Expenselt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expenselt.Services
{
    public class PersonService
    {
        public List<Person> GetPerson()
        {
            return new List<Person> {
                new Person{Id = 1, Name = "Mike", Department = "Legal"},
                new Person{Id = 2, Name = "Lisa", Department = "Marketing"},
                new Person{Id = 3, Name = "John", Department = "Engineering"},
                new Person{Id = 4, Name = "Mary", Department = "Finance"},
            };
        }
    }
}
