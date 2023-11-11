using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Person
    {
        public string Name { get; set; }
        private readonly string _id;
        private DateTime _birthDate;

        public string Id
        {
            get { return _id; }
        }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate >= DateTime.Now)
                {
                    throw new InvalidOperationException("Birth date must be lower then today");
                }
                else
                {
                    _birthDate = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        public Person(string name, string id, DateTime birthDate)
        {
            Name = name;
            _id = id;
            BirthDate = birthDate;
        }

        public static Family operator +(Person a, Person b)
        {
            Person[] people = { a, b };
            return new Family("Unknown", people);
        }
    }
}



    }
}
