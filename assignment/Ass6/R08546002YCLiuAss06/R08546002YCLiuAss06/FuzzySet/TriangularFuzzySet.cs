using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class TriangularFuzzySet : FuzzySet
    {
        public override double MaxDegree => 1.0;
        public override double COACrispValue => parameters[0];
        public override double BOACrispValue => parameters[0];
        public override double MOMCrispValue => parameters[0];
        public override double LOMCrispValue => parameters[0];
        public override double SOMCrispValue => parameters[0];
        static int count = 0;
        
        //properties
        //Attributes
        [Category("MemberFunctionParameter"), Description("The left of triangular function."), DisplayName("Left")]
        public double Left
        {
            set
            {
                if (value >= theUniverse.Minimum && value < Peak) parameters[0] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The peak of triangular function."), DisplayName("Peak")]
        public double Peak
        {
            set
            {
                if (value > Left && value < Right) parameters[1] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[1];
            }
        }
        [Category("MemberFunctionParameter"), Description("The right of triangular function."), DisplayName("Right")]
        public double Right
        {
            set
            {
                if (value > Peak && value <= theUniverse.Maximum) parameters[2] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[2];
            }
        }


        [Browsable(false)]
        public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public TriangularFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[3];
            // initialized 
            parameters[0] = 3;
            parameters[1] = 4;
            parameters[2] = 5;
            title = $"Triangular FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x <= parameters[0])
            {
                y = 0;
            }
            else
            {
                if (x >= parameters[0] && x <= parameters[1])
                {
                    y = (x - parameters[0]) / (parameters[1] - parameters[0]);
                }
                else
                {
                    if (x >= parameters[1] && x <= parameters[2])
                    {
                        y = (parameters[2] - x) / (parameters[2] - parameters[1]);
                    }
                    else
                    {
                        y = 0;
                    }
                }
            }
            return y;
        }
    }
}
