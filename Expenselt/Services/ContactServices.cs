using Expenselt.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Expenselt.Services
{
    public class ContactServices
    {
        public IEnumerable<Contact> GetContacts()
        {

            return new List<Contact> {
                new Contact{Id=1, Person = new Person{ Id = 1 }, Description = "Nome",      Value = "Joao",                 Estado = new Estado{ Id = 1 }  },
                new Contact{Id=2, Person = new Person{ Id = 1 }, Description = "Email",     Value = "joao@teste.com.br",    Estado = new Estado{ Id = 1 }  },
                new Contact{Id=3, Person = new Person{ Id = 1 }, Description = "telefone",  Value = "98886666",             Estado = new Estado{ Id = 53 } },
                new Contact{Id=4, Person = new Person{ Id = 1 }, Description = "Nome",      Value = "Maria",                Estado = new Estado{ Id = 53 }  },
                new Contact{Id=5, Person = new Person{ Id = 1 }, Description = "Email",     Value = "maria@teste.com.br",   Estado = new Estado{ Id = 53 }  },
                new Contact{Id=6, Person = new Person{ Id = 1 }, Description = "telefone",  Value = "98887777",             Estado = new Estado{ Id = 53 }  },
                new Contact{Id=7, Person = new Person{ Id = 2 }, Description = "Nome",      Value = "antonio",              Estado = new Estado{ Id = 53 }  },
                new Contact{Id=8, Person = new Person{ Id = 2 }, Description = "Email",     Value = "antonio@teste.com.br", Estado = new Estado{ Id = 53 }  },
                new Contact{Id=9, Person = new Person{ Id = 2 }, Description = "telefone",  Value = "98884444",             Estado = new Estado{ Id = 53 }  },
                new Contact{Id=10, Person = new Person{ Id = 2 }, Description = "Nome",     Value = "José",                 Estado = new Estado{ Id = 53 }  },
                new Contact{Id=11, Person = new Person{ Id = 2 }, Description = "Email",    Value = "jose@teste.com.br",    Estado = new Estado{ Id = 53 }  },
                new Contact{Id=12, Person = new Person{ Id = 2 }, Description = "telefone", Value = "98882222",             Estado = new Estado{ Id = 52 }  },
                new Contact{Id=13, Person = new Person{ Id = 2 }, Description = "Nome",     Value = "José",                 Estado = new Estado{ Id = 52 }  },
                new Contact{Id=14, Person = new Person{ Id = 2 }, Description = "Email",    Value = "jose@teste.com.br",    Estado = new Estado{ Id = 52 }  },
                new Contact{Id=15, Person = new Person{ Id = 2 }, Description = "telefone", Value = "98882222",             Estado = new Estado{ Id = 52 }  },
                new Contact{Id=16, Person = new Person{ Id = 3}, Description = "Nome",      Value = "José",                 Estado = new Estado{ Id = 52 }  },
                new Contact{Id=17, Person = new Person{ Id = 3}, Description = "Email",     Value = "jose@teste.com.br",    Estado = new Estado{ Id = 52 }  },
                new Contact{Id=18, Person = new Person{ Id = 3}, Description = "telefone",   Value = "98882222",            Estado = new Estado{ Id = 52 }  },
            };
        }

        public ObservableCollection<Contact> GetContactsByPerson(int PersonId)
        {
            var lista = GetContacts().Where(x => x.Person.Id == PersonId);
            return new ObservableCollection<Contact>(lista);
        }
    }
}
