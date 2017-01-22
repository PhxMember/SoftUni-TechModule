using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int digits = 0;
            bool is5or7or11 = false;
            for (int i = 1; i <= n; i++)
            {
                digits = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                is5or7or11 = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{digits} -> {is5or7or11}");
                sumOfDigits = 0;
                i = digits;
            }

        }
    }
}
