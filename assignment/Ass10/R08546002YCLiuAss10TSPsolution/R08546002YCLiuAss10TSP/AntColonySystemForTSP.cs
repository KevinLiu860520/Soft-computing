using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss10TSP
{
    delegate double ObjectiveFunction(int[] s);
    public enum OptimizationType { Minimization, Maximization }
    public enum PheromoneDrop { StepWise, TrailWise }
    class AntColonySystemForTSP
    {
        Random rnd = new Random();
        protected OptimizationType optimizationType = OptimizationType.Minimization;
        protected PheromoneDrop pheromoneDrop = PheromoneDrop.StepWise;
        int numberOfAnts = 40;
        [Category("Execution"), Description("Iteration limit or Stopping condition.")]
        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value > 0) iterationLimit = value; 
            }
        }
        [Category("ACS Setting"), Description("Number of ants employed")]
        public int NumberOfAnts
        {
            get => numberOfAnts;
            set
            {
                if (value > 2) numberOfAnts = value;
            }
        }
        [Category("ACS Setting"), Description("Initial pheromone values.")]
        public double InitialPheromoneValue
        {
            get
            {
                return initialPheromoneValue;
            }
            set
            {
                if (value > 0) initialPheromoneValue = value;
            }
        }
        double initialPheromoneValue = 0.01;
        [Browsable(false)]
        public int IterationCount { set; get; } = 0;
        double evaporationRate = 0.001;
        int numberOfCities;
        public int[][] solutions;
        double[] ObjectiveValues;
        ObjectiveFunction objective;
        public double[,] pheromoneMap;
        double[,] heuristicValues;
        double fitnessSum;
        double alpha = 2.0;
        double beta = 3.0;
        double soFarTheBestObjective;
        double deterministicThresh = 0.7;
        int[] soFarTheBestSolution;
        int iterationLimit = 100;
        [Browsable(false)]
        public double IterationBestObjective { get; set; }
        [Browsable(false)]
        public double IterationAverageObjective { get; set; }
        bool[] cityAvailable;
        int[] availableCityIDs;
        double[] fitness;
        [Category("ACS Setting"), Description("Percentage of using deterministic selection.")]
        public double DeterministicThresh
        {
            get => deterministicThresh;
            set
            {
                if (value >= 0 && value <= 1) deterministicThresh = value;
            }
        }
        internal void Reset()
        {
            solutions = new int[NumberOfAnts][];
            for (int i = 0; i < NumberOfAnts; i++)
                solutions[i] = new int[numberOfCities];
            ObjectiveValues = new double[numberOfAnts];
            // randomly initialize pheromone table
            for (int r = 0; r < numberOfCities; r++)
                for (int c = 0; c < numberOfCities; c++)
                    pheromoneMap[r, c] = InitialPheromoneValue;
            // randomly initialize solutions
            for (int i = 0; i < NumberOfAnts; i++)
            {
                for (int c = 0; c < numberOfCities; c++)
                    solutions[i][c] = c;
                ShuffleIntegerArray(solutions[i]);
            }
            IterationCount = 0;
            if (optimizationType == OptimizationType.Maximization)
                soFarTheBestObjective = double.MinValue;
            else
                soFarTheBestObjective = double.MaxValue;
        }

        private void ShuffleIntegerArray(int[] vs)
        {
            for (int i = 0; i < numberOfCities; i++)
            {
                vs[i] = i;
            }
            for (int j = numberOfCities - 1; j > 0; j--)
            {
                //swap交換
                int pos = rnd.Next(j + 1);
                int temp = vs[pos];
                vs[pos] = vs[j];
                vs[j] = temp;
            }
        }

        public AntColonySystemForTSP(int numberOfCities, ObjectiveFunction obj, double[,] fromToDistance)
        {
            this.numberOfCities = numberOfCities;
            soFarTheBestSolution = new int[this.numberOfCities];
            pheromoneMap = new double[numberOfCities, numberOfCities];
            heuristicValues = new double[numberOfCities, numberOfCities];
            for (int r = 0; r < numberOfCities; r++)
                for (int c = 0; c < numberOfCities; c++)
                    if (r == c) heuristicValues[r, c] = 1e10;
                    else heuristicValues[r, c] = 1.0 / fromToDistance[r, c];
            cityAvailable = new bool[numberOfCities];
            availableCityIDs = new int[numberOfCities];
            fitness = new double[numberOfCities];
            objective = obj;

            //for (int i = 0; i < numberOfCities; i++)
            //    soFarTheBestSolution[i] = i;
            //soFarTheBestSolution = TSPBenchmark.TSPBenchmarkProblem.GetGreedyShortestRoute();
        }

        internal void RunOneIteration()
        {
            EachAntCountructionItsSolution();
            ComputeObjectiveValueAndUpdateSoFarTheBest();
            UpdatePheromoneMap();
            IterationCount ++;
        }

        private void UpdatePheromoneMap()
        {
            // solutions[ACIIEncoding]
            // update  so far the best solution pheromone
            int fid, tid;
            fid = SoFarTheBestSolution[0];
            for (int i = 0; i < numberOfCities; i++)
            {
                tid = soFarTheBestSolution[i];
                pheromoneMap[fid, tid] += evaporationRate;
                fid = tid;
            }
        }
        private void ComputeObjectiveValueAndUpdateSoFarTheBest()
        {
            double objSum = 0;
            int antIndex = 0;
            for (int i = 0; i < NumberOfAnts; i++)
            {
                ObjectiveValues[i] = objective(solutions[i]);
                objSum += ObjectiveValues[i];
            }
            //update so far compute average
            IterationAverageObjective = objSum / NumberOfAnts;
            //update iteration best
            if (optimizationType == OptimizationType.Minimization) //OptimizationType.Minimization
            {
                IterationBestObjective = double.MaxValue;
                for (int i = 0; i < NumberOfAnts; i++)
                {
                    if (ObjectiveValues[i] < IterationBestObjective)
                    {
                        IterationBestObjective = ObjectiveValues[i];
                        antIndex = i;
                    }
                }
                if (IterationBestObjective < SoFarTheBestObjective)
                {
                    soFarTheBestObjective = IterationBestObjective;
                    for (int i = 0; i < numberOfCities; i++)
                    {
                        soFarTheBestSolution[i] = solutions[antIndex][i];
                    }
                }
            }
            else //OptimizationType.Maximization
            {
                for (int i = 0; i < NumberOfAnts; i++)
                {
                    IterationBestObjective = double.MinValue;
                    if (ObjectiveValues[i] > IterationBestObjective)
                    {
                        IterationBestObjective = ObjectiveValues[i];
                        antIndex = i;
                    }
                }
                if (IterationBestObjective > SoFarTheBestObjective)
                {
                    soFarTheBestObjective = IterationBestObjective;
                    for (int i = 0; i < numberOfCities; i++)
                    {
                        soFarTheBestSolution[i] = solutions[antIndex][i];
                    }
                }
            }
        }

        private void EachAntCountructionItsSolution()
        {
            int numberCandidate = numberOfCities;
            int currentCityID;
            for (int i = 0; i < NumberOfAnts; i++)
            {
                for (int j = 0; j < numberOfCities; j++) availableCityIDs[j] = j;
                int pos = rnd.Next(numberOfCities);
                currentCityID = availableCityIDs[pos];
                availableCityIDs[pos] = availableCityIDs[numberCandidate - 1];
                solutions[i][0] = currentCityID;

                // step count
                for (int s = 1; s < numberOfCities; s++)
                {
                    numberCandidate--;
                    pos = -1;
                    double maxFit = double.MinValue;
                    fitnessSum = 0;
                    for (int j = 0; j < numberCandidate; j++)
                    {
                        // compute relative probability for each candidate
                        int candidateID = availableCityIDs[j];
                        fitness[j] = Math.Pow(pheromoneMap[currentCityID, candidateID], alpha) *
                                Math.Pow(heuristicValues[currentCityID, candidateID], beta);
                        fitnessSum += fitness[j];
                        if (fitness[j] > maxFit)
                        {
                            pos = j;
                            maxFit = fitness[j];
                        }
                    }
                    double r = rnd.NextDouble();
                    int nextCityID = -1;
                    if (r >= DeterministicThresh)
                    {
                        //stochastic
                        fitness[0] = fitness[0] / fitnessSum;
                        for (int j = 1; j < numberCandidate; j++)
                        {
                            fitness[j] = fitness[j] / fitnessSum + fitness[j - 1];
                        }
                        double q = rnd.NextDouble();
                        for (int j = 0; j < numberCandidate; j++)
                        {
                            if (fitness[j] > q)
                            {
                                nextCityID = availableCityIDs[j];
                                solutions[i][s] = nextCityID;
                                availableCityIDs[j] = availableCityIDs[numberCandidate - 1];
                                break;
                            }
                        }
                    }
                    else
                    {
                        //deterministic
                        nextCityID = availableCityIDs[pos];
                        solutions[i][s] = nextCityID;
                        availableCityIDs[pos] = availableCityIDs[numberCandidate - 1];
                    }
                    // add pheromone if segement pheromone dropping is enabled.
                    if (pheromoneDrop == PheromoneDrop.StepWise)
                    {
                        pheromoneMap[currentCityID, availableCityIDs[nextCityID]] = pheromoneMap[pos, availableCityIDs[nextCityID]] * (1 - evaporationRate)
                        + InitialPheromoneValue * evaporationRate;
                    }
                    currentCityID = nextCityID;
                }
                numberCandidate = numberOfCities;
            }
        }
        public void RunToEnd()
        {
            do
            {
                RunOneIteration();
            }
            while (IterationCount < iterationLimit);
        }
        [Browsable(false)]
        public int[] SoFarTheBestSolution
        {
            get => soFarTheBestSolution;
            //set => soFarTheBestSolution = value; 
        }
        [Browsable(false)]
        public double SoFarTheBestObjective
        {
            get => soFarTheBestObjective;
            //set => soFarTheBestObjective = value; 
        }
        [Category("ACS Setting"), Description("It is suggested to be 0.1.")]
        public double EvaporationRate
        {
            get => evaporationRate;
            set
            {
                if (value >= 0 && value <= 1) evaporationRate = value;
            }
        }
        [Category("ACS Setting"), Description("Power with pheromone value. It is suggested to be greater than 1.")]
        public double Alpha
        {
            get => alpha;
            set
            {
                if (value >= 0) alpha = value;
            }
        }
        [Category("ACS Setting"), Description("Power with heuristic value. It is suggested to be greater than 1.")]
        public double Beta
        {
            get => beta;
            set
            {
                if (value >= 0) beta = value;
            }
        }
    }
}
