using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/*
1. employeeName = Joshua Montain
2. all values in decimal
3. Employee commission = 7% total sales
4. Employee taxFederal = 18%
5. Employee taxRetirement = 10%
6. Employee taxSocialSecutity = 6%
7. saleMonth = $ 161.432
8. Aligment the numbers, with comma separators, no dollar sign, 2 decimal positions
9. totalDeductions = $
10. finalTakeHome = $
11. Run
12. Change the value of sales to 1,3 million
13. Rerun
*/


namespace SalesEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            const decimal taxComission = 0.07M;
            const decimal taxFederal = 0.18M;
            const decimal taxRetirement = 0.10M;
            const decimal taxSocialSecurity = 0.06M;
            decimal salesMonth = 1300000;
            string employeeName = "Joshua Montain";
            
            decimal comission = taxComission * salesMonth;
            decimal federal = comission * taxFederal;
            decimal retirement = comission * taxRetirement;
            decimal socialSecurity = comission * taxSocialSecurity;
            decimal totalDeductions = federal + retirement + socialSecurity;
            decimal takeHomePay = comission - totalDeductions;

            WriteLine("Name of Employee:           {0,15}", employeeName);
            WriteLine("Total sales this mounth:    {0,15:C}", salesMonth);
            WriteLine("The comission tax is:       {0,15:C}", comission);
            WriteLine("The federal tax is:         {0,15:C}", federal);
            WriteLine("The retirement tax is:      {0,15:C}", retirement);
            WriteLine("The Social Security tax is: {0,15:C}", socialSecurity);
            WriteLine("Total deduction is:         {0,15:C}", totalDeductions);
            WriteLine("Final take home pay is:     {0,15:C}", takeHomePay);
            ReadLine();


        }
    }
}
