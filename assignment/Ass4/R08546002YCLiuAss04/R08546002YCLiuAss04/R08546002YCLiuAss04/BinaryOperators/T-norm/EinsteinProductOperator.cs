using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class EinsteinProductOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Einstein Product T-norm ";

        public override double Evaluate(double a, double b)
        {
            return (a * b) / (2 - (a + b - a * b));
        }
    }
}
