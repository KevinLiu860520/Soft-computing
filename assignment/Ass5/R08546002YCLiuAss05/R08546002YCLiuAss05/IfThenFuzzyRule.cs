using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss05
{
    class IfThenFuzzyRule
    {
        FuzzySet[] antecedents;
        FuzzySet conclusion;

        public IfThenFuzzyRule(FuzzySet[] intputs, FuzzySet output)
        {
            antecedents = intputs;
            conclusion = output;
        }

        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditinos, bool isCut = true)
        {
            // fault-proof
            //
            double fireValue = double.MaxValue;
            // loop throught each antecedent fuzzy set
            for (int i = 0; i < antecedents.Length; i++)
            {
                double maxDegree;
                if (antecedents[i].TheUniverse != conditinos[i].TheUniverse)
                {
                    return null;
                }
                FuzzySet f = (antecedents[i] & conditinos[i]);
                maxDegree = f.MaxDegree;
                if (maxDegree < fireValue) fireValue = maxDegree;
            }
            if (isCut)
                return fireValue - conclusion;
            else
                return fireValue * conclusion;
        }
    }
}
