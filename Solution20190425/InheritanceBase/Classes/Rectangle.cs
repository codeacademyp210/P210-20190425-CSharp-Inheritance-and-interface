using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBase.Classes
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width, string text) : base(height, width)
        {
            Console.WriteLine("Rectangle constructor " + text);
        }

        public string GetColor()
        {
            return "Red";
        }


        public void Show()
        {
            base.Display();
            Console.WriteLine("Color: " + GetColor());
        }


    }
}
