using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //needed for file operations

namespace UserInfoApp
{
    public partial class Form1 : Form
    {
        //form field members
        //form data, form data members
        //form data structure
        List<UserInfo> UserList = new List<UserInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidentally created by double clicking form
            //DO NOT DELETE
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World\nMy name is Priya");
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("User Name must be entered");
            } else if (UserIdTextBox.Text == "")
            {
                MessageBox.Show("User Id cannot be empty");
            } else if (UserAgeTextBox.Text == "")
            {
                MessageBox.Show("User Age cannot be empty");
            } else if (!int.TryParse(UserAgeTextBox.Text, out int UserAge) 
                            || UserAge <= 0)
            {
                MessageBox.Show("Age must be whole number > 0");
            } else
            {
               // MessageBox.Show("Yay! valid input");
                //Create UserInfo object
                UserInfo eachUser = new UserInfo(UserNameTextBox.Text,
                                                 UserIdTextBox.Text, UserAge);


                OutputListBox.Items.Clear();
                OutputListBox.Items.Add("User Name:" + eachUser.UserName);
                OutputListBox.Items.Add("User Id: " + eachUser.UserId);
                OutputListBox.Items.Add("User Age: " + eachUser.UserAge.ToString("F1"));

                //Add user info object to list of objects
                UserList.Add(eachUser);

                //update status label
                //\t - not recognized in a label, tab is recognized in listbox
                //\n - is recognized in a label, \n not recognized in listbox
                StatusLabel.Text = "Added user: " + eachUser.ToString();
                StatusLabel.Text += "\nTotal Users: " + UserList.Count;

                //display all objects from list into listbox
                LoadAllUsersToListBox();

                //reset text fields
                ClearTextFields();
            }

        }

        private void ClearTextFields()
        {
            UserNameTextBox.Text = "";
            UserIdTextBox.Text = "";
            UserAgeTextBox.Text = "";
            UserAgeTextBox.Clear(); //another way to reset the text box

        }
        private void LoadAllUsersToListBox()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("UserId\tUserName\tUserAge"); //header line added to the listbox
            foreach(UserInfo user in UserList)
            {
                OutputListBox.Items.Add(user);
            }
        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputListBox.SelectedIndex >= 0)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    StatusLabel.Text = "You have selected header";
                    ClearTextFields();
                }
                else if (UserList.Count > 0) //at least one user is added to the data structure
                {
                    int lbIndex = OutputListBox.SelectedIndex;
                    UserNameTextBox.Text = UserList[lbIndex - 1].UserName;
                    UserIdTextBox.Text = UserList[lbIndex - 1].UserId;
                    UserAgeTextBox.Text = UserList[lbIndex - 1].UserAge.ToString();
                }
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            //leave the method alone
            //DO NOT delete (because this method is being called in the Designer code)
            //empty method body means no consequence to this method
        }

        private void UpdateSelectedUserBtn_Click(object sender, EventArgs e)
        {
            if (OutputListBox.SelectedIndex <= 0)
            {
                StatusLabel.Text = "Please select data to update";
            } else if (UserNameTextBox.Text == "" || UserIdTextBox.Text == "" 
                        || UserAgeTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            } else if (!int.TryParse(UserAgeTextBox.Text, out int UserAge) 
                            || UserAge <= 0)
            {
                MessageBox.Show("Age must be whole number > 0");
            } else if (UserList.Count > 0)
            {
                UserInfo user = 
                    new UserInfo(UserNameTextBox.Text, UserIdTextBox.Text, UserAge);
                //update data from text box into the UserList and listbox
                int lbIndex = OutputListBox.SelectedIndex;
                UserList[lbIndex - 1] = user; //updates the data in the list
                OutputListBox.Items[lbIndex] = UserList[lbIndex - 1]; //updates the item in the listbox
                StatusLabel.Text = "Updated data for " + UserList[lbIndex - 1].UserName;
            }
        }

        private void Sub10FromSelUserBtn_Click(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                StatusLabel.Text = "Please select data to update age";
            } else if (UserList.Count > 0)
            {
                if (UserList[lbIndex - 1].UserAge <= 10)
                {
                    StatusLabel.Text = "Age must be > 10 to subtract 10";
                } else
                {
                    UserList[lbIndex - 1].UserAge -= 10; //updates the data
                    OutputListBox.Items[lbIndex] = UserList[lbIndex - 1];
                    StatusLabel.Text = "Subtracted 10 years from " 
                                            + UserList[lbIndex - 1].UserName;
                }
            }
        }

        private void Add10ToEachUserBtn_Click(object sender, EventArgs e)
        {
            foreach(UserInfo user in UserList)
            {
                user.UserAge += 10;
            }
            LoadAllUsersToListBox();
        }

        private void WriteToFileBtn_Click(object sender, EventArgs e)
        {
            //need using System.IO at the top
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("users.csv"))
                {
                    // myOutputStream.WriteLine("Hello World");
                    string headerLine = "UserId,UserName,UserAge";
                    myOutputStream.WriteLine(headerLine);
                    foreach(UserInfo eachUser in UserList)
                    {
                        //myOutputStream.Write(eachUser);
                        myOutputStream.WriteLine(eachUser.UserId + "," + eachUser.UserName
                                            + "," + eachUser.UserAge);
                    }
                } //at the end of using block, file stream is closed automatically
                StatusLabel.Text = "Written " + UserList.Count + " Users to file";
                UserList.Clear();
                OutputListBox.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSelUserBtn_Click(object sender, EventArgs e)
        {
            int lbIndex = OutputListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                StatusLabel.Text = "Please select data to delete";
            } else if (UserList.Count > 0)
            {
                //update status label
                StatusLabel.Text = "Deleted data for " 
                                        + UserList[lbIndex - 1].UserName;
                //remove selected data from list
                UserList.RemoveAt(lbIndex - 1);

                //remove selected item from listbox
                OutputListBox.Items.RemoveAt(lbIndex);

                //clear text fields
                ClearTextFields();
            }
        }

        private void ReadFromFileBtn_Click(object sender, EventArgs e)
        {
            //clear existing UserList
            UserList.Clear();
            //using System.IO - already added
            try
            {
                using (StreamReader myInputStream 
                                = new StreamReader("userinfo.csv"))
                {
                    string eachLine;
                    if (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine(); //reads the first line
                        MessageBox.Show(eachLine);
                    }
                    while (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        string[] eachUserFields = eachLine.Split(',');
                        string userId = eachUserFields[0];
                        string userName = eachUserFields[1];
                        string ageStr = eachUserFields[2];
                        int.TryParse(ageStr, out int userAge);
                        UserInfo eachUser = new UserInfo(userName, userId, userAge);
                        UserList.Add(eachUser);
                    }
                }
                LoadAllUsersToListBox();
                StatusLabel.Text = "Loaded " + UserList.Count + " users from the file";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortUsersByAgeBtn_Click(object sender, EventArgs e)
        {
            List<UserInfo> SortedList = UserList.OrderBy(user => user.UserAge).ToList();

            SortedList = UserList.OrderBy(user => user.UserAge)
                                .ThenByDescending(user => user.UserName).ToList();

            UserList = SortedList;
            LoadAllUsersToListBox();
        }
    }
}
