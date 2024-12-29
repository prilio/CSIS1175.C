/* CSIS 1175
 * Section #001
 * Prof: Priya
 *Student: Priscila Lio Crudi
 *ID: 300358805 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaC_Assign2
{
    internal class GroceryInformation
    {
        /*Properties:
         * ItemCode, ItemName, QtyMinForRestock, InitialQty, QtySold, QtyRestocked
         * Computed read-only properties:
         * AvailableQty, TotalSales
         * ToString Method
         */

        //Properties
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public double QtySold { get; set; }
        
        public int InitialQty { get; set; }
        public int QtyRestocked { get; set; }

        public double[] Availability { get; set; }
        public double[] Sales { get; set; }

        //Constructor
        public GroceryInformation(string itemCode, string itemName, double unitPrice, int qtyMinForRestock,
                                    int qtySold, int initialQty, int qtyRestocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
            /*Availability = availability;
            Sales = sales;*/
        }

        public GroceryInformation(double[] availability, double[] sales)
        {
            Availability = availability;
            Sales = sales;
        }

        //Computed read-only properties
        public double AvailableQty(double[] availability)
        {
            //Initial quantity – Quantity Sold + Restocked Quantity
            double initQty = 0;
            double qtySold = 0;
            double qtyMinForRestock = 0;
            double availQty = 0;
            foreach (double value in availability)
            {
                initQty += value;
            }
            if (qtySold > 0)
            {
                availQty = initQty - qtySold + qtyMinForRestock;
            }
            return availQty;
            
        }

        public double TotalSales (double[] finalSales)
        {
                double sales = 0;
                double totalSales = 0;
                foreach(double value in finalSales)
                {
                    sales += value;
                }
                if(totalSales > 0)
                {
                    totalSales = UnitPrice*QtySold;
                }
                return totalSales;
            
        }

        //ToString Method

        public override string ToString()
        {
            string outputStr = ItemCode + "\t" +
                               ItemName + "\t" +
                               UnitPrice.ToString("C") + "\t" +
                               QtyMinForRestock + "\t" +
                               InitialQty + "\t" +
                               QtySold + "\t" +
                               QtyRestocked + "\t";

            for (int i=0; i < Availability.Length; i++)
            {
                outputStr += Availability[i];
            }
            outputStr += "\t";
            for (int i = 0; i < Sales.Length; i++)
            {
                outputStr += Sales[i].ToString("C");
            }
            outputStr += "\t";
            outputStr += AvailableQty(Availability) + "\t" + TotalSales(Sales).ToString("C");

            return outputStr;
        }



    }
}
