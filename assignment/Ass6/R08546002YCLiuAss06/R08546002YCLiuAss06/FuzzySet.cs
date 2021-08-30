using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss06
{
    class FuzzySet
    {
        #region OperatorOverloading
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
            return title;
        }
        // Negate
        public static FuzzySet operator !(FuzzySet fs)
        {
            UnaryFSOperator op = new NegateOperator();
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
            op.ScaleValue = ScaleValue;
            return new UnaryOperatedFuzzySet(fs, op);
        }
        // Concentration
        public static FuzzySet operator +(FuzzySet operand)
        {
            UnaryFSOperator op = new ConcentrationOperator();
            return new UnaryOperatedFuzzySet(operand, op);

        }
        // Extremely
        public static FuzzySet operator ++(FuzzySet operand)
        {
            UnaryFSOperator op = new ExtremelyOperator();
            return new UnaryOperatedFuzzySet(operand, op);
        }
        //Dilation
        public static FuzzySet operator --(FuzzySet operand)
        {
            UnaryFSOperator op = new DilationOperator();
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
        #endregion
        //protected：not public for anywhere, but son and grandson can use
        protected double[] parameters; // for each function's parameter
        protected string title;
        protected Random randomizer = new Random(); // create random funcion's varible

        protected Universe theUniverse; // create Universe
        protected Series theSeries; // create Series



        public virtual void SaveFile(StreamWriter sw)
        {
            sw.WriteLine($"FuzzySetType:{this.GetType().Name}");
            sw.WriteLine($"OriginHashCode:{this.GetHashCode()}");
            sw.WriteLine($":Title: {title}");
            sw.WriteLine($":NumberOfParameters: {parameters.Length}");
            if(parameters != null)
            {
                int c = 0;
                foreach (double p in parameters)
                    sw.WriteLine($"Par{c}:{parameters[c++]}");
            }
        }
        public virtual void ReadFile(StreamReader sr)
        {
            string[] items;
            items = sr.ReadLine().Split(':');
            title = items[2];
            int num;
            items = sr.ReadLine().Split(':');
            num = Convert.ToInt32(items[2]);
            parameters = new double[num];
            for(int i =0; i < num; i++)
            {
                items = sr.ReadLine().Split(':');
                parameters[i] = Convert.ToDouble(items[1]);
            }
        }

        public event EventHandler FS_ParameterChanged; // event

        public void FireParameterChangedEvent() // if parameter changed, event happened
        {
            if (FS_ParameterChanged != null)
                FS_ParameterChanged(this, null);
        }
        [Browsable(false)]
        public SeriesChartType TheChartType
        {
            get => theSeries.ChartType;
            set
            {
                theSeries.ChartType = value;  //讓最後result可以更改為shade
            }
        }
        public virtual double MaxDegree
        {
            get
            {
                double maxDegree = 0.0;
                if (theSeries == null)
                {
                    // traverse the range of universe to get the maximum degree
                    double deltaX = (theUniverse.Maximum - theUniverse.Minimum) / (theUniverse.Resolution - 1);
                    for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + deltaX)
                    {
                        double y;
                        y = GetMembershipDegree(x);
                        if (y > maxDegree)
                        {
                            maxDegree = y;
                        }
                    }
                }
                else
                {
                    // traverse each DataPoint of the series
                    for (int i = 0; i < theSeries.Points.Count; i++)
                    {
                        if (theSeries.Points[i].YValues[0] > maxDegree)
                            maxDegree = theSeries.Points[i].YValues[0];
                    }
                }
                return maxDegree;
            }
        }
        [Browsable(false)]
        public Universe TheUniverse { get => theUniverse; }

        [Browsable(false)]
        public Series TheSeries { get => theSeries; set => theSeries = value; } // for delete buttom

        [Browsable(false)]
        public string Legend
        {
            set  // 存取子
            {
                theSeries.LegendText = value;
                title = theSeries.LegendText;   // change legend title
            }
            get  // 存取子
            {
                return title;
            }
        }
        [Category("Property")]
        public bool ShowSeries
        {
            set
            {
                if (value)
                {
                    if (theSeries == null)
                    {
                        theSeries = new Series(Title);
                        theSeries.ChartType = SeriesChartType.Line;
                        theSeries.Legend = theUniverse.s;
                        UpdateSeriesDataPoints();
                        // add this series to chart via univarse
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
                return theSeries == null ? false : true; // 三元運算值
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
        // Support tsukamoto inferencing
        public virtual double GetUniverseValueforADegree(double degree)
        {
            // traverse universe values
            double min = theUniverse.Minimum; double max = theUniverse.Maximum; double x_value;
            if(GetMembershipDegree(min) < GetMembershipDegree(max))
            {
                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y >= degree)
                    {
                        x_value = x;
                        return x_value;
                    }
                   
                }              
            }
            if (GetMembershipDegree(min) > GetMembershipDegree(max))
            {
                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y <= degree)
                    {
                        if (y != degree)
                        {
                            x_value = x - theUniverse.Delta;
                            return x_value;
                        }
                    }
                }
            }
            return 0.0;
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
            throw new NotImplementedException();
        }
        [Browsable(false)]
        public virtual string Core { get => ""; }
        public virtual bool IsMonotomic
        {
            set; get;
        } = false;

        public FuzzySet(Universe u)
        {
            theUniverse = u;
            // subscribe ParameterChanged Event
            u.ParameterChanged += Universe_ParameterChanged;
        }

        private void Universe_ParameterChanged(object sender, EventArgs e)
        {
            if (ShowSeries) UpdateSeriesDataPoints();
        }

        #region DefuzzicationType
        [Browsable(false)]//no show
        //centroid of area
        public virtual double COACrispValue
        {
            get
            {
                double XtimesArea = 0, Area = 0;
                double delta = theUniverse.Delta;
                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + theUniverse.Delta)
                {
                    double PieceOfArea = delta * GetMembershipDegree(x);
                    Area += PieceOfArea;
                    XtimesArea += x * PieceOfArea;
                }       
                return XtimesArea / Area;
            }
        }

        [Browsable(false)]//no show
        //bisector of area
        public virtual double BOACrispValue
        {
            get
            {
                double Area = 0;
                double delta = theUniverse.Delta;
                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + theUniverse.Delta)
                {
                    double PieceOfArea = delta * GetMembershipDegree(x);
                    Area += PieceOfArea;
                }
                double HalfOfArea = Area / 2;
                double BOA = 0; double Z_BOA = 0;
                for (double x = theUniverse.Minimum; x <= theUniverse.Maximum; x = x + theUniverse.Delta)
                {
                    double PieceOfArea = delta * GetMembershipDegree(x);
                    BOA += PieceOfArea;
                    if (BOA > HalfOfArea)
                    {
                        Z_BOA = x;
                        break;
                    }                        
                }
                return Z_BOA;
            }
        }

        [Browsable(false)]//no show
        //mean of maximum
        public virtual double MOMCrispValue
        {
            get
            {
                double theSmallMax = 0;
                for (double x = theUniverse.Minimum; x < theUniverse.Maximum; x += theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y == MaxDegree)
                    {
                        theSmallMax = x;
                        break;
                    }
                }
                double theLargeMax = 0;
                for (double x = theUniverse.Minimum; x < theUniverse.Maximum; x += theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y == MaxDegree)
                    {
                        theLargeMax = x;
                    }
                }
                return (theSmallMax + theLargeMax) / 2;                
            }
        }

        [Browsable(false)]//no show
        //smallest of maximum
        public virtual double SOMCrispValue
        {
            get
            {
                double theSmallMax = 0;
                for (double x = theUniverse.Minimum; x < theUniverse.Maximum; x += theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y == MaxDegree)
                    {
                        theSmallMax = x;
                        break;
                    }
                }
                return theSmallMax;       
            }
        }

        [Browsable(false)]//no show
        //largest of maximum
        public virtual double LOMCrispValue
        {
            get
            {             
                double theLargeMax = 0;
                for (double x = theUniverse.Minimum; x < theUniverse.Maximum; x += theUniverse.Delta)
                {
                    double y = GetMembershipDegree(x);
                    if (y == MaxDegree)
                    {
                        theLargeMax = x;
                    }
                }
                return theLargeMax;              
            }
        }
        #endregion
    }
}

