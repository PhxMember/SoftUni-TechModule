using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(dec, 16);
            string upperhex = hex.ToUpper();
            string binary = Convert.ToString(dec, 2);
            Console.WriteLine("{0}\n{1}", upperhex, binary);
        }
    }
}
