using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConditionalsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo 1: Use of if statement");
            Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
            char weatherForeCast = char.Parse(ReadLine()); //you may use int instead of char data type because options are numbers
            if (weatherForeCast == '1')
            {
                WriteLine("Wear rain boots today");
            }
            if (weatherForeCast == '2')
            {
                WriteLine("Wear snow boots today");
            }
            if (weatherForeCast == '3')
            {
                WriteLine("Wear sandals today");
            }

            WriteLine("\n\nDemo 2:Use of if-else for seeing if the weather is sunny or not..");
            if (weatherForeCast == '3')
            {
                WriteLine("Yay! It is warm and sunny, wear sandals today");
            }
            else
            {
                WriteLine("I wish it was warm and sunny!");
            }

            WriteLine("\n\nDemo 3: Use of combined conditions to check for valid vs. invalid input");
            Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
            int weatherOption = int.Parse(ReadLine()); //just showing with int, similar to char data type
            if (weatherOption == 1 || weatherOption == 2 || weatherOption == 3)
            {
                WriteLine("Yay! you entered valid input");
            }
            if (weatherOption != 1 && weatherOption != 2 && weatherOption != 3)
            {
                WriteLine("Invalid input - option entered must be 1, 2 or 3 only");
            }

            WriteLine("\n\nDemo 4: Use of else if statement to check for mutually exclusive conditions");
            Write("Enter the weather forecast (1 if rainy, 2 if snowing, 3 if warm and sunny): ");
            weatherOption = int.Parse(ReadLine()); //already declared int weatherOption, re-using here

            if (weatherOption == 1)
            {
                WriteLine("Please wear rain boots");
            }
            else if (weatherOption == 2)
            {
                WriteLine("Please wear snow boots");
            }
            else if (weatherOption == 3)
            {
                WriteLine("Please wear sandals");
            }
            else
            {
                WriteLine("Invalid number, must be only 1, 2 or 3");
            }
        }
    }
}
