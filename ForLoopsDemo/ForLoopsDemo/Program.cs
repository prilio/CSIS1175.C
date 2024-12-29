using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ForLoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo 1: Times table using for with increasing counter");
            //int i;
            for (int i = 1; i <= 12; i++)
            {
                WriteLine("Entered loop " + i);
                WriteLine(i + "\t" + i * 6);
            }
            //WriteLine("i after for loop..." + i); //i can be used outside for loop if declared before

            WriteLine("Demo 2: Times table using for with decreasing order " +
                                "and concatenated string output");
            string outputStr = "";
            for (int i = 12; i > 0; i--)
            {
                WriteLine("Entered loop " + i);
                outputStr += i + "\t" + i * 6 + "\n"; //string conjunctive  concatenation
            }
            WriteLine(outputStr); //Displaying the combined string after loop is done


            WriteLine("Demo 3: Times table until product limit is reached");
            int product = 0;
            for (int numCount = 1; numCount < 10 || product < 100; numCount++)
            {
                product = numCount * 6;
                string outputStr1 = numCount + "\t" + product; //note here it is not string concatenation
                WriteLine(outputStr1);
            }

        }
    }
}
