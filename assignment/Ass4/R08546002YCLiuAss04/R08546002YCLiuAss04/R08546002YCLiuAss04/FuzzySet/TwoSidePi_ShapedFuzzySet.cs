using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class TwoSidePi_ShapedFuzzySet : FuzzySet
    {
        static int count = 0;

        //properties
        [Category("MemberFunctionParameter"), Description("The left of twoSidePi_Shaped function."), DisplayName("Left")]
        public double Left
        {
            set
            {
                if (value >= theUniverse.Minimum) parameters[0] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The leftpeak of twoSidePi_Shaped function."), DisplayName("LeftPeak")]
        public double LeftPeak
        {
            set
            {
                if (value > Left && value < RightPeak) parameters[1] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[1];
            }
        }

        [Category("MemberFunctionParameter"), Description("The rightpeak of twoSidePi_Shaped function."), DisplayName("RightPeak")]
        public double RightPeak
        {
            set
            {
                if (value > Left && value < Right) parameters[2] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[2];
            }
        }
        [Category("MemberFunctionParameter"), Description("The right of twoSidePi_Shaped function."), DisplayName("Right")]
        public double Right
        {
            set
            {
                if (value > RightPeak && value <= theUniverse.Maximum) parameters[3] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[3];
            }
        }
        [Browsable(false)]
        //public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public TwoSidePi_ShapedFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[4];
            // initialized 
            parameters[0] = 1;
            parameters[1] = 3;
            parameters[2] = 5;
            parameters[3] = 7;
            title = $"TwoSidePi_Shaped FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x <= parameters[0])
            {
                y = 0;
            }
            else
            {
                if (x >= parameters[0] && x <= ((parameters[0] + parameters[1]) / 2))
                {
                    y = 2 * Math.Pow((x - parameters[0]) / (parameters[1] - parameters[0]), 2);
                }
                else
                {
                    if (x >= ((parameters[0] + parameters[1])) / 2 && x <= parameters[1])
                    {
                        y = 1 - 2 * Math.Pow((x - parameters[1]) / (parameters[1] - parameters[0]), 2);
                    }
                    else
                    {
                        if (x >= parameters[1] && x <= parameters[2])
                        {
                            y = 1;
                        }
                        else
                        {
                            if (x >= parameters[2] && x <= ((parameters[2] + parameters[3]) / 2))
                            {
                                y = 1 - 2 * Math.Pow((x - parameters[2]) / (parameters[3] - parameters[2]), 2);
                            }
                            else
                            {
                                if (x >= ((parameters[2] + parameters[3]) / 2) && x <= parameters[3])
                                {
                                    y = 2 * Math.Pow((x - parameters[3]) / (parameters[3] - parameters[2]), 2);
                                }
                                else
                                {
                                    y = 0;
                                }
                            }
                        }
                    }
                }
            }
            return y;
        }
    }
}
