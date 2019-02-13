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
		int[] insertSum;

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
			//Sätt in insert talet i lblSum
			lblSum.Text = "Sum up" + insert + "sums on the latest try";
			//Skapa en array där man sätter in det inmatade talets antal summor
			//räknat från starten av försöket.
			



			if (insert > 3 && insert < 25)
            {
				while (sum != insert)
				{

					for (int i = 0 ; sum != insert ; i++)
					{
						num1 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.1 = " + num1.ToString() + " \n");
						num2 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.2 = " + num2.ToString() + " \n");
						num3 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.3 = " + num3.ToString() + " \n");
						num4 = rnd.Next(1, 7);
						tbxDice.AppendText("Dice Roll Num.4 = " + num4.ToString() + " \n");
						sum = num1 + num2 + num3 + num4;
						tbxDice.AppendText("Summan =" + sum + " \n" + " \n");
						insertSum = new int[i];
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
            btnSum.Enabled = true;
        }

        public void btnSum_Click(object sender, EventArgs e)
        {
			//Summera det inmatade talets antal summor från start
			double entireSum = 0;
			for (int j = 0; j < insertSum.Length; j++) entireSum = entireSum + insertSum[j];
            btnRollDice.Enabled = true;
            tbxSum.Enabled = true;
			btnSum.Enabled = false;
        }
    }
}
    


