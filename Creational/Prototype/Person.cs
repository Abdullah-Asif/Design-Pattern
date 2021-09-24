using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person : IClone
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public object Clone()
        {
            var person = new Person();
            person.Name = Name;
            person.Email = Email;
            return person;
        }
    }
}
