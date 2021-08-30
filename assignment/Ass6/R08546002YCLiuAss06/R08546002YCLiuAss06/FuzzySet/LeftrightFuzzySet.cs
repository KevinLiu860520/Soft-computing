using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class LeftrightFuzzySet : FuzzySet
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
        [Category("MemberFunctionParameter"), Description("The leftalpha of lef-tright function."), DisplayName("LeftAlpha")]
        public double LeftAlpha
        {
            set
            {
                if (value >= 0) parameters[0] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The rightbeta of left-right function."), DisplayName("RightBeta")]
        public double RightBeta
        {
            set
            {
                if (value >= 0) parameters[1] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[1];
            }
        }

        [Category("MemberFunctionParameter"), Description("The center of left-right function."), DisplayName("Center")]
        public double Center
        {
            set
            {
                if (value >= theUniverse.Minimum && value <= theUniverse.Maximum) parameters[2] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[2];
            }
        }
        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public LeftrightFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[3];
            // initialized 
            parameters[0] = 4;
            parameters[1] = 6;
            parameters[2] = 8;
            title = $"Leftright FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x <= parameters[2])
            {
                y = Math.Sqrt(Math.Max(0, 1 - Math.Pow(((parameters[2] - x) / parameters[0]), 2)));
            }
            else
            {
                y = Math.Exp(-Math.Pow(Math.Abs((x - parameters[2]) / parameters[1]), 3));
            }
            return y;
        }
    }
}
