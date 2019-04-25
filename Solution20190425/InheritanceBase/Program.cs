using InheritanceBase.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBase
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter Height: ");
            bool xConverted = Double.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Enter Width: ");
            bool yConverted = Double.TryParse(Console.ReadLine(), out y);
            
            Rectangle rectangle = new Rectangle(x, y, "Hello");
            rectangle.Show();

            Console.ReadLine();
        }


    }



}
