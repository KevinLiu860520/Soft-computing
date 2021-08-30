using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class BoundedProductOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Bounded Product T-norm ";

        public override double Evaluate(double a, double b)
        {
            return Math.Max(0, a + b - 1);
        }
    }
}
