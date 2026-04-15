using System;
using System.Windows.Forms;

namespace ClassActivity2
{
    public partial class Form1 : Form
    {
        private const string CompanyID = "ECO-2026";
        private double BaseTaxRate = 1.15;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private double CalculateEmissions(double distance, double weight, double efficiency)
        {
            return (distance * 0.05) + (weight * 0.01) / efficiency;
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            double distance = Convert.ToDouble(txtDistance.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double efficiency = Convert.ToDouble(txtEfficiency.Text);

            double emission = CalculateEmissions(distance, weight, efficiency);

            double finalScore = emission * BaseTaxRate;

            lblResult.Text = "Carbon Score: " + finalScore.ToString("F2") + "\nCompany: " + CompanyID + "\nTax Rate: " + BaseTaxRate;
        }
    }
}