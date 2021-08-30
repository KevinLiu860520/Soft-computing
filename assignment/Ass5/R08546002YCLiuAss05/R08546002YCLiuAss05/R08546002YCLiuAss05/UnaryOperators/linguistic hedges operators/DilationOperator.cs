using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class DilationOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "More or less(Dilation) ";
        public override double Evaluate(double a)
        {
            return Math.Pow(a, 0.5);
        }
    }
}
