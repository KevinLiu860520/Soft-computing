﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class StepDownFuzzySet : FuzzySet
    {
        public override double MaxDegree => 1.0;
        public override double COACrispValue => parameters[0];
        public override double BOACrispValue => parameters[0];
        public override double MOMCrispValue => parameters[0];
        public override double LOMCrispValue => parameters[0];
        public override double SOMCrispValue => parameters[0];
        static int count = 0;

        //properties
        [Category("MemberFunctionParameter"), Description("The right of StepDown function."), DisplayName("Right")]
        public double Right
        {
            set
            {
                if (value <= theUniverse.Maximum && value >= parameters[1]) parameters[0] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[0];
            }
        }
        [Category("MemberFunctionParameter"), Description("The left of StepDown function."), DisplayName("Left")]
        public double Left
        {
            set
            {
                if (value <= parameters[0] && value >= theUniverse.Minimum) parameters[1] = value;
                UpdateSeriesDataPoints();
                FireParameterChangedEvent();
            }
            get
            {
                return parameters[1];
            }
        }

        [Browsable(false)]
        //public override string Core => $"{theUniverse.Title} = {parameters[2]}";
        public StepDownFuzzySet(Universe u) : base(u) // 繼承base
        {
            parameters = new double[2];
            // initialized 
            parameters[1] = (theUniverse.Maximum + theUniverse.Minimum) / 2 - Math.Round(randomizer.NextDouble(), 2) * (theUniverse.Maximum + theUniverse.Minimum) / 2; ; ;
            parameters[0] = (theUniverse.Maximum + theUniverse.Minimum) / 2 + Math.Round(randomizer.NextDouble(), 2) * (theUniverse.Maximum + theUniverse.Minimum) / 2; ; ;
            title = $"StepDown FS {++count}";
        }

        public override double GetMembershipDegree(double x)
        {
            double y;
            if (x >= parameters[0])
            {
                y = 0;
            }
            else
            {
                if (x <= parameters[0] && x >= parameters[1])
                {
                    y = 1 - (x - parameters[1]) / (parameters[0] - parameters[1]);
                }
                else
                {
                    y = 1;
                }
            }
            return y;
        }
    }
}