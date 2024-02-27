using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob6._9
{
    public partial class Form1 : Form
    {
        private string computerChoice;
        public Form1()
        {
            InitializeComponent();
            computerChoiceLabel.Visible = false;
            resultLabel.Visible = false;
            computerChoice = generateComputerChoice();
        }

        private string generateComputerChoice()
        {   
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            string computerChoice;
            if (randomNumber == 1)
            {
                computerChoice = "rock";
            }
            else if (randomNumber == 2)
            {
                computerChoice = "paper";
            }
            else
            {
                computerChoice = "scissors";
            }
            return computerChoice;
        }

        private string chooseWinner(string userInput, string computerChoice)
        {
            if (userInput == "rock" && computerChoice == "scissors" || userInput == "paper" && computerChoice == "rock" || userInput == "scissors" && computerChoice == "paper")
            {
                return "Player won!";
            } 
            else if (userInput == computerChoice)
            {
                return "Tie!";
            }
            else
            {
                return "Computer won!";
            }
        }
        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            playGame("rock");
        }
        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            playGame("paper");
        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            playGame("scissors");
        }

        private void playGame(string userInput)
        {
            computerChoice = generateComputerChoice();
            computerChoiceLabel.Text = "Computer chose: " + computerChoice;
            computerChoiceLabel.Visible = true;
            resultLabel.Visible = true;
            resultLabel.Text = chooseWinner(userInput, computerChoice);
        }
    }
}
