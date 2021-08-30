using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public enum CrossoverType { PMX, OX, POX, Oss, occc }
    public enum MutationType { Swap, xxx }
    public class PermutationGASolver : GeneticAlgorithm<int>
    {
        int[] temp;
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.PMX;
        public MutationType MutationOperator { set; get; } = MutationType.Swap;
        public PermutationGASolver(int numberOfVaribles, OptimizationType type, ObjectiveFunction<int> theMethod)
            : base(numberOfVaribles, type, theMethod)
        {
            temp = new int[numberOfVaribles];
        }
        public override void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            // assign chromosomes[childIdx], ...
            for (int i = 0; i < numberOfGenes; i++)
            {
                chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
            }
            switch (CrossoverOperator)
            {
                case CrossoverType.PMX:
                    break;
                case CrossoverType.OX:
                    break;

            }
        }

        public override void MutateAChild(int parentIdx, int childIdx)
        {
            for (int i = 0; i < numberOfGenes; i++)
                chromosomes[childIdx][i] = chromosomes[parentIdx][i];
            switch (MutationOperator)
            {
                case MutationType.Swap:
                    int pos1 = randomizer.Next(numberOfGenes);
                    int pos2 = randomizer.Next(numberOfGenes);
                    do pos2 = randomizer.Next(numberOfGenes); while (pos2 == pos1);
                    int temp = chromosomes[childIdx][pos1];
                    chromosomes[childIdx][pos1] = chromosomes[childIdx][pos2];
                    chromosomes[childIdx][pos1] = temp;
                    break;
            }
        }
    }
}
