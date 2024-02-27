using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob7._10
{
    public partial class Form1 : Form
    {
        private double amountInserted = 0;
        private double amountWon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You used {amountInserted:C} and won {amountWon:C}.");
            this.Close();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {

            double inserted;
            if (double.TryParse(txtAmountInserted.Text, out inserted))
            {
                if(inserted <= 0)
                {
                    MessageBox.Show("Invalid amount inserted.");
                    return;
                }
                amountInserted += inserted;
            }
            else
            {
                MessageBox.Show("Invalid amount inserted.");
                return;
            }

            Random rand = new Random();
            int img1 = rand.Next(0, 10);
            int img2 = rand.Next(0, 10);
            int img3 = rand.Next(0, 10);

            this.pbxImage1.Image = imgPictures.Images[img1];
            this.pbxImage2.Image = imgPictures.Images[img2];
            this.pbxImage3.Image = imgPictures.Images[img3];

            if (img1 == img2 && img2 == img3)
            {
                amountWon += inserted * 3;
                MessageBox.Show($"You won {inserted*3:C}");
            }
            else if (img1 == img2 || img2 == img3 || img1 == img3)
            {
                amountWon += inserted * 2;
                MessageBox.Show($"You won {inserted*2:C}");
            }
            else
            {
                MessageBox.Show($"You won {0:C}");
            }
        }
    }
}
