using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("Demo 1: Initializing and displaying an integer array");
            int[] numbersArray = new int[]{ 78, 89, 77, 23, 98 };
            int numberOfElements = numbersArray.Length;
            for (int i = 0; i < numberOfElements; i++)
            {
                Write(numbersArray[i] + "\t");
            }
            WriteLine();

            WriteLine("Demo 2: string array");
            string[] namesArray = { "John", "Amy", "William" };
            namesArray = new string[] {"Willow","Adam"};
            WriteLine("Displaying string array elements...");

            for (int i = 0; i < namesArray.Length; i++)
            {
                WriteLine(namesArray[i]);
            }

            DisplayArray(namesArray);
            WriteLine("Demo 3: Working with double[] grades...getting user input...");

            int numOfGrades;
            Write("Enter the number of grades to process: ");
            while(!int.TryParse(ReadLine(), out numOfGrades) || numOfGrades <= 0)
            {
                Write("Number of grades must be whole number > 0. Please re-enter: ");
            }

            double[] grades = new double[numOfGrades];
            LoadGrades(grades);
            DisplayArray(grades);
            WriteLine("Average using unformatted op = " 
                                + GetAvg(grades).ToString("F1"));
            WriteLine("Average = {0:F1}",GetAvg(grades));
            WriteLine("Minimum = " + GetMinMax(grades)[0].ToString("F1"));
            double[] minMax = GetMinMax(grades);
            WriteLine("Max = " + minMax[1].ToString("F1"));


            //Additional Practice: For each of these below,
            //ask the user how many objects you need to process, 
            //and set up a loop to assign objects to the array of objects
            //Additional practice 1: using array of objects e.g., PhotoPrint[] from your assignment main program, 
            //find the total of All Objects PrintTotal, and then compute discount


            //Additional practice 2: using array of Ticket objects Ticket[] in your program
            //Additional practice 3: using array of objects for RealEstate[] in the real estate application

            //Note in this case, suppose you have the user entering number of tickets
            //as numTickets
            //Ticket[] AllTickets = new Ticket[numTickets];
            //Then each element i in AllTickets corresponds to one object.
            //AllTickets[0] is the first ticket object
            //AllTickets[0].StudentName, AllTickets[0].StudentCategory, AllTickets[0].ToString(),
            //AllTickets[0].Fine are all possible to get these values...


        }
        static double[] GetMinMax(double[] anyGrades)
        {
            double[] MinMax = new double[2];
            double min = anyGrades[0];
            double max = anyGrades[0];
            //Practice Exericse: set up a for loop
            //from element 2/index 1 all the way until end
                //if current element < min, then min = current element
                //if current element > max, max = current element
            //note that the for loop starts from element 2 till end for comparison with
            //the current min and max, each of which are assigned to the first 
            //element in the array
            for (int i = 1; i < anyGrades.Length; i++)
            {
                if (anyGrades[i] < min)
                {
                    min = anyGrades[i];
                }
                if (anyGrades[i] > max)
                {
                    max = anyGrades[i];
                }
            }
            MinMax[0] = min;
            MinMax[1] = max;
            return MinMax;
        }
        static void LoadGrades(double[] gradesArray)
        {
            WriteLine("Let us enter the grades for each student...");
            for(int i = 0; i < gradesArray.Length; i++)
            {
                //get value for ith element in the array
                double grade;
                Write("Please enter the grade for student " + (i + 1) + ": ");
                while(!double.TryParse(ReadLine(), out grade) 
                                        || grade < 0 || grade > 100)
                {
                    Write("Grade must be double >= 0 and <= 100. " +
                                        "Please re-enter grade: ");
                }
                gradesArray[i] = grade;

            }
        }

        static void DisplayArray(string[] anyArray)
        {
            WriteLine("Inside Display Array method using array as parameter....");
            for (int i = 0; i < anyArray.Length; i++)
            {
                WriteLine(anyArray[i]);
            }
            WriteLine();
        }
        static void DisplayArray(double[] anyGrades)
        {
            WriteLine("Displaying all the grades...");
            for (int i = 0; i < anyGrades.Length; i++)
            {
                WriteLine(anyGrades[i].ToString("F1"));
            }
            WriteLine("Displaying using foreach....");
            foreach(double grade in anyGrades)
            {
                // WriteLine(grade.ToString("F2"));
                WriteLine("{0,10:F2}", grade);
                //grade = 100; //foreach is read-only, so grade cannot be assigned to a value
            }

        }
        static double GetAvg(double[] anyGrades)
        {
            double avg = 0;
            double sum = 0;
            foreach (double grade in anyGrades)
            {
                sum += grade;
            }
            if (anyGrades.Length > 0)
            {
                avg = sum / anyGrades.Length;
            }
            return avg;
        }
    }
}
