/*Dear Prof. Pryia:
I really tried to format the output with String.Format and the Override concept, however I did not know or understand if what I did is it right.
I know how I should to do the asterikLine, the character count, right or left wrapping, and even how to place values ​​in 
decimal places or currency.
Such as-> {0, 20}: {0, -22:C}
Please, if you can, review this part on class or with extra material on Blackboard just to clear my mind.
I also would like you to know about my code, I am learning for the first time in my life about programming and 
I am thinking challenge and funny!
Regards,
Priscila Lio Crudi.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace PriscilaC_Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create the objects of PhotoPrint
            PhotoPrint photoPrintObj1 = new PhotoPrint("4X6", 1.25);
            PhotoPrint photoPrintObj2 = new PhotoPrint("5X7", 2.99);
            PhotoPrint photoPrintObj3 = new PhotoPrint("8X11", 6.99);

            //Call the Introduction Method
            DisplayIntroduction(photoPrintObj1, photoPrintObj2, photoPrintObj3);

            //Call the SetNumPrints Method
            SetNumPrints(photoPrintObj1);
            SetNumPrints(photoPrintObj2);
            SetNumPrints(photoPrintObj3);


            WriteLine("The number of prints for each print size has been entered.");
            WriteLine();
            WriteLine();

            //call method ChooseAction
            ChooseAction(photoPrintObj1, photoPrintObj2, photoPrintObj3);


        }
        //I created this method for display the first information about the project.
        static void DisplayIntroduction(PhotoPrint photoPrintObj1, PhotoPrint photoPrintObj2, PhotoPrint photoPrintObj3)
        {
            WriteLine("Welcome to Photo Print Service!");
            WriteLine("You can place orders for three different print sizes!");
            WriteLine();
            WriteLine("The print sizes we have in stock are: ");
            WriteLine("{0} width print unit price {1:C}", photoPrintObj1.SizeName, photoPrintObj1.PrintUnitPrice);
            WriteLine("{0} width print unit price {1:C}", photoPrintObj2.SizeName, photoPrintObj2.PrintUnitPrice);
            WriteLine("{0} width print unit price {1:C}", photoPrintObj3.SizeName, photoPrintObj3.PrintUnitPrice);
            WriteLine();
            WriteLine();
            WriteLine("Let us begin by entering the number of prints for each of these print sizes");

        }

        /*I changed the name Update for Set in this Method, 
         * because is more sense for me while I was doing/learning */
        static void SetNumPrints(PhotoPrint anyPrint)
        {
            Write("Enter the number of prints for {0}: ", anyPrint.SizeName);
            int quantity = int.Parse(ReadLine());
            anyPrint.NumPrints = quantity;
        }

        static void UpdateNumPrints(PhotoPrint anyPrint)
        {
            Write("Enter the new quantity for {0}: ", anyPrint.SizeName);
            int quantity = int.Parse(ReadLine());
            anyPrint.NumPrints = quantity;
        }

        static void ChooseAction(PhotoPrint PrintSize1, PhotoPrint PrintSize2, PhotoPrint PrintSize3)
        {
            WriteLine();
            WriteLine("What would you like to do?");
            Write("Press 1 for View Cart  |  Press 2 for Update Cart  |  Press 3 for quitting the application: ");
            int option = int.Parse(ReadLine());
            WriteLine();

            if (option == 1)
            {
                WriteLine("Your Photo Cart ");
                //display banner cart
                //call method ViewOrder
                ViewOrder(PrintSize1, PrintSize2, PrintSize3);
            }
            else if (option == 2)
            {
                WriteLine("Updating your Photo Cart ");
                //display the update 
                //call method UpdateOrder
                UpdateOrder(PrintSize1, PrintSize2, PrintSize3);
            }
            else if (option == 3)
            {
                WriteLine("Thank you for ordering the photo prints. Good Bye! ");
            }
            else
            {
                WriteLine("Available options can only 1, 2 or 3.");
            }
        }


        static void ViewOrder(PhotoPrint PrintSize1, PhotoPrint PrintSize2, PhotoPrint PrintSize3)
        {
            //Call method
            //Display all the details inside a banner + formating

            //First formatting trying
            //string asterikLine = new string('*', 64);
            //WriteLine(asterikLine);
            //WriteLine(PrintSize1);
            //WriteLine(PrintSize2);
            //WriteLine(PrintSize3);
            //GetOrderTotalsSummary(PrintSize1, PrintSize2, PrintSize3, out double totalBeforeDiscount, out double discountAmount, out double totalAfterDiscount);
            //WriteLine("*{0,62}", "*");
            //WriteLine("*      Total before discount: {0}                            *", totalBeforeDiscount.ToString("C"));
            //WriteLine("*                   Discount: {0}                             *", discountAmount.ToString("C"));
            //WriteLine("*       Total after discount: {0}                            *", totalAfterDiscount.ToString("C"));
            //WriteLine(asterikLine);

            //Second formatting trying

            //call method
            string asterikLine = new string('*', 64);
            string blankLine = String.Format("*{0,63}", '*');
            WriteLine(asterikLine);
            WriteLine(blankLine);
            WriteLine(PrintSize1);
            WriteLine(blankLine);
            WriteLine(PrintSize2);
            WriteLine(blankLine);
            WriteLine(PrintSize3);
            GetOrderTotalsSummary(PrintSize1, PrintSize2, PrintSize3, out double totalBeforeDiscount, 
                out double discountAmount, out double totalAfterDiscount);
            WriteLine(blankLine);
            WriteLine("*{0,36}: {1,-24:C}*", "Total before discount", totalBeforeDiscount);
            WriteLine("*{0,36}: {1,-24:C}*", "Discount", discountAmount);
            WriteLine("*{0,36}: {1,-24:C}*", "Total after discount", totalAfterDiscount);
            WriteLine(blankLine);
            WriteLine(asterikLine);


            //call method ChooseAction again
            ChooseAction(PrintSize1, PrintSize2, PrintSize3);


        }

        static double GetOrderTotalsSummary(PhotoPrint PrintSize1, PhotoPrint PrintSize2, PhotoPrint PrintSize3, out double totalBeforeDiscount,
                                            out double discountAmount, out double totalAfterDiscount)
        {
            totalBeforeDiscount = PrintSize1.PrintTotal + PrintSize2.PrintTotal + PrintSize3.PrintTotal;
            discountAmount = 0;
            if (totalBeforeDiscount > 50.00)
            {
                discountAmount = (totalBeforeDiscount / 10);
                totalAfterDiscount = totalBeforeDiscount - discountAmount;
            }
            else
            {
                totalAfterDiscount = totalBeforeDiscount;
            }
            return totalAfterDiscount;
        }

        static void UpdateOrder(PhotoPrint PrintSize1, PhotoPrint PrintSize2, PhotoPrint PrintSize3)
        {
            WriteLine();
            WriteLine("Press 1 for update the number of prints for {0}", PrintSize1.SizeName);
            WriteLine("Press 2 for update the number of prints for {0}", PrintSize2.SizeName);
            WriteLine("Press 3 for update the number of prints for {0}", PrintSize3.SizeName);
            Write("Enter the number (1, 2, 3): ");
            int option = int.Parse(ReadLine());

            if (option == 1)
            {
                //Write("Enter the new quantity for {0}: ", PrintSize1.SizeName);
                //int size1 = int.Parse(ReadLine());
                //update NumPrints Size1
                UpdateNumPrints(PrintSize1);
                WriteLine("Great! Quantity for {0} has been updated to {1}", PrintSize1.SizeName, PrintSize1.NumPrints);
            }
            else if (option == 2)
            {
                //Write("Enter the new quantity for {0}: ", PrintSize2.SizeName);
                //int size2 = int.Parse(ReadLine());
                //update NumPrints Size2
                UpdateNumPrints(PrintSize2);
                WriteLine("Great! Quantity for {0} has been updated to {1}", PrintSize2.SizeName, PrintSize2.NumPrints);
            }
            else if (option == 3)
            {
                //Write("Enter the new quantity for {0}: ", PrintSize3.SizeName);
                //int size3 = int.Parse(ReadLine());
                //update NumPrints Size3
                UpdateNumPrints(PrintSize3);
                WriteLine("Great! Quantity for {0} has been updated to {1}", PrintSize3.SizeName, PrintSize3.NumPrints);
            }
            else
            {
                WriteLine("Available options can only 1, 2 or 3.");
            }

            WriteLine();
            WriteLine();
            ChooseAction(PrintSize1, PrintSize2, PrintSize3);
        }



    }

}
