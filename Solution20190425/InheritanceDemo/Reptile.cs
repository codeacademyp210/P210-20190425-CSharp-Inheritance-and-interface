using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Reptile : Animal
    {
        private string Name;
        public bool SudaYashiyan { get; set; }
        public bool AyagiVarYaYox { get; set; }
        public bool ZeherliYaZehersiz { get; set; }

        public void Surunsun()
        {
            Console.WriteLine("Surunuruk");
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}
