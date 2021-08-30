using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class AlgebraicSumOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Algebraic Sum S-norm ";

        public override double Evaluate(double a, double b)
        {
            return a + b - a * b;
        }
    }
}
