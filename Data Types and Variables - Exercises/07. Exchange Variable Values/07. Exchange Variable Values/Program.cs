using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", num1, num2);
            Console.WriteLine("After:\na = {0}\nb = {1}", num2, num1);
        }
    }
}
