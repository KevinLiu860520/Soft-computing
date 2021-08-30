using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss02
{
    public partial class MainForm : Form
    {
        Random myRnd = new Random(); // set random function

        public MainForm()
        {
            InitializeComponent();
            // lsbselection.SelectedIndex = 0; // default first item selected in listbox
            FunctionSelection.SelectedIndex = 0; //default first item selected in combobox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudPar2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void FunctionSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = FunctionSelection.SelectedIndex; // index from item in combobox
            switch (idx)  // if idx == below case, enter the condition of case
            {
                case 0: // Triangular: index = 0, enter below code
                    labPar1.Text = TriangleFunction.parameterNames[0]; // first paramterName obtained by TriangularFunction
                    labPar2.Text = TriangleFunction.parameterNames[1]; // second paramterName obtained by TriangularFunction
                    labPar3.Text = TriangleFunction.parameterNames[2]; // third paramterName obtained by TriangularFunction
                    labPar3.Visible = true; // show third paramterName
                    nudPar3.Visible = true; // third paramter input
                    nudPar1.Value = 3; // first parameter initial value = 3
                    nudPar2.Value = 4; // second parameter initial value = 4
                    nudPar3.Value = 5; // third parameter initial value = 5
                    tFormula.Visible = true; // show triangular_function formula
                    sgFormula.Visible = false; // hide sigmoid_function formula
                    gFormula.Visible = false; // hide gaussian_function formula
                    bFormula.Visible = false; // hide bell_function formula
                    TriangularNote.Visible = true; // show triangular_function Note
                    SigmoidNote.Visible = false;// hide sigmoid_function Note
                    GaussianNote.Visible = false;// hide gaussian_function Note
                    BellNote.Visible = false;// hide bell_function Note
                    break;
                case 1: // Bell: index = 1, enter below code
                    labPar1.Text = BellFunction.parameterNames[0];
                    labPar2.Text = BellFunction.parameterNames[1];
                    labPar3.Text = BellFunction.parameterNames[2];
                    labPar3.Visible = true; 
                    nudPar3.Visible = true; 
                    nudPar1.Value = myRnd.Next(-5, 6); // first parameter initial number is between -5 and 6 by myRnd Function
                    nudPar2.Value = Math.Round((decimal)(myRnd.NextDouble() * 3.0),2); // second parameter initial number is between 0 and 1 by myRnd Function times 3
                    nudPar3.Value = myRnd.Next(-3, 5); // third parameter initial number is between -5 and 6 by myRnd Function
                    bFormula.Visible = true;
                    tFormula.Visible = false;
                    gFormula.Visible = false;
                    sgFormula.Visible = false;
                    TriangularNote.Visible = false;
                    SigmoidNote.Visible = false;
                    GaussianNote.Visible = false;
                    BellNote.Visible = true;
                    break;
                case 2: // Gaussian: index = 2, enter below code
                    labPar3.Visible = false;
                    labPar1.Text = GaussianFunction.parameterNames[0];
                    labPar2.Text = GaussianFunction.parameterNames[1];
                    nudPar3.Visible = false;
                    nudPar1.Value = myRnd.Next(-5, 10);
                    nudPar2.Value = Math.Round((decimal)(myRnd.NextDouble() * 3.0),2);
                    gFormula.Visible = true;
                    tFormula.Visible = false;
                    sgFormula.Visible = false;
                    bFormula.Visible = false;
                    TriangularNote.Visible = false;
                    SigmoidNote.Visible = false;
                    GaussianNote.Visible = true;
                    BellNote.Visible = false;
                    break;
                case 3:// Sigmoid: index = 3, enter below code
                    labPar3.Visible = false;
                    labPar1.Text = SigmoidFunction.parameterNames[0];
                    labPar2.Text = SigmoidFunction.parameterNames[1];
                    nudPar3.Visible = false;
                    nudPar1.Value = myRnd.Next(-5, 10);
                    nudPar2.Value = Math.Round((decimal)(myRnd.NextDouble() * 3.0),2);
                    sgFormula.Visible = true;
                    tFormula.Visible = false;
                    gFormula.Visible = false;
                    bFormula.Visible = false;
                    TriangularNote.Visible = false;
                    SigmoidNote.Visible = true;
                    GaussianNote.Visible = false;
                    BellNote.Visible = false;
                    break;
            }
        }
 /*       private void lsbselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lsbselection.SelectedIndex;
            switch (idx)
            {
                case 0: // Triangular
                    labPar1.Text = TriangleFunction.parameterNames[0];
                    labPar2.Text = TriangleFunction.parameterNames[1];
                    labPar3.Text = TriangleFunction.parameterNames[2];
                    labPar3.Visible = true;
                    nudPar3.Visible = true;
                    nudPar1.Value = 3;
                    nudPar2.Value = 4;
                    nudPar3.Value = 5;
                    break;
                case 1: // Bell
                    labPar1.Text = BellFunction.parameterNames[0];
                    labPar2.Text = BellFunction.parameterNames[1];
                    labPar3.Text = BellFunction.parameterNames[2];
                    labPar3.Visible = true;
                    nudPar3.Visible = true;
                    nudPar1.Value = myRnd.Next(-5, 6);
                    nudPar2.Value = (decimal)(myRnd.NextDouble() * 3.0);
                    nudPar1.Value = myRnd.Next(-3, 5);
                    break;
                case 2: // Gaussian
                    labPar3.Visible = false;
                    labPar1.Text = GaussianFunction.parameterNames[0];
                    labPar2.Text = GaussianFunction.parameterNames[1];
                    nudPar3.Visible = false;
                    nudPar1.Value = myRnd.Next(-5, 6);
                    nudPar2.Value = (decimal)(myRnd.NextDouble() * 3.0);
                    break;
                case 3:// Sigmoid
                    labPar3.Visible = false;
                    labPar1.Text = SigmoidFunction.parameterNames[0];
                    labPar2.Text = SigmoidFunction.parameterNames[1];
                    nudPar3.Visible = false;
                    nudPar1.Value = myRnd.Next(-5, 6);
                    nudPar2.Value = (decimal)(myRnd.NextDouble() * 3.0);
                    break;
            }
        }*/

        private void nudPar1_Click(object sender, EventArgs e)
        {

        }

        private void nudPar3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreatButtonClicked(object sender, EventArgs e)
        {
            double X_from, X_to; // define X limit
            X_from = (double)Xlimit_min.Value;
            X_to = (double)Xlimit_max.Value;
            switch (FunctionSelection.SelectedIndex) // if idx == below case, enter the condition of case
            {
                case 0: //Triangular
                    double leftpoint, peakpoint,rightpoint; //define parameter
                    leftpoint = (double)nudPar1.Value;
                    peakpoint = (double)nudPar2.Value;
                    rightpoint = (double)nudPar3.Value;
                    TriangleFunction myTriangleObj = new TriangleFunction(leftpoint, peakpoint, rightpoint); // get class and name it

                    Series t = new Series();
                    t.ChartType = SeriesChartType.Line;
                    t.Color = Color.FromArgb(myRnd.Next(256), myRnd.Next(256), myRnd.Next(256)); // random color
                    t.LegendText = "TriangularFunction with" + Environment.NewLine + $"leftpoint = {leftpoint}"+ $", peakpoint = {peakpoint}" + $", rightpoint = {rightpoint}"; // legend name

                    // if leftpoint > peakpoint > rightpoint & leftpoint,peakpoint,rightpoint > X_to, show below MessageBox
                    if (leftpoint > peakpoint || leftpoint > rightpoint || peakpoint > rightpoint || leftpoint > X_to || peakpoint > X_to || rightpoint > X_to)
                    {
                        MessageBox.Show("Each value of parameter cannot be large than X_to and leftpoint<peakpoint<rightpoint !!" + Environment.NewLine + "Please re-enter !!!");
                        return;
                    }
                    // Clear previous line when we create new line
                    
                    for (double x = X_from; x <= X_to; x = x + 0.1)
                    {
                        double y = myTriangleObj.GetFunctionValue(x); // get y by run myTriangleObj's function(GetFunctionValue)
                        t.Points.AddXY(x, y);// plot Function line
                    }
                    theChart.Series.Add(t);
                    break;

                case 1:// Bell
                    double Width, Slope, Center;
                    Width = (double)nudPar1.Value;
                    Slope = (double)nudPar2.Value;
                    Center = (double)nudPar3.Value;
                    BellFunction myBellObj = new BellFunction(Width, Slope, Center);
                    Series b = new Series();
                    b.ChartType = SeriesChartType.Line;
                    b.Color = Color.FromArgb(myRnd.Next(256), myRnd.Next(256), myRnd.Next(256));
                    b.LegendText = "BellFunction with" + Environment.NewLine + $"Width = {Width}" + $", Slope = {Slope}" + $", Center = {Center}";
                    // if params_A, params_B, params_C >X_to, show below MessageBox
                    if (Width > X_to || Slope > X_to || Center > X_to)
                    {
                        MessageBox.Show("Each value of parameter cannot be large than X_to !!" + Environment.NewLine + "Please re-enter !!!");
                        return;
                    }

                    for (double x = X_from; x <= X_to; x = x + 0.1)
                    {
                        double y = myBellObj.GetFunctionValue(x);
                        b.Points.AddXY(x, y);
                    }
                    theChart.Series.Add(b);
                    break;

                case 2://Gaussian
                    double c, sigma;
                    c = (double)nudPar1.Value;
                    sigma = (double)nudPar2.Value;
                    GaussianFunction myGaussianObj = new GaussianFunction(c, sigma);
                    Series s = new Series();
                    s.ChartType = SeriesChartType.Line;
                    s.Color = Color.FromArgb(myRnd.Next(256), myRnd.Next(256), myRnd.Next(256));
                    s.LegendText = "GaussianFunction with" + Environment.NewLine + $"Center = {c}" + $", Std = {sigma}";

                    // if c, sigma >10, show below MessageBox
                    if (c > X_to || sigma > X_to)
                    {
                        MessageBox.Show("Each value of parameter cannot be large than X_to !!" + Environment.NewLine + "Please re-enter !!!");
                        return;
                    }

                    for (double x = X_from; x <= X_to; x = x + 0.1)
                    {
                        double y = myGaussianObj.GetFunctionValue(x);
                        s.Points.AddXY(x, y);
                    }
                    theChart.Series.Add(s);
                    break;
                case 3:// sigmoid
                    double slope, center;
                    slope = (double)nudPar1.Value;
                    center = (double)nudPar2.Value;
                    SigmoidFunction mySigmoidObj = new SigmoidFunction(slope, center);
                    Series sg = new Series();
                    sg.ChartType = SeriesChartType.Line;
                    sg.Color = Color.FromArgb(myRnd.Next(256), myRnd.Next(256), myRnd.Next(256));
                    sg.LegendText = "SigmoidFunction with" + Environment.NewLine + $"Slope = {slope}" + $", Center = {center}" ;

                    // if params_A, params_C >X_to, show below MessageBox
                    if (slope > X_to || center > X_to)
                    {
                        MessageBox.Show("Each value of parameter cannot be large than X_to !!" + Environment.NewLine + "Please re-enter !!!");
                        return;
                    }

                    
                    for (double x = X_from; x <= X_to; x = x + 0.1)
                    {
                        double y = mySigmoidObj.GetFunctionValue(x);
                        sg.Points.AddXY(x, y);
                    }
                    theChart.Series.Add(sg);
                    break;
            }
        }
        private void Refresh_Click(object sender, EventArgs e) // Clear all lines
        {
            foreach (var series in theChart.Series)
            {
                series.Points.Clear();
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SigmoidNote_Click(object sender, EventArgs e)
        {

        }
    }
}
