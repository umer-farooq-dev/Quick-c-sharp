using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("C");

            listBox1.Items.Add("C++");

            listBox1.Items.Add("Java");

            listBox1.Items.Add("C#");

            listBox1.Items.Add("Database");

            listBox1.Items.Add("Networking");

            listBox1.Items.Add("Operating System");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //ii) When user click btnRight, if there is an item selected (otherwise give Message to user that no item is selected) in LstLeft, it would move from LstLeft to LstRight.
            if (listBox1.SelectedIndex == -1) 

                MessageBox.Show("Please select the item to move");

            else

            {

                while (listBox1.SelectedItems.Count > 0) 

                {

                    string itemList1 = (string)listBox1.SelectedItems[0];

                    listBox2.Items.Add(itemList1);

                    listBox1.Items.Remove(itemList1);

                }

            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            //iii) When user click btnRightAll, if there are one or more items are selected in LstLeft, all will be moved from LstLeft to LstRight.
            while (listBox1.SelectedItems.Count > 0) 

                {

                    string itemList1 = (string)listBox1.SelectedItems[0];

                    listBox2.Items.Add(itemList1);

                    listBox1.Items.Remove(itemList1);

                }

            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //iv) When User click btnClear, write a code that will empty/clear both lists.
         

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
        }
    

