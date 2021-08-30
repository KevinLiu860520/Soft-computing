using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
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

        public virtual void SaveFile(StreamWriter sw)
        {
            if (parameters.Length != 0)
            {
                sw.WriteLine($"OperatorType:{this.GetType().Name}");
                sw.WriteLine($"NumberOfParameters:{parameters.Length}");
                for (int i = 0; i < parameters.Length; i++)
                    sw.WriteLine($"Par{i}:{parameters[i]}");
            }
            else
            {
                sw.WriteLine($"OperatorType:{this.GetType().Name}");
                sw.WriteLine($"NumberOfParameters: 0");
            }
        }

        public virtual void ReadFile(StreamReader sr)
        {
            string[] items;
            items = sr.ReadLine().Split(':');
            int num = Convert.ToInt32(items[1]);
            parameters = new double[num];
            for(int i =0; i <num; i++)
            {
                items = sr.ReadLine().Split(':');
                parameters[i] = Convert.ToDouble(items[1]);
            }
        }
        
        // public virtual double Evaluate(double a) { throw new Exception("No implemented"); }
        public abstract double Evaluate(double a);


    }
}
