using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class UnaryOperatedFuzzySet : FuzzySet
    {
        static int count = 0;
        UnaryFSOperator theOperator;
        FuzzySet theFS;

        [Category("Parameters"), TypeConverter(typeof(ExpandableObjectConverter))]
        public UnaryFSOperator TheOperator { get => theOperator; }


        public override void SaveFile(StreamWriter sw)
        {
            // call parent
            sw.WriteLine($"FuzzySetType:{this.GetType().Name}");
            theOperator.SaveFile(sw);
            sw.WriteLine($"OpperandHashCode:{theFS.GetHashCode()}");

            // Same as parent  FS
            sw.WriteLine($"OriginHashCode:{this.GetHashCode()}");
            sw.WriteLine($":Title: {title}");
        }

        public override void ReadFile(StreamReader sr)
        {
            string[] items;
            items = sr.ReadLine().Split(':');
            title = items[2];
            // no parameter
        }

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
            if (ShowSeries) UpdateSeriesDataPoints();
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
