/* CSIS 1175
 * Section #001
 * Prof: Priya
 *Student: Priscila Lio Crudi
 *ID: 300358805 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace PriscilaC_Assign2
{
    public partial class Form1 : Form
    {
        /*Create a new Class for the Main Program
         * Get/Set Properties from Class
         * Maintains a list of all Grocery objects added
         * Data, Data members and Data structure*/

        List<GroceryInformation> GroceryList = new List<GroceryInformation>();

        public Form1()
        {
            InitializeComponent();
        }



        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
            //Creating a Header Line for ListBox
            OutputListBox.Items.Add("ItemID\t\tItemName\t\tUnitPrice\t\tQtyMinForRestock\t\t" +
                "InitialQty\t\tQtySold\t\tQtyRestocked\t\tAvailability\t\tSales"); 
            foreach (GroceryInformation item in GroceryList)
            {
                OutputListBox.Items.Add(item);
            }
            try
            {
                using (StreamReader myInputStream = new StreamReader("superstore.csv"))
                {
                    string eachLine;
                    if (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        MessageBox.Show(eachLine);
                    }
                    while (!myInputStream.EndOfStream) 
                    {
                        eachLine= myInputStream.ReadLine();
                        string[] eachGroceryItems = eachLine.Split(',');
                        string itemCode = eachGroceryItems[0];
                        string itemName = eachGroceryItems[1];
                        string price = eachGroceryItems[2];
                        double.TryParse(price, out double unitPrice);
                        string restock = eachGroceryItems[3];
                        int.TryParse(restock, out int qtyMinForRestock);
                        string initial = eachGroceryItems[4];
                        int.TryParse(initial, out int initialQty);
                        string sold = eachGroceryItems[5];
                        int.TryParse(sold, out int qtySold);
                        string restocked = eachGroceryItems[6];
                        int.TryParse(restocked, out int qtyRestocked);
                        GroceryInformation eachItem1 = new GroceryInformation(itemCode, itemName, 
                                            unitPrice, qtyMinForRestock, initialQty, qtySold, qtyRestocked);
                        GroceryList.Add(eachItem1);
                        string availQty = eachGroceryItems[7];
                        int.TryParse(availQty, out int availability);
                        string finalsales = eachGroceryItems[8];
                        double.TryParse(finalsales, out double sales);
                        GroceryInformation eachItem2 = new GroceryInformation(availability, sales);
                        GroceryList.Add(eachItem2);

                    }
                }
                OutputStatusLabel.Text = "Loaded " + GroceryList.Count + " item from input file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Selecting one item from List Box
        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputListBox.SelectedIndex >= 0)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    OutputStatusLabel.Text = "You have selected the header";
                }
                else if (GroceryList.Count > 0)
                {
                    int lbIndex = OutputListBox.SelectedIndex;
                    QtySoldTextBox.Text = GroceryList[lbIndex - 1].QtySold.ToString();
                    QtyRestockedTextBox.Text = GroceryList[lbIndex - 1].QtyRestocked.ToString();
                }
            }
            
        }

        private void UpdateQtySoldButton_Click(object sender, EventArgs e)
        {
            //Error message for inputs
            if (OutputListBox.SelectedIndex <= 0)
            {
                OutputStatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else if (QtySoldTextBox.Text == "")
            {
                OutputStatusLabel.Text = "Please fill the Quantity Restocked field.";
            }
            else if (!int.TryParse(QtySoldTextBox.Text, out int QtySold) || QtySold <= 0)
            {
                OutputStatusLabel.Text = "Quantity sold must be grater than 0";
            }
            else if (GroceryList.Count > 0)
            {
                int lbIndex = OutputListBox.SelectedIndex;
                OutputListBox.Items[lbIndex] = GroceryList[lbIndex - 1].QtySold;
                OutputStatusLabel.Text = "Incremented Restocked Qty for the item with item code " + GroceryList[lbIndex].ItemCode;

            }
            /*if(QtySoldTextBox.Text == "")
            {
                OutputStatusLabel.Text= "Please selected a grocery item to increment sold qty";
            }
            else if (!int.TryParse(QtySoldTextBox.Text, out int QtySold) || QtySold <= 0)
            {
                OutputStatusLabel.Text = "Quantity sold must be grater than 0";
            }
            /*else if (!int.TryParse(QtySoldTextBox.Text, out int QtySold) || QtySold > Availability)
            {
                OutputStatusLabel.Text= "Quantity sold must be less than Availability in Stock";
            }
            else if
            {

                foreach(GroceryInformation item in GroceryList)
                {
                    item.QtySold = int.Parse(QtySoldTextBox.Text);
                    item.QtySold++;
                }
                else if (GroceryList.Count > 0)
                {
                    
            }*/
        }

        private void UpdateRestockedButton_Click(object sender, EventArgs e)
        {
            //Error message for inputs
            /*if (QtyRestockedTextBox.Text == "")
            {
                OutputStatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else if (!int.TryParse(QtyRestockedTextBox.Text, out int QtyRestocked) || QtyRestocked <= 0)
            {
                OutputStatusLabel.Text = "Quantity restocked must be grater than 0";
            }
            else
            {
                foreach (GroceryInformation item in GroceryList)
                {
                    item.QtyRestocked = int.Parse(QtyRestockedTextBox.Text);
                    item.QtyRestocked++;
                }
                OutputStatusLabel.Text = "Incremented Restocked Qty for the item with item code ABC"; //need to update ItemCode here
            }*/

            if (OutputListBox.SelectedIndex <= 0)
            {
                OutputStatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else if(QtyRestockedTextBox.Text == "")
            {
                OutputStatusLabel.Text = "Please fill the Quantity Restocked field.";
            }
            else if (!int.TryParse(QtyRestockedTextBox.Text, out int QtyRestocked) || QtyRestocked <= 0)
            {
                OutputStatusLabel.Text = "Quantity restocked must be grater than 0";
            }
            else if(GroceryList.Count > 0)
            {
                int lbIndex = OutputListBox.SelectedIndex;
                OutputListBox.Items[lbIndex] = GroceryList[lbIndex-1].QtyRestocked;
                OutputStatusLabel.Text = "Incremented Restocked Qty for the item with item code " + GroceryList[lbIndex].ItemCode;

            }

        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if(lbIndex <= 0)
            {
                OutputStatusLabel.Text = "Please selected a grocery item to delete.";

            }
            else if (GroceryList.Count > 0)
            {
                //Update Status Label
                OutputStatusLabel.Text = "Deleted item with item code " + GroceryList[lbIndex - 1].ItemCode;
                //Remove selected Item from List
                GroceryList.RemoveAt(lbIndex- 1);
                //Remove selected Item from ListBox
                OutputListBox.Items.RemoveAt(lbIndex);
                //Clear text fields
                ClearTextFields();
            }

        }

        private void SortItemButton_Click(object sender, EventArgs e)
        {
            List<GroceryInformation> SortedList = GroceryList.OrderBy(item => item.Sales).ToList();

            SortedList = GroceryList.OrderBy(item => item.Sales).ThenByDescending(item => item.Sales).ToList();


        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            WriteToFile("updatedgrocery.csv");
            OutputStatusLabel.Text = "Saved " + GroceryList.Count + " records into the output memory file.";
            GroceryList.Clear();

        }

        private void WriteToFile(string filename)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filename))
                {
                    string headerLine = "ItemCode,ItemName,InitialQty,QtyMinForRestock,QtySold,QtyRestocked,UnitPrice";
                    writer.WriteLine(headerLine);
                    foreach(GroceryInformation grocery in GroceryList)
                    {
                        writer.WriteLine(grocery.ItemCode + "," + 
                                        grocery.ItemName + "," +
                                        grocery.InitialQty + "," +
                                        grocery.QtyMinForRestock + "," +
                                        grocery.QtySold + "," +
                                        grocery.QtyRestocked + "," +
                                        grocery.UnitPrice.ToString("C"));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSalesButton_Click(object sender, EventArgs e)
        {
            List<GroceryInformation> SaveList = GroceryList.ToList();

            SaveList = (from item in GroceryList
                       where item.QtySold > 0
                       select item).ToList();
            WriteToFile("grocerysales.csv");
            OutputStatusLabel.Text = "Saved " + GroceryList.Count + " records into the output memory file.";
            GroceryList.Clear();
        }

        private void SaveRestockButton_Click(object sender, EventArgs e)
        {
            List<GroceryInformation> RestockedList = GroceryList.ToList();

            RestockedList = (from item in GroceryList
                             where item.AvailableQty < QtyMinForRestock
                             select item).ToList();
            WriteToFile("groceryrestocks.csv");
            OutputStatusLabel.Text = "Saved " + GroceryList.Count + " records into the output memory file.";
            GroceryList.Clear();
        }

        private void QtySoldLabel_Click(object sender, EventArgs e)
        {
            //Created accidentally
        }


        

        //Method to Clear Text Fields
        private void ClearTextFields()
        {
            QtySoldTextBox.Clear();
            QtyRestockedTextBox.Clear();
        }
    }
}
