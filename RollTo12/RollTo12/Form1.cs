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
		//Deklarerar 4 st tärningar
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
		//Deklarerar en random
        Random rnd = new Random();
		//Deklarerar en array för att samla de inmatade talets antal summor
		//från det att loopen börjat.
		int[] insertSum;

		//Denna kommer när man skapar Form1
		public Form1()
        {
            InitializeComponent();
        }

		//Click event till btnRollDice
        public void btnRollDice_Click(object sender, EventArgs e)
        {
			//Tar bort allt som finns i tbxDice när man klickar på knappen.
            tbxDice.Clear();
			//Deklarerar där summan av kasten med de fyra tärningarna sparas.
            int sum = 0;
			//Hämtar det användaren skrivit i tbxSum.
            int insert = int.Parse(tbxSum.Text);
			//Deklarerar där antalet försök ska sparas.
			int tries = 0;
			//Printa ut en text i lblSum för att veta antalet summor som ska summeras.
			lblSum.Text = "Sum up " + insert + "  sums on the latest try";
			//Lägger in det användaren skrivit i arrayen.
			insertSum = new int[insert];

			//Skapar en if sats för att loopen inte ska hålla på i all evighet.
			if (insert > 3 && insert < 25)
            {
				//En for loop där räknaren används i sync med den ny deklarerade
				//Int:en (i) för att lägga in summor i rätt antal element.
				for (int i = 0 ; sum != insert ; i++)
				{
					//Det utvecklas vidare genom att inte gå längre än att arrayen blir full
					if (i < insertSum.Length)
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
						insertSum[i] = sum;
						tries++;
					}
					//När arrayen är full utförs else satsen som innehåller i princip
					//samma sak exlsive arrayen
					else
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
			lblAll.Text = "" + entireSum;
        }
    }
}
    


