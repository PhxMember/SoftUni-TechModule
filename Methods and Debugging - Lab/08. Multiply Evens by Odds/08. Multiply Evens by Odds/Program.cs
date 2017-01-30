using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        public static int GetSumOfEvenDigits(int n)
        {
            var result = 0;
            foreach (var symbol in n.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    result += digit;
                }
            }

            return result;
        }
        public static int GetSumOfOddDigits(int n)
        {
            var result = 0;
            foreach (var symbol in n.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }
            
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
    }
}
