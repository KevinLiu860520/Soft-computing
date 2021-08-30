using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss02
{
    class BellFunction
    {
        // Define parameters as a private array of double type
        private double[] parameters;

        // Define the list of parameter names as a public static array of string type (LeftPoint, PeakPoint, RightPoint)
        public static string[] parameterNames = new string[3] { "Width", "Slope", "Center" }; // initialized

        // constuctors, define parameter input
        public BellFunction(double Width, double Slope, double Center)
        {
            parameters = new double[3];
            parameters[0] = Width;
            parameters[1] = Slope;
            parameters[2] = Center;
        }

        public double GetFunctionValue(double x) // logic of this Function
        {
            double y;
            y = 1 / (1 + Math.Pow(Math.Abs((x - parameters[2]) / parameters[0]), 2 * parameters[1]));
            return y;
        }
    }
}
