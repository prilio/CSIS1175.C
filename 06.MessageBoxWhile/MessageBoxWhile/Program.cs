using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string  toDisplay = "\tn\tsquared\n";
            int     index = 1;

            //while(index<=10)
            //{
            //    toDisplay = toDisplay + "\t" + index + "\t" + Math.Pow(index, 2)+"\n";
            //    index++;
            //}

            //for loop
            //for(;index<=10;index++)
            //{
            //    toDisplay = toDisplay + "\t" + index + "\t" + Math.Pow(index, 2) + "\n";
            //}

            //for loop lcv changes within loop body
            for (; ; )
            {
                toDisplay = toDisplay + "\t" + index + "\t" + Math.Pow(index, 2) + "\n";
                index++;
                if (index > 10)
                    break;
            }
            MessageBox.Show(toDisplay);
            //MessageBox.Show(toDisplay,"TEST",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }
    }
}
