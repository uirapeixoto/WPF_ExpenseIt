using Expenselt.Services;
using System.Collections;
using System.Collections.Generic;

namespace Expenselt.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public Person Person { get; set; }

    }
}