using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class Train : Vehicle
    {
        private TrainCar[] _cars;

        private string _id;

        private int _currentSpeed = 0;

        private int _maxSpeed;



        public TrainCar[] Cars { get { return _cars; } set { _cars = value; } }

        public string Id { get { return _id; } set { _id = value; } }

        public int CurrentSpeed { get { return _currentSpeed; } set { _currentSpeed = value; } }

        public int MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }





        public Train(string id, TrainCar[] cars, int maxSpeed, int year, string color, string manufacturer)

            : base(year, color, manufacturer)

        {

            Id = id;

            Cars = cars;

            MaxSpeed = maxSpeed;

        }



        public Train(string id, int maxSpeed, int year, string color, string manufacturer)

            : this(id, new TrainCar[5], maxSpeed, year, color, manufacturer)

        {

            for (int i = 0; i < Cars.Length; i++)

            {

                Cars[i] = new TrainCar(50, i);

            }

        }





        //second way for the second constructor

        public Train(string id, int maxSpeed, int year, string color, string manufacturer)

           : base(year, color, manufacturer)

        {

            Id = id;

            Cars = new TrainCar[5];

            MaxSpeed = maxSpeed;

            for (int i = 0; i < Cars.Length; i++)

            {

                Cars[i] = new TrainCar(50, i);

            }

        }



        public Train() : base(2023, "Red", "Alstom")

        {



            Id = "xxxxx";

            Cars = new TrainCar[5];

            MaxSpeed = 300;

        }



        //another example for the constructor above

        public Train() : this("xxxxx", new TrainCar[5], 300, 2023, "Red", "Alstom") { }





    }

}

    }
}
