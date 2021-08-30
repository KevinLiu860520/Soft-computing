using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class YagerSnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Yager S-norm ";
        public YagerSnormOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(0, 10);
        }
        [Category("Parameters"), Description("The value must be larger than 0.")]
        public double q_parameter
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
            return Math.Min(1, Math.Pow(Math.Pow(a, parameters[0]) + Math.Pow(b, parameters[0]), 1 / parameters[0]));
        }
    }
}
