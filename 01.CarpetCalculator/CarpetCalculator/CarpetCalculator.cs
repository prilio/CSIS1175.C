﻿/* CarpetCalculator.cs	Author:	Doyle	
 * Calculates the total cost of carpet, given
 * room dimension in feet and inches and carpet
 * price in price per square yard.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class CarpetCalculator
    {
        static void Main(string[] args)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            int roomLengthFeet = 12,
                roomLengthInches = 2,
                roomWidthFeet = 14,
                roomWidthInches = 7;

            double roomLength,
                    roomWidth,
                    carpetPrice,
                    numOfSquareFeet,
                    numOfSquareYards,
                    totalCost;

            roomLength = roomLengthFeet +
                (double)roomLengthInches / INCHES_PER_FOOT;
            roomWidth = roomWidthFeet +
                 (double)roomWidthInches / INCHES_PER_FOOT;
            numOfSquareFeet = roomLength * roomWidth;
            numOfSquareYards = numOfSquareFeet / SQ_FT_PER_SQ_YARD;
            carpetPrice = 27.95;
            totalCost = numOfSquareYards * carpetPrice;
            Console.Out.WriteLine("The cost of " + BEST_CARPET
                + " is {0:C}", totalCost);
            Console.Out.WriteLine();
            carpetPrice = 15.95;
            totalCost = numOfSquareYards * carpetPrice;
            Console.Out.WriteLine("The cost of " + ECONOMY_CARPET
                + " is " + "{0:C}", totalCost);
            Console.ReadKey();
        }
    }
}
