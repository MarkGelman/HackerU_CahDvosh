using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_abstract_project
{
    abstract class Shape
    {
        public string Name { get; set; }
        public double Angles { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
