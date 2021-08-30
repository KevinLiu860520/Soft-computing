using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss03
{
    class GaussianFuzzySet : FuzzySet // 繼承Fuzzy set
    {
        static int count = 0;

        //properties
        //Attributes
        [Category("MemberFunctionParameter"),Description("The location of the symmetric point."),DisplayName("Center")]
        public double Center
        {
            set
            {
               parameters[0] = value;
               UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The standard deviation of Gaussian function."), DisplayName("StandardDeviation")]
        public double StandardDeviation
        {
            set
            {
                if (value >= 0) parameters[1] = value; //the value need to larger than 0
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[1];
            }
        }
        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[0]}";
        public GaussianFuzzySet(Universe u) : base(u) //base()：call father function  //v：local variable
        {
            parameters = new double[2]; // number of parameter
            // initialized 
            parameters[0] = Math.Round(u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum),2);
            parameters[1] = Math.Round((u.Maximum - u.Minimum)*randomizer.NextDouble() / 10.0,2);
            title = $"Gaussian FS {++count}";
        }

        public override double GetMembershipDegree(double x) // logic of Gaussian
        {
            return Math.Exp(-0.5 * (x - parameters[0]) * (x - parameters[0]) / parameters[1] / parameters[1]); //base.GetMembershipDegree(x);
        }
    }
}
