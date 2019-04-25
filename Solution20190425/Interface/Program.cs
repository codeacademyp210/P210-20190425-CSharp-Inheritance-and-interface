using Interface.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                CurrentSpeed = 0
            };

            car1.Start();
            car1.IncreaseSpeed(10);
            car1.IncreaseSpeed(10);
            car1.IncreaseSpeed(10);
            car1.IncreaseSpeed(10);
            Console.ReadLine();
        }
    }
}
