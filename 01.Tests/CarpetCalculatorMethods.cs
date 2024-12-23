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
           
            double roomWidth, 
				roomLength, 
                priceSQYD, 
                numSQYD;

            DisplayInstructions();
            
            roomLength = GetDimension("Lenght");
            roomWidth = GetDimension("Widht");
            priceSQYD = GetPrice();
            numSQYD = DetermineSQYD(roomWidth, roomLength);
            
            DisplayResults(numSQYD, priceSQYD);
            
            ReadLine();


            
        }
        public static void DisplayInstructions()
        {
            WriteLine("This program will determine how much carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to enter the size of the room and ");
            WriteLine("the price of the carpet, in price per square yards.");
            WriteLine();

        }
        public static void DisplayResults(double sqYD, double priceSQYD)
        {
            WriteLine();
            Write("Total square yards needed: ");
            WriteLine("{0:N2}", sqYD);
            Write("Total cost at {0:C} ", priceSQYD);
            WriteLine("per square yard: {0:C}", DeterminePrice(sqYD,priceSQYD)); 
        }
        public static double GetDimension(string side)
        {
            //string inputValue;
            int feet,
                inches;
            Write("Enter the {0} in feet: ", side);
            feet = int.Parse(ReadLine()); 
            Write("Enter the {0} in inches: ", side);
            //inputValue = ReadLine();
            inches = int.Parse(ReadLine());

            return (feet + (double)inches/12);
        }
        public static double GetPrice()
        {
            //string inputValue;
            double price;
            Write("Enter the price per Square Yard: ");
            //inputValue = ReadLine();
            price = double.Parse(ReadLine());

            return price;
        }
        public static double DetermineSQYD (double widht, double length)
        {
            const int sqFTsqYD = 9;
            double numSQYD;
            numSQYD = length * widht / sqFTsqYD;
            return numSQYD;
        }

        public static double DeterminePrice (double sqYD, double priceSQYD)
        {
            return (priceSQYD * sqYD);
        }

    }    



    
}