using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        double total = 0.0;

        //HHH
        //HHT
        //HTH
        //HTT
        //THH
        //THT
        //TTH
        //TTT

        int coin1, coin2, coin3, coinTotal = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            double[] flips = new double[4];
            total = 0;

            if (textBox1.Text != "")
            {
                double numTrials = double.Parse(textBox1.Text);

                //flip coin 3 times to get result
                for (int i = 0; i < numTrials; i++)
                {
                    coin1 = rand.Next(1, 3);
                    coin2 = rand.Next(1, 3);
                    coin3 = rand.Next(1, 3);
                    coinTotal = coin1 + coin2 + coin3;

                #region switch
                    switch (coinTotal)
                    { 
                        case 3:
                            flips[0]++;
                            break;

                        case 4:
                            flips[1]++;
                            break;

                        case 5:
                            flips[2]++;
                            break;

                        case 6:
                            flips[3]++;
                            break;
                    }
            #endregion    
                }
                //display total in text box
                for (int j = 0; j < 4; j++)
                    {
                        total += flips[j];
                    }

                label10.Text = String.Format("{0:0,0}", total).ToString();

                label16.Text = String.Format("{0:0,0}", flips[0]).ToString();
                label17.Text = String.Format("{0:0,0}", flips[1]).ToString();
                label18.Text = String.Format("{0:0,0}", flips[2]).ToString();
                label19.Text = String.Format("{0:0,0}", flips[3]).ToString();

                label36.Text = String.Format("{0:P1}.", flips[0] / numTrials).ToString();
                label35.Text = String.Format("{0:P1}.", flips[1] / numTrials).ToString();
                label34.Text = String.Format("{0:P1}.", flips[2] / numTrials).ToString();
                label33.Text = String.Format("{0:P1}.", flips[3] / numTrials).ToString();

                label44.Text = String.Format("{0:P1}.", (flips[0] / numTrials) - (1.0 / 8.0)).ToString();
                label43.Text = String.Format("{0:P1}.", (flips[1] / numTrials) - (3.0 / 8.0)).ToString();
                label42.Text = String.Format("{0:P1}.", (flips[2] / numTrials) - (3.0 / 8.0)).ToString();
                label41.Text = String.Format("{0:P1}.", (flips[3] / numTrials) - (1.0 / 8.0)).ToString();
            }
        }
    }
}
