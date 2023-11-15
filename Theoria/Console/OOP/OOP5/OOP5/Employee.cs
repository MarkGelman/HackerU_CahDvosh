using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Employee: Person
    {
        public Employee(string name, int age) : base(name, age)
        {
        }

        public void Describe()
        {
            Console.WriteLine(name + " " + age);
        }
    }
}
