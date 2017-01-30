﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        public static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            } else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            } else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
