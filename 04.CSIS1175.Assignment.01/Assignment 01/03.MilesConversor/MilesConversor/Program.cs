using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MilesConversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Miles to feet
            2. Miles to kilometer
            3. Miles = 4.5
            4. 01 mile = 5280 feet
            5. 01 mile = 1.60934 km
            6. Alignment the components (https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting)
            7. Change the value of miles
            8. Rerun the application
            */


            double miles = 4.5;
            const int MILESTOFEET = 5280;
            const double MILESTOKM = 1.60934;

            WriteLine("{0:F2} miles = {1,15:N2} feet ", miles, miles * MILESTOFEET);
            WriteLine("{0:F2} miles = {1,15:F2} km ", miles, miles * MILESTOKM);
            ReadLine();

            miles = 12.3; // Rewritten the app above or just change the quantity of miles in: double miles
            WriteLine("{0:F2} miles = {1,15:N2} feet ", miles, miles * MILESTOFEET);
            WriteLine("{0:F2} miles = {1,15:F2} km ", miles, miles * MILESTOKM);
            ReadKey();

        }
    }
}
