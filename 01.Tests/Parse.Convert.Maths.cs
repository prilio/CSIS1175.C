using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
 /*
 double.Parse("string number")
 int.Parse ("string number")
 char.Parse ("string number")
 bool.Parse ("string number")
 */
 
 /*
 Convert.ToDouble()
 Convert.ToDecimal()
 Convert.ToInt32()
 Convert.ToBoolean()
 Convert.ToChar()
 */

namespace Learning_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            //string aValue;
            Write("Enter your age: ");
            age = int.Parse(ReadLine());
            //age = int.Parse(aValue);
            WriteLine("Your age next year will be {0}.", ++age);
            WriteLine(" ");

            string inputStringValue;
            double aValue, result;

            Write("Enter a value to be squared: ");
            //inputStringValue = ReadLine();
            //aValue = double.Parse(inputStringValue);
            aValue = double.Parse(ReadLine());
            result = Math.Pow(aValue, 5);
            WriteLine("{0} squared is {1}", aValue, result);
       
			WriteLine(" ");
			
			double aValue = 78.926;
            double result1;
            double result2;

            result1 = Math.Floor(aValue);
            result2 = Math.Sqrt(aValue);

            WriteLine("aValue rounded to 2 decimal places is {0}", Math.Round(aValue, 2));


            int aValue1 = 200;
            int aValue2 = 896;
            int result;
            result = Math.Max(aValue1, aValue2);
            result += aValue2 * Math.Max(aValue1, aValue2)-aValue1;
            WriteLine("Largest value between {0} and {1} is {2}.", aValue1, aValue2, Math.Max(aValue1, aValue2));
            
            ReadLine();
        }
    }    


    
}
