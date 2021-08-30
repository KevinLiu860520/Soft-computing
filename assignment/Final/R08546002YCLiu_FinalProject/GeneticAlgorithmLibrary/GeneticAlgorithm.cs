using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{    
    public enum OptimizationType { Minimization, Maximization}
    public enum SelectionType {Deterministic, Stochastic}
    public delegate double ObjectiveFunction<S>(S[] solution);
    public class GeneticAlgorithm<T>
    {
        protected OptimizationType optimizationType = OptimizationType.Minimization;
        protected Random randomizer = new Random();
        public T[][]chromosomes;
        protected double[] objectiveValues;
        protected double[] fitnessValues;
        protected T[] soFarTheBestSolution;
        protected double soFarTheBestObjectiveValue;
        protected double iterationAverageObj;
        protected double iterationBestObj;
        protected int iterationBestIdx;
        protected int iterationCount;
        protected int iterationLimit = 500;
        protected int numberOfPositions;
        protected int numberOfGenes; // number of genes in a  chromosome 
        protected int populationSize = 100;
        protected double crossoverRate = 0.8;
        protected bool isGeneBasedMutation = false;
        protected bool isMinimization = true;
        protected double mutationRate = 0.05; // gene-based chromosome-based
        protected double leastfitnessfraction = 0.25;

        protected int numberOfCrossoveredChildren;
        protected int numberOfMutatedChildren;
        protected T[][] selectedChromosomes;
        protected double[] selectedObjectives;
        protected int[] indices;
        protected int[] mutatedPositions;

        protected ObjectiveFunction<T> theObjectiveEvalutaionMethod;
        public GeneticAlgorithm(int numberOfVariables,OptimizationType type, ObjectiveFunction<T> theMethod)
        {
            optimizationType = type;
            numberOfGenes = numberOfVariables;
            soFarTheBestSolution = new T[numberOfGenes];
            theObjectiveEvalutaionMethod = theMethod;
            mutatedPositions = new int[numberOfVariables];
        }
        //properties
        [Category("GA Selection Setting"), Description("Select Operation mode")]
        public SelectionType SelectionMode { set; get; } = SelectionType.Deterministic;
        [Category("GA setting"), Description("Initialize # of chromosomes. It need to larger than 1/4 # of variables")]
        public int PopulationSize 
        {
            get => populationSize;
            set
            {
                if(value > 1.0)
                {
                    populationSize = value;
                }
            }
        }
        [Category("GA setting"), Description("Crossover rate is suggested between 0.5 and 0.9.")]
        public double CrossoverRate 
        {
            get => crossoverRate;
            set
            {
                if (value > 1.0)
                    crossoverRate = 1.0;
                else if (value >0)
                    crossoverRate = value;
            }
        }
        [Category("GA setting"), Description("Mutation rate is suggested between 0.01 and 0.1.")]
        public double MutationRate
        {
            get => mutationRate;
            set
            {
                if (value > 1.0)
                    mutationRate = 1.0;
                else if (value > 0)
                    mutationRate = value;
            }
        }
        //[Category("GA setting"), Description("The upper bound condition of evolution.")]
        [Browsable(false)]
        public int IterationLimit
        {
            set
            {
                if (value > 0) iterationLimit = value;
            }
            get => iterationLimit;
        }
        [Category("Valid"), Description("Check current iterationCount.")]
        public int IterationCount { get => iterationCount; }
        double iterationBestObjective, iterationAverageObjective;
        [Browsable(false)]
        public double IterationBestObjective { get => iterationBestObjective; }
        [Browsable(false)]
        public double IterationAverageObjective { get => iterationAverageObjective; }
        [Browsable(false)]
        public double SoFarTheBestObjectiveValue { get => soFarTheBestObjectiveValue;}
        [Browsable(false)]
        public T[] SoFarTheBestSolution { get => soFarTheBestSolution; }
        [Browsable(false)]
        public T[][] Chromosomes { get => chromosomes; }



        public bool Reset()
        {
            // allocate memory
            chromosomes = new T[populationSize * 3][];
            for (int i = 0; i < chromosomes.Length; i++)
                chromosomes[i] = new T[numberOfGenes];
            objectiveValues = new double[populationSize * 3];
            fitnessValues = new double[populationSize * 3];

            selectedChromosomes = new T[populationSize][];
            for (int i = 0; i < selectedChromosomes.Length; i++)
                selectedChromosomes[i] = new T[numberOfGenes];
            selectedObjectives = new double[populationSize];

            indices = new int[populationSize * 3];
            // randomly assign initail gene values
            InitializePopulation();
            //compute objective values
            for (int r = 0; r < populationSize; r++)
                objectiveValues[r] = theObjectiveEvalutaionMethod(chromosomes[r]);

            numberOfCrossoveredChildren = 0;
            numberOfMutatedChildren = 0;

            iterationCount = 0;

            if (optimizationType == OptimizationType.Maximization)
            {
                iterationBestObj = double.MinValue;
                for (int i = 0; i > populationSize; i++)
                {
                    if (objectiveValues[i] > iterationBestObj)
                    {
                        iterationBestObj = objectiveValues[i];
                        soFarTheBestObjectiveValue = objectiveValues[i];
                        soFarTheBestSolution = chromosomes[i];
                    }
                }
            }
            if (optimizationType == OptimizationType.Minimization)
            {
                iterationBestObj = double.MaxValue;
                for (int i = 0; i < populationSize; i++)
                {
                    if (objectiveValues[i] < iterationBestObj)
                    {
                        iterationBestObj = objectiveValues[i];
                        soFarTheBestObjectiveValue = objectiveValues[i];
                        soFarTheBestSolution = chromosomes[i];
                    }
                }
            }
            return true;
        }

        public virtual bool InitializePopulation()
        {
            throw new NotImplementedException();
        }
        public bool RunOneIteration()
        {
            performCrossoverOperation();
            performMutationOperation();
            performSelectionOperation();
            updateSoFarTheBestObjectiveAndSolution();
            iterationCount++;
            return true;
        }

        private void performSelectionOperation()
        {
            // calculate fitness
            CalculateFitnessValues();
            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            switch (SelectionMode)
            {
                case SelectionType.Deterministic:
                    for (int i = 0; i < limit; i++)
                        indices[i] = i;
                    Array.Sort(fitnessValues,indices,0,limit);
                    Array.Reverse(fitnessValues, 0, limit);
                    Array.Reverse(indices, 0, limit);
                    break;
                case SelectionType.Stochastic:
                    // Reassign selected ids to indices
                    // aggregate fitness
                    double[] cumulatedfitnessvalue = new double[limit];
                    double fitnessvaluesum = 0;
                    for (int i = 0; i < limit ; i++)
                    {
                        fitnessvaluesum += fitnessValues[i];
                    }
                    cumulatedfitnessvalue[0] = fitnessValues[0] / fitnessvaluesum;
                    for (int i = 1; i < limit; i++)
                    {
                        cumulatedfitnessvalue[i] = cumulatedfitnessvalue[i - 1] + fitnessValues[i] / fitnessvaluesum;
                    }
                    double randomdouble;
                    // execute populationSize stochastic selection
                    for (int i = 0; i < populationSize; i++)
                    {
                        randomdouble = randomizer.NextDouble();
                        for (int j = 0; j < limit; j++)
                        {
                            if (randomdouble <= cumulatedfitnessvalue[j])
                            {
                                indices[i] = j;
                                break;
                            }
                        }
                    }
                    break;
            }
            // gene-wise copy selected chromosomes to selected chromosome
            for(int r = 0; r < populationSize; r++)
            {
                selectedObjectives[r] = objectiveValues[indices[r]];
                for (int c = 0; c < numberOfGenes; c++)
                    selectedChromosomes[r][c] = chromosomes[indices[r]][c];
            }
            // copy back to parent chromosome for the next generation
            for (int r = 0; r < populationSize; r++)
            {
                objectiveValues[r] = selectedObjectives[r];
                for (int c = 0; c < numberOfGenes; c++)
                    chromosomes[r][c] = selectedChromosomes[r][c];
            }
        }

        private void CalculateFitnessValues()
        {
            double omax, omin;
            omax = double.MinValue;
            omin = double.MaxValue;
            for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren; i++)  
            {
                if (objectiveValues[i] > omax) omax = objectiveValues[i]; 
                if (objectiveValues[i] < omin) omin = objectiveValues[i];
            }
            double compareValue = leastfitnessfraction * (omax - omin);
            if (compareValue < 1e-5) compareValue = 1e-5;
            if (optimizationType == OptimizationType.Maximization)
            {
                for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren; i++)
                {
                    fitnessValues[i] = compareValue + objectiveValues[i] - omin;
                }
            }
            else if (optimizationType == OptimizationType.Minimization)
            {
                for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren ; i++)
                {
                    fitnessValues[i] = compareValue + omax - objectiveValues[i];
                }
            }
        }

        private void updateSoFarTheBestObjectiveAndSolution()
        {
            iterationAverageObjective = 0.0;
            iterationBestObj = optimizationType == OptimizationType.Maximization ? double.MinValue : double.MaxValue;
            // check objectives calculate average, iteration best
            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren; i++)
            {
                iterationAverageObjective += objectiveValues[i];
            }
            iterationAverageObjective /= limit;

            // if new so far the best solution happens           
            //update so far the best solution and objective value
            if (optimizationType == OptimizationType.Maximization)
            {
                iterationBestObjective = double.MinValue;
                for (int i = 0; i < limit; i++)
                {
                    if (objectiveValues[i] > iterationBestObjective)
                    {
                        iterationBestObjective = objectiveValues[i];  
                        iterationBestIdx = i;
                    }
                }
                if (iterationBestObjective > soFarTheBestObjectiveValue)
                {
                    soFarTheBestObjectiveValue = iterationBestObjective;
                    // gene-wise copy the chromosome value to soFarTheBestSolution
                    for (int j = 0; j < numberOfGenes; j++)
                    {
                        soFarTheBestSolution[j] = chromosomes[iterationBestIdx][j];
                    }
                }
            }
            else  //OptimizationType.minimization
            {
                iterationBestObjective = double.MaxValue;
                for (int i = 0; i < limit; i++)
                {
                    if (objectiveValues[i] < iterationBestObjective)
                    {
                        iterationBestObjective = objectiveValues[i];  
                        iterationBestIdx = i;
                    }
                }
                if (iterationBestObjective < soFarTheBestObjectiveValue)
                {
                    soFarTheBestObjectiveValue = iterationBestObjective;
                    // gene-wise copy the chromosome value to soFarTheBestSolution
                    for (int j = 0; j < numberOfGenes; j++)
                    {
                        soFarTheBestSolution[j] = chromosomes[iterationBestIdx][j];
                    }
                }
            }
        }
        private void performMutationOperation()
        {
            if (isGeneBasedMutation)
            {
                // gene based
                int all = populationSize * numberOfGenes;
                int num = (int)(all * mutationRate);  
                if (num > indices.Length) num = indices.Length;
                for (int i = 0; i < num; i++)
                {
                    indices[i] = randomizer.Next(all);
                }
                Array.Sort(indices, 0, num);  

                //indices contains locations of genes to be mutated
                numberOfMutatedChildren = 0;
                int cid = populationSize + numberOfCrossoveredChildren - 1;
                List<int> geneLocation = new List<int>();
                for (int i = 0; i < populationSize; i++)
                {
                    geneLocation.Clear();
                    for (int j = 0; j < num; j++)
                    {
                        //parent i cannot be mutated
                        if (indices[j] / numberOfGenes != i) continue;
                        else if (indices[j] / numberOfGenes == i)
                        {
                            if (geneLocation.Count == 0)
                            {
                                numberOfMutatedChildren++;
                                cid++;
                            }
                            geneLocation.Add(indices[j] % numberOfGenes);
                            MutateAChild(i, cid, geneLocation);
                            objectiveValues[cid] = theObjectiveEvalutaionMethod(chromosomes[cid]);
                        }
                    }
                }

            }
            else
            {
                // chromosome-based
                numberOfMutatedChildren = (int)(populationSize * mutationRate);
                if (numberOfMutatedChildren > populationSize) numberOfMutatedChildren = populationSize;
                ShuffleAnIntegerArray(indices, PopulationSize);

                int ChildIdx = populationSize + numberOfCrossoveredChildren;
                for(int i =0;i<numberOfMutatedChildren; i++)
                {
                    MutateAChild(indices[i],ChildIdx);
                    objectiveValues[ChildIdx] = theObjectiveEvalutaionMethod(chromosomes[ChildIdx]);
                    ChildIdx++;
                }
            }
        }
        public virtual void MutateAChild(int parentIdx, int childIdx, List<int> geneLocation)
        {

        }

        public virtual void MutateAChild(int parentIdx, int childIdx)
        {

        }
        private void performCrossoverOperation()
        {
            ShuffleAnIntegerArray(indices, populationSize);
            numberOfCrossoveredChildren = (int)(populationSize * crossoverRate);
            if (numberOfCrossoveredChildren % 2 == 1) numberOfCrossoveredChildren--;
            int child1Idx = populationSize;
            int child2Idx = populationSize + 1;
            for (int p = 0; p < numberOfCrossoveredChildren / 2; p++)
            {
                CrossoverAPairOfChildren(indices[p], indices[p+1], child1Idx, child2Idx );
                objectiveValues[child1Idx] = theObjectiveEvalutaionMethod(chromosomes[child1Idx]);
                objectiveValues[child2Idx] = theObjectiveEvalutaionMethod(chromosomes[child2Idx]);
                child1Idx += 2;
                child2Idx += 2;
            }
        }

        public virtual void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int childIdx, int child2Idx)
        {
            throw new NotImplementedException();
        }
        public virtual bool RunToEnd()
        {
            do RunOneIteration(); while (iterationCount < iterationLimit);
            return true;
        }

        protected void ShuffleAnIntegerArray(int[] a, int len)
        {
            for (int i = 0; i < len; i++) a[i] = i;
            for(int c = len - 1; c > 0; c--)
            {
                int pos = randomizer.Next(c + 1);
                int temp = a[pos];
                a[pos] = a[c];
                a[c] = temp;
            }
        }
    }
}
