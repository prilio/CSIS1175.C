using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace TimeConversor
{
    internal class Program
    {
        // Method to ask for seconds and return it on hh:mm:ss format.
        static void Main(string[] args)
        {

            Write("Enter seconds: ");
            int nSeconds = int.Parse(Console.ReadLine());

            /* Without methods:
            int nHours = nSeconds / 3600;
            nSeconds = nSeconds % 3600; //To get the remaining number after division (Resto da divisao)
            int nMinutes = nSeconds / 60;
            nSeconds %= 60; // The same expression to nSeconds % 60
            */

            // Call methods for each calculation.
            int nHours   = makeHours(nSeconds);
            int nMinutes = makeMinutes(nSeconds);
            nSeconds = makeSeconds(nSeconds);

            WriteLine("{0:D2}:{1:D2}:{2:D2}" , nHours,nMinutes,nSeconds);
            ReadLine();

        }
        // Method to return number of hours taken from number of seconds.
        static int makeHours(int iSecs)
        {
            int hours = iSecs / 3600;
            return hours;
        }

        // Method to return number of minutes taken from number of seconds minus hours.
        static int makeMinutes(int iSeconds)
        {
            int minutes = (iSeconds % 3600) / 60;
            return minutes;
        }

        // Method to return number of seconds remaining after taking out hours and minutes.
        static int makeSeconds(int iSeconds)
        {
            int seconds = (iSeconds % 3600) % 60;
            return seconds;
        }

    }
}
