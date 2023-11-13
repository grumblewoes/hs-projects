using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
//class calculator
            /*  //operation variables
            double firstNumber;
            double secondNumber;
            bool result = false;
            int operation;
            */
            Calculator myCalc = new Calculator(); //calls on the constructor

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (myCalc.Result) //call the instance (ex. textBox)
            {
                textBox1.Text = "";
                textBox1.Text += "1";
                //result = false;
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (myCalc.Result) //short notation for if (result == true)
            {
                textBox1.Text = "";
                textBox1.Text += "2";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "3";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "4";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "5";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "6";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "7";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "8";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "9";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (myCalc.Result)
            {
                textBox1.Text = "";
                textBox1.Text += "0";
                myCalc.Result = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //plus
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != ".")
            {
                myCalc.FirstNumber = double.Parse(textBox1.Text);
                myCalc.Operation = 1;
                textBox1.Text = "";
            }
        }

        //minus
        private void buttonMin_Click(object sender, EventArgs e)
            {
                myCalc.FirstNumber = double.Parse(textBox1.Text);
                myCalc.Operation = 2;
                textBox1.Text = "";
            }

        //equals
        private void buttonEq_Click(object sender, EventArgs e)
        {
            myCalc.SecondNumber = double.Parse(textBox1.Text);
            
            if (myCalc.Operation == 1) //plus
            {
                //textBox1.Text = (firstNumber + secondNumber).ToString();
                textBox1.Text = myCalc.Addition().ToString(); //methods have ();
            }
            else if (myCalc.Operation == 2) //minus
            {
                //textBox1.Text = (firstNumber - secondNumber).ToString();
                textBox1.Text = myCalc.Subtraction().ToString();
            }
            else if (myCalc.Operation == 3) //divide
            {
                if (myCalc.SecondNumber == 0)
                {
                    textBox1.Text = "Error: Division by 0";
                    //MessageBox.Show("Error: Division by Zero");
                }
                else
                {
                    textBox1.Text = myCalc.Division().ToString();
                }
            }
            else if (myCalc.Operation == 4) //multiply
            {
                textBox1.Text = myCalc.Multiplication().ToString();
            }
            else if (myCalc.Operation == 5) //exponent; calling math class
            {
                textBox1.Text = myCalc.Exponent().ToString();
            }

            myCalc.Result = true;
        }

        //decimal
        private void buttonDec_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        //divide
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            myCalc.FirstNumber = double.Parse(textBox1.Text);
            myCalc.Operation = 3;
            textBox1.Text = "";
        }

        //multiply
        private void buttonMult_Click(object sender, EventArgs e)
        {
            myCalc.FirstNumber = double.Parse(textBox1.Text);
            myCalc.Operation = 4;
            textBox1.Text = "";
        }

        //positive/negative
        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * double.Parse(textBox1.Text)).ToString();
        }

        //exponent
        private void buttonExp_Click(object sender, EventArgs e)
        {
            myCalc.FirstNumber = double.Parse(textBox1.Text);
            myCalc.Operation = 5;
            textBox1.Text = "";
        }

        //clear all
        private void button1_Click(object sender, EventArgs e)
        {
            myCalc.FirstNumber = 0;
            myCalc.SecondNumber = 0;
            myCalc.Operation = 0;
            myCalc.Result = false;
            textBox1.Text = "";
        }

        
        

        







    }
}
