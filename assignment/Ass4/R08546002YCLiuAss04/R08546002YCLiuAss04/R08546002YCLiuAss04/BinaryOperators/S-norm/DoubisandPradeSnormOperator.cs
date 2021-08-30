using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class DoubisandPradeSnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "DoubisandPrade S-norm ";
        public DoubisandPradeSnormOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.NextDouble();
        }
        [Category("Parameters"), Description("The value must be between 0 and 1.")]
        public double alpha
        {
            get => parameters[0];
            set
            {
                if (value >= 0 && value <= 1.0)
                {
                    parameters[0] = value;
                    // fire event
                    FireParameterChangedEvent();
                }
            }
        }
        public override double Evaluate(double a, double b)
        {
            return a + b - (a * b) - Math.Min(a, Math.Min(b, 1 - parameters[0])) / Math.Max(1 - a, Math.Max(1 - b, parameters[0]));
        }
    }
}
