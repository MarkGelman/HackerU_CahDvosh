using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_abstract_project
{
    class Circle: Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Angles = 0;
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
