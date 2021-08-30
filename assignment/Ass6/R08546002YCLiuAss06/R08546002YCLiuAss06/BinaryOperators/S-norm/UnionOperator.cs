using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class UnionOperaotr : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Maximum S-norm ";

        public override double Evaluate(double a, double b)
        {
            return Math.Max(a, b);
        }
    }
}
