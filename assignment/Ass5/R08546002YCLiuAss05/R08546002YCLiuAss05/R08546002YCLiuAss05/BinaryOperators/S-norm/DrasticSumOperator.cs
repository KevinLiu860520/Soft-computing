using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class DrasticSumOperator : BinaryFSOperator
    {
        [Browsable(false)]
        public override string Title => "Drastic Sum S-norm ";
        public override double Evaluate(double a, double b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                if (a == 0)
                {
                    return b;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
