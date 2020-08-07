using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
       //create public properties here
        public double height { get; set; }
        public double weight { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(HeightInput.Text);
            weight = Convert.ToDouble(WeightInput.Text);
            double result = 0.00;

            if (height != 0 && weight !=0)
            {
                if (radioImperial.Checked)
                {
                    result = (weight * 703) / height * height;
                    BMIResult.Text = "BMI is " + result.ToString("#.#");
                    if (result < 18.5)
                    {
                        BMIScale.Text = "Underweight";
                    }
                    else if (result >=18.5  && result <= 24.9)
                    {
                        BMIScale.Text = "Normal";
                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        BMIScale.Text = "Overweight";
                    }
                    else if (result > 30)
                    {
                        BMIScale.Text = "Obese";
                    }
                }
                else if (radioMetric.Checked)
                {
                    result = (weight / (height * height)) * 10000;
                    BMIResult.Text = "BMI is " + result.ToString("#.#");
                    if(result < 18.5)
                    {
                        BMIScale.Text = "Underweight";
                    }
                    else if (result >= 18.5 && result <= 24.9)
                    {
                        BMIScale.Text = "Normal";
                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        BMIScale.Text = "Overweight";
                    }
                    else if (result > 30)
                    {
                        BMIScale.Text = "Obese";
                    }
                }
            }
            else
            {
                BMIResult.Text = "Fill out a form ";
                BMIScale.Text = "Fill out a form";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            radioImperial.Checked = false;
            radioMetric.Checked = false;
            HeightInput.Text = "";
            WeightInput.Text = "";
            BMIResult.Text = "";
            BMIScale.Text = "";
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void ResultGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
