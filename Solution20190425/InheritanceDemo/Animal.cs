using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Animal
    {
        protected string Name { get; set; }
        public bool IsDomestic { get; set; }

        public bool Nutrition()
        {
            return true;
        }

        public double Move()
        {
            return 0;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
