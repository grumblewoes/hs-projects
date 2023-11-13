using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*Anna Pomerantz
* 
*A pizza program that stores user's choice of crust type, toppings, and
*pizza size, and will display a receipt detailing the total price and choices
*after the "submit" button is pressed. If placing a second order, the "Reset"
*button will clear the receipt and price.
*
*9/28/18
*/
namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Total
        int total;

        //Crust type variables
        int stuffedCrust = 5;
        int sicilian = 5;
        int thinCrust = 5;

        //Toppings variables
        int pepperoni = 2;
        int sausage = 2;
        int olives = 3;
        int peppers = 2;
        int bacon = 3;
        int extraCheese = 2;
        int caviar = 3;
        int extraTomatoSauce = 2;
        int onions = 3;

        //Size variables
        int small = 9;
        int med = 12;
        int lrg = 15;

        //Crust options
        private void radioCrust1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrust1.Checked == true)
            {
                total += stuffedCrust;
            }
            else {
                total -= stuffedCrust;
            }
        }

        private void radioCrust2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrust2.Checked == true)
            {
                total += sicilian;
            }
            else
            {
                total -= sicilian;
            }
        }

        private void radioCrust3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrust3.Checked == true)
            {
                total += thinCrust;
            }
            else
            {
                total -= thinCrust;
            }
        }

        //Toppings options
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                total += pepperoni;
            }
            else
            {
                total -= pepperoni;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                total += sausage;
            }
            else
            {
                total -= sausage;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                total += olives;
            }
            else
            {
                total -= olives;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                total += peppers;
            }
            else
            {
                total -= peppers;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                total += bacon;
            }
            else
            {
                total -= bacon;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                total += extraCheese;
            }
            else
            {
                total -= extraCheese;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                total += caviar;
            }
            else
            {
                total -= caviar;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                total += extraTomatoSauce;
            }
            else
            {
                total -= extraTomatoSauce;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                total += onions;
            }
            else
            {
                total -= onions;
            }
        }

       
        //Size options
        private void radioSize1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSize1.Checked == true)
            {
                total += small;
            }
            else
            {
                total -= small;
            }
        }

        private void radioSize2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSize2.Checked == true)
            {
                total += med;
            }
            else
            {
                total -= med;
            }
        }

        private void radioSize3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSize3.Checked == true)
            {
                total += lrg;
            }
            else
            {
                total -= lrg;
            }
        }

        //Prints price after button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "$" + total.ToString() + ".00";
        //Prints crust type
            if (radioCrust1.Checked == true)
                {
                    order1Input.Text = "Stuffed Crust";
                }
            else if (radioCrust2.Checked == true)
                {
                    order1Input.Text = "Sicilian";
                }
            else if (radioCrust3.Checked == true)
                {
                    order1Input.Text = "Thin Crust";
                }
            else
                {
                    order1Input.Text = "N/A";
                }
            //Prints toppings
            if (checkBox1.Checked == true)
            {
                order2Input.Text += "Pepperoni\n";
            }
            if (checkBox2.Checked == true)
            {
                order2Input.Text += "Sausage\n";
            } 
            if (checkBox3.Checked == true)
            {
                order2Input.Text += "Olives\n";
            } 
            if (checkBox4.Checked == true)
            {
                order2Input.Text += "Peppers\n";
            }
            if (checkBox5.Checked == true)
            {
                order2Input.Text += "Bacon\n";
            }
            if (checkBox6.Checked == true)
            {
                order2Input.Text += "Extra Cheese\n";
            }
            if (checkBox7.Checked == true)
            {
                order2Input.Text += "Caviar\n";
            }
            if (checkBox8.Checked == true)
            {
                order2Input.Text += "Extra Tomato Sauce\n";
            }
            if (checkBox9.Checked == true)
            {
                order2Input.Text += "Onions\n";
            }
       //Prints size
            if (radioSize1.Checked == true)
            {
                order3Input.Text = "12\"";
            }
            else if (radioSize2.Checked == true)
            {
                order3Input.Text = "18\"";
            }
            else if (radioSize3.Checked == true)
            {
                order3Input.Text = "30\"";
            }
            else
            {
                order3Input.Text = "N/A";
            }

        }
       
        //Resets receipt and price after "Reset" is clicked
        private void reset_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            order1Input.Text = null;
            order2Input.Text = null;
            order3Input.Text = null;
        }

        

        

    }
}
