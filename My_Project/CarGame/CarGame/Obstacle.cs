using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarGame
{
    class Obstacle : GameObject
    {
        private int direction;

        public Obstacle(int x, int y, int speed, Image representation) : base(x, y, speed, representation)
        {
            Random rand = new Random();
            direction = rand.Next(-1, 2);
        }

        public override void Move()
        {
            Y += Speed;
            X += direction * Speed;
            Draw();
        }
    }
}
