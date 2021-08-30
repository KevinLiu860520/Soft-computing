using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public class RealNumberGASolver : GeneticAlgorithm<double>
    {
        private int[] numberOfCuts = new int[1];
        private bool[] selectedGene;
        private double[] lowerBounds;
        private double[] upperBounds;
        public double degreeOfNonuniformity = 2;  //dynamic mutation(uniform)
        public enum CrossoverType { Convex, Affine, Linear, LargeValueDivided, SmallValueDivided, MiddleAndOneEndSegments, TwoEndSegments, FowardAndBackwardMiddleSegments }
        [Category("RealNumber GA setting")]
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.Convex;
        public RealNumberGASolver(int numberOfVaribles, OptimizationType type, ObjectiveFunction<double> theMethod, double[] lower, double[] upper)
            : base(numberOfVaribles, type, theMethod)
        {
            lowerBounds = lower;
            upperBounds = upper;
            selectedGene = new bool[numberOfGenes];
        }

        [Category("RealNumber GA setting"), Description("Number of point cuts.")]
        public int NumberOfCuts
        {
            get => numberOfCuts.Length;
            set
            {
                if (value == numberOfCuts.Length) return;
                numberOfCuts = new int[value];
            }
        }
        public override bool InitializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
            {
                for (int c = 0; c < numberOfGenes; c++)
                {
                    chromosomes[r][c] = lowerBounds[c] + randomizer.NextDouble() * (upperBounds[c] - lowerBounds[c]); // set real number in genes
                }
            }              
            return true;
        }
        [Category("RealNumber GA setting"), Description("Parameter determines degree of nonuniformity \n value between 0 and 10.")]
        public double DegreeOfNonuniformity
        {
            get => degreeOfNonuniformity;
            set
            {
                if (value <= 10 && value >= 0) degreeOfNonuniformity = value;
            }
            
        }
        // generate crossover
        public override void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            for (int i = 0; i < numberOfCuts.Length; i++) // define cut point position
                numberOfCuts[i] = randomizer.Next(numberOfGenes);
            Array.Sort(numberOfCuts); // sort cut array
            bool crossoverPoint = false; // crossover point set true, or false
            int cutPoint = 0;
            for (int i = 0; i <= numberOfCuts.Length; i++)
            {
                // individually select each cut point to set up crossoverPoint = true/false
                // If run to end cut point, cutPointposition = gene.length to let last cut point to last gene be judged. 
                int cutPointposition = i >= numberOfCuts.Length ? numberOfGenes : numberOfCuts[i];
                for (int j = cutPoint; j < cutPointposition; j++)
                    selectedGene[j] = crossoverPoint; // odd cut point is false, even is true
                crossoverPoint = !crossoverPoint;
                cutPoint = cutPointposition; // change cut point position
            }
            for (int i = 0; i < numberOfGenes; ++i) // observed by gene 
            {
                if (selectedGene[i])
                {
                    switch (CrossoverOperator)
                    {
                        case CrossoverType.Convex: // alpha + beta = 1 and alpha & beta >=0
                            double Convex_alpha = randomizer.NextDouble();
                            double Convex_beta = 1 - Convex_alpha;
                            chromosomes[child1Idx][i] = Convex_alpha * chromosomes[fatherIdx][i] + Convex_beta * chromosomes[motherIdx][i];
                            chromosomes[child2Idx][i] = Convex_beta * chromosomes[fatherIdx][i] + Convex_alpha * chromosomes[motherIdx][i];
                            continue;

                        case CrossoverType.Affine: // alpha + beta = 1 , I set alpha between -1 and 1. 
                            double Affine_alpha = 2 * randomizer.NextDouble() - 1;
                            double Affine_beta = 1 - Affine_alpha;
                            chromosomes[child1Idx][i] = Affine_alpha * chromosomes[fatherIdx][i] + Affine_beta * chromosomes[motherIdx][i];
                            chromosomes[child2Idx][i] = Affine_beta * chromosomes[fatherIdx][i] + Affine_alpha * chromosomes[motherIdx][i];
                            continue;

                        case CrossoverType.Linear: // alpha &  beta belongs to Real. I set both between -1 and 1.
                            double Linear_alpha = 2 * randomizer.NextDouble() - 1;
                            double Linear_beta = 2 * randomizer.NextDouble() - 1;
                            chromosomes[child1Idx][i] = Linear_alpha * chromosomes[fatherIdx][i] + Linear_beta * chromosomes[motherIdx][i];
                            chromosomes[child2Idx][i] = Linear_beta * chromosomes[fatherIdx][i] + Linear_alpha * chromosomes[motherIdx][i];
                            continue;

                        case CrossoverType.LargeValueDivided:
                            // if father's gene <= mother's gene, max = mother's, or else
                            double LVD_max = chromosomes[fatherIdx][i] <= chromosomes[motherIdx][i] ? chromosomes[motherIdx][i] : chromosomes[fatherIdx][i];
                            double LVD_alpha = randomizer.NextDouble();
                            double LVD_beta = 1.0 - LVD_alpha; // 1 - alpha
                            chromosomes[child1Idx][i] = LVD_alpha * lowerBounds[i] + LVD_beta * LVD_max;
                            chromosomes[child2Idx][i] = LVD_alpha * LVD_max + LVD_beta * upperBounds[i];
                            continue;

                        case CrossoverType.SmallValueDivided:
                            // if father's gene <= mother's gene, min = father's, or else
                            double SVD_min = chromosomes[fatherIdx][i] <= chromosomes[motherIdx][i] ? chromosomes[fatherIdx][i] : chromosomes[motherIdx][i];
                            double SVD_alpha = randomizer.NextDouble();
                            double SVD_beta = 1.0 - SVD_alpha; // 1 - alpha
                            chromosomes[child1Idx][i] = SVD_alpha * lowerBounds[i] + SVD_beta * SVD_min;
                            chromosomes[child2Idx][i] = SVD_alpha * SVD_min + SVD_beta * upperBounds[i];
                            continue;

                        case CrossoverType.MiddleAndOneEndSegments:
                            double MOES_max;
                            double MOES_min;
                            if (chromosomes[fatherIdx][i] > chromosomes[motherIdx][i])
                            {
                                MOES_max = chromosomes[fatherIdx][i];
                                MOES_min = chromosomes[motherIdx][i];
                            }
                            else
                            {
                                MOES_max = chromosomes[motherIdx][i];
                                MOES_min = chromosomes[fatherIdx][i];
                            }
                            double MOES_alpha = randomizer.NextDouble();
                            double MOES_beta = 1.0 - MOES_alpha;
                            chromosomes[child1Idx][i] = MOES_alpha * MOES_min + MOES_beta * MOES_max;
                            if (randomizer.NextDouble() > 0.5)
                                chromosomes[child2Idx][i] = MOES_alpha * MOES_max + MOES_beta * upperBounds[i];
                            else
                                chromosomes[child2Idx][i] = MOES_alpha * lowerBounds[i] + MOES_beta * MOES_min;
                            continue;

                        case CrossoverType.TwoEndSegments:
                            double TES_max;
                            double TES_min;
                            if (chromosomes[fatherIdx][i] > chromosomes[motherIdx][i])
                            {
                                TES_max = chromosomes[fatherIdx][i];
                                TES_min = chromosomes[motherIdx][i];
                            }
                            else
                            {
                                TES_max = chromosomes[motherIdx][i];
                                TES_min = chromosomes[fatherIdx][i];
                            }
                            double TES_alpha = randomizer.NextDouble();
                            double TES_beta = 1.0 - TES_alpha;
                            chromosomes[child1Idx][i] = TES_alpha * lowerBounds[i] + TES_beta * TES_min;
                            chromosomes[child2Idx][i] = TES_alpha * TES_max + TES_beta * upperBounds[i];
                            continue;

                        case CrossoverType.FowardAndBackwardMiddleSegments:
                            double FBMS_max;
                            double FBMS_min;
                            if (chromosomes[fatherIdx][i] > chromosomes[motherIdx][i])
                            {
                                FBMS_max = chromosomes[fatherIdx][i];
                                FBMS_min = chromosomes[motherIdx][i];
                            }
                            else
                            {
                                FBMS_max = chromosomes[motherIdx][i];
                                FBMS_min = chromosomes[fatherIdx][i];
                            }
                            double FBMS_alpha = randomizer.NextDouble();
                            double FBMS_beta = 1.0 - FBMS_alpha;
                            chromosomes[child1Idx][i] = FBMS_alpha * FBMS_min + FBMS_beta * FBMS_max;
                            chromosomes[child2Idx][i] = FBMS_alpha * FBMS_max + FBMS_beta * FBMS_min;
                            continue;
                    }
                }
                else
                {
                    chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                    chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
                }
            }
        }
        public override void MutateAChild(int parentIdx, int childIdx)
        {
            for (int i = 0; i < numberOfGenes; i++)
            {
                chromosomes[childIdx][i] = chromosomes[parentIdx][i];
            }
            double Randomterm = randomizer.NextDouble();
            int position = randomizer.Next(numberOfGenes);

            if (Randomterm > 0.5)
            {
                chromosomes[childIdx][position] = chromosomes[parentIdx][position] +
                    randomizer.NextDouble() * (upperBounds[position] - chromosomes[parentIdx][position]) * Math.Pow((1 - (iterationCount / iterationLimit)), degreeOfNonuniformity);
            }
            else
            {
                chromosomes[childIdx][position] = chromosomes[parentIdx][position] -
                    randomizer.NextDouble() * (chromosomes[parentIdx][position] - lowerBounds[position]) * Math.Pow((1 - (iterationCount / iterationLimit)), degreeOfNonuniformity);
            }
            if(chromosomes[childIdx][position] > upperBounds[position])
            {
                chromosomes[childIdx][position] = upperBounds[position];
            }
            else if (chromosomes[childIdx][position] < lowerBounds[position])
            {
                chromosomes[childIdx][position] = lowerBounds[position];
            }
        }
    }
}
