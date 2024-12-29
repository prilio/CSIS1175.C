using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LoopsTryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\n\nDemo 1 (from previous lecture): Use of else if statement to check for grade with input validations");
            Write("Enter the grade: ");

            if (!int.TryParse(ReadLine(), out int grade1))
            {
                //Note the NOT (!) operator - will enter if only grade is not an integer
                WriteLine("Grade needs to be a valid integer between 0 and 100");
            }
            else if (grade1 < 0)
            {
                //Will enter this if grade1 is valid integer but < 0
                WriteLine("Grade1 cannot be negative");
            }
            else if (grade1 > 100)
            {
                //Will enter this if grade1 is valid integer, >= 0 but also > 100
                WriteLine("Grade1 cannot be > 100");
            }
            else
            {
                //Will enter else only if grade1 is valid integer, >=0 and <=100
                //Means it is valid grade1 data
                //Now we display the corresponding letter grade
                if (grade1 >= 80)
                {
                    WriteLine("You got an A");
                }
                else if (grade1 >= 70)
                {
                    WriteLine("You got a B");
                }
                else if (grade1 >= 60)
                {
                    WriteLine("You got a C");
                }
                else if (grade1 >= 50)
                {
                    WriteLine("You got a P");
                }
                else
                {
                    WriteLine("It is a failing grade. Do better next time");
                }
            }

            WriteLine("\n\nDemo 2: Use of while statement to check for grade with input validations");
            Write("Enter the grade: ");
            int myGrade;
            while (!int.TryParse(ReadLine(), out myGrade) || myGrade < 0 || myGrade > 100)
            {
                WriteLine("Grade needs to be a valid integer between 0 and 100");
                Write("Please re-enter the grade: ");
                //no ReadLine() inside the loop
            }
            //while loop is quit/exitted only when valid grade (integer between 0 and 100
            if (myGrade >= 80)
            {
                WriteLine("You got an A");
            }
            else if (myGrade >= 70)
            {
                WriteLine("You got a B");
            }
            else if (myGrade >= 60)
            {
                WriteLine("You got a C");
            }
            else if (myGrade >= 50)
            {
                WriteLine("You got a P");
            }
            else
            {
                WriteLine("It is a failing grade. Do better next time");
            }

            Write("Enter the address: ");
            string address = ReadLine(); //initial expression

            while (address == "") //conditional expression
            {
                Write("Address cannot be blank. Please re-enter address: ");
                address = ReadLine(); //update expression, must ultimately lead to condition becoming false at some point
            }

            WriteLine("Demo 3: Times table using while with increasing counter");
            int count = 1;
            while (count <= 12)
            {
                WriteLine("Entered loop " + count);
                WriteLine(count + "\t" + count * 6); //\t - tab escape character
                count++; //Note here count is incremented by 1
            }

            WriteLine("Demo 4: Times table using while with decreasing order " +
                                "and concatenated string output");
            string outputStr = ""; //empty string to begin with
            int decCount = 12; //initial expression starts with the upper limit 12
            while (decCount > 0)
            {
                WriteLine("Entered loop " + decCount);
                outputStr += decCount + "\t" + decCount * 6 + "\n"; //string accumulator to keep combining string output inside a loop
                decCount--; //Note here count is decremented by 1
            }
            WriteLine(outputStr); //Displaying the combined string after loop is done


            WriteLine("Demo 5: Times table until product limit is reached");
            int numCount = 1;
            int product = numCount * 6;

            while (product < 100)
            {
                string outputStr1 = numCount + "\t" + product; //note here it is not string accumulation
                WriteLine(outputStr1);
                numCount++; //does not always have to be increment by 1
                product = numCount * 6;
            }


            WriteLine("Demo 6: Given Initial enrollment, cap in enrollment " +
                "and annual rate of increase, compute " +
                "yearly enrollment projections, repeat if user wants to enter more enrollment data");

            bool moreEnrollments = true;
            while (moreEnrollments)
            {
                //Process one college enrollment data
                WriteLine("Processing college enrollment...");
                int initialEnrollment = 0, finalEnrollment = 0;
                double annualRate = 0;
                Write("Enter initial enrollment: ");
                while(!int.TryParse(ReadLine(), out initialEnrollment) ||
                                                initialEnrollment <= 0)
                {
                    Write("Initial enrollment must be integer > 0. " +
                                        "Please re-enter initial Enrollment: ");
                }
                Write("Enter the annual rate: ");
                while(!double.TryParse(ReadLine(), out annualRate) 
                            || annualRate <= 0 || annualRate > 10)
                {
                    Write("Annual Rate must be double value >0 and <= 10. " +
                        "Please re-enter the annual rate: ");
                }
                Write("Enter the final enrollment: ");
                while(!int.TryParse(ReadLine(), out finalEnrollment) || 
                            finalEnrollment <= initialEnrollment)
                {
                    Write("Final enrollment must be integer > intial enrollment. " +
                        "Re-enter final enrollment: ");
                }
                //Get enrollments for each year until final enrollment limit is reached
                int currentYear = 1;
                int currentYearEnrollment = initialEnrollment;
                while(currentYearEnrollment < finalEnrollment)
                {
                    WriteLine("Enrollment in " + currentYear 
                                            + " is " + currentYearEnrollment);
                    currentYear++;
                    currentYearEnrollment = currentYearEnrollment +
                                               (int)Math.Round(currentYearEnrollment * annualRate / 100);

                }
                WriteLine("It will take " + currentYear + " to reach " + finalEnrollment);

                Write("Do you have more colleges to process (yes/no)? ");
                string moreCollegeInput = ReadLine();
                while(moreCollegeInput != "yes" && moreCollegeInput != "no")
                {
                    Write("Please re-enter yes/no for more college enrollment: ");
                    moreCollegeInput = ReadLine();
                }
                if (moreCollegeInput == "no")
                {
                    WriteLine("Good Bye!");
                    moreEnrollments = false;
                }
            }
            //Practice Exericse 1: 6 Times table until product limit is reached
            //and only displaying every third multiplier
            //using string accumulator to display the times table using
            //formatted output
            //with a banner and the times table content inside the banner

            //Practice Excercise 2: with loops, user validation, TryParse, Loops:
            //create a new console application called CollegeEnrollment
            //In that create an Enrollment class, 
            //which has initialEnrollment, annualRate  - these two are read-only AutoProperties 
            //and finalEnrollment is readWrite auto property
            //Additionally, you will create a computed read-only property NumYears
            //which returns as computation the number of years it will take to reach final enrollment
            //Note that the get for NumYears will have a loop inside it

            //Have a constructor to set up the read-only auto properties and finalEnrollment

            //Then, create a ToString() method that displays initial, annual rate, final and num years

            //Then in the main program, you will get user input for initialEnrollment,
            //annualRate and finalEnrollment (do the same user validations done in class)
            //Create Enrollment object
            //Then use ToString() to display the details

            //Ask user if more enrollments need to be processed
            //each time you create one object at a time and display that object details

            //Also try the Ticketing Practice Exercise posted on blackboard
            //I will post the solution on the weekend but please try on your own 
            //first to build your skills and confidence.

        }
    }
}
