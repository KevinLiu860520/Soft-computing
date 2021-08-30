using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class UnaryOperatedFuzzySet : FuzzySet
    {
        static int count = 0;
        UnaryFSOperator theOperator;
        FuzzySet theFS;

        [Category("Parameters"), TypeConverter(typeof(ExpandableObjectConverter))]
        public UnaryFSOperator TheOperator { get => theOperator; }

        public UnaryOperatedFuzzySet(FuzzySet fs, UnaryFSOperator op) : base(fs.TheUniverse)
        {
            theFS = fs; // fuzzt set
            theOperator = op; // operator 
            title = op.Title + fs.Title + $"{++count}"; // new title
            // subscribe events
            theOperator.ParameterChanged += TheFS_ParameterChanged;
        }

        private void TheFS_ParameterChanged(object sender, EventArgs e) // if parameters change, fire event
        {
            if (ShowSeriers) UpdateSeriesDataPoints();
            // fire event
            FireParameterChangedEvent();
        }

        public override double GetMembershipDegree(double x) // get a and then complete  series
        {
            double a = theFS.GetMembershipDegree(x);
            return theOperator.Evaluate(a);
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
