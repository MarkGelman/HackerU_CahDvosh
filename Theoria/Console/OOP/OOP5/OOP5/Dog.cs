using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Dog: Animal
    {
        public Dog(string sound) : base(sound)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
