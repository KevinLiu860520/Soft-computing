using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss00
{
    abstract class UnaryFSOperator
    {
        protected static Random rnd = new Random(); // set random function
        // properties
        public virtual string Title { get => ""; }
        // data
        protected double[] parameters;


        //events
        public event EventHandler ParameterChanged; // event 
        protected void FireParameterChangedEvent()
        {
            if (ParameterChanged != null)
                ParameterChanged(this, null);
        }

        // 
        // public virtual double Evaluate(double a) { throw new Exception("No implemented"); }
        public abstract double Evaluate(double a);
    }
}
