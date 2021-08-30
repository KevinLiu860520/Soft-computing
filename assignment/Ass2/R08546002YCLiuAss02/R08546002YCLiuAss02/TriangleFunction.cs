using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss02
{
    class TriangleFunction
    {
        // Define parameters as a private array of double type
        private double[] parameters;

        // Define the list of parameter names as a public static array of string type (LeftPoint, PeakPoint, RightPoint)
        public static string[] parameterNames = new string[3] { "LeftPoint", "PeakPoint", "RightPoint" }; // initialized

        // constuctors, define parameter input
        public TriangleFunction(double leftpoint, double peakpoint, double rightpoint)
        {
            parameters = new double[3];
            parameters[0] = leftpoint;
            parameters[1] = peakpoint;
            parameters[2] = rightpoint;
        }

        public double GetFunctionValue(double x)// logic of this Function
        {
            double y;
            if (x <= parameters[0])
            {
                y = 0;
            }
            else if (x >= parameters[0] && x <= parameters[1])
            {
                y = (x - parameters[0]) / (parameters[1] - parameters[0]);
            }
            else if (x >= parameters[1] && x <= parameters[2])
            {
                y = (parameters[2] - x) / (parameters[2] - parameters[1]);
            }
            else
            {
                y = 0;
            }
            return y;
        }
    }
}
