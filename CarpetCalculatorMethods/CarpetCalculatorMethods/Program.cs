using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarpetCalculatorMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthInFt = GetDimension("length");
            double widthInFt = GetDimension("width");
            WriteLine("Total length in feet: " + lengthInFt.ToString("F2"));
            WriteLine("Total width in feet: " + widthInFt.ToString("F2"));
            double areaInSqYds = GetSqYds(lengthInFt, widthInFt);
            WriteLine("Area in sq. yds: {0:F2}", areaInSqYds);
            GetCarpetPrices("berber", "pile",
                out double berberPrice, out double pilePrice);
            //Use WriteLine with ToString() to display the prices
            //to check they have been got right
            WriteLine("Berber price: " + berberPrice.ToString("C"));
            //Practice Exercise 1: Display pilePrice in the similar
            //manner as above
            WriteLine("Pile Price: " + pilePrice.ToString("C"));

            double berberCost = GetCarpetCost(berberPrice, areaInSqYds);
            double pileCost = GetCarpetCost(pilePrice, areaInSqYds);

            //Practice Exercise 3: After defining the method in exercise (2)
            //Create a variable berberCost and assign it
            // to the method call GetCarpetCost
            // double berberCost = GetCarpetCost(berberPrice, areaInSqYds);
            //Similarly declare and assign double pileCost

            //Practice Exercise 6: After completing 
            //DisplayBanner() method definition below.
            //Call it with needed input arguments
            //DisplayBanner(lengthInFt,widthInFt,
            //    berberPrice,pilePrice,berberCost,pileCost)
            DisplayBanner(lengthInFt, widthInFt, berberPrice, pilePrice, berberCost, pileCost);


        }
        //Practice Exercise 2: Create/Define a value-returning method
        //called GetCarpetCost(), that returns the double cost 
        //of the carpet given carpetPrice (double) and areaInSqYds (double)
        //as input parameters
        static double GetCarpetCost(double price, double areaInSqYds)
        {
            return price * areaInSqYds; //you may return a computation
        }

        //Practice Exercise 4: See the method definition below
        //DisplayBanner is similar to DisplayBanner in the Lec4MethodsDemo
        //It is a void method that takes as input lengthFt, widthFt,
        //berberPrice, pilePrice,berberCost, pileCost, 
        //displays formatted output in banner form
        static void DisplayBanner(double lengthFt, double widthFt,
                                    double berberPrice, double pilePrice,
                                       double berberCost, double pileCost)
        {
            WriteLine(new string('*', 50));
            WriteLine("*{0, 16}: {1, -8:F1}{2, -22}*", "Length", lengthFt, "Feet");
            //Practice exercise 4 - complete this banner - similar to Lec4Methods demo Display banner
            //and using the format given above, complete the banner to display
            //widthFt, berberPrice, pilePrice, berberCost, pileCost
            WriteLine("*{0, 16}: {1, -8:F1}{2, -22}*", "Width", widthFt, "Feet");
            WriteLine("*{0, 16}: {1, -8:C}{2, -22}*", "Berber Price", berberPrice, "Per Sq. Yd."); //currency specifier is given by C in format pattern
            WriteLine("*{0, 16}: {1, -8:C}{2, -22}*", "Pile Price", pilePrice, "Per Sq. Yd.");
            WriteLine("*{0, 16}: {1, -30:C}*", "Berber Cost", berberCost);
            WriteLine("*{0, 16}: {1, -30:C}*", "Pile Cost", pileCost);
            WriteLine(new string('*', 50));

            //Don't forget to call this method in the main method to see the result
        }

        static void GetCarpetPrices(string carpetType1, 
                                        string carpetType2,
                                        out double price1, 
                                        out double price2)
        {
            Write("Enter the price for " + carpetType1 + ": ");
            price1 = double.Parse(ReadLine());
            Write("Enter the price for " + carpetType2 + ": ");
            price2 = double.Parse(ReadLine());
        }
        static double GetSqYds(double lengthInFeet, double widthInFeet)
        {
            const int SQFT_PER_SQYD = 9;
            double sqYds = lengthInFeet*widthInFeet / SQFT_PER_SQYD;
            return sqYds;
        }
        static double GetDimension(string carpetSide) 
         //carpetSide can be "length" or "width"
        {
            Write("Enter the " + carpetSide + " in feet: ");
            int feet = int.Parse(ReadLine());
            Write("Enter the " + carpetSide + " in inches: ");
            int inches = int.Parse(ReadLine());
            double totalDimension = feet + (double)inches / 12;
            return totalDimension;
        }
        
    }
}
