using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person
    {
        public string DateRegistered { get; set; }
    }
}
