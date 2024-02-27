using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Prob8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // This was here cause originally I had the button calculate and show the results, but then I did a textchange actions and so I'm just using this button like a main method
            string user = userText.Text;
            countVowels(user);
            countConsonants(user);

        }

        private void countVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

                if (vowels.Contains(letter))
                {
                    count++;
                }
            }
            vowelCountLabel.Text = count.ToString();

        }

        private void countConsonants(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    if (!vowels.Contains(letter))
                    {
                        count++;
                    }
                }
            }

            consonantCountLabel.Text = count.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
