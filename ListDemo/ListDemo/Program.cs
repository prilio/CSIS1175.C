using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> NamesList = new List<string>(); //constructing an empty list of string with 0 elements to start with
            WriteLine("Total number of names in the list before adding the names = " + NamesList.Count);

            NamesList.Add("John"); //this adds John to the end of the list
            NamesList.Add("William");
            NamesList.Add("Jim");
            NamesList.Add("Amy");

            //Note that List has Count property but arrays have Length property
            WriteLine("Total number of names in the list = " + NamesList.Count);

            foreach (string name in NamesList)
            {
                Write(name + "\t");
            }
            WriteLine();

        }
    }
}
