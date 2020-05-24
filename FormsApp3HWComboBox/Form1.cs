using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3HWComboBox
{
    public partial class Form1 : Form
    {
        
        List<string> lists = new List<string>
                {
                    "Automobil",
                    "Fruit",
                    "City",
                    "Student"
                };

        List<string> listsAuto = new List<string>()
        {
            "Toyota",
            "Madza",
            "Peugeot",
            "BMW"
        };
        List<string> listsFruit = new List<string>()
        {
            "Orange",
            "Kiwi",
            "Lemon",
            "Banana"
        };
        List<string> listsCity = new List<string>()
        {
            "Kiev",
            "Paris",
            "New York",
            "Brazzaville"
        };
        List<string> listsStudent = new List<string>()
        {
            "Junes",
            "Cardorel",
            "Yuri",
            "Nazar"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add list of ComboList when the form is loaded;
            comboBox1.Items.AddRange(lists.ToArray());

        }


        //*******************************************Add each list in ChecklistBox**********************************//
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Automobil")
            {
                //Clear if you have something
                checkedListBox1.Items.Clear();
                //Add the automobil just;
                checkedListBox1.Items.AddRange(listsAuto.ToArray());
            }
            else if (comboBox1.SelectedItem.ToString() == "Fruit")
            {
                //Clear anything before that to add something by selecting The fruit
                checkedListBox1.Items.Clear();
                //Add the fruit
                checkedListBox1.Items.AddRange(listsFruit.ToArray());
                //refresh
                checkedListBox1.Refresh();
            }
            else if (comboBox1.SelectedItem.ToString() == "City")
            {
                //Clear the precedent items if it's not City;
                checkedListBox1.Items.Clear();
                //Add the city
                checkedListBox1.Items.AddRange(listsCity.ToArray());
                //Refresh give some animation by clicking
                checkedListBox1.Refresh();
            }
            else if (comboBox1.SelectedItem.ToString() == "Student")
            {
                //Clear the precedent items if it's not Student;
                checkedListBox1.Items.Clear();
                //Add Students
                checkedListBox1.Items.AddRange(listsStudent.ToArray());
                //Refresh 
                checkedListBox1.Refresh();
            }
        }

        //********************************Add the item in the Each list****************************************//
        private void button1_Click(object sender, EventArgs e)
        {
          
            //Get the index by selecting if -1 it's meaning is not selected
            if (comboBox1.SelectedIndex != -1)
            {
                //Check if it's not Empty or it is the gap
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    //If the length of the text is less than 3.
                    if (textBox1.Text.Length >= 3)
                    {
                        AddInTheList();
                        textBox1.Text = "";
                        checkedListBox1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Be sure the length is more or equal Three (3)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TextBox is empty, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("select  the list combo please for the Adding", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //***************************************Created the simple function addList*******************************//
        private void AddInTheList()
        {
            //Check if the select item is automobil
            if (comboBox1.SelectedItem.ToString() == "Automobil")
            {
                //check if the user doesn't add the same value
                if (!checkedListBox1.Items.Contains(textBox1.Text))
                {
                    listsAuto.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("value always exists, try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Check if the select item is Fruit
            else if (comboBox1.SelectedItem.ToString() == "Fruit")
            {
                //check if the user doesn't add the same value
                if (!checkedListBox1.Items.Contains(textBox1.Text))
                {
                    listsFruit.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("value always exists, try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Check if the select item is City
            else if (comboBox1.SelectedItem.ToString() == "City")
            {
                //check if the user doesn't add the same value
                if (!checkedListBox1.Items.Contains(textBox1.Text))
                {
                    listsCity.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("value always exists, try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Check if the select item is student....
            else if (comboBox1.SelectedItem.ToString() == "Student")
            {
                //check if the user doesn't add the same value
                if (!checkedListBox1.Items.Contains(textBox1.Text))
                {
                    listsStudent.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("value always exists, try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        //****************************Sort the list on Clicking***************************************//

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Automobil")
            {
                //By default is false and we will put true is sort Button is clicked
                checkedListBox1.Sorted = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Fruit")
            {
                checkedListBox1.Sorted = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "City")
            {
                checkedListBox1.Sorted = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Student")
            {
                checkedListBox1.Sorted = true;
            }
        }




        //**************************************Copy the the checklistBox in the listBox1*************************;
        private void button3_Click(object sender, EventArgs e)
        {
            //check if user selected the combo list, if the index is -1, nothing will happen
            if(comboBox1.SelectedIndex != -1)
            {
                //check if user selected the checkListBox, if the index is -1, nothing will happen
                if (checkedListBox1.SelectedIndex != -1)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        //if the Thing exist we don't want to add it in the file
                        if(!checkedListBox1.CheckedItems.Contains(item))
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Any thing have not selected , please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("select the list combo please for the copying", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveInFile("listCombo.txt");
        }


        private void loadFile()
        {
            var path = "listCombo.txt";
            try
            {
                using (StreamReader myFile = new StreamReader(path))
                {
                    string lines;
                    while((lines = myFile.ReadLine()) != null)
                    {
                        //To allow the User to Load Once the same file
                        if(!listBox1.Items.Contains(lines))
                        {
                            listBox1.Items.Add(lines);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($@"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInFile(string path)
        {
            using (StreamWriter myFile = new StreamWriter(path))
            {
                if(listBox1.Items.Count != 0)
                {
                    foreach(var item in listBox1.Items)
                    {
                        myFile.WriteLine(item);
                    }
                }
                else
                {
                    MessageBox.Show("List box is Empty , please try to add again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadFile();
        }
    }
}
