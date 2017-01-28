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
            float distanceInMeters = float.Parse(Console.ReadLine());
            float distanceInKm = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / 1609;
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalInSeconds = hours * 3600 + minutes * 60 + seconds;
            float metersPerSecond = distanceInMeters / totalInSeconds;
            float totalInHours = totalInSeconds / 3600;
            float kilometersPerHour = distanceInKm / totalInHours;
            float milesPerHour = distanceInMiles / totalInHours;
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
            

        }
    }
}
