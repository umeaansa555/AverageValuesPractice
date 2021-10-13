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
        int sum;
        int totalNumbers;
        int avg;


        public form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(inputBox.Text);
            avg = (sum / totalNumbers);

            if(sum != 0)
            {
                //fill this in
            }
            else
            {
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
