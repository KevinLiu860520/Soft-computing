using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss00
{
    class Universe
    {
        // for Title name
        static int count = 0; // you can use this even if you don't have to initialize
        // data member
        // double minimum = 0;
        // double maximum = 10;
        int resolution = 100; // how many datapoint we need
        Chart theChart;
        ChartArea theArea;


        //public void SetTitle(string s)
        //{
        //    // Check validity
        //    title =  s;
        //}
        //public string GetTitle()
        //{
        //    return title;
        //}

        public event EventHandler ParameterChanged; // an event


        // property 
        [Category("Display")] // show the topic name in the propertygrid
        public string Title
        {
            set
            {
                // check validity of value
                theArea.AxisX.Title = value; // x axis name
            }
            get
            {
                return theArea.AxisX.Title;
            }
        }
        [Category("Parameters"), Description("Must be lower than Maximum.")] // description is describe how the parameter use 
        public double Minimum
        {
            get => theArea.AxisX.Minimum; // get value
            set  // write value
            {
                if (value < theArea.AxisX.Maximum)
                {
                    theArea.AxisX.Minimum = value;
                    // Fire parameter changed event
                    if (ParameterChanged != null)
                        ParameterChanged(this, null);
                }
            }
        }

        public void AddASeriesofFuzzySet(Series aSeries)
        {
            // register the series the chartarea
            aSeries.ChartArea = theArea.Name;

            // add the series  to Chart.Series
            theChart.Series.Add(aSeries);
        }
        [Category("Parameters"), Description("Must be larger than Minimum.")]
        public double Maximum
        {
            get => theArea.AxisX.Maximum; // get value
            set  // write value
            {
                if (value > theArea.AxisX.Minimum)
                {
                    theArea.AxisX.Maximum = value;
                    // Fire parameter changed event
                    if (ParameterChanged != null)
                        ParameterChanged(this, null);
                }
            }
        }
        [Category("Parameters"), Description("Resolution must greater than 50")]
        public int Resolution // datapoint
        {
            get => resolution;
            set
            {
                if (value >= 50) resolution = value;
            }
        }
        [Browsable(false)] // don;t display below topic in the propertygrid
        public Chart TheChart { get => theChart; set => theChart = value; }
        [Browsable(false)]
        public ChartArea TheArea { get => theArea; set => theArea = value; }

        // constructor
        public Universe(Chart theChart)
        {
            string s = $"Universe{++count}"; // chart name = $"Universe{++count}"
            theArea = new ChartArea(s);
            theArea.AxisX.MajorGrid.LineWidth = 0; // don't display grid in x-axis and y-axis
            theArea.AxisY.MajorGrid.LineWidth = 0;
            theArea.AxisX.Title = s;
            theArea.AxisY.Title = "Membership Degree";
            theArea.AxisX.Enabled = theArea.AxisY.Enabled = AxisEnabled.True;
            theArea.BackColor = Color.SeaShell; // change the area backcolor
            theArea.AxisX.Minimum = 0;
            theArea.AxisX.Maximum = 10;
            theArea.AxisX.TitleFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); // change the font size and type
            theArea.AxisY.TitleFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.theChart = theChart; // let fuzzy set know thechart
            this.theChart.ChartAreas.Add(theArea);
        }
    }
}

