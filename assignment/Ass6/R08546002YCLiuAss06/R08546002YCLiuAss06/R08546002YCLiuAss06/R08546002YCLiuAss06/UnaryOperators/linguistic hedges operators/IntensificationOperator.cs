using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class IntensificationOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Intensification ";
        public override double Evaluate(double a)
        {
            if (a >= 0 && a <= 0.5)
            {
                return 2 * Math.Pow(a, 2);
            }
            else
            {
                return 1 - 2 * Math.Pow(1 - a, 2);
            }
        }
    }
}
