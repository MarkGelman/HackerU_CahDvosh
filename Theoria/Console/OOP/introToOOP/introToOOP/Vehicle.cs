using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class Vehicle
    {
        private int _yearOfManufacturer;
        private string _color;
        private string _manufacturer;

       

        public string Manufacturer {
            get {
                return _manufacturer;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("");
                }

                this._manufacturer = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public int YearOfManufacturer
        {
            get
            {
                return _yearOfManufacturer;
            }

            set
            {
                if(value < 1920 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Year must be between 1920 and" + DateTime.Now.Year);
                }

                _yearOfManufacturer = value;
            }
        }

        public Vehicle(int yearOfManufacturer, string color, string manufacturer)
        {
            YearOfManufacturer = yearOfManufacturer;
            Color = color;
            Manufacturer = manufacturer;
        }

        public void Start()
        {
            Console.WriteLine($"The Vehicle {Manufacturer} is start moving");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Manufacturer}`s vehicle is stop moving");
        }
    }
}
