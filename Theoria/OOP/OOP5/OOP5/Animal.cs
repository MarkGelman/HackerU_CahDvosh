using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Animal
    {
        protected string sound;

        public Animal(string sound)
        {
            this.sound = sound;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
