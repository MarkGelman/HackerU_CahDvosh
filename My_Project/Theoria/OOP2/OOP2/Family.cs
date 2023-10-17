using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Family
    {
        public string Name { get; set; }
        private Person[] _people;


        public Family(string name, Person[] people)
        {
            Name = name;
            _people = people;
        }
        public void ShowFamily()
        {
            foreach (Person person in _people)
            {
                Console.WriteLine(person.Name);
            }
        }
        public double GetAvgAge()
        {
            double avg = 0;
            foreach (Person person in _people)
            {
                avg += person.Age;
            }
            return avg / _people.Length;
        }

        public void AddPerson(Person person)
        {
            Person[] people = new Person[_people.Length + 1];
            bool flag = false;
            for (int i = 0; i < _people.Length; i++)
            {
                if (person.Age > _people[i].Age || flag == true)
                {
                    if (flag == false)
                        people[i] = _people[i];
                    else people[i + 1] = _people[i];
                }
                else
                {
                    flag = true;
                    people[i] = person;
                    i--;
                }

            }
            _people = people;

        }
        public Person this[int i]
        {
            get { return _people[i]; }

        }

        public static Family operator +(Family family1, Person p1)
        {
            Person[] newArray = (Person[])family1._people.Clone();
            Family newFamily = new Family(family1.Name, newArray);
            newFamily.AddPerson(p1);
            return newFamily;
        }


    }
}


