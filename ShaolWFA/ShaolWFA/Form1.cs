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

namespace ShaolWFA
{
    public partial class Form1 : Form
    {
        List<Shoal> ShoalList = new List<Shoal>(); //maintains a list of all shoal objects added so far, called field property of the form
        //This demo is based on problem given in textbook in page 888 Chapter 13
        //Shoal Water Depth Application
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //if you accidentally create a method like this, leave it alone.
            //if you need to remove it, it needs to be removed in the Designer code and here.
            //better to leave it alone for now
            //changing the name of a control after you create handler will not rename the event handler
            //for this reason, you must always create the control, change its name to the appropriate name,
            //before create the event handler for this control
        }

        private void AddShoalButton_Click(object sender, EventArgs e)
        {
            //MessageBox just for testing button click
            //MessageBox.Show("You clicked " +
            //    "on the add shoal button");

            //When this button is clicked, values from the textboxes are used, parsed if numeric, and 
            //used to create one shoal object, then that object is added to the list of shoal objects (ShoalList)


            //Create Shoal Object and add it to a list of shoals (ShoalList)
            AddItem();

            //Load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class.
            LoadToListBox();

            //Clear TextBox Fields. Note that we do not want to clear the textbox text property unil the item is added to the list
            ClearFields();

            statusLabel.Text = "Added shoal object to the list and output list box";

        }

        private void AddItem()
        {
            //This method gets all values from TextBoxes, converts numeric values into numbers from string
            //got from Text property, create a shoal object, and then add it to the list

            //you can add several else if for validation if you like
            if (locationTextBox.Text == "" || stateTextBox.Text == ""
                || mileMarkerTextBox.Text == "")
            {
                MessageBox.Show("Please enter location, state and mile marker");
            } else
            {
                double mileMarker;
                double[] lowTides = new double[4];
                double[] highTides = new double[4];
                double.TryParse(mileMarkerTextBox.Text, out mileMarker);
                double.TryParse(lowTidesTB1.Text, out lowTides[0]);
                double.TryParse(lowTidesTB2.Text, out lowTides[1]);
                double.TryParse(lowTidesTB3.Text, out lowTides[2]);
                double.TryParse(lowTidesTB4.Text, out lowTides[3]);

                //do the same for high tides
                double.TryParse(highTidesTB1.Text, out highTides[0]);
                double.TryParse(highTidesTB2.Text, out highTides[1]);
                double.TryParse(highTidesTB3.Text, out highTides[2]);
                double.TryParse(highTidesTB4.Text, out highTides[3]);

                string location = locationTextBox.Text;
                string state = stateTextBox.Text;

                Shoal eachShoal = new Shoal(location, state,
                                        mileMarker, lowTides, highTides);
                ShoalList.Add(eachShoal);
            }
            
        }

        private void LoadToListBox()
        {
            //clear listbox and then load all shoal objects 
            //from shoal list to list box 

            //After clearing output list box, load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class, and then add the string to the listbox
            //Make sure you understand the purpose of listbox and list of shoal objects, and the difference between
            //ShoalList and outputListBox here. outputListBox is just for viewing the data
            //ShoalList is the actual data

            outputListBox.Items.Clear(); //first clear previous items from listbox
            string headerStr = "Location\tState\tMileMarker....add rest of fields"; //creating header string, does not add it to the listbox
            outputListBox.Items.Add(headerStr); //this is what adds header line to the listbox

            foreach (Shoal shoualObj in ShoalList)
            {
                outputListBox.Items.Add(shoualObj); //because is ToString() is defined in the Shoal class
            }

        }

        private void ClearFields()
        {
            //all textboxes are rest to empty strings
            locationTextBox.Text = ""; //resets the location textbox to empty
            stateTextBox.Text = "";
            mileMarkerTextBox.Text = "";
            lowTidesTB1.Text = "";
            lowTidesTB2.Text = "";
            lowTidesTB3.Text = "";
            lowTidesTB4.Text = "";
            highTidesTB1.Text = "";
            highTidesTB2.Text = "";
            highTidesTB3.Text = "";
            highTidesTB4.Text = "";
        }





        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = outputListBox.SelectedIndex; //value will be -1 if nothing selected

            //Load Item into Textboxes. This way whatever item is selected can be easily updated in the listbox when 
            //update button is clicked

