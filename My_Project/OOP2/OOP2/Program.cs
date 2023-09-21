using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] cars1 = { 50, 50, 50, 50, 0, 0, 0, 0, 0, 0 };
            //int[] cars2 = { 50, 50, 10 , 50, 50, 50, 50, 50, 50, 20 };

            //Train t1 = new Train(cars1, 200, "11111", 2020, "Black", "mercedes");
            //Train t2 = new Train(cars2, 250, "22222", 2023, "Black", "Jp");

            //t1.MaxSpeed = 220;
            //t2.Color = "Red";

            ////Console.WriteLine(t1.MaxSpeed);
            //t2.DeleteCar(2);
            //Console.WriteLine(t2.ToString());
            //Console.WriteLine(t2.Cars[2]);

            DateTime birthday = new DateTime(1974, 02, 01);

            Person person = new Person("Ichak","333333333",birthday);
            Family family = new Family("Moshe");



            Console.ReadKey();
        }
    }
}
