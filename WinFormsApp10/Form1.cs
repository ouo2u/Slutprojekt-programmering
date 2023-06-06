using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
       private int secretNumber;
        public Form1()
        {
            InitializeComponent();
            cmbMaxNumber.Items.AddRange(new object[] { "10", "20", "50", "100" });
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            int maxNumber = Convert.ToInt32(cmbMaxNumber.SelectedItem);
            Random random = new Random();
            secretNumber = random.Next(0, maxNumber + 1);
            lblResult.Text = "Gissa på ett tal mellan 0 och " + maxNumber + ".";
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guessedNumber;
            bool isNumber = Int32.TryParse(txtGuess.Text, out guessedNumber);

            if (isNumber)
            {
                if (guessedNumber == secretNumber)
                {
                    lblResult.Text = "Grattis! Du gissade rätt.";
                    txtGuess.Enabled = false;
                    btnGuess.Enabled = false;
                }
                else if (guessedNumber < secretNumber)
                {
                    lblResult.Text = "Fel! Gissa högre.";
                }
                else
                {
                    lblResult.Text = "Fel! Gissa lägre.";
                }
            }
            else
            {
                lblResult.Text = "Felaktig inmatning. Ange ett heltal.";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaxNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int maxNumber = Convert.ToInt32(cmbMaxNumber.SelectedItem);
            Random random = new Random();
            secretNumber = random.Next(0, maxNumber + 1);
            lblResult.Text = "Gissa på ett tal mellan 0 och " + maxNumber + ".";
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
        }

        private void datortal_TextChanged_1(object sender, EventArgs e)
        {

            string s;
            s = secretNumber.ToString();
            datortal.Text = s;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       
      

      
    }
}
