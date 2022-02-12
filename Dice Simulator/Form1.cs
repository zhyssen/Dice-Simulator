using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulator
{
    public partial class DiceSimulatorForm : Form
    {
        public DiceSimulatorForm()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            // Variable for the number equal to the die face.
            int die1;
            int die2;
            int total;

            // Create the random object
            Random rand = new Random();

            // Get a random number for each die
            die1 = rand.Next(1, 7);
            die2 = rand.Next(1, 7);
            
            // Switch statement to change the die1 pictureBox image
            // based on the random number generated.
            switch (die1)
            {
                case 1:
                    this.die1PictureBox.Load("dice1.png");
                    break;
                case 2:
                    this.die1PictureBox.Load("dice2.png");
                    break;
                case 3:
                    this.die1PictureBox.Load("dice3.png");
                    break;
                case 4:
                    this.die1PictureBox.Load("dice4.png");
                    break;
                case 5:
                    this.die1PictureBox.Load("dice5.png");
                    break;
                case 6:
                    this.die1PictureBox.Load("dice6.png");
                    break;
                    default:
                    break;
            }

            // Switch statement to change the die2 pictureBox image
            // based on the random number generated.
            switch (die2)
            {
                case 1:
                    this.die2PictureBox.Load("dice1.png");
                    break;
                case 2:
                    this.die2PictureBox.Load("dice2.png");
                    break;
                case 3:
                    this.die2PictureBox.Load("dice3.png");
                    break;
                case 4:
                    this.die2PictureBox.Load("dice4.png");
                    break;
                case 5:
                    this.die2PictureBox.Load("dice5.png");
                    break;
                case 6:
                    this.die2PictureBox.Load("dice6.png");
                    break;
                default:
                    break;
            }

            // Calculate the total of the dice
            total = die1 + die2;

            // Display the total of the dice in the totalLabel.
            totalLabel.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
