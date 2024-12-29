/* CSIS 1175 - DOUGLAS COLLEGE
 * Section #001 - FALL 2022
 * Prof: Priya
 * Student: Priscila Lio Crudi
 * ID: 300358805 */

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
        public string ItemCode { get; }
        public string ItemName { get; }
        public double UnitPrice { get; }
        public int QtyMinForRestock { get; }
        public int InitialQty { get; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }
        
        //public int Availability { get; }
        //public double Sales { get; }

        //Constructors
        public GroceryInformation(string itemCode, string itemName, double unitPrice, int qtyMinForRestock,
                                    int initialQty, int qtySold, int qtyRestocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
        }

        /*public GroceryInformation(int availability, double sales)
        {
            Availability = availability;
            Sales = sales;
        }*/


        //Computed read-only properties
        public double Availability
        {
            //Initial quantity – Quantity Sold + Restocked Quantity
            get
            {
                return (InitialQty - QtySold + QtyRestocked);
            }
        }

        public double Sales
        {
            get
                {
                    return (UnitPrice * QtySold);
                }
            
        }

        //ToString Method
        public override string ToString()
        {
            //Setting the number of characters for each ListBox Item/Column
            //Setting "C" for currency data
            string outputStr = ItemCode.PadRight(15) +
                               ItemName.PadRight(25) +
                               UnitPrice.ToString("C").PadRight(15) +
                               QtyMinForRestock.ToString().PadRight(20) +
                               InitialQty.ToString().PadRight(15) +
                               QtySold.ToString().PadRight(15) +
                               QtyRestocked.ToString().PadRight(15) +
                               Availability.ToString().PadRight(15) +
                               Sales.ToString("C").PadRight(15);
            return outputStr;
        }



    }
}
