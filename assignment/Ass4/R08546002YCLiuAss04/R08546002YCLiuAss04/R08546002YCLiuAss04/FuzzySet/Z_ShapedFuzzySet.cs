using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class Z_ShapedFuzzySet : FuzzySet
    {
        static int count = 0;

        //properties
        [Category("MemberFunctionParameter"), Description("The left of Z_Shaped function."), DisplayName("Left")]
        public double Left
        {
            set
            {
                if (value >= theUniverse.Minimum && value <= parameters[1]) parameters[0] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The right of Z_Shaped function."), DisplayName("Right")]
        public double Right
        {
            set
            {
                if (value >= parameters[0] && value <= theUniverse.Maximum) parameters[1] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[1];
            }
        }

        [Browsable(false)]
        //public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public Z_ShapedFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[2];
            // initialized 
            parameters[0] = 2;
            parameters[1] = 7;
            title = $"Z_Shaped FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x <= parameters[0])
            {
                y = 1;
            }
            else
            {
                if (x >= parameters[0] && x <= ((parameters[0] + parameters[1]) / 2))
                {
                    y = 1 - (2 * Math.Pow((x - parameters[0]) / (parameters[1] - parameters[0]), 2));
                }
                else
                {
                    if (x >= ((parameters[0] + parameters[1]) / 2) && x <= parameters[1])
                    {
                        y = 1 - (1 - 2 * Math.Pow((x - parameters[1]) / (parameters[1] - parameters[0]), 2));
                    }
                    else
                    {
                        y = 0;
                    }
                }
            }
            return y;
        }
    }
}
