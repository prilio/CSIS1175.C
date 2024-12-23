using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MetersConversor
{
    internal class Program
    {
        public static double makeFeets(double xMeters)
        {
            double feets = xMeters * 3.28084;
            return feets;
        }
        public static double makeInches(double xMeters)
        {
            double inches = xMeters * 39.3701;
            return inches;
        }
        static void Main(string[] args)
        {
            
                Write("Enter meters: ");
                double nMeters = double.Parse(ReadLine());

                //Call methods for each calculation.
                double nFeets = makeFeets(nMeters);
                double nInches = makeInches(nMeters);

                WriteLine("Results: {0,10:F2} Feets\n {1,18:F2} Inches", nFeets, nInches);
                ReadLine();

            }
    }
}
