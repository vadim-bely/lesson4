using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxHX.Text = "1";
            textBoxXN.Text = "1";
            TextBoxX0.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Font = new Font("Teams new Roman", 14, FontStyle.Italic);
            
            double x0 = Convert.ToDouble(TextBoxX0.Text);
            double xn = Convert.ToDouble(textBoxXN.Text);
            double hx = Convert.ToDouble(textBoxHX.Text);

            if (radioButtonMin.Checked)
            {
                result.Text = Calculation.min(Calculation.tab(x0, xn, hx).ToArray()).ToString();
            } 
            else if (radioButtonMax.Checked)
            {
                result.Text = Calculation.max(Calculation.tab(x0, xn, hx).ToArray()).ToString();
            }
            else if (radioButtonAverage.Checked)
            {
                result.Text = Calculation.average(Calculation.tab(x0, xn, hx).ToArray()).ToString();
            }
            else
            {
                result.Text = "I can't do that";
            }

        }


    }
}