using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class IntersectionOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Minimum T-norm ";

        public override double Evaluate(double a, double b)
        {
            return Math.Min(a, b);
        }
    }
}
