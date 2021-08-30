using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class NegateOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Not ";
        [Category("Parameters"), Description("This is negative operator.")]
        public override double Evaluate(double a)
        {
            return 1.0 - a;
        }
    }
}
