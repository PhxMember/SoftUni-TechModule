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
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumofdigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumofdigits += digits % 10;
                    digits = digits / 10;

                }
                bool special = (sumofdigits == 5) || (sumofdigits == 7) || (sumofdigits == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
