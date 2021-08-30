using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class HamacherProductOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Hamacher Product T-norm ";
        public HamacherProductOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(0, 10);
        }
        [Category("Parameters"), Description("The value must be larger than 0.")]
        public double Gamma
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
            // if denominator of a fraction is 0, the value will be infinity.
            if (a == 0 && b == 0 && parameters[0] == 0)
            {
                return 0;
            }
            else
            {
                return (a * b) / (parameters[0] + (1 - parameters[0]) * (a + b - a * b));
            }
        }
    }
}
