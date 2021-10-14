using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValuesPractice
{
    public partial class form1 : Form
    {
        int inputNum;
        int sum = 0;
        int totalNumbers;
        int avg;


        public form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                inputNum = Convert.ToInt32(inputBox.Text);
            //}
            //catch
            //{
            //    outputLabel.Text = $"Enter a valid integer";
            //}

            if (inputNum != 0)
            {
                sum = sum + inputNum;
                outputLabel.Text = $"{inputNum} was added to the sum.";
                totalNumbers++;
            }
            else
            {
                avg = sum / totalNumbers;
                outputLabel.Text = $"The average of all numbers entered is: {avg}";
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            sum = 0;
            totalNumbers = 0;
        }
    }
}
