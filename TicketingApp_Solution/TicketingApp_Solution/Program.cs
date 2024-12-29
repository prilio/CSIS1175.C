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
            int numTickets;
            Write("How many tickets would you like to process? ");
            while(!int.TryParse(ReadLine(), out numTickets) || numTickets <= 0)
            {
                Write("Number of tickets must be whole number > 0. Please re-enter: ");
            }
            //Declaring an array of tickets based on number of tickets to be 
            //processed

            Ticket[] AllTickets = new Ticket[numTickets];
            
            //setting up the loop to enter each ticket details

            for (int i = 0; i < numTickets; i++)
            {

                Write("Let us enter the details of Ticket " + (i + 1) + " ...");
                GetTicketDetails(out string stId, out char stCat,
                            out int spLimit, out int spReported);
                WriteLine("Final value of student id is: " + stId);
                WriteLine("Student category is: " + stCat.ToString());
                WriteLine("Speed Limit: " + spLimit);
                WriteLine("Speed Reported: " + spReported);
                Ticket myTicket = new Ticket(stId, stCat, spLimit, spReported);
                AllTickets[i] = myTicket; //adding the one ticket object at a time to the ticket array
            } //end of loop for entering all the tickets

            WriteLine("\n\nDisplaying all the Tickets...\n");
            DisplayAllTicketDetails(AllTickets);
            WriteLine("Average of all the Fines: "
                    + GetAvgFineOfAllTickets(AllTickets).ToString("C"));

        }

        static double GetAvgFineOfAllTickets(Ticket[] AllTix)
        {
            double sum = 0;
            foreach(Ticket eachTicket in AllTix)
            {
                sum += eachTicket.Fine;
            }
            return (sum / AllTix.Length);
        }
        static void DisplayAllTicketDetails(Ticket[] AllTix)
        {
            foreach(Ticket eachTicket in AllTix)
            {
                WriteLine(eachTicket);
                WriteLine(); //blankline after each ticket
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
