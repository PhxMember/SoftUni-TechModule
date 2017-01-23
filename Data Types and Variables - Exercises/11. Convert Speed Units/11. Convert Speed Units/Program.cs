using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distanceInMeters = decimal.Parse(Console.ReadLine());
            decimal distanceInKm = (decimal)distanceInMeters / 1000;
            decimal distanceInMiles = (decimal)distanceInMeters / 1609;
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            
            decimal totalInSeconds = (decimal)hours * 3600 + minutes * 60 + seconds;
            decimal metersPerSecond = Math.Ceiling(distanceInMeters / totalInSeconds);
            decimal kilometersPerHour = Math.Ceiling(metersPerSecond * 3.6M);
            decimal milesPerHour = Math.Ceiling(kilometersPerHour * 0.621371192M);
            Console.WriteLine("{0:f6}\n{1:f6}\n{2:f6}", metersPerSecond, kilometersPerHour, milesPerHour);
            

        }
    }
}
