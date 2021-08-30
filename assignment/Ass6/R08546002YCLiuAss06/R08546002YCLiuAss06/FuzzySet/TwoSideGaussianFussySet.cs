using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class TwoSideGaussianFussySet : FuzzySet
    {
        public override double MaxDegree => 1.0;
        public override double COACrispValue => parameters[0];
        public override double BOACrispValue => parameters[0];
        public override double MOMCrispValue => parameters[0];
        public override double LOMCrispValue => parameters[0];
        public override double SOMCrispValue => parameters[0];
        static int count = 0;
        
        //properties
        //Attributes
        [Category("MemberFunctionParameter"), Description("The location of the symmetric point."), DisplayName("Center 1")]
        public double Center1
        {
            set
            {
                if (value <= Center2) parameters[0] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The location of the symmetric point."), DisplayName("Center 2")]
        public double Center2
        {
            set
            {
                if (value >= Center1) parameters[1] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[1];
            }
        }
        [Category("MemberFunctionParameter"), Description("The standard deviation of Gaussian function."), DisplayName("StandardDeviation 1")]
        public double StandardDeviation1
        {
            set
            {
                if (value >= 0) parameters[2] = value; //the value need to larger than 0
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[2];
            }
        }
        [Category("MemberFunctionParameter"), Description("The standard deviation of Gaussian function."), DisplayName("StandardDeviation 2")]
        public double StandardDeviation2
        {
            set
            {
                if (value >= 0) parameters[3] = value; //the value need to larger than 0
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[3];
            }
        }
        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[0]}";
        public TwoSideGaussianFussySet(Universe u) : base(u) //base()：call father function  //v：local variable
        {
            parameters = new double[4]; // number of parameter
            // initialized 
            parameters[0] = 3;
            parameters[1] = 5;
            parameters[2] = Math.Round(u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum) / 10, 2);
            parameters[3] = Math.Round((u.Maximum - u.Minimum) * randomizer.NextDouble() / 10.0, 2);
            title = $"TwoSideGaussian FS {++count}";
        }

        public override double GetMembershipDegree(double x) // logic of Gaussian
        {
            double y;
            if (x <= parameters[0])
            {
                y = Math.Exp(-0.5 * (x - parameters[0]) * (x - parameters[0]) / (parameters[2] * parameters[2]));
            }
            else if (parameters[0] < x && parameters[1] > x)
            {
                y = 1;
            }
            else
            {
                y = Math.Exp(-0.5 * (x - parameters[1]) * (x - parameters[1]) / (parameters[3] * parameters[3]));
            }
            return y;
        }
    }
}
