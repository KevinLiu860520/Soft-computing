using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class TsukamotoIfThenRule
    {
        FuzzySet[] antecedents; 
        FuzzySet conclusion;
        public double FiringStrength { get; set; } = 0.0;

        public TsukamotoIfThenRule(FuzzySet[] intputs, FuzzySet output)
        {
            antecedents = intputs;
            conclusion = output;
        }
        public double CrispInCrispOutInferencing(double[] Crispconditions)
        {
            FiringStrength = 0.0;
            // fault-proof
            //
            FiringStrength = double.MaxValue;
            // loop throught each antecedent fuzzy set
            for (int i = 0; i < antecedents.Length; i++)
            {
                double f = antecedents[i].GetMembershipDegree(Crispconditions[i]);
                if (f < FiringStrength) FiringStrength = f;
            }
            return FiringStrength * conclusion.GetUniverseValueforADegree(FiringStrength);
        }

    }
}
