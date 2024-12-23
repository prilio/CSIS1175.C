/* VaryingArguments.cs      Author:  Doyle
 * This example demonstrates the use of the params 
 * keyword. A varying number of arguments can be sent
 * to a method. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VaryingArguments
{
    class VaryingArguments
    {
        static void Main(string[] args)
        {
            DisplayItems(1, 2, 3, 5);

            int[] anArray = new int[5] { 100, 200, 300, 400, 500 };

            DisplayItems(anArray);
            DisplayItems(1500, anArray[1] * anArray[2]);

            int[] nums = { 1, 2, 3, 4, 5 };

            int i = 1;
            foreach (int num in nums)
            {
                WriteLine("num[{0}]={1}",i,num);
                i++;
            }
            alterVariable(nums);
            foreach (int num in nums)
            {
                WriteLine("num[{0}]={1}", i, num);
                i++;
            }
            Console.ReadKey();
        }

        public static void DisplayItems(params int[] item) //DOES NOT mean item is an int[]
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.Write(item[i] + "\t");
            }
            Console.WriteLine();
        }
        public static void alterVariable(int[] nums)
        { 
            for(int i=0;i<nums.Length;i++)
            {
                nums[i] = nums[i] + 5;
            }
          
        }
        public static void alterVarialbe(int num)
        { }
    }
}
