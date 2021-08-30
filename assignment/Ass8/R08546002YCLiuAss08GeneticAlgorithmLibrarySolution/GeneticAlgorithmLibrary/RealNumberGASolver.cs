using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public class RealNumberGASolver : GeneticAlgorithm<double>
    {
        double[] LowerBounds;
        double[] UpperBounds;
        public RealNumberGASolver(int numberOfVaribles, double[] lowerBounds, double[] upperBounds, OptimizationType type, ObjectiveFunction<double> theMethod)
            : base(numberOfVaribles, type, theMethod)
        {
            //...
        }
        public override bool InitializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
                for (int c = 0; c < numberOfGenes; c++)
                {
                    chromosomes[r][c] = (byte)randomizer.Next(2);
                }
            return true;
        }
    }
}
