﻿using System;
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

        public IfThenFuzzyRule(FuzzySet[] inputs, FuzzySet output)
        {
            antecedents = inputs;
            conclusion = output;
        }

        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditions, bool isCut = true)
        {
            // fault-proof
            //
            double fireValue = double.MaxValue;
            //loop through each antecedent fuzzy set
            for (int i = 0; i < antecedents.Length; i++)
            {
                double maxDegree;
                if (antecedents[i].TheUniverse != conditions[i].TheUniverse)
                {
                    return null;
                }
                maxDegree = (antecedents[i] & conditions[i]).MaxDegree;
                if (maxDegree < fireValue) fireValue = maxDegree;
            }
            if (isCut)
                return fireValue - conclusion;
            else
                return fireValue * conclusion;

        }
    }
}
