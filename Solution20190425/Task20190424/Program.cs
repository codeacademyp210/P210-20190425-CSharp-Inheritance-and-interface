using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20190424
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Group myGroup = new Group();

            Console.Write("Adinizi daxil edin: ");
            student1.FirstName = Console.ReadLine();

            Console.Write("Soyadinizi daxil edin: ");
            student1.SurName = Console.ReadLine();


            Console.Write("Qrupunuzu daxil edin: ");
            myGroup.GroupName = Console.ReadLine();
 
            student1.StudentGroup = myGroup;


            Console.WriteLine($"Salam {student1.FirstName} {student1.SurName}. Qrupunuz: {student1.StudentGroup.GroupName}");
            Console.Read();

        }
    }
    class Group
    {
        private string _groupName;
        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
            }
        }

    }
    class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public Group StudentGroup { get; set; }
    }
}
