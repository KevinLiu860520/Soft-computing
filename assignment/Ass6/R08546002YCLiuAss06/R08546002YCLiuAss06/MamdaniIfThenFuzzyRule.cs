using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss06
{
    class MamdaniIfThenFuzzyRule
    {           
        FuzzySet[] antecedents;
        FuzzySet conclusion;
        // For weightedAverage requirement
        public double FiringStrength { get; set; } = 0.0;

        public MamdaniIfThenFuzzyRule(FuzzySet[] intputs, FuzzySet output)
        {
            antecedents = intputs;
            conclusion = output;
        }
        // Mamdani use
        public FuzzySet FuzzyInFuzzyOutInferencing(FuzzySet[] conditinos, bool isCut = true)
        {
            FiringStrength = 0.0;
            // fault-proof
            //
            FiringStrength = double.MaxValue;
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
                if (maxDegree < FiringStrength) FiringStrength = maxDegree;
            }
            if (isCut)
                return FiringStrength - conclusion;
            else
                return FiringStrength * conclusion;
        }

        public FuzzySet CrispInFuzzyOutInferencing(double[] Crispconditions, bool isCut = true)
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
            if (isCut)
                return FiringStrength - conclusion;
            else
                return FiringStrength * conclusion; 
        }

        //public double FuzzyInCrispOutInferencing(FuzzySet[] conditions)
        //{
        //    if(! conclusion.IsMonotomic )return double.NaN;
        //    //FiringStrength = ?
        //    //conclusion.GetUniverseValueforADegree() ?
        //    return 0.0;
        //}
    }
}
