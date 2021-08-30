using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    class BinaryGASolver : GeneticAlgorithm<byte>
    {
        /// <summary>
        /// This is the constructor of creating a binary-coded GA Solver
        /// </summary>
        /// <param name="numberOfVaribles"> Number of variables in the Optimization Problem </param>
        /// <param name="type"> Optimization type: maximization or miniimization. </param>
        /// <param name="theMethod"> The objective function delegate </param>
        public BinaryGASolver(int numberOfVaribles, OptimizationType type, ObjectiveFunction<byte> theMethod)
            : base(numberOfVaribles, type, theMethod)
        {

        }
        public override bool InitializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
                for (int c = 0; c < numberOfGenes; c++)
                {
                    // random give 0 or 1.
                    chromosomes[r][c] = (byte)randomizer.Next(2);
                }
            return true;
        }
    }
}
