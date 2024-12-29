/* CSIS 1175 - DOUGLAS COLLEGE
 * Section #001 - FALL 2022
 * Prof: Priya
 * Student: Priscila Lio Crudi
 * ID: 300358805 */

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
using System.Diagnostics;

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

        //Creating UpdateListDisplay Method
        //Will clean and rebuild the OutputListBox when it has updates.
        private void UpdateListDisplay()
        {
            OutputListBox.Items.Clear();

            //Setting the number of characters for each ListBox Item/Column
            //Using PadRigth method to fix the formating on the list box
            OutputListBox.Items.Add("ItemID".PadRight(15) + "ItemName".PadRight(25) + "UnitPrice".PadRight(15) + "QtyMinForRestock".PadRight(20) +
                "InitialQty".PadRight(15) + "QtySold".PadRight(15) + "QtyRestocked".PadRight(15) + "Availability".PadRight(15) + "Sales".PadRight(15));
            
            foreach (GroceryInformation item in GroceryList)
            {
                OutputListBox.Items.Add(item);
            }
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            //Creating the Grocery List
            try
            {
                //Load the CSV file from Default folder
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
                        GroceryInformation eachItem = new GroceryInformation(itemCode, itemName, 
                                            unitPrice, qtyMinForRestock, initialQty, qtySold, qtyRestocked);
                        GroceryList.Add(eachItem);


                    }
                }
                //Call UpdateListDisplay Method

                UpdateListDisplay();
                
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

                    OutputStatusLabel.Text = "You have selected item: " + GroceryList[lbIndex - 1].ItemCode.ToString() + 
                                            " - " + GroceryList[lbIndex - 1].ItemName.ToString();
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
                OutputStatusLabel.Text = "Quantity sold must be a number grater than 0";
            }
            else if (GroceryList.Count > 0)
            {
                int lbIndex = OutputListBox.SelectedIndex;
                int.TryParse(QtySoldTextBox.Text, out int amountSold);
                GroceryList[lbIndex-1].QtySold += amountSold;
                OutputStatusLabel.Text = "Incremented Qty Sold for the item with item code " + GroceryList[lbIndex-1].ItemCode;
            }

            //Call method
            UpdateListDisplay();
            ClearTextFields();
        }

        private void UpdateRestockedButton_Click(object sender, EventArgs e)
        {
            //Error message for inputs
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
                OutputStatusLabel.Text = "Quantity restocked must be a number grater than 0";
            }
            else if(GroceryList.Count > 0)
            {
                int lbIndex = OutputListBox.SelectedIndex;
                int.TryParse(QtyRestockedTextBox.Text, out int amountRestocked);
                //OutputListBox.Items[lbIndex] = GroceryList[lbIndex-1].QtyRestocked;
                GroceryList[lbIndex - 1].QtyRestocked += amountRestocked;
                OutputStatusLabel.Text = "Incremented Restocked Qty for the item with item code " + GroceryList[lbIndex].ItemCode;

            }
            //Call method
            UpdateListDisplay();
            ClearTextFields();
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
            // Sort the list box by descending
            SortedList = GroceryList.OrderByDescending(item => item.Sales).ToList();
            
            OutputListBox.Items.Clear();
            //Using PadRigth method to fix the formating on the list box
            OutputListBox.Items.Add("ItemID".PadRight(15) + "ItemName".PadRight(25) + "UnitPrice".PadRight(15) + "QtyMinForRestock".PadRight(20) +
                "InitialQty".PadRight(15) + "QtySold".PadRight(15) + "QtyRestocked".PadRight(15) + "Availability".PadRight(15) + "Sales".PadRight(15));
            foreach (GroceryInformation item in SortedList)
            {
                OutputListBox.Items.Add(item);
            }
        }

        //Method to Write CSV files for the 3 buttons
        private void WriteToFile(string filename)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filename))
                {
                    if (filename == "updatedgrocery.csv")
                    {
                        //Creating a List for all updates made by user and a new Header to be used in a new file
                        string headerLine = "ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked";
                        writer.WriteLine(headerLine);
                        foreach (GroceryInformation grocery in GroceryList)
                        {
                            writer.WriteLine(grocery.ItemCode + "," +
                                            grocery.ItemName + "," +
                                            grocery.UnitPrice + "," +
                                            grocery.QtyMinForRestock + "," +
                                            grocery.InitialQty + "," +
                                            grocery.QtySold + "," +
                                            grocery.QtyRestocked);
                        }
                        //Update the Status Label
                        OutputStatusLabel.Text = "Saved " + GroceryList.Count + " records into the output memory file.";
                    }
                    else if (filename == "grocerysales.csv")
                    {
                        //Creating a List for Sales items and a new Header to be used in a new file
                        List<GroceryInformation> SalesList = GroceryList.ToList();
                        SalesList = (from item in GroceryList
                                    orderby item.Sales
                                    where item.QtySold > 0
                                    select item).ToList();

                        string headerLine = "ItemCode,ItemName,UnitPrice,QtySold,Sales";
                        writer.WriteLine(headerLine);
                        foreach (GroceryInformation grocery in SalesList)
                        {
                            writer.WriteLine(grocery.ItemCode + "," +
                                            grocery.ItemName + "," +
                                            grocery.UnitPrice + "," +
                                            grocery.QtySold + "," +
                                            grocery.Sales);
                        }
                        //Update the Status Label
                        OutputStatusLabel.Text = "Saved " + SalesList.Count + " records into the output memory file.";

                    }
                    else if (filename == "groceryrestocks.csv")
                    {
                        //Creating a List for Restock items and a new Header to be used in a new file
                        List<GroceryInformation> RestockedList = GroceryList.ToList();

                        RestockedList = (from item in GroceryList
                                         where item.Availability < item.QtyMinForRestock
                                         select item).ToList();
                        string headerLine = "ItemCode,ItemName,Availability,QtyMinForRestock";
                        writer.WriteLine(headerLine);
                        foreach (GroceryInformation grocery in RestockedList)
                        {
                            writer.WriteLine(grocery.ItemCode + "," +
                                            grocery.ItemName + "," +
                                            grocery.Availability + "," +
                                            grocery.QtyMinForRestock);
                        }
                        //Update the Status Label
                        OutputStatusLabel.Text = "Saved " + RestockedList.Count + " records into the output memory file.";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            //Call method WriteToFile and write a new file with updates made by user
            WriteToFile("updatedgrocery.csv");
        }

        private void SaveSalesButton_Click(object sender, EventArgs e)
        {
            //Call method WriteToFile and write a new file with sales made by user
            WriteToFile("grocerysales.csv");
        }

        private void SaveRestockButton_Click(object sender, EventArgs e)
        {
            //Call method WriteToFile and write a new file with items need to restock
            WriteToFile("groceryrestocks.csv");
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
