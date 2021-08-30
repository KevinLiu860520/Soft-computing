using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class FrankTnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Frank T-norm ";
        public FrankTnormOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(0, 10);
        }
        [Category("Parameters"), Description("The value must be larger than 0.")]
        public double s_parameter
        {
            get => parameters[0];
            set
            {
                if (value > 0)
                {
                    parameters[0] = value;
                    // fire event
                    FireParameterChangedEvent();
                }
            }
        }
        public override double Evaluate(double a, double b)
        {
            return Math.Log(1 + (Math.Pow(parameters[0], a) - 1) * (Math.Pow(parameters[0], b) - 1) / (parameters[0] - 1), parameters[0]);
        }
    }
}
