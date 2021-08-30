using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    class DrasticProductOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Drastic Product T-norm ";

        public override double Evaluate(double a, double b)
        {
            if (b == 1)
            {
                return a;
            }
            else
            {
                if (a == 1)
                {
                    return b;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
