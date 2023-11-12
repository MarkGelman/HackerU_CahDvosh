using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Cat : Animal
    {
        public Cat(string sound):base(sound)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
