using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Priscila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. create two methods TotalDistance() AverageFuel()
            //2. ask about speed (km/h, int)
            //3. ask about duration (hrs, int)
            //4. ask about total distance (km, int)
            //5. ask about average fuel cost (L/100km, double)
            //6.totalDistance = speed*duration;
            //7. averageFuel = 100 * gas / totalDistance;

            /* THIS IS ORIGINAL TEST
             
            int speed= 75;
            int duration= 6;
            int consume = 43;
            double totalDistance = 450;
            double averageFuel = 9.6;
         


            WriteLine("Please input the speed of your car: " +speed);
            ReadKey();
            WriteLine("Please input the duration: " +duration);
            ReadKey();
            WriteLine("Please input the gas consume: " +consume);
            ReadKey();
            WriteLine("The total distance is: " + totalDistance);
            ReadKey();
            WriteLine("The average fuel cost: " + averageFuel + " L/100KM");
            ReadKey();
            */

            int duration;
            int speed;
            int distance;            
            int gas;
            double average;

            WriteLine("Please input the speed of your car: ");
            speed = int.Parse(ReadLine());

            WriteLine("Please input the duration: ");
            duration = int.Parse(ReadLine());

            WriteLine("Please input the gas consume: ");
            gas = int.Parse(ReadLine());

            distance = TotalDistance(duration, speed);
            average = AverageFuel(gas, distance);

            WriteLine("The total distance is: {0} km", distance);
            WriteLine("The average fuel cost: {0:F2} L/100Km", average);
            ReadKey();
        }

        public static int TotalDistance(int duration, int speed)
        {
            return duration * speed;
        }

        public static double AverageFuel(int gas, int distance)
        {
            return (double)gas / distance * 100;
        }
    }
}
