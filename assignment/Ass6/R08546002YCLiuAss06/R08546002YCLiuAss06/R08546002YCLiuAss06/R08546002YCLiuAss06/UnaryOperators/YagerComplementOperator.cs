using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class YagerComplementOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => " Yager's Complement ";

        public YagerComplementOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next(0, 10);
        }

        public double W_parameter
        {
            get => parameters[0];
            // guard
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
        public override double Evaluate(double a)
        {
            return Math.Pow((1 - Math.Pow(a, parameters[0])), (1 / parameters[0]));
        }
    }
}
