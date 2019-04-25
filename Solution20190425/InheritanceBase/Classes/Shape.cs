using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBase.Classes
{
    class Shape
    {
        protected double height;
        protected double width;

        public Shape(double h, double w)
        {
            height = h;
            width = w;
            Console.WriteLine("Shape constructor");

        }

        public double GetArea()
        {
            return height * width;
        }

        public void Display()
        {
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + GetArea());
        }

    }
}
