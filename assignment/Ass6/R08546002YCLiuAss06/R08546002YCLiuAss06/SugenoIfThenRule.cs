using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class SugenoIfThenRule
    {
        FuzzySet[] antecedents; // 前項
        int conclusion;
        public double FiringStrength { get; set; } = 0.0;

        public SugenoIfThenRule(FuzzySet[] intputs, int output)
        {
            antecedents = intputs;
            conclusion = output;
        }

        public double CrispInCrispyOutInferencing(double[] conditinos)
        {

            FiringStrength = double.MaxValue;
            // loop throught each antecedent fuzzy set
            for (int i = 0; i < antecedents.Length; i++)
            {
                double d = antecedents[i].GetMembershipDegree(conditinos[i]);  
                if (d < FiringStrength) FiringStrength = d;
            }          
           return GetOutputValue(conditinos, conclusion);
        }

        public double GetOutputValue(double[] inputs, int equationID)
        {
            switch (equationID)
            {
                case 0: // Y=0.1X+6.4
                    return 0.1 * inputs[0] + 6.4;
                case 1: // Y=-0.5X+4
                    return -0.5 * inputs[0] + 4;
                case 2: // Y=X-2
                    return inputs[0] - 2;
                case 3: // Z=-X+Y+1
                    return -inputs[0] + inputs[1] + 1;
                case 4: // Z=-Y+3
                    return -inputs[1] + 3;
                case 5: // Z=-X+3
                    return -inputs[0] + 3;
                case 6: // Y=X+Y+2
                    return inputs[0] + inputs[1] + 2;
            }
            return 0.0;
        }
    }
}
