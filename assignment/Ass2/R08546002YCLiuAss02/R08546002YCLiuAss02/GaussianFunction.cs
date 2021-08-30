using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss02
{
    class GaussianFunction
    {

        // Define parameters as a private array of double type
        private double[] parameters;

        // Define the list of parameter names as a public static array of string type (center, std)
        public static string[] parameterNames = new string[2] {"Center","Standard"+ Environment.NewLine + "Deviation"}; // initialized

        // public string title;
        // static int count = 0;
        // constuctors, define parameter input
        public GaussianFunction(double center, double std)
        {
            parameters = new double[2];
            parameters[0] = center;
            parameters[1] = std;

            // count++;
            // title = $"Gaussian{count}";
        }


        public double GetFunctionValue(double x)// logic of this Function
        {
            double y = Math.Exp(-(Math.Pow(x - parameters[0], 2)) / (2 * (Math.Pow(parameters[1], 2))));
            return y;
        }
    }
}
