using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Adam", 15);
            e.Describe();

            Console.ReadKey();
        }
    }
}
