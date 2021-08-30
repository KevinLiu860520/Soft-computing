using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class DiminishOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Diminish ";
        public override double Evaluate(double a)
        {
            if (a >= 0 && a < 0.5)
            {
                return Math.Pow(0.5 * a, 0.5);
            }
            else if (a == 0.5)
            {
                return 0.5;
            }
            else
            {
                return 1 + (-1 * (Math.Pow(0.5 * (1 - a), 0.5)));
            }
        }
    }
}
