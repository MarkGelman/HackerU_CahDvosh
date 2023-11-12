using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class TrainCar
    {
        private int _numCar;
        private int _numberOfSeats;

        public int NumCar
        {
            get
            {
                return _numCar;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of car must be positive")
                }
                _numCar = value;
            }
        }
        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Seats must be positive")
                }
                _numberOfSeats = value;
            }
        }

        public TrainCar (int numCar, int seats)
        {
            NumCar = numCar;
            NumberOfSeats = seats;
        }

        public void Announcment(string text)
        {
            Console.WriteLine(text);
        }
    }

    
}
