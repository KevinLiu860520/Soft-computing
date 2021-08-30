using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class MinimumOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Minimum T-norm ";

        public override double Evaluate(double a, double b)
        {
            return Math.Min(a, b);
        }
    }
}
