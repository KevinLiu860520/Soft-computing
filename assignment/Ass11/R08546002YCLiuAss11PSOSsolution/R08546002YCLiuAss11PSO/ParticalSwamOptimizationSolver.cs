using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss11PSO
{
    public enum OptimizationType { Minimization,Maximization};
    public delegate double ObjectiveFunction(double[] solution);
    class ParticalSwamOptimizationSolver
    {
        Random rnd = new Random();
        // data file
        double[][] solutions;
        double[][] SelflBestSolutions;
        double[] SelfBestObj;
        int iterationLimit = 200;
        int BestPosition = -1;
        int numberOfVariables = 10;
        ObjectiveFunction obj;
        double[] Lower;
        double[] Upper;
        protected OptimizationType optimizationtype = OptimizationType.Minimization;
        double[] soFarTheBestSolution;
        int numberOfParticles = 40;
        double[] ObjectiveValues;
        double soFarTheBestObjective;
        double cognitionFactor = 0.5;
        double socialFactor = 0.5;
        double iterationAverageObj;
        double iterationBestObj;

        // properties
        [Browsable(false)]
        public int IterationCount { set; get; } = 0;
        [Browsable(false)]
        public double[][] Solutions { get => solutions; }
        [Category("PSO Setting"), Description("Number of particles employed.")]
        public int NumberOfParticles
        {
            get => numberOfParticles;
            set
            {
                if (value > 2) numberOfParticles = value;
            }
        }
        [Category("PSO Setting"), Description("Factor for local postitions of each particle.")]
        public double CognitionFactor
        {
            get => cognitionFactor;
            set
            {
                if (value >= 0) cognitionFactor = value;
            }
        }
        [Category("PSO Setting"), Description("Factor for global postition among all particles.")]
        public double SocialFactor
        {
            get => socialFactor;
            set
            {
                if (value >= 0) socialFactor = value;
            }
        }

        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value >= 10) iterationLimit = value;
            }
        }
        [Browsable(false)]
        public double SoFarTheBestObjective { get => soFarTheBestObjective;}
        [Browsable(false)]
        public double IterationAverageObj { get => iterationAverageObj;}
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double[] SoFarTheBestSolution { get => soFarTheBestSolution;}

        public ParticalSwamOptimizationSolver(int numberOfvariables,
            OptimizationType optimizationType,double[] lowerBounds, double[] upperBounds,ObjectiveFunction objFunction)
        {
            numberOfVariables = numberOfvariables;
            Lower = lowerBounds;
            Upper = upperBounds;
            obj = objFunction;
            optimizationtype = optimizationType;
            soFarTheBestSolution = new double[numberOfvariables];
        }
        internal void Reset()
        {
            solutions = new double[NumberOfParticles][];
            for (int i = 0; i < NumberOfParticles; i++)
                solutions[i] = new double[numberOfVariables];
            ObjectiveValues = new double[NumberOfParticles];

            SelflBestSolutions = new double[numberOfParticles][];
            for (int i = 0; i < numberOfParticles; i++)
                SelflBestSolutions[i] = new double[numberOfVariables];
            SelfBestObj = new double[numberOfParticles];
            InitializeNumberOfParticlesSolutions();
            IterationCount = 0;
        }
        private void InitializeNumberOfParticlesSolutions()
        {
            for(int i =0; i<numberOfParticles;i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    solutions[i][j] = Lower[j] + rnd.NextDouble() * (Upper[j] - Lower[j]);
                    SelflBestSolutions[i][j] = solutions[i][j];
                }
                ObjectiveValues[i] = obj(solutions[i]);
                SelfBestObj[i] = ObjectiveValues[i];
            }
            // initialize best sol & obj
            if (optimizationtype == OptimizationType.Minimization)
            {
                soFarTheBestObjective = double.MaxValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    if (ObjectiveValues[i] < soFarTheBestObjective)
                    {
                        BestPosition = i;
                        soFarTheBestObjective = ObjectiveValues[i];                       
                    }
                }
            }
            else  //OptimizationType.Maximization
            {
                soFarTheBestObjective = double.MinValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    if (ObjectiveValues[i] > soFarTheBestObjective)
                    {
                        BestPosition = i;
                        soFarTheBestObjective = ObjectiveValues[i];                       
                    }
                }
            }
            for (int i = 0; i < numberOfVariables; i++)
            {
                soFarTheBestSolution[i] = SelflBestSolutions[BestPosition][i];
            }
        }
        public void RunOneIteratioin()
        {
            MoveParticlesToNewPositions();
            ComputeObjectiveValueAndUpdateSoFarTheBest();
            IterationCount++;
        }

        private void MoveParticlesToNewPositions()
        {
            for (int i = 0; i < numberOfParticles; i++)
            {
                double alpha = cognitionFactor * rnd.NextDouble();
                double beta = socialFactor * rnd.NextDouble();
                for (int j = 0; j < numberOfVariables; j++)
                {
                    double tempPosition = solutions[i][j] + alpha * (SelflBestSolutions[i][j] - solutions[i][j]) + beta * (soFarTheBestSolution[j] - solutions[i][j]);
                    if (tempPosition > Upper[j])solutions[i][j] = Upper[j];
                    else if (tempPosition < Lower[j]) solutions[i][j] = Lower[j];
                    else
                        solutions[i][j] = tempPosition;
                }
            }
        }
        private void ComputeObjectiveValueAndUpdateSoFarTheBest()
        {
            // compute obj & iAvg
            iterationAverageObj = 0.0;
            for (int i = 0; i < numberOfParticles; i++)
            {
                ObjectiveValues[i] = obj(solutions[i]);
                iterationAverageObj += ObjectiveValues[i];
            }
            //update iterationAverageObjectiveValue
            iterationAverageObj /= numberOfParticles;

            if (optimizationtype == OptimizationType.Maximization) // Maximization
            {
                iterationBestObj = double.MinValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    // update each particle best
                    if (ObjectiveValues[i] > SelfBestObj[i])
                    {
                        SelfBestObj[i] = ObjectiveValues[i];
                        for (int j = 0; j < numberOfVariables; j++)
                        {
                            SelflBestSolutions[i][j] = solutions[i][j];
                        }                          
                    }
                    // update iteration best
                    if (ObjectiveValues[i] > iterationBestObj)
                    {
                        BestPosition = i;
                        iterationBestObj = ObjectiveValues[i];
                    }
                }
                // update so far the best
                if (iterationBestObj > soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        soFarTheBestSolution[j] = SelflBestSolutions[BestPosition][j];
                    }
                }
            }
            else // Minimization
            {
                iterationBestObj = double.MaxValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    // update each particle best
                    if (ObjectiveValues[i] < SelfBestObj[i])
                    {
                        SelfBestObj[i] = ObjectiveValues[i];
                        for (int j = 0; j < numberOfVariables; j++)
                        {
                            SelflBestSolutions[i][j] = solutions[i][j];
                        }
                    }
                    // update iteration best
                    if (ObjectiveValues[i] < iterationBestObj)
                    {
                        BestPosition = i;
                        iterationBestObj = ObjectiveValues[i];
                    }
                }
                // update so far the best
                if (iterationBestObj < soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        soFarTheBestSolution[j] = SelflBestSolutions[BestPosition][j];
                    }
                }
            }
        }
        public void RunToEnd()
        {
            do
            {
                RunOneIteratioin();
            }
            while (IterationCount < iterationLimit);
        }
    }
}
