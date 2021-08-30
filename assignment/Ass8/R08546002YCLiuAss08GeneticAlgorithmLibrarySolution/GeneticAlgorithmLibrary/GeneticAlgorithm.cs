using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{
    public enum OptimizationType { Minimization, Maximization }
    public enum SelectionType { Deterministic, Stochastic, Hybrid }
    public delegate double ObjectiveFunction<S>(S[] solution);
    public class GeneticAlgorithm<T>
    {
        protected OptimizationType optimizationType = OptimizationType.Minimization;
        protected Random randomizer = new Random();
        protected T[][] chromosomes;
        protected double[] objectiveValues;
        protected double[] fitnessValues;
        protected T[] soFarTheBestSolution;
        private double soFarTheBestObjectiveValue;
        double iterationAverageObj;
        double iterationBestObj;
        int iterationCount;

        protected int numberOfGenes; // number of genes in a  chromosome 
        protected int populationSize = 100;
        protected double crossoverRate = 0.8;
        protected bool isGeneBasedMutation = true;
        protected bool isMinimization = true;
        protected double mutationRate = 0.05; // gene-based chromosome-based

        protected int numberOfCrossoveredChildren;
        protected int numberOfMutatedChildren;
        protected T[][] selectedChromosomes;
        protected double[] selectedObjectives;
        protected int[] indices;

        protected ObjectiveFunction<T> theObjectiveEvalutaionMethod;
        public GeneticAlgorithm(int numberOfVariables, OptimizationType type, ObjectiveFunction<T> theMethod)
        {
            optimizationType = type;
            numberOfGenes = numberOfVariables;
            soFarTheBestSolution = new T[numberOfGenes];
            theObjectiveEvalutaionMethod = theMethod;
        }
        public SelectionType SelectionMode { set; get; } = SelectionType.Deterministic;
        public int PopulationSize
        {
            get => populationSize;
            set
            {
                if (value > 1.0)
                {
                    populationSize = value;
                }
            }
        }
        public double CrossoverRate
        {
            get => crossoverRate;
            set
            {
                if (value > 1.0)
                    crossoverRate = 1.0;
                else if (value > 0)
                    crossoverRate = value;
            }
        }
        protected int iterationLimit = 100;
        public int IterationLimit
        {
            set
            {
                if (value > 0) iterationLimit = value;
            }
            get => iterationLimit;
        }
        [Browsable(false)]
        public int IterationCount { get => iterationCount; }
        double iterationBestObjective, iterationAverageObjective;
        public double IterationBestObjective { get => iterationBestObjective; }
        public double IterationAverageObjective { get => iterationAverageObjective; }
        protected double SoFarTheBestObjectiveValue { get => soFarTheBestObjectiveValue; }

        public

        bool Reset()
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

            // ....
            iterationCount = 0;
            return true;
        }

        public virtual bool InitializePopulation()
        {
            throw new NotImplementedException();
        }



        bool RunOneIterarion()
        {
            performCrossoverOperation();
            performMutationOperation();
            performSelectionOperation();
            updateSoFarTheBestObjectiveAndSolution();
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
                    Array.Sort(fitnessValues, indices, 0, limit);
                    Array.Reverse(indices, 0, limit);
                    break;
                case SelectionType.Stochastic:
                    break;
            }
            // gene-wise copy selected chromosomes to selected chromosome
            for (int r = 0; r < populationSize; r++)
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
            for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;)
                fitnessValues[i] = objectiveValues[i];
        }

        private void updateSoFarTheBestObjectiveAndSolution()
        {
            iterationAverageObjective = 0.0;
            iterationBestObj = optimizationType ==
                OptimizationType.Maximization ? double.MinValue : double.MaxValue;
            // check objectives calculate average, iteration best
            int limit = populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren;
            for (int i = 0; i < populationSize + numberOfCrossoveredChildren + numberOfMutatedChildren; i++)
            {
                iterationAverageObjective += objectiveValues[i];

            }
            iterationAverageObjective /= limit;

            // if new so far the best solution happens
            // gene-wise copy the chromosome value to soFarTheBestSolution
        }

        private void performMutationOperation()
        {
            if (isGeneBasedMutation)
            {
                // preprocessing
                int pid = 0, cid = 0;
                int[] pos = null;
                MutateAChild(pid, pos, cid);
            }
            else
            {
                // chromosome-based
                numberOfMutatedChildren = (int)(populationSize * mutationRate);
                if (numberOfMutatedChildren > populationSize) numberOfMutatedChildren = populationSize;
                ShuffleAnIntegerArray(indices, PopulationSize);
                int ChildIdx = populationSize + numberOfCrossoveredChildren;
                for (int i = 0; i < numberOfMutatedChildren; i++)
                {
                    MutateAChild(indices[i], ChildIdx);
                    objectiveValues[ChildIdx] = theObjectiveEvalutaionMethod(chromosomes[ChildIdx]);
                    ChildIdx++;
                }
            }
        }
        public virtual void MutateAChild(int parentIdx, int[] geneLocations, int childIdx)
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
                CrossoverAPairOfChildren(indices[p], indices[p + 1], child1Idx, child2Idx);
                objectiveValues[child1Idx] = theObjectiveEvalutaionMethod(chromosomes[child1Idx]);
                objectiveValues[child2Idx] = theObjectiveEvalutaionMethod(chromosomes[child2Idx]);
                child1Idx += 2;
                child2Idx += 2;
            }
        }

        public virtual void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int childIdx, int child2Idx)
        {
            throw new Exception("No implementation");
        }

        bool RunToEnd()
        {
            return true;
        }

        void ShuffleAnIntegerArray(int[] a, int len)
        {
            for (int i = 0; i < len; i++) a[i] = i;
            for (int c = len - 1; c > 1; c--)
            {
                int pos = randomizer.Next(c + 1);
                int temp = a[c];
                a[c] = a[pos];
                a[pos] = temp;
            }
        }
    }
}
