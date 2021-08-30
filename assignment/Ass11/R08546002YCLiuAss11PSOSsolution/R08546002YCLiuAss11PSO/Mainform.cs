using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COP;
using GeneticAlgorithmLibrary;

namespace R08546002YCLiuAss11PSO
{
    public partial class Mainform : Form
    {
        ParticalSwamOptimizationSolver theSolver;
        RealNumberGASolver GASolver;
        COPBenchmark theProblem;

        public Mainform()
        {
            InitializeComponent();
            btnCreatePSOSolver.Enabled = false;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;

            cbxUpdate.Checked = true;
            ckxShowSolutions.Checked = true;
        }
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            theProblem = COPBenchmark.LoadAProblemFromAFile();
            if (theProblem == null) return;
            theProblem.DisplayOnPanel(spcMain.Panel1);
            theProblem.DisplayObjectiveGraphics(tabObjective);
            //if (theSolver != null)
            //    theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
            btnCreatePSOSolver.Enabled = true;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
        }

        private void btnCreatePSOSolver_Click(object sender, EventArgs e)
        {
            OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                   OptimizationType.Minimization : OptimizationType.Maximization;

            theSolver = new ParticalSwamOptimizationSolver(theProblem.Dimension, type,
                theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
            theGrid.SelectedObject = theSolver;

            btnReset.Enabled = true;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;

        }
        
        GeneticAlgorithmLibrary.OptimizationType type;
        private void btnCreateGASolver_Click(object sender, EventArgs e)
        {
            if (theProblem.OptimizationGoal == COP.OptimizationType.Maximization)
            {
                type = GeneticAlgorithmLibrary.OptimizationType.Maximization;
            }
            else if (theProblem.OptimizationGoal == COP.OptimizationType.Minimization)
            {
                type = GeneticAlgorithmLibrary.OptimizationType.Minimization;
            }

            GASolver = new RealNumberGASolver(theProblem.Dimension, type,
                    theProblem.GetObjectiveValue, theProblem.LowerBound, theProblem.UpperBound);
            theGrid.SelectedObject = GASolver;

            btnGAReset.Enabled = true;
            btnGARunOneIteration.Enabled = false;
            btnGARunEnd.Enabled = false;
        }
        private void btnNewProblem_Click(object sender, EventArgs e)
        {
            COPBenchmark newProblem = COPBenchmark.CreateANewProblemAndShowEditor();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ltbSolutions.Items.Clear();
            MainChart.Series[0].Points.Clear();
            MainChart.Series[1].Points.Clear();
            MainChart.Series[2].Points.Clear();
            rtbSoFarTheBestSolution.Clear();

            theSolver.Reset();
            progressbar.Maximum = theSolver.IterationLimit;
            theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
            theGrid.SelectedObject = theSolver;
            labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            labSoFarTheBestSolution.Text = "So Far The Best Solution : ";
            labMessage.Text = "Time Spent";
            progressbar.Minimum = 0;
            progressbar.Value = 0;
            progressbar.Step = 1;

            btnRunOneIteration.Enabled = true;
            btnRunEnd.Enabled = true;          
        }
        private void btnGAReset_Click(object sender, EventArgs e)
        {
            ltbSolutions.Items.Clear();
            MainChart.Series[0].Points.Clear();
            MainChart.Series[1].Points.Clear();
            MainChart.Series[2].Points.Clear();
            rtbGASoFarTheBestSolution.Clear();

            GASolver.Reset();
            progressbar.Maximum = GASolver.IterationLimit;
            theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
            theGrid.SelectedObject = GASolver;
            labGASoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            labGASoFarTheBestSolution.Text = "So Far The Best Solution : ";
            labMessage.Text = "Time Spent";
            progressbar.Minimum = 0;
            progressbar.Value = 0;
            progressbar.Step = 1;

            btnGARunOneIteration.Enabled = true;
            btnGARunEnd.Enabled = true;
        }
        protected void AddPointIntoChart()
        {
            MainChart.Series[0].Points.AddXY(theSolver.IterationCount, theSolver.IterationAverageObj);
            MainChart.Series[1].Points.AddXY(theSolver.IterationCount, theSolver.IterationBestObj);
            MainChart.Series[2].Points.AddXY(theSolver.IterationCount, theSolver.SoFarTheBestObjective);          
        }
        protected void AddGAPointIntoChart()
        {
            MainChart.Series[0].Points.AddXY(GASolver.IterationCount, GASolver.IterationAverageObjective);
            MainChart.Series[1].Points.AddXY(GASolver.IterationCount, GASolver.IterationBestObjective);
            MainChart.Series[2].Points.AddXY(GASolver.IterationCount, GASolver.SoFarTheBestObjectiveValue);
        }

        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            ltbSolutions.Items.Clear();
            theSolver.RunOneIteratioin();
            AddPointIntoChart();
            //display solution on graphics
            theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
            if (ckxShowSolutions.Checked == true)
            {
                for (int i = 0; i < theSolver.NumberOfParticles; i++)
                {
                    string Solutions = "";
                    foreach (int variables in theSolver.Solutions[i])
                    {
                        Solutions += $"{variables.ToString("0.00")} ";
                    }
                    ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                }
            }
            tabObjective.Refresh();
            progressbar.PerformStep();
            labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theSolver.SoFarTheBestObjective.ToString("0.0000")}";
            rtbSoFarTheBestSolution.Text = "";
            for (int i = 0; i < theProblem.Dimension; i++)
            {
                rtbSoFarTheBestSolution.Text += $"{theSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
            }
        }
        private void btnGARunOneIteration_Click(object sender, EventArgs e)
        {
            ltbSolutions.Items.Clear();
            GASolver.RunOneIterarion();
            AddGAPointIntoChart();
            //display solution on graphics
            theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
            if (ckxShowSolutions.Checked == true)
            {
                for (int i = 0; i < GASolver.PopulationSize; i++)
                {
                    string Solutions = "";
                    foreach (int variables in GASolver.Chromosomes[i])
                    {
                        Solutions += $"{variables.ToString("0.00")} ";
                    }
                    ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                }
            }
            tabObjective.Refresh();
            progressbar.PerformStep();
            labGASoFarTheShortestLength.Text = $"So Far The Shortest Length : {GASolver.SoFarTheBestObjectiveValue.ToString("0.0000")}";
            rtbGASoFarTheBestSolution.Text = "";
            for (int i = 0; i < theProblem.Dimension; i++)
            {
                rtbGASoFarTheBestSolution.Text += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
            }
        }
        private void btnRunEnd_Click(object sender, EventArgs e)
        {
            if (cbxUpdate.Checked)
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnRunOneIteration_Click(null, null);
                    MainChart.Update();
                }
                while (theSolver.IterationCount < theSolver.IterationLimit);

                string BestSolution;
                BestSolution = new string(new char[] { });
                theSolver.RunOneIteratioin();
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < theSolver.NumberOfParticles; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in theSolver.Solutions[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions}");
                    }
                    ltbSolutions.Refresh();
                }
                tabObjective.Refresh();
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    rtbSoFarTheBestSolution.Text += $"{theSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                }
                progressbar.PerformStep();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            else
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnRunOneIteration_Click(null, null);                   
                }
                while (theSolver.IterationCount < theSolver.IterationLimit);
                progressbar.PerformStep();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(theSolver.Solutions);
                string GABestSolution;
                GABestSolution = new string(new char[] { });
                theSolver.RunOneIteratioin();             
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < theSolver.NumberOfParticles; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in theSolver.Solutions[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions}  ");
                    }

                }
                tabObjective.Refresh();
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    rtbSoFarTheBestSolution.Text += $"{theSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                }
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            MessageBox.Show("Local Optimum Found!");        
        }

        private void btnGARunEnd_Click(object sender, EventArgs e)
        {
            if (cbxGAUpdate.Checked)
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnGARunOneIteration_Click(null, null);
                    MainChart.Update();
                }
                while (GASolver.IterationCount < GASolver.IterationLimit);

                string BestSolution;
                BestSolution = new string(new char[] { });
                GASolver.RunOneIterarion();
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < GASolver.PopulationSize; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in GASolver.Chromosomes[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions}");
                    }
                    ltbSolutions.Refresh();
                }
                tabObjective.Refresh();
                labGASoFarTheShortestLength.Text = $"So Far The Shortest Length : {GASolver.SoFarTheBestObjectiveValue.ToString("0.0000")}";
                rtbGASoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    rtbGASoFarTheBestSolution.Text += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                }
                progressbar.PerformStep();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            else
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnGARunOneIteration_Click(null, null);
                }
                while (GASolver.IterationCount < GASolver.IterationLimit);
                progressbar.PerformStep();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
                string GABestSolution;
                GABestSolution = new string(new char[] { });
                GASolver.RunOneIterarion();
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < GASolver.PopulationSize; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in GASolver.Chromosomes[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions}  ");
                    }

                }
                tabObjective.Refresh();
                labGASoFarTheShortestLength.Text = $"So Far The Shortest Length : {GASolver.SoFarTheBestObjectiveValue.ToString("0.0000")}";
                rtbGASoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    rtbGASoFarTheBestSolution.Text += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                }
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            MessageBox.Show("Local Optimum Found!");
        }
    }
}
