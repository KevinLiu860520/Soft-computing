using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    abstract class BinaryFSOperator
    {
        protected static Random rnd = new Random();
        // properties       
        public virtual string Title { get => ""; }
        // data
        protected double[] parameters;

        //events
        public event EventHandler ParameterChanged;

        // 
        // public virtual double Evaluate(double a) { throw new Exception("No implemented"); }
        public abstract double Evaluate(double a, double b); // two fuzzy set

        protected void FireParameterChangedEvent()
        {
            if (ParameterChanged != null) ParameterChanged(this, null);
        }
    }
}
