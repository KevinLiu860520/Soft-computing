using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiu_FinalProject
{
    class BeetleSwarmOptimizationSolver
    {
        Random rnd = new Random();
        // data file
        double c1;
        double c2;
        double[][] RandomDirectionVector;
        double[][] solutions;
        double lambda = 0.4;
        double[][] SelflBestSolutions;
        double[][] Right_antennae_solutions;
        double[][] Left_antennae_solutions;
        double[][] velocity;
        double[][] incrementalFunction;
        //int velocity_max = 5; // initialize by self
        //int velocity_min = -5;// initialize by self
        double diameterSensing = 5;
        double multiplyConstant = 3;
        double []weight;
        double weight_max = 1; // from paper
        double weight_min = 0.1;
        double eta_step = 0.95;
        double[] SelfBestObj;
        int iterationLimit = 500;
        int BestPosition = -1;
        int numberOfVariables;
        ObjectiveFunction obj;
        double[] Lower;
        double[] Upper;
        protected OptimizationType optimizationtype = OptimizationType.Minimization;
        double[] soFarTheBestSolution;
        int numberOfBeetles = 100;
        double stepSize;
        double[] ObjectiveValues;
        double soFarTheBestObjective;
        double iterationAverageObj;
        double iterationBestObj;
        int iterationCount;
        #region property
        // properties
        [Category("BSO Setting"), Description("Number of beetles employed.")]
        public int NumberOfBeetles
        {
            get => numberOfBeetles;
            set
            {
                if (value > 2) numberOfBeetles = value;
            }
        }
        [Category("BSO Setting"), Description("Ratio between diameterSensing and StepSize\n c * D = Step\n越大隻的天牛步伐越大.")]
        public double MultiplyConstant
        {
            get => multiplyConstant;
            set
            {
                if (value > 0) multiplyConstant = value;
            }
        }
        [Category("BSO Setting"), Description("Sensing length of antennae corresponding to the exploit ability, which should be large enough to cover an appropriate searching area to be cable of jumping out of local minimum points at the beginning and then attenuate as time elapses.")]
        public double DiameterSensing
        {
            get => diameterSensing;
            set
            {
                if (value > 0) diameterSensing = value;
            }
        }
        [Category("BSO Setting"), Description("Step size of searching which accounts for the convergence speed following a decreasing function of t instead of an increasing function or a constant.")]
        public double StepSize
        {
            get => multiplyConstant* diameterSensing;
        }
        //[Category("BSO Setting"), Description("The upper bound condition of evolution.")]
        [Browsable(false)]
        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value >= 10) iterationLimit = value;
            }
        }
        [Category("BSO Setting"), Description("A positive constant belongs to [0,1].\nIt means the weight of speed(PSO) and beetle movement(BAS).")]
        public double Lambda
        {
            get => lambda;
            set
            {
                if (value >= 0 & value <=1) lambda = value;
            }
        }
        [Category("BSO Setting"), Description("Update coefficient with step size.\nThe smaller the value is, the faster the converge speed is.")]
        public double Eta_step
        {
            get => eta_step;
            set
            {
                if (value >= 0 & value <= 1) eta_step = value;
            }
        }
        //[Category("BSO Default"), Description("The upper bound of velocity.")]
        //public double Velocity_max { get => velocity_max; }
        //[Category("BSO Default"), Description("The lower bound of velocity.")]
        //public double Velocity_min { get => velocity_min; }
        [Category("BSO Default"), Description("The upper bound of inertia weight.")]
        public double Weight_max { get => weight_max; }
        [Category("BSO Default"), Description("The lower bound of inertia weight.")]
        public double Weight_min { get => weight_min; }
        [Browsable(false)]
        public double SoFarTheBestObjective { get => soFarTheBestObjective; }
        [Browsable(false)]
        public double IterationAverageObj { get => iterationAverageObj; }
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double[] SoFarTheBestSolution { get => soFarTheBestSolution; }
        [Category("Valid"), Description("Check current iterationCount.")]
        public int IterationCount { get => iterationCount; }
        [Browsable(false)]
        public double[][] Solutions { get => solutions; }

        #endregion
        public BeetleSwarmOptimizationSolver(int numberOfvariables,
            OptimizationType optimizationType, double[] lowerBounds, double[] upperBounds, ObjectiveFunction objFunction)
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
            diameterSensing = 5;
            weight = new double[numberOfVariables];
            stepSize = multiplyConstant * diameterSensing;
            solutions = new double[numberOfBeetles][];
            SelflBestSolutions = new double[numberOfBeetles][];
            velocity = new double[numberOfBeetles][];
            Left_antennae_solutions = new double[numberOfBeetles][];
            Right_antennae_solutions = new double[numberOfBeetles][];
            incrementalFunction = new double[numberOfBeetles][];
            RandomDirectionVector = new double[numberOfBeetles][];
            for (int i = 0; i < numberOfBeetles; i++)
            {
                solutions[i] = new double[numberOfVariables];
                SelflBestSolutions[i] = new double[numberOfVariables];
                velocity[i] = new double[numberOfVariables];
                Left_antennae_solutions[i] = new double[numberOfVariables];
                Right_antennae_solutions[i] = new double[numberOfVariables];
                incrementalFunction[i] = new double[numberOfVariables];
                RandomDirectionVector[i] = new double[numberOfVariables];
            }            
            ObjectiveValues = new double[numberOfBeetles];
            SelfBestObj = new double[numberOfBeetles];
            double[] Distance_randomvector = new double[numberOfBeetles];
            // Random direction vector 
            for (int i = 0; i < NumberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    RandomDirectionVector[i][j] = rnd.Next((int)Lower[j], (int)Upper[j]) * 0.9;
                    Distance_randomvector[i] += RandomDirectionVector[i][j] * RandomDirectionVector[i][j];
                }
            }
            // scale
            for (int i = 0; i < NumberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    double Distance = Math.Sqrt(Distance_randomvector[i]);
                    if (Distance == 0) RandomDirectionVector[i][j] = double.MinValue;//分母為0會是NAN
                    else
                        RandomDirectionVector[i][j] /= Distance;
                }
            }
            // create initial left and right antennae
            for (int i = 0; i < NumberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    Right_antennae_solutions[i][j] = solutions[i][j] + diameterSensing * RandomDirectionVector[i][j]/2;
                    Left_antennae_solutions[i][j] = solutions[i][j] - diameterSensing * RandomDirectionVector[i][j]/2;
                    if (Right_antennae_solutions[i][j] > Upper[j]) Right_antennae_solutions[i][j] = Upper[j];
                    else if (Right_antennae_solutions[i][j] < Lower[j]) Right_antennae_solutions[i][j] = Lower[j];
                    if (Left_antennae_solutions[i][j] > Upper[j]) Left_antennae_solutions[i][j] = Upper[j];
                    else if (Left_antennae_solutions[i][j] < Lower[j]) Left_antennae_solutions[i][j] = Lower[j];
                }
            }
            InitializeSolutions();
            iterationCount = 0;
        }
        private void InitializeSolutions()
        {
            for (int i = 0; i < numberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    solutions[i][j] = (int)Lower[j] + rnd.NextDouble() * (Upper[j] - Lower[j]);
                    SelflBestSolutions[i][j] = solutions[i][j];
                    velocity[i][j] = rnd.Next(-100, 100) * rnd.NextDouble();
                }
                ObjectiveValues[i] = obj(solutions[i]);
                SelfBestObj[i] = ObjectiveValues[i];
            }
            // initialize best sol & obj
            if (optimizationtype == OptimizationType.Minimization)
            {
                soFarTheBestObjective = double.MaxValue;
                for (int i = 0; i < numberOfBeetles; i++)
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
                for (int i = 0; i < numberOfBeetles; i++)
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
            MoveBeetleToNewPosition();
            UpdateSoFarTheBestandParameters();
            iterationCount++;
        }

        private void MoveBeetleToNewPosition()
        {
            //Set inertia weight
            for (int i = 0; i < numberOfVariables; i++)
            {
                weight[i] = weight_max - ((weight_max - weight_min) / IterationLimit) * IterationCount;
            }
            diameterSensing = stepSize / multiplyConstant; // update at second iteration

            // because update antennae needs old velocity, it cannot calculate with below for loop.
            for (int i = 0; i < numberOfBeetles; i++)
            {
                int Decide_direction = Math.Sign(obj(Right_antennae_solutions[i]) - obj(Left_antennae_solutions[i]));
                c1 = 1.3 + 1.2 * Math.Cos(i * Math.PI) / numberOfBeetles; // from paper
                c2 = 2 - 1.2 * Math.Cos(i * Math.PI) / numberOfBeetles;
                for (int j = 0; j < numberOfVariables; j++)
                {
                    // Update the incremental function
                    incrementalFunction[i][j] = stepSize * velocity[i][j] * Decide_direction;
                    // update left and right antennae，這裡的V是舊的，下面更新完才會變新的，不用擔心會用到新的來算
                    Right_antennae_solutions[i][j] = Right_antennae_solutions[i][j] + velocity[i][j] * diameterSensing / 2;
                    Left_antennae_solutions[i][j] = Left_antennae_solutions[i][j] - velocity[i][j] * diameterSensing / 2;
                    if (Right_antennae_solutions[i][j] > Upper[j]) Right_antennae_solutions[i][j] = Upper[j];
                    else if (Right_antennae_solutions[i][j] < Lower[j]) Right_antennae_solutions[i][j] = Lower[j];
                    if (Left_antennae_solutions[i][j] > Upper[j]) Left_antennae_solutions[i][j] = Upper[j];
                    else if (Left_antennae_solutions[i][j] < Lower[j]) Left_antennae_solutions[i][j] = Lower[j];
                    //Update the speed formula
                    velocity[i][j] = weight[j] * velocity[i][j] + c1 * rnd.NextDouble() * (SelflBestSolutions[i][j] - solutions[i][j])
                        + c2 * rnd.NextDouble() * (soFarTheBestSolution[j] - solutions[i][j]);
                    //if (velocity[i][j] > velocity_max) solutions[i][j] = velocity_max; //加這個照理說會更好，但這裡不加會更好，所以不家
                    //else if (velocity[i][j] < velocity_min) solutions[i][j] = velocity_min;
                    //Update the position of the current search agent
                    solutions[i][j] = solutions[i][j] + lambda * velocity[i][j] + (1 - lambda) * incrementalFunction[i][j];
                    if (solutions[i][j] > Upper[j]) solutions[i][j] = Upper[j];
                    else if (solutions[i][j] < Lower[j]) solutions[i][j] = Lower[j];
                }
            }
            stepSize = Eta_step * stepSize + 0.01;
        }
        private void UpdateSoFarTheBestandParameters()
        {
            // compute obj & Avg
            iterationAverageObj = 0.0;
            for (int i = 0; i < numberOfBeetles; i++)
            {
                ObjectiveValues[i] = obj(solutions[i]);
                iterationAverageObj += ObjectiveValues[i];
            }
            //update iterationAverageObjectiveValue
            iterationAverageObj /= numberOfBeetles;

            if (optimizationtype == OptimizationType.Maximization) // Maximization
            {
                iterationBestObj = double.MinValue;
                for (int i = 0; i < numberOfBeetles; i++)
                {
                    // update each beetle best
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
                for (int i = 0; i < numberOfBeetles; i++)
                {
                    // update each beetle best
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
    }
}
