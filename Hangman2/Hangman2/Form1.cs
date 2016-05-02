using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Hangman2
{

    public partial class Form1 : Form
    {
        int guessNumber = 1; //Ökar med 1 för varje felgissing så att nästa bild visas.

        char guess; //char innehåller ETT tecken och här lagras den bokstav som du gissar på.

        string rightAnswer = null; //Här lagras rätt ord. Här försvinner bokstäver när du gissar rätt.

        string rightAnswer2 = null; //Här lagras också rätt ord men denna här försvinner inte bokstäver. Denna

        string strtmpAnsver = null;

        bool txtBoxUpdate;

        //variabel används när vi gissar på hela ordet 

        public Form1()
        {
            InitializeComponent();
        }

        string returnWordSwedish()
        {

            Random rnd1 = new Random();
            //Debug.Write( Directory.GetCurrentDirectory.Text);
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);

            string[] allLines = null;

            if (rbtnSwedish.Checked)
                {
                    allLines = File.ReadAllLines("Bibliotek\\swedish.txt");
                }
            else
                {
                    allLines = File.ReadAllLines("Bibliotek\\english.txt");
                };

            string rightWord = allLines[rnd1.Next(allLines.Length)];

            return rightWord;
        }

        private void CheckSymb ()
        {
            if (!(txtGuess.Text == ""))
            {

                guess = char.Parse(txtGuess.Text); //Här gör man sin gissning med en bokstav.
                txtBoxUpdate = false;
                txtGuess.Clear();
                
            }

            //För varje gissning som är fel så blir man mer hängd.

            //guessNumber ökar med ett för varje felgissning så att rätt bild laddas.

            if (!rightAnswer.Contains(guess) && guessNumber == 1)
               
                pictureBox1.Load("fel1.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 2)

                pictureBox1.Load("fel2.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 3)

                pictureBox1.Load("fel3.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 4)

                pictureBox1.Load("fel4.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 5)

                pictureBox1.Load("fel5.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 6)

                pictureBox1.Load("fel6.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 7)

                pictureBox1.Load("fel7.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 8)

                pictureBox1.Load("fel8.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 9)

            {

                pictureBox1.Load("fel9.gif");

                btnGissa.Enabled = false;

                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;

            }
            strtmpAnsver = lblShowLetters.Text;
            if (!rightAnswer.Contains(guess)) //Om gissningen INTE är rätt ökas guessNumber för nästa bild.

                guessNumber++;

            else if (rightAnswer.Contains(guess)) //Om gissningen ÄR rätt så minskas bokstäver att gissa på.

            {
                //strtmpAnsver = "";
                //lblShowLetters.Text = "";
                for (int n = 0; n < rightAnswer2.Length; n++)
                {
                    if (String.Equals(char.Parse(rightAnswer2.Substring(n, 1)), guess))
                    {
                        // lblShowLetters.Text += guess;
                        strtmpAnsver = strtmpAnsver.Substring(0, n) + guess + strtmpAnsver.Substring(n + 1, strtmpAnsver.Length - n - 1);
                    }
                    else
                    {
                        // strtmpAnsver += "_ ";
                    }
                };

                lblShowLetters.Text = strtmpAnsver.ToString();

                //Om ordet innehåller mer än en bokstav av samma sort, ser denna till att alla visas.

                while (rightAnswer.IndexOf(guess) != -1)

                {

                    //lblShowLetters.Text += guess.ToString();

                    int index = rightAnswer.IndexOf(guess); //Tar reda på indexet för bokstaven du gissade på


                    if (index != -1) //Om det inte är tomt på bokstäver

                    {

                        if (rightAnswer.Length == 1)

                            btnGissa.Enabled = false;

                        rightAnswer = rightAnswer.Remove(index, 1); //"Index" är numret för bokstaven, "1" är hur

                    } //många bokstäver som ska tas bort

                    else

                        btnGissa.Enabled = false;

                }//End of while 
            }
        }


        private void btnGissa_Click(object sender, EventArgs e)
        {
            CheckSymb();
            txtGuess.Focus();
            if(lblShowLetters.Text==rightAnswer2)
                pictureBox1.Load("smile.gif");

        }

        private void btnNyttOrd_Click(object sender, EventArgs e)
        {
            int n = 0;
            //Det rätta svaret lägg i en variabel för att minska för varje rätt bokstav.

            rightAnswer = returnWordSwedish(); //txtTheWord.Text;
            lblShowLetters.Text="";

            //Rätt svar läggs även i en variabel som INTE minskar. Denna variabel visas om man gissar rätt ord.

            rightAnswer2 = rightAnswer; //txtTheWord.Text;
            label1.Text= rightAnswer;

            txtTheWord.Clear();
            n = rightAnswer.Length;
            while (n>0)
            {
                lblShowLetters.Text += "_";
                n--;
            }
        }

        private void btnGissaHelaOrdet_Click(object sender, EventArgs e)
        {
            if (txtGuessTheWord.Text.Equals(rightAnswer2))
            {
                lblSlutResultat.Text = "Du gissade rätt ord: " + rightAnswer2;
                pictureBox1.Load("smile.gif");
            }
            
            else

            {
                pictureBox1.Load("fel5.gif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
           {
            //if (txtBoxUpdate)
              //  {
               
               // CheckSymb();
               
                
            //   };
        }

    }
}
