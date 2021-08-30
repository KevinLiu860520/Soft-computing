using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R08546002YCLiuAss01
{
    public partial class Assignment1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Assignment1()
        {
            InitializeComponent();
        }
        private void tFunctionButtom_Click(object sender, EventArgs e)
        {
            // get a,b,c from tFunctionButtom UI
            double a = Convert.ToDouble(textLeft1.Text);
            double b = Convert.ToDouble(textLeft2.Text);
            double c = Convert.ToDouble(textLeft3.Text);

            // if a>b>c & a,b,c >10, show below MessageBox
            if (a > b || a > c || b > c || a > 10 || b > 10 || c > 10)
            {
                MessageBox.Show("Each value of parameter cannot be large than 10 and a<b<c !!" + Environment.NewLine + "Please re-enter !!!");
                return;
            }
            // Clear previous line when we create new line 
            theChart.Series[0].Points.Clear();
            // logic of tFunction
            for (double x = 0.0; x <= 10; x = x + 0.1)
            {
                double y;
                if (x <= a)
                {
                    y = 0;
                }
               else if(x >= a && x<=b)
                {
                    y = (x - a) / (b - a);
                }
               else if (x >= b && x <= c)
                {
                    y = (c - x) / (c - b);
                }
               else
                {
                    y = 0;
                }
                // plot tFunction line
                theChart.Series[0].Points.AddXY(x, y);
            }
        }

        private void gFunctionButtom_Click(object sender, EventArgs e)
        {
            // get c, sigma from gFunctionButtom UI
            double c = Convert.ToDouble(textCenter1.Text);
            double sigma = Convert.ToDouble(textCenter2.Text);

            // if c, sigma >10, show below MessageBox
            if (c > 10 || sigma > 10)
            {
                MessageBox.Show("Each value of parameter cannot be large than 10 !!" + Environment.NewLine + "Please re-enter !!!");
                return;
            }
            // Clear previous line when we create new line
            theChart.Series[1].Points.Clear();
            // logic of gFunction
            for (double x = 0.0; x <= 10.0; x = x + 0.1)
            {
                double y = Math.Exp(-(Math.Pow(x - c, 2)) / (2 * (Math.Pow(sigma, 2))));
                theChart.Series[1].Points.AddXY(x, y); // plot tFunction line
            }
        }

        private void bFunctionButtom_Click(object sender, EventArgs e)
        {
            // get a,b,c from bFunctionButtom UI
            double a = Convert.ToDouble(textRight1.Text);
            double b = Convert.ToDouble(textRight2.Text);
            double c = Convert.ToDouble(textRight3.Text);

            // if a,b,c >10, show below MessageBox
            if ( a > 10 || b > 10 || c > 10)
            {
                MessageBox.Show("Each value of parameter cannot be large than 10 !!" + Environment.NewLine + "Please re-enter !!!");
                return;
            }
            // Clear previous line when we create new line
            theChart.Series[2].Points.Clear();
            // logic of bFunction
            for (double x = 0.0; x <= 10; x = x + 0.1)
            {
                double y = 1 / (1 + Math.Pow(Math.Abs((x - c) / a), 2 * b));
                theChart.Series[2].Points.AddXY(x, y); // plot tFunction line
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tFunction_A_Click_1(object sender, EventArgs e)
        {

        }

        private void tFunction_B_Click_1(object sender, EventArgs e)
        {

        }
    }
}
