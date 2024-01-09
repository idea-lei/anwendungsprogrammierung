using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWP_1
{
    internal class Student
    {
        public string Name { get; set; }
        public static int InstanceCount { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"print from instance: {Name}");
        }

        public static void PrintName(Student student)
        {
            Console.WriteLine($"print from static: {student.Name}");
        }
    }
}
