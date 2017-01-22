using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)capacity / people);
            Console.WriteLine(courses);
        }
    }
}
