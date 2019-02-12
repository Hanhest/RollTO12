using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTo12
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        Random rnd = new Random();
        int[] all;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void btnRollDice_Click(object sender, EventArgs e)
        {

            tbxDice.Clear();
            int sum = 0;
            int insert = int.Parse(tbxSum.Text);
			int tries = 1;

            if (insert > 3 && insert < 25)
            {
				while (sum != insert)
				{

					all = new int[tries];
					for (int i = 0 ; sum != insert ; i++)
					{
						int num1 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.1 = " + num1.ToString() + " \n");
						int num2 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.2 = " + num2.ToString() + " \n");
						int num3 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.3 = " + num3.ToString() + " \n");
						int num4 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.4 = " + num4.ToString() + " \n");
						sum = num1 + num2 + num3 + num4;
						tbxDice.AppendText("Summan =" + sum + " \n" + " \n");
						tries++;
					}
				}
				tbxDice.AppendText("Försök = " + tries + " \n" + " \n");
			}

            else
            {
                tbxDice.AppendText("Thats Tha Wrong Numba \n");
            }
            btnRollDice.Enabled = false;
            tbxSum.Enabled = false;
            btnAll.Enabled = true;
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {

        }

        private void lblDiceRoll_Click(object sender, EventArgs e)
        {

        }

        public void btnAll_Click(object sender, EventArgs e)
        {

			lblAll.Text = "" + all[0]; 
            btnRollDice.Enabled = true;
            tbxSum.Enabled = true;
        }
    }
}
    


