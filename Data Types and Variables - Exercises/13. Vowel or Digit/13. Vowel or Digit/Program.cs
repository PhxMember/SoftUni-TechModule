using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isNumeric = input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9" || input == "0";
            bool isVowel = input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y" || input == "A" || input == "E" || input == "I" || input == "O" || input == "U" || input == "Y";
            if (isNumeric)
            {
                Console.WriteLine("digit");
            } else if (isVowel)
            {
                Console.WriteLine("vowel");
            } else
            {
                Console.WriteLine("other");
            }
        }
    }
}
