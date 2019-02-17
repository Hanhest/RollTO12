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
			lblSum.Text = "Sum up " + insert + "  sums from the beginning on the latest try";
			//Lägger in det användaren skrivit i arrayen.
			insertSum = new int[insert];

			//Skapar en if sats för att loopen inte ska hålla på i all evighet. Det är omöjligt att 
			//tärningarna får summorna under antalet tärningar och över 6 * (antal tärningar).
			if (insert > 3 && insert < 25)
            {
				//En for loop där räknaren används i sync med den nydeklareradeInt:en (i) för att lägga
				//in summor i rätt antal element. Det förklaras hur det funkar mer utförligt längre ner.
				for (int i = 0 ; sum != insert ; i++)
				{
					//Det utvecklas vidare med en if sats som inte går längre än att arrayen blir full.
					if (i < insertSum.Length)
					{
						//Det läggs in ett random nummer frånt 1 till 7 och till och med 6 vilket
						//simulerar en tärning.
						num1 = rnd.Next(1, 7);
						//Det som är inom parentesen skrivs ut i tbx dice.
						tbxDice.AppendText("Dice Roll Num.1 = " + num1.ToString() + " \n");
						//Det händer samma sak som med num1 fast i num2.
						num2 = rnd.Next(1, 7);
						//Det händer samma sak som med num1 fast med num2.
						tbxDice.AppendText("Dice Roll Num.2 = " + num2.ToString() + " \n");
						//Det händer samma sak som med num1 fast i num3.
						num3 = rnd.Next(1, 7);
						//Det händer samma sak som med num1 fast med num3.
						tbxDice.AppendText("Dice Roll Num.3 = " + num3.ToString() + " \n");
						//Det händer samma sak som med num1 fast i num4.
						num4 = rnd.Next(1, 7);
						//Det händer samma sak som med num1 fast med num4.
						tbxDice.AppendText("Dice Roll Num.4 = " + num4.ToString() + " \n");
						//Här summeras alla tärningsslag.
						sum = num1 + num2 + num3 + num4;
						//Det som är inom parentesen skrivs ut i tbx dice.
						tbxDice.AppendText("Summan =" + sum + " \n");
						//Varje gång loopen går läggs den nya summan in i arrayen, med hälp av loopen
						//så ökas variabeln (i) med 1 varje gång och därmed ökas även array indexen.
						insertSum[i] = sum;
						//Antal försök ökas med 1 varje gång.
						tries++;
					}
					//När arrayen är full utförs else satsen som innehåller i princip
					//samma sak exlsive arrayen.
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
						tbxDice.AppendText("Sum =" + sum + " \n" + " \n");
						tries++;
					}
				}
				//När for loopens villkor uppfyllts tas antalet försök och skrivs ut i tbxDice.
				tbxDice.AppendText("Tries = " + tries);
				//btnRollDice görs oklickbar.
				btnRollDice.Enabled = false;
				//tbxSum görs oskrivbar.
				tbxSum.Enabled = false;
				//btnSum görs klickbar.
				btnSum.Enabled = true;
			}

            else
            {
				//Om användaren skrivit en summa utanför intervallen skrivs det som finns innanför
				//parentesen i tbxDice.
                tbxDice.AppendText("Thats Tha Wrong Numba \n");
			}
        }

		//Clickevent till btnSum.
        public void btnSum_Click(object sender, EventArgs e)
        {
			//Deklarerar där alla de inmatade talets antal summor från arrayen ska summeras upp.
			double entireSum = 0;
			//En for loop används för att ta ut innehållet av arrayen och summera det. Eftersom indexen
			//till en array börjar från 0 så måste även (j) börja på 0 och klättra till numret precis
			//under arrayens längd.
			for (int j = 0; j < insertSum.Length; j++) entireSum = entireSum + insertSum[j];
			//När användaren tryckt på knappen går det åter igen att skriva i tbxSum.
			tbxSum.Enabled = true;
			//När användaren tryckt på knappen går det åter igen att trycka på btnRollDice.
			btnRollDice.Enabled = true;
			//När användaren tryckt på knappen går det inte längre att trycka på btnSum.
			btnSum.Enabled = false;
			//Sedan skrivs summan ut i lblAll.
			lblAll.Text = "" + entireSum;
        }
    }
}
    


