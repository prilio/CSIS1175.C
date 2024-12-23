using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int anInt = 10;
            
            
            double aDouble = 10.5;
            aDouble = anInt;

            //byte aByte = (byte)anInt * 1000;
            byte aByte = (byte) (anInt*1000);
            
            char aChar = (char) 97;
            
            //uint anUint = -789;
            //uint anUint = (uint)(789 - 800);
            uint anUint = (uint)(889-800);
            
            long aLong = 12345L;
            //anInt = aLong;

            short aShort = 256;
            anInt = aShort;

            anInt = aChar; 
            aDouble = anInt^1;
           // anInt = aDouble;
            WriteLine("An int is " + anInt);

           
            WriteLine("A double is " + aDouble);

            WriteLine("A char is " + aChar);
            WriteLine("A byte is " + aByte);
            WriteLine("An uint is " + anUint);
            WriteLine("A long is {0,10:F4}" , aLong);
            ReadKey();
        }
    }
}
