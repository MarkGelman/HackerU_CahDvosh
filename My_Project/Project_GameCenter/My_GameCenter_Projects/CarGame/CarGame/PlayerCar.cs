using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CarGame
{
    class PlayerCar : GameObject
    {
        public bool LeftKeyPresed { get; set; }
        public bool RightKeyPresed { get; set; }
        public PlayerCar(int x, int y, int speed, Image carImage) : base(x, y, speed, carImage)
        {
            
        }

        public override void Move()
        {
            
            if (LeftKeyPresed && X > 0)
            {
                X -= Speed;
            }
            if (RightKeyPresed && X < Application.Current.MainWindow.Width - Representation.Width)
            {
                X += Speed;
            }
            Draw();
        }
    }

}
