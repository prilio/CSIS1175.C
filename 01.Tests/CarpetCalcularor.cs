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
            int roomLenghtFeet = 12;
            int roomLenghtInches = 2;
            int roomWidthFeet = 14;
            int roomWidthInches = 7;
            const int sqFTsqYARD = 9;
            const int inchFoot = 12;
            double roomLenght;
            double roomWidth;
            const string bestCarpet = "Berber";
            const string economyCarpet = "Pile";
            
            roomLenght = roomLenghtFeet + (double) roomLenghtInches / inchFoot;
            roomWidth = roomWidthFeet + (double) roomWidthInches / inchFoot;
            double numofSQFT = roomLenght * roomWidth;
            double numofSQYD = numofSQFT / sqFTsqYARD;

            double carpetPrice = 27.95;
            double totalCost = numofSQYD * carpetPrice;
            WriteLine("Total cost of {0} is {1:C}", bestCarpet, totalCost);

            carpetPrice = 15.95;
            totalCost = numofSQYD * carpetPrice;
            WriteLine("Total cosf of {0} is {1:C}", economyCarpet, totalCost);
            ReadLine();
            
        }
    }    


    }
}
