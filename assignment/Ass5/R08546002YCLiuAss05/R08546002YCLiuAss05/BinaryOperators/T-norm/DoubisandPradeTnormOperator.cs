using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class DoubisandPradeTnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "DoubisandPrade T-norm ";
        public DoubisandPradeTnormOperator()
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
            return a * b / Math.Max(a, Math.Max(b, parameters[0]));
        }
    }
}
