using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class BoundedSumOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Bounded Sum S-norm ";

        public override double Evaluate(double a, double b)
        {
            return Math.Min(1, a + b);
        }
    }
}
