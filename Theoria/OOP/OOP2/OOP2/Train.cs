using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Train : Vehicle
    {
        private int[] _cars = new int[10];
        private readonly string _id;
        private int _currentSpeed = 0;
        private int _maxSpeed;


        public int[] Cars
        {
            get { return _cars; }
            set
            {
                if (value.Length < _cars.Length)
                    Array.Copy(value, _cars, value.Length);
                else
                    _cars = value;
            }
                
                
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }

            set
            {
                _maxSpeed = value;
            }
        }

        public Train(int[] cars, int maxSpeed, string id, int yearOfManufacturer, string color, string manufacturer)
            : base(yearOfManufacturer, color, manufacturer)
        {
            MaxSpeed = maxSpeed;
            _id = id;
             
            Cars = cars;
        }

        public void AddCar(int numberOfPassengers)
        {

            for (int i = 0; i < _cars.Length; i++)
            {
                if (_cars[i] == 0)
                {
                    _cars[i] = numberOfPassengers;
                    count++;
                }
                if (count > 0)
                {
                    _cars.CopyTo(_cars2, 0);
                    _cars2.Append(numberOfPassengers);
                    break;
                }
            }
        }

        public void Accelerate()
        {
            if (_currentSpeed + 10 <= MaxSpeed)
            {
                _currentSpeed += 10;
            }

            else
            {
                _currentSpeed = MaxSpeed;
            }
        }

        public void Decelerate()
        {
            if (_currentSpeed - 10 >= 0)
            {
                _currentSpeed -= 10;
            }

            else
            {
                _currentSpeed = 0;
            }
        }

        public void DeleteCar (int numCar)
        {
            Array.Copy(_cars, numCar+1, _cars, numCar, _cars.Length - numCar-1);
            _cars[_cars.Length - 1] = 0;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in GetType().GetProperties())
            {
                if (item.Name != "Cars")
                    str += $"{item.Name} : {item.GetValue(this)} \n";
            }

            for (int i = 0; i < _cars.Length; i++)
            {
                if (_cars[i] != 0)
                    str += $"Car {i} Pssengers: {_cars[i]}\n";
            }

            return str;
        }

    }
}
