using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class Pi_ShapedFuzzySet : FuzzySet
    {
        static int count = 0;

        //properties
        [Category("MemberFunctionParameter"), Description("The left of Pi_Shaped function."), DisplayName("Left")]
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
        [Category("MemberFunctionParameter"), Description("The right of Pi_Shaped function."), DisplayName("Right")]
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
        public Pi_ShapedFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[2];
            // initialized 
            parameters[0] = randomizer.Next();
            parameters[1] = parameters[0] + 5;
            title = $"Pi_Shaped FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x <= parameters[1] - parameters[0])
            {
                if (x >= parameters[1] - parameters[0] && x <= ((parameters[1] - parameters[0] + parameters[1]) / 2))
                {
                    y = 2 * Math.Pow((x - parameters[1] - parameters[0]) / (parameters[1] - parameters[1] - parameters[0]), 2);
                }
                else
                {
                    if (x >= ((parameters[1] - parameters[0] + parameters[1]) / 2) && x <= parameters[1])
                    {
                        y = 1 - 2 * Math.Pow((x - parameters[1]) / (parameters[1] - parameters[1] - parameters[0]), 2);
                    }
                    else
                    {
                        y = 1;
                    }
                }

            }
            else
            {
                if (x >= parameters[1] && x <= ((parameters[0] + parameters[1] + parameters[0]) / 2))
                {
                    y = 1 - (2 * Math.Pow((x - parameters[1]) / (parameters[1] + parameters[0] - parameters[0]), 2));
                }
                else
                {
                    if (x >= ((parameters[1] + parameters[1] + parameters[0]) / 2) && x <= parameters[1] + parameters[0])
                    {
                        y = 1 - (1 - 2 * Math.Pow((x - parameters[1] + parameters[0]) / (parameters[1] + parameters[0] - parameters[1]), 2));
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
