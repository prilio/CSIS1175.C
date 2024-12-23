using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Learning_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicialStrideCount,
                finalStrideCount,
                hrs,
                mins,
                totalMins;
            double nSPM,
                distanceTraveled;

            DisplayInstructions();
            inicialStrideCount = GetNumberStrides("first");
            finalStrideCount = GetNumberStrides("last");
            InputJoggingTime(out hrs, out mins);
            totalMins = CalculateTime(hrs, mins);
            nSPM = CalculateAvgSteps(inicialStrideCount, finalStrideCount);
            distanceTraveled = CalculateDistance(nSPM, totalMins);
            DisplayResults(nSPM, hrs, mins, distanceTraveled);
            ReadKey();


        }
        public static void DisplayInstructions()
        {
            WriteLine("How many miles did you jog?");
            WriteLine("Distance (in miles) will be calculated " +
                "based on stride and number of steps");
            WriteLine("taken per minute. \n");
            WriteLine("You will be asked to enter ");
            WriteLine("your initial and ending strides...");
            WriteLine("OR how many steps you took the ");
            WriteLine("first minute and how many ");
            WriteLine("steps during the last minute.");
            WriteLine("Average stride is calculated from those entries. \n");
            WriteLine("Calculations are based on a ");
            WriteLine("2.5 feet stride-each step is 2.5 feet long.");
            WriteLine();
            WriteLine("\nYou will also be asked to enter the length");
            WriteLine("of time (hours and minutes)");
            WriteLine("you jogged.");
            WriteLine();
            WriteLine("Press any key when you are ready to begin!");
            ReadKey();
        }
        public static int GetNumberStrides(string when)
        {
            int nSteps;
            Write("Enter number of steps taken during {0} minute: ", when);
            nSteps=int.Parse(Console.ReadLine());
            return nSteps;
        }
        public static void InputJoggingTime(out int hrs, out int mins)
        {
            WriteLine("\nHow much time did you spend jogging?");
            Write("Hours: ");
            hrs = int.Parse(ReadLine());
            Write("Minutes: ");
            mins = int.Parse(ReadLine());
        }
        public static double CalculateAvgSteps(int initialStrideCount, int finalStrideCount)
        {
            return (initialStrideCount+finalStrideCount) / 2.0;
        }
        public static int CalculateTime(int hrs, int mins)
        {
            return hrs * 60 + mins;
        }
        public static double CalculateDistance(double nSPM, int totalMins)
        {
            const double Stride = 2.5;
            const int FpM = 5280;
            return nSPM * Stride * totalMins / FpM;
        }
        public static void DisplayResults (double nSPM, int hrs, int mins, double distanceTraveled)
        {
            Clear();
            WriteLine("{0,35}", "Jogging Distance Calculator");
            WriteLine();
            WriteLine("{0,−25} {1} Feet Per Step ", 
                "Stride:", 
                2.5);
            WriteLine("{0,−25} {1} Steps", "Strides Per Minute: ", nSPM);
            WriteLine("{0,−25} {1} Hour(s) and {2} Minute(s)" + "Jogging Time:", hrs, mins);
            WriteLine("{0,−25} {1:f2} Miles", "Distance Traveled:", distanceTraveled);
        }

    }    
  
}
