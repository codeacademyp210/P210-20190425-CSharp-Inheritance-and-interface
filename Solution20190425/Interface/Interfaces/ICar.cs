using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    interface ICar
    {
        bool Start();
        bool Stop();
        double IncreaseSpeed(double speed);
    }
}
