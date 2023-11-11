using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle1 = new Vehicle(2020, "black", "Mercedes");
            Vehicle myVehicle2 = new Vehicle(2015, "black", "Volvo");
            myVehicle1.Start();
            myVehicle2.Stop();

            Console.ReadKey();
        }
    }
}
