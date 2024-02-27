using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            partsTextBox.Text = "0";
            laborTextBox.Text = "0";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            serviceCostTextBox.Text = Convert.ToString(OilChangeCharges() + LubeCharges() + RadiatorFlushCharges() + TransmissionFlushCharges() + InspectionCharges() +  MufflerCharges() + TireRotationCharges() + LaborCharges());
            partsCostTextBox.Text = Convert.ToString(PartsCharges());
            taxCostTextBox.Text = Convert.ToString(TaxCharges());
            totalFeesTextBox.Text = Convert.ToString(TotalCharges());
        }

        private double OilChangeCharges()
        {
            if (oilChangeCheckBox.Checked)
            {
                return 50;
            }
            return 0;
        }
        private double LubeCharges()
        {
            if (lubeJobCheckBox.Checked)
            {
                return 40;
            }
            return 0;
        }
        private double RadiatorFlushCharges()
        {
            if (radiatorCheckBox.Checked)
            {
                return 100;
            }
            return 0;
        }
        private double TransmissionFlushCharges()
        {
            if (transmissionFlushCheckBox.Checked)
            {
                return 120;
            }
            return 0;
        }
        private double InspectionCharges()
        {
            if (inspectionCheckBox.Checked)
            {
                return 35;
            }
            return 0;
        }
        private double MufflerCharges()
        {
            if (replaceMufflerCheckBox.Checked)
            {
                return 150;
            }
            return 0;
        }
        private double TireRotationCharges()
        {
            if (tireRotationCheckBox.Checked)
            {
                return 25;
            }
            return 0;
        }
       private double PartsCharges()
        {
            double total = Convert.ToDouble(partsTextBox.Text);
            return total;
        }
        private double LaborCharges()
        {
            if (!(Convert.ToInt32(laborTextBox.Text) == 0))
            {
                double total = Convert.ToDouble(laborTextBox.Text) * 75;
                return total;
            }
            else
            {
                return 0.0;
            }

        }
        private double TaxCharges(double taxRate = 0.07)
        {
            double total = Convert.ToDouble(partsTextBox.Text) * taxRate;
            return total;
        }
        private double TotalCharges() 
        {
            return Convert.ToDouble(serviceCostTextBox.Text) + Convert.ToDouble(partsCostTextBox.Text) + Convert.ToDouble(taxCostTextBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;   
            radiatorCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;  
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false; 
            tireRotationCheckBox.Checked = false;
            partsTextBox.Text = "0";
            laborTextBox.Text = "0";
            serviceCostTextBox.Text = "";
            partsCostTextBox.Text = "";
            taxCostTextBox.Text = "";
            totalFeesTextBox.Text = ""; 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
