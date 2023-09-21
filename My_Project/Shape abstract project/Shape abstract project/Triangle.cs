using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_abstract_project
{
    class Triangle: Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Triangle(double height, double baseLength, double sideALength, double sideBLength)
        {
            Name = "Triangle";
            Angles = 3;
            Height = height;
            Base = baseLength;
            SideA = sideALength;
            SideB = sideBLength;
        }

        public override double CalculateArea()
        {
            return Height * Base / 2;
        }
        public override double CalculatePerimeter()
        {
            return Base + SideA + SideB;
        }
    }
}
