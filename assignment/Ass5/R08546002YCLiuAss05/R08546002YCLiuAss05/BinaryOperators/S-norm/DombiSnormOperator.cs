using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class DombiSnormOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Dombi S-norm ";
        public DombiSnormOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(0, 10);
        }
        [Category("Parameters"), Description("The value must be larger than 0.")]
        public double lambda
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
            return 1 / (1 + Math.Pow(Math.Pow(1 / a - 1, -parameters[0]) + Math.Pow(1 / b - 1, -parameters[0]), -1 / parameters[0]));
        }
    }
}
