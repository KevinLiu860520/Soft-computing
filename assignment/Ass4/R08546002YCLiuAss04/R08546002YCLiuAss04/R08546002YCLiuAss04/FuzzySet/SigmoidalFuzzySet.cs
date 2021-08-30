using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class SigmoidalFuzzySet : FuzzySet
    {
        static int count = 0;

        //properties
        //Attributes
        [Category("MemberFunctionParameter"), Description("The center of Sigmoidal function."), DisplayName("Center")]
        public double Center
        {
            set
            {
                if (value >= theUniverse.Minimum && value <= theUniverse.Maximum) parameters[0] = value;
                UpdateSeriesDataPoints();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The slope of Sigmoidal function."), DisplayName("Slope")]
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
        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[0]}";
        public SigmoidalFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[2];
            // initialized 
            parameters[0] = Math.Round(u.Minimum + randomizer.NextDouble() * (u.Maximum - u.Minimum), 2);
            parameters[1] = Math.Round((u.Maximum - u.Minimum) * randomizer.NextDouble() / 10.0, 2);
            title = $"Sigoidal FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            return 1 / (1 + Math.Exp(-parameters[1] * (x - parameters[0])));
        }
    }
}

