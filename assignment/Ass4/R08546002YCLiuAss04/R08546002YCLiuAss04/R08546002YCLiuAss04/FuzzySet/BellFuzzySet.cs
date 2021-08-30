using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class BellFuzzySet : FuzzySet
    {
        static int count = 0;

        //properties
        //Attributes
        [Category("MemberFunctionParameter"), Description("The width of bell function."), DisplayName("Width")]
        public double Width
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
        [Category("MemberFunctionParameter"), Description("The slope of bell function."), DisplayName("Slope")]
        public double Slope
        {
            set
            {
                parameters[1] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[1];
            }
        }

        [Category("MemberFunctionParameter"), Description("The center of bell function."), DisplayName("Center")]
        public double Center
        {
            set
            {
                parameters[2] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[2];
            }
        }
        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public BellFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[3];
            // initialized 
            parameters[0] = Math.Round(u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum), 2);
            parameters[1] = Math.Round((u.Maximum - u.Minimum) * randomizer.NextDouble() / 10.0, 2);
            parameters[2] = Math.Round(u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum), 2);
            title = $"Bell FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            return 1 / (1 + Math.Pow(Math.Abs(((x - parameters[2]) / parameters[0])), 2 * parameters[1]));
        }
    }
}
