using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class BinaryOperatedFuzzySet : FuzzySet
    {
        static int count = 0;

        // data
        BinaryFSOperator theOperator;
        FuzzySet theFirstFS;
        FuzzySet theSecondFS;
        [Category("Parameters"), TypeConverter(typeof(ExpandableObjectConverter))]
        public BinaryFSOperator TheOperator { get => theOperator; }
        public BinaryOperatedFuzzySet(FuzzySet FirstFS, FuzzySet SecondFS, BinaryFSOperator op) : base(FirstFS.TheUniverse)
        {
            theFirstFS = FirstFS;
            theSecondFS = SecondFS;
            // theFirstFS.FS_ParameterChanged += TheFS_ParameterChanged;
            // theSecondFS.FS_ParameterChanged += TheFS_ParameterChanged;
            theOperator = op;
            title = op.Title + FirstFS.Title + "@" + SecondFS.Title + $"_FS{++count}";
            theOperator.ParameterChanged += TheFS_ParameterChanged;
        }

        private void TheFS_ParameterChanged(object sender, EventArgs e)
        {
            if (ShowSeries) UpdateSeriesDataPoints();

            // fire event
            FireParameterChangedEvent();
        }

        public override double GetMembershipDegree(double x) // two fuzzyset 
        {
            double a = theFirstFS.GetMembershipDegree(x);
            double b = theSecondFS.GetMembershipDegree(x);
            return theOperator.Evaluate(a, b);
        }
    }
}
