using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise3
{
    public partial class Form1 : Form
    {
        //class scope variable to store the player balance
        private int playerBalance = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //close application when exit button is clicked
            Application.Exit();
        }

        private void buttonTossCoins_Click(object sender, EventArgs e)
        {
            //declare variables
            int betAmount = 0;

            //check if amount textbox is empty
            if (string.IsNullOrEmpty(textBoxBet.Text))
            {
                //show an error message and return from the method
                MessageBox.Show("Please enter a bet amount.");
                return;
            }    

            //parse bet amount textbox value to an integer
            betAmount = int.Parse(textBoxBet.Text);

            //check if the player has sufficient balance to place the bet
            if (playerBalance>=betAmount)
            {
                //generate a random number (1 or 2) to represent the coin toss result
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 3);

                //check if the user has selected heads or tails
                if (!radioButtonHeads.Checked && !radioButtonTails.Checked)
                {
                    //show an error message if the user hasn't selected heads or tails
                    MessageBox.Show("Please select heads or tails.");
                }
                //check if the user won the bet
                if (randomNumber == 1 && radioButtonHeads.Checked || randomNumber == 2 && radioButtonTails.Checked)
                {
                    //show a message indicating that the user won the bet
                    MessageBox.Show("You won " + betAmount.ToString());

                    //update the player balance by adding the bet amount
                    playerBalance += betAmount;

                    //update the balance textbox with the new balance
                    textBoxBalance.Text = playerBalance.ToString();

                }

                else
                {
                    //show a message indicating that the user lost the bet
                    MessageBox.Show("You lost " + betAmount.ToString());

                    //update the player balance by subtracting the bet amount
                    playerBalance -= betAmount;

                    // Update the balance textbox with the new balance
                    textBoxBalance.Text = playerBalance.ToString();
                }

                // Clear the bet amount textbox and set focus to it
                textBoxBet.Text = "";
                textBoxBet.Focus();
                
             
            }
            else
            {
                //show an error message if the player doesn't have sufficient balance to place the bet
                MessageBox.Show("Insufficient balance to place bet");
            }
            
        }

        private void radioButtonHeads_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //set focus to the bet amount textbox when the form is shown
            textBoxBet.Focus();
            //set the balance textbox to read-only mode
            textBoxBalance.ReadOnly = true;
            //set the balance textbox value to the initial player balance
            textBoxBalance.Text = playerBalance.ToString();
        }
    }
}
