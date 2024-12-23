using System;
using static System.Console;

namespace TestWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int lcv = 0;
            while(lcv<=10)
            {
                result = result + lcv;
                WriteLine("lcv is " + lcv);
                lcv++;
            }
            WriteLine("The summation is " + result);


            WriteLine("Now let's start another test");
            bool test = true;
            string inputValue;
            while(test)
            {
                WriteLine("Please input true or false:");
                inputValue = ReadLine();
                test = bool.Parse(inputValue);
                WriteLine("Your input is :"+test);

            }
        }
    }
}
