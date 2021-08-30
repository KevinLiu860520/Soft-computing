using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class SugenoComplementOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => " Sugeno's Complement ";

        public SugenoComplementOperator()
        {
            parameters = new double[1];
            parameters[0] = rnd.Next();
        }

        public double Lambda
        {
            get => parameters[0];
            // guard
            set
            {
                if (value > -1)
                {
                    parameters[0] = value;
                    // fire event
                    FireParameterChangedEvent();
                }
            }
        }
        public override double Evaluate(double a)
        {
            return (1 - a) / (1 - a * parameters[0]);
        }
    }
}
