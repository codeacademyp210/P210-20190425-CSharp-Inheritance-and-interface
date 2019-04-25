using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    class Car : ICar
    {
        public double CurrentSpeed { get; set; }


        public double IncreaseSpeed(double speed)
        {
            CurrentSpeed += speed;
            return CurrentSpeed;
        }

        public bool Start()
        {
            return true;
        }

        public bool Stop()
        {
            return true;
        }
    }
}
