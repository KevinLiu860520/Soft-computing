using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class AlgebraicProductOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Algebraic Product T-norm ";

        public override double Evaluate(double a, double b)
        {
            return a * b;
        }
    }
}
