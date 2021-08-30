using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class ExtremelyOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Extremely ";
        public override double Evaluate(double a)
        {
            return Math.Pow(a, 8);
        }
    }
}
