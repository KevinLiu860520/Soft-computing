using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class ValueCutOperator : UnaryFSOperator
    {
        [Browsable(false)]
        public override string Title => $"Value Cut ";

        public ValueCutOperator()
        {
            parameters = new double[1];
            parameters[0] = Math.Round(rnd.NextDouble(), 2);
        }

        // the value  is between 0 and 1 
        [Category("Parameters"), Description("The value must be between 0 and 1.")]
        public double CutValue
        {
            get => parameters[0];
            set
            {
                if (value >= 0 && value <= 1.0)
                {
                    parameters[0] = value;
                    // fire event
                    FireParameterChangedEvent();
                }
            }
        }
        public override double Evaluate(double a)
        {
            return a >= parameters[0] ? parameters[0] : a; //when a >= CutValue ? value = CutValue : or is a
        }
    }
}
