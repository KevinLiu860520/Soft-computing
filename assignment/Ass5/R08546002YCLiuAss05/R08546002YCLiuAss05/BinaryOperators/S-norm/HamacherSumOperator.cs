using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class HamacherSumOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Hamacher Sum S-norm ";
        public HamacherSumOperator()
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
            return (a + b + (parameters[0] - 2) * a * b) / (1 + (parameters[0] - 1) * a * b);
        }
    }
}
