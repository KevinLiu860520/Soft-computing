using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss05
{
    class FuzzySet
    {
        // operator overloaded
        /*public static FuzzySet operator !(FuzzySet fs)
        {
            UnaryFSOperator op = new NegateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        public static FuzzySet operator -(FuzzySet fs)
        {
            UnaryFSOperator op = new ValueCutOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }

        //* for intersection binary operation
        public static FuzzySet operator *(FuzzySet leftFs, FuzzySet rightFs)
        {
            return null;
        }*/
        // Unary operator overloaded
        public override string ToString()
        {
            return Title;
        }
        // Negate
        public static FuzzySet operator !(FuzzySet fs)
        {
            NegateOperator op = new NegateOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }
        // ValueCut
        public static FuzzySet operator -(double cutValue, FuzzySet fs)
        {
            ValueCutOperator op = new ValueCutOperator();
            op.CutValue = cutValue;
            return new UnaryOperatedFuzzySet(fs, op);
        }
        // ValueScale
        public static FuzzySet operator *(double ScaleValue, FuzzySet fs)
        {
            ValueScaleOperator op = new ValueScaleOperator();
            return new UnaryOperatedFuzzySet(fs, op);
        }
        // Concentration
        public static FuzzySet operator +(FuzzySet operand)
        {
            ConcentrationOperator op = new ConcentrationOperator();
            return new UnaryOperatedFuzzySet(operand, op);

        }
        // Extremely
        public static FuzzySet operator ++(FuzzySet operand)
        {
            ExtremelyOperator op = new ExtremelyOperator();
            return new UnaryOperatedFuzzySet(operand, op);
        }
        //Dilation
        public static FuzzySet operator --(FuzzySet operand)
        {
            DilationOperator op = new DilationOperator();
            return new UnaryOperatedFuzzySet(operand, op);
        }
        // Intensify
        public static FuzzySet operator ~(FuzzySet operand)
        {
            UnaryFSOperator op = new IntensificationOperator();
            return new UnaryOperatedFuzzySet(operand, op);
        }
        // Binary Operators
        // Intersection 
        public static FuzzySet operator &(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new IntersectionOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Union
        public static FuzzySet operator |(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new UnionOperaotr();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Algebraic Product
        public static FuzzySet operator <(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new AlgebraicProductOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Algebraic Sum
        public static FuzzySet operator >(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new AlgebraicSumOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Bounded Product
        public static FuzzySet operator <=(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new BoundedProductOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Bounded Sum
        public static FuzzySet operator >=(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new BoundedSumOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Drastic Product
        public static FuzzySet operator %(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new DrasticProductOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }
        // Drastic Sum
        public static FuzzySet operator ^(FuzzySet left, FuzzySet right)
        {
            BinaryFSOperator op = new DrasticSumOperator();
            return new BinaryOperatedFuzzySet(left, right, op);
        }

        //protected：not public for anywhere, but son and grandson can use
        protected double[] parameters; // for each function's parameter
        protected string title;
        protected Random randomizer = new Random(); // create random funcion's varible

        protected Universe theUniverse; // create Universe
        protected Series theSeries; // create Series
        public event EventHandler FS_ParameterChanged; // event

        public void FireParameterChangedEvent() // if parameter changed, event happened
        {
            if (FS_ParameterChanged != null)
                FS_ParameterChanged(this, null);
        }
        public virtual double MaxDegree
        {
            get
            {
                // initiate maxDegree Variable
                double maxDegree = 0.0;

                if (theSeries == null)
                {
                    //theSeries = new Series(Title);
                    //theSeries.ChartType = SeriesChartType.Line;
                    //// Update Series Data Points
                    //UpdateSeriesDataPoints();
                }
                // traverse each DataPoint of the series
                else
                {
                    for (int i = 0; i < theSeries.Points.Count; i++)
                    {
                        if (theSeries.Points[i].YValues[0] > maxDegree)
                        {
                            maxDegree = theSeries.Points[i].YValues[0];
                        }
                    }
                }
        
                return maxDegree;
            }
        }
        [Browsable(false)]
        public Universe TheUniverse { get => theUniverse; }

        [Browsable(false)]
        public Series TheSeries { get => theSeries; set => theSeries = value; } // for delete buttom

        [Category("Property")]
        public bool ShowSeriers //DisplaySeries
        {
            set
            {
                // if showSeries is true, prepare series
                if (value)
                {
                    if (theSeries == null) // if not series, new one series
                    {
                        theSeries = new Series(Title);
                        theSeries.ChartType = SeriesChartType.Line;
                        UpdateSeriesDataPoints();
                        // Add this series to chart via universe
                        theUniverse.AddASeriesofFuzzySet(theSeries);
                    }
                }
                else
                {
                    if (theSeries != null) theSeries = null;
                }
            }
            get
            {
                return theSeries == null ? false : true;
            }
        }

        [Category("Property")]
        public string Title
        {
            get => title;
            set
            {
                title = value;
                //update series's title
                if (theSeries != null)
                {
                    theSeries.Name = value;
                }
            }
        }

        protected void UpdateSeriesDataPoints() // update your series
        {
            if (theSeries == null) return;

            theSeries.Points.Clear(); // I think it can be taken off (useless here)
            double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1); // set the increment for x
            for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + deltaX)
            {
                double y;
                y = GetMembershipDegree(x);
                theSeries.Points.AddXY(x, y);
            }
        }

        public virtual double GetMembershipDegree(double x)
        {
            return 0;
        }
        [Browsable(false)]
        public virtual string Core { get => ""; }
        public FuzzySet(Universe u)
        {
            theUniverse = u;
            // subscribe ParameterChanged Event
            u.ParameterChanged += Universe_ParameterChanged;
        }

        private void Universe_ParameterChanged(object sender, EventArgs e)
        {
            if (ShowSeriers) UpdateSeriesDataPoints();
        }
    }
}

