using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss02
{
    class SigmoidFunction
    {
        // Define parameters as a private array of double type
        private double[] parameters;

        // Define the list of parameter names as a public static array of string type (LeftPoint, PeakPoint, RightPoint)
        public static string[] parameterNames = new string[2] { "Slope", "Center" }; // initialized

        // constuctors, define parameter input
        public SigmoidFunction(double Slope, double Center)
        {
            parameters = new double[2];
            parameters[0] = Slope;
            parameters[1] = Center;
        }

        public double GetFunctionValue(double x)// logic of this Function
        {
            double y;
            y = 1 / (1 + Math.Exp(-(parameters[0]) * (x - parameters[1])));
            return y;
        }
    }
}
