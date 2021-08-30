using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiu_FinalProject
{
    class BeetleAntennaeSearchSolver
    {
        Random rnd = new Random();
        // data file
        double[] RandomDirectionVector;
        double[] right_antennae;
        double[] left_antennae;
        double[] solutions;
        int iterationLimit = 500;
        int numberOfVariables;
        ObjectiveFunction obj;
        double[] Lower;
        double[] Upper;
        protected OptimizationType optimizationtype = OptimizationType.Minimization;
        double[] soFarTheBestSolution;
        double ObjectiveValue = 0;
        double soFarTheBestObjective = 0;
        double multiplyConstant = 3;
        double diameterSensing = 5;
        double stepSize;
        double eta_diameter = 0.95;
        double eta_step = 0.95;
        double iterationBestObj;
        int iterationCount;
        #region property
        // properties
        [Category("Valid"), Description("Check current iterationCount.")]
        public int IterationCount { get => iterationCount; }
        [Browsable(false)]
        public double[] Solutions { get => solutions; }
        [Category("BAS Setting"), Description("Ratio between diameterSensing and StepSize\n c * D = Step\n越大隻的天牛步伐越大.")]
        public double MultiplyConstant
        {
            get => multiplyConstant;
            set
            {
                if (value > 0) multiplyConstant = value;
            }
        }
        [Category("BAS Setting"), Description("Sensing length of antennae corresponding to the exploit ability, which should be large enough to cover an appropriate searching area to be cable of jumping out of local minimum points at the beginning and then attenuate as time elapses.")]
        public double DiameterSensing
        {
            get => diameterSensing;
            set
            {
                if (value > 0) diameterSensing = value;
            }
        }
        [Category("BAS Setting"), Description("Step size of searching which accounts for the convergence speed following a decreasing function of t instead of an increasing function or a constant.")]
        public double StepSize
        {
            get => multiplyConstant * diameterSensing;
        }
        [Category("BAS Setting"), Description("Update coefficient with diameter sensing.\nThe smaller the value is, the faster the converge speed is.")]
        public double Eta_diameter 
        { 
            get => eta_diameter;
            set
            {
                if (value > 0 & value <= 1) eta_diameter = value;
            }
        }
        [Category("BAS Setting"), Description("Update coefficient with step size.\nThe smaller the value is, the faster the converge speed is.")]
        public double Eta_step
        {
            get => eta_step;
            set
            {
                if (value > 0 & value <= 1) eta_step = value;
            }
        }
        //[Category("BAS Setting"), Description("The upper bound condition of evolution.")]
        [Browsable(false)]
        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value >= 10) iterationLimit = value;
            }
        }
        [Browsable(false)]
        public double SoFarTheBestObjective { get => soFarTheBestObjective; }
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double[] SoFarTheBestSolution { get => soFarTheBestSolution; }
        
        #endregion

        public BeetleAntennaeSearchSolver(int numberOfvariables,
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
            solutions = new double[numberOfVariables];
            right_antennae = new double[numberOfVariables];
            left_antennae = new double[numberOfVariables];
            ObjectiveValue = 0.0;
            RandomDirectionVector = new double[numberOfVariables];
            InitializeSolutions();
            iterationCount = 0;
        }
        private void InitializeSolutions()
        {
       
            for (int i = 0; i < numberOfVariables; i++)
            {
                solutions[i] = Lower[i] + rnd.NextDouble() * (Upper[i] - Lower[i]); //initial position
            }
            ObjectiveValue = obj(solutions);
            
            // initialize best sol & obj
            if (optimizationtype == OptimizationType.Minimization)
            {
                soFarTheBestObjective = double.MaxValue;
                if (ObjectiveValue < soFarTheBestObjective)
                {
                    soFarTheBestObjective = ObjectiveValue;
                }
            }
            else  //OptimizationType.Maximization
            {
                soFarTheBestObjective = double.MinValue;
                if (ObjectiveValue > soFarTheBestObjective)
                {
                    soFarTheBestObjective = ObjectiveValue;
                }
                
            }
            for (int i = 0; i < numberOfVariables; i++)
            {
                soFarTheBestSolution[i] = solutions[i];
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
            double Distance_randomvector = 0.0;
            // Random direction vector 
            for (int i = 0; i < numberOfVariables; i++)
            {
                RandomDirectionVector[i] = rnd.Next((int)Lower[i], (int)Upper[i]) * 0.9; // transform to double
                Distance_randomvector += RandomDirectionVector[i] * RandomDirectionVector[i];
            }
            // scale
            for (int i = 0; i < numberOfVariables; i++)
            {
                double Distance = Math.Sqrt(Distance_randomvector);
                if (Distance == 0) RandomDirectionVector[i] = double.MinValue; //分母為0會是NAN
                else
                    RandomDirectionVector[i]/= Distance;
            }
            // create left and right antennae
            for(int i = 0; i < numberOfVariables; i++)
            {
                right_antennae[i] = solutions[i] + diameterSensing * RandomDirectionVector[i];
                left_antennae[i] = solutions[i] - diameterSensing * RandomDirectionVector[i];
                if (right_antennae[i] > Upper[i]) right_antennae[i] = Upper[i];
                else if (right_antennae[i] < Lower[i]) right_antennae[i] = Lower[i];
                if (left_antennae[i] > Upper[i]) left_antennae[i] = Upper[i];
                else if (left_antennae[i] < Lower[i]) left_antennae[i] = Lower[i];
            }
            // new position
            int Decide_direction = Math.Sign(obj(right_antennae) - obj(left_antennae));
            for(int i = 0; i < numberOfVariables; i++)
            {
                solutions[i] = solutions[i] + stepSize * RandomDirectionVector[i] * Decide_direction;
                if (solutions[i] > Upper[i]) solutions[i] = Upper[i];
                else if (solutions[i] < Lower[i]) solutions[i] = Lower[i];
            }
        }
        private void UpdateSoFarTheBestandParameters()
        {
            // compute obj 
            ObjectiveValue = obj(solutions);
            if (optimizationtype == OptimizationType.Maximization) // Maximization
            {
                iterationBestObj = ObjectiveValue;         
                // update so far the best
                if (iterationBestObj > soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int i = 0; i < numberOfVariables; i++)
                    {
                        soFarTheBestSolution[i] = solutions[i];
                    }
                }
            }
            else // Minimization
            {
                iterationBestObj = ObjectiveValue;             
                // update so far the best
                if (iterationBestObj < soFarTheBestObjective)
                {
                    soFarTheBestObjective = iterationBestObj;
                    for (int i = 0; i < numberOfVariables; i++)
                    {
                        soFarTheBestSolution[i] = solutions[i];
                    }
                }
            }
            diameterSensing = eta_diameter * diameterSensing + 0.01; // 不要讓兩觸角的直徑更新為0，這樣就等於只剩一隻觸角
            stepSize = Eta_step * stepSize + 0.01; // 不要讓步伐更新為0，這樣位置就無法更新
        }
    }
}
