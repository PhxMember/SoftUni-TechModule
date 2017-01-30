using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }
        static void PrintReceiptBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }
        static void PrintReceiptFooter()
        {
            Console.WriteLine(@"------------------------------
© SoftUni");
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