            LoadItem(index-1); //ith item in listbox corresponds to (i-1)th item in the list
        }
        private void LoadItem(int index)
        {
            //index - data index not listbox index
            if (index >= 0 && ShoalList.Count > 0)
            {
                locationTextBox.Text = ShoalList[index].Location;
                stateTextBox.Text = ShoalList[index].State;
                mileMarkerTextBox.Text = ShoalList[index].MileMarker.ToString("F1");
                lowTidesTB1.Text = ShoalList[index].DepthLowTides[0].ToString("F1");
                lowTidesTB2.Text = ShoalList[index].DepthLowTides[1].ToString("F1");
                lowTidesTB3.Text = ShoalList[index].DepthLowTides[2].ToString("F1");
                lowTidesTB4.Text = ShoalList[index].DepthLowTides[3].ToString("F1");
                highTidesTB1.Text = ShoalList[index].DepthHighTides[0].ToString("F1");
                highTidesTB2.Text = ShoalList[index].DepthHighTides[1].ToString("F1");
                highTidesTB3.Text = ShoalList[index].DepthHighTides[2].ToString("F1");
                highTidesTB4.Text = ShoalList[index].DepthHighTides[3].ToString("F1");

            } else
            {
                ClearFields();
            }
        }

        

        private void updateSelectedItemButton_Click(object sender, EventArgs e)
        {
            UpdateItem(); //updates selected item in the list (not list box)

            LoadToListBox(); //loads the list to listbox

            statusLabel.Text = "Updated the selected item in the list and loaded list into output listbox";
        }

        private void UpdateItem()
        {
            //PRACTICE EXERCISE
            //get the selected index from listbox
            //find the data index (lbIndex - 1)
            //then update data for that object from TextBoxes
            int listIndex = outputListBox.SelectedIndex - 1;
            if (listIndex < 0)
            {
                MessageBox.Show("Please select a shoal item to update");
            }
            else if (locationTextBox.Text == ""
                || stateTextBox.Text == ""
                || mileMarkerTextBox.Text == "")
            {
                    MessageBox.Show("Location, state and mile marker must be entered!");
            }
            else if (ShoalList.Count > 0)
            {
                    //get data from TextBoxes
                    //Parse needed data
                    //Update the selected item in the List
                    //Update selected item in the ListBox
            }
        }

        private void BtnReadFromFile_Click(object sender, EventArgs e)
        {
            //Read from file method using file name
            ReadFromFile("ShoalInputFile.csv");
            //load to listbox
            LoadToListBox();

            statusLabel.Text = "Read " + ShoalList.Count() + " records from input file";
        }

        private void ReadFromFile(string fileName)
        {
            ShoalList = new List<Shoal>();
            try
            {
                using(StreamReader reader = new StreamReader(fileName))
                {
                    string eachLine;
                    if (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }
                    while (!reader.EndOfStream)
                    {
                        eachLine = reader.ReadLine();
                        string[] fieldsArray = eachLine.Split(',');
                        string location = fieldsArray[0];
                        string state = fieldsArray[1];
                        double.TryParse(fieldsArray[2], out double mileMarker);
                        string lowTidesStr = fieldsArray[3];
                        string highTidesStr = fieldsArray[4];

                        double[] lowTides = new double[4];
                        double[] highTides = new double[4];
                        //e.g., lowTidesStrArray = {"15.6","6.7","7.6",9.5"}

                        string[] lowTidesStrArray = lowTidesStr.Split('-');
                        for(int i = 0; i < lowTidesStrArray.Length; i++)
                        {
                            double.TryParse(lowTidesStrArray[i], out lowTides[i]);
                        }

                        string[] highTidesStrArray = highTidesStr.Split('-');
                        for (int i = 0; i < highTidesStrArray.Length; i++)
                        {
                            double.TryParse(highTidesStrArray[i], out highTides[i]);
                        }

                        Shoal eachShoal = new Shoal(location, state, 
                                                mileMarker, lowTides, highTides);
                        ShoalList.Add(eachShoal);

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            WriteToFile("ShoalOutput.csv");
            stateLabel.Text = "Written " + ShoalList.Count + " entries to text";
            ShoalList.Clear();
            outputListBox.Items.Clear();
        }
        private void WriteToFile(string fileName)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(fileName))
                {
                    string headerLine = "Location,State,MileMarker,LowTideAvg,HighTideAvg";
                    writer.WriteLine(headerLine);
                    foreach(Shoal shoal in ShoalList)
                    {
                        writer.WriteLine(shoal.Location + "," +
                                        shoal.State + "," +
                                        shoal.MileMarker.ToString("F1") + "," +
                                        shoal.LowTideAvg.ToString("F1") + "," +
                                        shoal.HighTideAvg.ToString("F1"));
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidentally created when form was double clicked
            //will talk about this in the online session
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            // PRACTICE EXERCISE
            //Display in the FilteredListBox
            //only those records where State of the object == California && HighTideAvg > 75
            //Note: you need to use LINQ command to select those records

            //and then convert it to list, and load that list into the FilteredListBox

            //Then update statusLabel.Text 
        }
    }
}
