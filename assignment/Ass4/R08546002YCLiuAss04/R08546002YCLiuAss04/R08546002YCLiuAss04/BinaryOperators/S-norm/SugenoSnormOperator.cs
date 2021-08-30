using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class SugenoSnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Sugeno S-norm ";
        public SugenoSnormOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(-1, 10);
        }
        [Category("Parameters"), Description("The value must be larger than -1.")]
        public double lambda
        {
            get => parameters[0];
            set
            {
                if (value >= -1)
                {
                    parameters[0] = value;
                    // fire event
                    FireParameterChangedEvent();
                }
            }
        }
        public override double Evaluate(double a, double b)
        {
            return Math.Min(1, a + b + parameters[0] * a * b);
        }
    }
}
