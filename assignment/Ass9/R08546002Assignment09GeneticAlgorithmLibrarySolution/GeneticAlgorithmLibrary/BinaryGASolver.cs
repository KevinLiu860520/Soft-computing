using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public class BinaryGASolver : GeneticAlgorithm<byte>
    {
        
        public enum CrossoverType {OnePointCut, TwoPointCut}
        [Category("Binary GA setting")]
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.OnePointCut;
        /// <summary>
        /// This is the constructor of creating a binary-coded GA Solver
        /// </summary>
        /// <param name="numberOfVaribles"> Number of variables in the Optimization Problem </param>
        /// <param name="type"> Optimization type: maximization or miniimization. </param>
        /// <param name="theMethod"> The objective function delegate </param>
        public BinaryGASolver(int numberOfVaribles,OptimizationType type ,ObjectiveFunction<byte> theMethod) 
            : base(numberOfVaribles , type, theMethod)
        {

        }
        int numberOfCuts = 1;
        [Category("Binary GA setting"), Description("Default point cut. Onlt 1 and 2.")]
        public int CrossoverPointCuts
        {
            get
            {
                if (CrossoverOperator.ToString() == "OnePointCut")
                {
                    numberOfCuts = 1;
                }
                else if (CrossoverOperator.ToString() == "TwoPointCut")
                {
                    numberOfCuts = 2;
                }
                return numberOfCuts;
            }

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
        public override void MutateAChild(int parentIdx, int childIdx, List<int> geneLocation)
        {
            for (int j = 0; j < numberOfGenes; j++)
            {
                if (geneLocation.Contains(j))  //list功能
                    chromosomes[childIdx][j] = chromosomes[parentIdx][j] == 1 ? (byte)0 : (byte)1;
                else
                    chromosomes[childIdx][j] = chromosomes[parentIdx][j];
            }
        }
        public override void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            switch (CrossoverOperator)
            {
                case CrossoverType.OnePointCut:
                    int pos = randomizer.Next(numberOfGenes);
                    for (int j = 0; j < numberOfGenes; j++)
                    {
                        if (j < pos)
                        {
                            chromosomes[child1Idx][j] = chromosomes[fatherIdx][j];
                            chromosomes[child2Idx][j] = chromosomes[motherIdx][j];
                        }
                        else 
                        {
                            chromosomes[child1Idx][j] = chromosomes[motherIdx][j];
                            chromosomes[child2Idx][j] = chromosomes[fatherIdx][j];
                        }
                    }
                    break;
                case CrossoverType.TwoPointCut:
                    int[] position = new int[numberOfCuts];
                    for (int i = 0; i < numberOfCuts; i++)
                    {
                        position[i] = randomizer.Next(numberOfGenes);
                    }
                    Array.Sort(position);
                    for (int j = 0; j < numberOfGenes; j++) 
                    {
                        for (int i = 1; i < numberOfCuts; i++)
                        {
                            if (j >= position[i - 1] && j < position[i])
                            {
                                chromosomes[child1Idx][j] = chromosomes[fatherIdx][j];
                                chromosomes[child2Idx][j] = chromosomes[motherIdx][j];
                            }
                            else
                            {
                                chromosomes[child1Idx][j] = chromosomes[fatherIdx][j];
                                chromosomes[child2Idx][j] = chromosomes[motherIdx][j];
                            }
                        }
                    }
                    break;
            }
        }
    }
}
