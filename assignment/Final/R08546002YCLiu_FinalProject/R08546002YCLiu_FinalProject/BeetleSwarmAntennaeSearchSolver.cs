using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiu_FinalProject
{
    class BeetleSwarmAntennaeSearchSolver
    {
        Random rnd = new Random();
        // data file
        double[][] solutions;
        double[][] temp_solutions;
        double[][] RandomDirectionVector;
        double[][] Right_antennae_solutions;
        double[][] Left_antennae_solutions;
        int iterationLimit = 500;
        int BestPosition = -1;
        int numberOfVariables;
        ObjectiveFunction obj;
        double[] Lower;
        double[] Upper;
        protected OptimizationType optimizationtype = OptimizationType.Minimization;
        double[] soFarTheBestSolution;
        int numberOfBeetles = 100;
        double[] ObjectiveValues;
        double soFarTheBestObjective;
        double multiplyConstant = 3;
        double diameterSensing = 5;
        double stepSize;
        double eta_diameter = 0.95;
        double eta_step = 0.95;
        double probabilitymissBettersolution = 0.2;
        double iterationAverageObj;
        double iterationBestObj;
        int count_restartFindBettersolution = 2;
        int flag_step = 0;
        int iterationCount;
        #region property
        // properties
        [Category("Valid"), Description("Check current iterationCount.")]
        public int IterationCount { get => iterationCount; }
        [Browsable(false)]
        public double[][] Solutions { get => solutions; }
        [Browsable(false)]
        public double[][] Temp_solutions { get => temp_solutions; }
        [Category("BSAS Setting"), Description("Number of beetles employed.")]
        public int NumberOfBeetles
        {
            get => numberOfBeetles;
            set
            {
                if (value > 2) numberOfBeetles = value;
            }
        }
        [Category("BSAS Setting"), Description("Ratio between diameterSensing and StepSize\n c * D = Step\n越大隻的天牛步伐越大.")]
        public double MultiplyConstant
        {
            get => multiplyConstant;
            set
            {
                if (value > 0) multiplyConstant = value;
            }
        }
        [Category("BSAS Setting"), Description("Sensing length of antennae corresponding to the exploit ability, which should be large enough to cover an appropriate searching area to be cable of jumping out of local minimum points at the beginning and then attenuate as time elapses.")]
        public double DiameterSensing
        {
            get => diameterSensing;
            set
            {
                if (value > 0) diameterSensing = value;
            }
        }
        [Category("BSAS Setting"), Description("Step size of searching which accounts for the convergence speed following a decreasing function of t instead of an increasing function or a constant.")]
        public double StepSize
        {
            get => multiplyConstant * diameterSensing;
        }
        [Category("BSAS Setting"), Description("Update coefficient with diameter sensing.\nThe smaller the value is, the faster the converge speed is.")]
        public double Eta_diameter
        {
            get => eta_diameter;
            set
            {
                if (value >= 0 & value <= 1) eta_diameter = value;
            }
        }
        [Category("BSAS Setting"), Description("Update coefficient with step size.\nThe smaller the value is, the faster the converge speed is.")]
        public double Eta_step
        {
            get => eta_step;
            set
            {
                if (value >= 0 & value <= 1) eta_step = value;
            }
        }
        //[Category("BSAS Setting"), Description("The upper bound condition of evolution.")]
        [Browsable(false)]
        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value >= 10) iterationLimit = value;
            }
        }
        [Category("BSAS Setting"), Description("There is a small probability that k beetles will miss the better position(parameters set) for objective function at the current step size.\n不改變參數的前提下，如果機率值越大代表使用者相信有很大的可能會錯過更好的解。")]
        public double ProbabilitymissBettersolution
        {
            get => probabilitymissBettersolution;
            set
            {
                if (value >= 0 & value <= 1) probabilitymissBettersolution = value;
            }
        }
        [Category("BSAS Update Setting"), Description("Remain same parameters to find better solution count in current step again.\n此設定值的下一個值如仍未找到更好的解才會開始更新")]
        public int Count_restartFindBettersolution
        {
            get => count_restartFindBettersolution;
            set
            {
                if (value > 0) count_restartFindBettersolution = value;
            }
        }
        [Browsable(false)]
        public double SoFarTheBestObjective { get => soFarTheBestObjective; }
        [Browsable(false)]
        public double IterationAverageObj { get => iterationAverageObj; }
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double[] SoFarTheBestSolution { get => soFarTheBestSolution; }
        #endregion
        public BeetleSwarmAntennaeSearchSolver(int numberOfvariables,
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
            stepSize = multiplyConstant * diameterSensing;
            count_restartFindBettersolution = 2;
            solutions = new double[numberOfBeetles][];
            temp_solutions = new double[numberOfBeetles][];
            Left_antennae_solutions = new double[numberOfBeetles][];
            Right_antennae_solutions = new double[numberOfBeetles][];
            RandomDirectionVector = new double[numberOfBeetles][];
            for (int i = 0; i < numberOfBeetles; i++)
            {
                solutions[i] = new double[numberOfVariables];
                temp_solutions[i] = new double[numberOfVariables];
                Left_antennae_solutions[i] = new double[numberOfVariables];
                Right_antennae_solutions[i] = new double[numberOfVariables];
                RandomDirectionVector[i] = new double[numberOfVariables];
            }
            ObjectiveValues = new double[numberOfBeetles];
            InitializeSolutions();
            iterationCount = 0;
        }
        private void InitializeSolutions() // 天牛鬚群是以一個點為質心，再去隨機生成k個天牛(方向向量)，因此在Reset部分僅有一個點而非k個。
        {
            for (int i = 0; i < numberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    if (i == 0)
                    {
                        solutions[i][j] = (int)Lower[j] + rnd.NextDouble() * (Upper[j] - Lower[j]);
                    }
                    else
                    {
                        // initial solutions are the same
                        solutions[i][j] = solutions[0][j];
                    }
                }
                ObjectiveValues[i] = obj(solutions[i]);
            }
            // initialize best sol & obj 其實一開始每個解代理人都一樣
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
                soFarTheBestSolution[i] = solutions[BestPosition][i];
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
            // create left and right antennae
            for (int i = 0; i < NumberOfBeetles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    Right_antennae_solutions[i][j] = solutions[i][j] + diameterSensing * RandomDirectionVector[i][j];
                    Left_antennae_solutions[i][j] = solutions[i][j] - diameterSensing * RandomDirectionVector[i][j];
                    if (Right_antennae_solutions[i][j] > Upper[j]) Right_antennae_solutions[i][j] = Upper[j];
                    else if (Right_antennae_solutions[i][j] < Lower[j]) Right_antennae_solutions[i][j] = Lower[j];
                    if (Left_antennae_solutions[i][j] > Upper[j]) Left_antennae_solutions[i][j] = Upper[j];
                    else if (Left_antennae_solutions[i][j] < Lower[j]) Left_antennae_solutions[i][j] = Lower[j];
                }
            }
            // new position
            for (int i = 0; i < NumberOfBeetles; i++)
            {
                int Decide_direction = Math.Sign(obj(Right_antennae_solutions[i]) - obj(Left_antennae_solutions[i]));
                for (int j = 0; j < numberOfVariables; j++)
                {
                    solutions[i][j] = solutions[i][j] + stepSize * RandomDirectionVector[i][j] * Decide_direction;
                    if (solutions[i][j] > Upper[j]) solutions[i][j] = Upper[j];
                    else if (solutions[i][j] < Lower[j]) solutions[i][j] = Lower[j];
                    temp_solutions[i][j] = solutions[i][j];
                }
            }
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
                    if (ObjectiveValues[i] > iterationBestObj)
                    {
                        // update iteration best
                        iterationBestObj = ObjectiveValues[i];
                        BestPosition = i;
                    }
                }
                // update so far the best
                if (iterationBestObj > soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        soFarTheBestSolution[j] = solutions[BestPosition][j];
                    }
                }
                else
                {
                    if (rnd.NextDouble() > probabilitymissBettersolution | flag_step > count_restartFindBettersolution)
                    {
                        diameterSensing = eta_diameter * diameterSensing + 0.01; // 不要讓兩觸角的直徑更新為0，這樣就等於只剩一隻觸角
                        stepSize = Eta_step * stepSize + 0.01; // 不要讓步伐更新為0，這樣位置就無法更新
                        flag_step = 0;
                    }
                    else // 不更新變數再找一次看有沒有更好的解
                    {
                        diameterSensing = diameterSensing;
                        stepSize = stepSize;
                        flag_step += 1;
                    }
                }
                // update next iteration initial position 有勝過sofarthebest更新位置，沒有的話就是舊的BestPosition
                for (int i = 0; i < numberOfBeetles; i++)
                {
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        // initial position is just one and beetles are generated by random direction vector. 
                        solutions[i][j] = solutions[BestPosition][j];
                    }
                }
            }
            else // Minimization
            {
                iterationBestObj = double.MaxValue;
                for (int i = 0; i < numberOfBeetles; i++)
                {
                    if (ObjectiveValues[i] < iterationBestObj)
                    {
                        // update iteration best
                        iterationBestObj = ObjectiveValues[i];
                        BestPosition = i;
                    }
                }
                // update so far the best
                if (iterationBestObj < soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        soFarTheBestSolution[j] = solutions[BestPosition][j];
                    }
                }
                else
                {
                    if (rnd.NextDouble() > probabilitymissBettersolution | flag_step > count_restartFindBettersolution)
                    {
                        diameterSensing = eta_diameter * diameterSensing + 0.01; // 不要讓兩觸角的直徑更新為0，這樣就等於只剩一隻觸角
                        stepSize = Eta_step * stepSize + 0.01; // 不要讓步伐更新為0，這樣位置就無法更新
                        flag_step = 0;
                    }
                    else // 不更新變數再找一次看有沒有更好的解
                    {
                        diameterSensing = diameterSensing;
                        stepSize = stepSize;
                        flag_step += 1;
                    }
                }
                // update next iteration initial position
                for (int i = 0; i < numberOfBeetles; i++)
                {
                    for (int j = 0; j < numberOfVariables; j++)
                    {
                        solutions[i][j] = solutions[BestPosition][j];
                    }
                }
            }
        }
    }
}
