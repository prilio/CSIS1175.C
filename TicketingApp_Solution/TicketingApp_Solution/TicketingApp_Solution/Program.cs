using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicketingApp_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can test this app using test input given in Pg 303 of the textbook

            char moreTicketInput = 'Y'; //a character to keep track of if user says 'y' for yes to more tickets or 'n' for no more tickets

            while (moreTicketInput == 'Y')
            {

                GetTicketDetails(out string stId, out char stCat,
                            out int spLimit, out int spReported);
                WriteLine("Final value of student id is: " + stId);
                WriteLine("Student category is: " + stCat.ToString());
                WriteLine("Speed Limit: " + spLimit);
                WriteLine("Speed Reported: " + spReported);
                Ticket myTicket = new Ticket(stId, stCat, spLimit, spReported);
                WriteLine(myTicket); //same as WriteLine(myTicket.ToString())

                //get user input to see if user enters 'Y' for more tickets or 'N' for no more tickets
                Write("Do you want to process another ticket? (Y - yes, N- no): ");
                while (!char.TryParse(ReadLine(), out moreTicketInput) || (moreTicketInput != 'Y' && moreTicketInput != 'N'))
                {
                    Write("Please re-enter your choice. Do you want to process another ticket? (Y-yes, N-no): ");
                }
            }

        }

        static void GetTicketDetails(out string studentId,
                                out char studentCat,
                                out int speedLimit,
                                out int speedReported)
        {
            studentId = "";
            studentCat = 'U'; //U refers to undefined, just as an initial value, all intial values not really needed here
            speedLimit = 0;
            speedReported = 0;
            WriteLine("Let us get the ticket details for the ticket....");
            Write("Enter the student id: ");
            studentId = ReadLine();
            while (studentId == "")
            {
                WriteLine("Student id cannot be blank");
                Write("Re-enter student id: ");
                studentId = ReadLine();
            }
            Write("Enter the student category (1-freshman, " +
                            "2-sophomore, 3-junior, 4-senior): ");

            while (!char.TryParse(ReadLine(), out studentCat) || (studentCat != '1' && studentCat != '2'
                && studentCat != '3' && studentCat != '4'))
            {
                //enters loop only if value is other than 1, 2, 3 or 4
                Write("Please Re-enter the student category (1-freshman, " +
                            "2-sophomore, 3-junior, 4-senior): ");
            }
            Write("Enter the speed limit: ");
            string inputValue = ReadLine();
            while (int.TryParse(inputValue, out speedLimit) == false)
            {
                Write("Please re-enter the speed: ");
                inputValue = ReadLine();
            }
            Write("Enter the speed reported: ");
            while (!int.TryParse(ReadLine(), out speedReported) ||
                speedReported < speedLimit)
            {
                WriteLine("Invalid speed - should be positive " +
                    "number greater than speed limit");
                Write("Enter the speed reported: ");
            }
        }


    }
}
