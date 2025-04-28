using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string ageStr = ageTextBox.Text;
            string heightStr = heightTextBox.Text;
            string weightStr = weightTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageStr) ||
                string.IsNullOrEmpty(heightStr) || string.IsNullOrEmpty(weightStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int age;
            double height, weight;
            if (!int.TryParse(ageStr, out age) || age <= 0 ||
                !double.TryParse(heightStr, out height) || height <= 0 ||
                !double.TryParse(weightStr, out weight) || weight <= 0)
            {
                MessageBox.Show("Please enter valid positive numbers for age, height, and weight.");
                return;
            }

            double bmi = weight / (height * height);

            List<string> results = new List<string>
            {
                "Name: " + name,
                "Age: " + age.ToString(),
                "BMI: " + bmi.ToString("F2")
            };

            Form2 form2 = new Form2(results);
            form2.ShowDialog();
        }
    }
}
