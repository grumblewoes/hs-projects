using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Probability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Random rand = new Random();
            int roll1, roll2, rolltotal = 0;
            double total = 0.0;

            private void button1_Click(object sender, EventArgs e)
            {
                double[] diceRolls = new double[11];
                total = 0;

                if (textBox1.Text != "")
                {
                    double numTrials = double.Parse(textBox1.Text);

                    //generate 2 rolls and get total
                    for (int i = 0; i < numTrials; i++)
                    {
                        roll1 = rand.Next(1, 7);
                        roll2 = rand.Next(1, 7);
                        rolltotal = roll1 + roll2;
                    //determine what was rolled to tally individ. counts
                        switch (rolltotal)
                        { 
                            case 2:
                                diceRolls[0]++;
                                break;

                            case 3:
                                diceRolls[1]++;
                                break;

                            case 4:
                                diceRolls[2]++;
                                break;

                            case 5:
                                diceRolls[3]++;
                                break;

                            case 6:
                                diceRolls[4]++;
                                break;

                            case 7:
                                diceRolls[5]++;
                                break;

                            case 8:
                                diceRolls[6]++;
                                break;

                            case 9:
                                diceRolls[7]++;
                                break;

                            case 10:
                                diceRolls[8]++;
                                break;

                            case 11:
                                diceRolls[9]++;
                                break;

                            case 12:
                                diceRolls[10]++;
                                break;
                        }
                    }

                    for (int j = 0; j < 11; j++)
                    {
                        total += diceRolls[j];
                    }

                    label57.Text = String.Format("{0:0,0}", total).ToString();

                    label23.Text = String.Format("{0:0,0}", diceRolls[0]).ToString();
                    label22.Text = String.Format("{0:0,0}", diceRolls[1]).ToString();
                    label21.Text = String.Format("{0:0,0}", diceRolls[2]).ToString();
                    label20.Text = String.Format("{0:0,0}", diceRolls[3]).ToString();
                    label19.Text = String.Format("{0:0,0}", diceRolls[4]).ToString();
                    label18.Text = String.Format("{0:0,0}", diceRolls[5]).ToString();
                    label17.Text = String.Format("{0:0,0}", diceRolls[6]).ToString();
                    label16.Text = String.Format("{0:0,0}", diceRolls[7]).ToString();
                    label15.Text = String.Format("{0:0,0}", diceRolls[8]).ToString();
                    label14.Text = String.Format("{0:0,0}", diceRolls[9]).ToString();
                    label13.Text = String.Format("{0:0,0}", diceRolls[10]).ToString();

                    label34.Text = String.Format("{0:P3}.", diceRolls[0] / numTrials).ToString();
                    label33.Text = String.Format("{0:P3}.", diceRolls[1] / numTrials).ToString();
                    label32.Text = String.Format("{0:P3}.", diceRolls[2] / numTrials).ToString();
                    label31.Text = String.Format("{0:P3}.", diceRolls[3] / numTrials).ToString();
                    label30.Text = String.Format("{0:P3}.", diceRolls[4] / numTrials).ToString();
                    label29.Text = String.Format("{0:P3}.", diceRolls[5] / numTrials).ToString();
                    label28.Text = String.Format("{0:P3}.", diceRolls[6] / numTrials).ToString();
                    label27.Text = String.Format("{0:P3}.", diceRolls[7] / numTrials).ToString();
                    label26.Text = String.Format("{0:P3}.", diceRolls[8] / numTrials).ToString();
                    label25.Text = String.Format("{0:P3}.", diceRolls[9] / numTrials).ToString();
                    label24.Text = String.Format("{0:P3}.", diceRolls[10] / numTrials).ToString();

                    label45.Text = String.Format("{0:P3}.", (diceRolls[0] / numTrials) - (1.0 / 36.0)).ToString();
                    label44.Text = String.Format("{0:P3}.", (diceRolls[1] / numTrials) - (1.0 / 36.0)).ToString();
                    label43.Text = String.Format("{0:P3}.", (diceRolls[2] / numTrials) - (1.0 / 36.0)).ToString();
                    label42.Text = String.Format("{0:P3}.", (diceRolls[3] / numTrials) - (1.0 / 36.0)).ToString();
                    label41.Text = String.Format("{0:P3}.", (diceRolls[4] / numTrials) - (1.0 / 36.0)).ToString();
                    label40.Text = String.Format("{0:P3}.", (diceRolls[5] / numTrials) - (1.0 / 36.0)).ToString();
                    label39.Text = String.Format("{0:P3}.", (diceRolls[6] / numTrials) - (1.0 / 36.0)).ToString();
                    label38.Text = String.Format("{0:P3}.", (diceRolls[7] / numTrials) - (1.0 / 36.0)).ToString();
                    label37.Text = String.Format("{0:P3}.", (diceRolls[8] / numTrials) - (1.0 / 36.0)).ToString();
                    label36.Text = String.Format("{0:P3}.", (diceRolls[9] / numTrials) - (1.0 / 36.0)).ToString();
                    label35.Text = String.Format("{0:P3}.", (diceRolls[10] / numTrials) - (1.0 / 36.0)).ToString();






                }
            }
    }
}
