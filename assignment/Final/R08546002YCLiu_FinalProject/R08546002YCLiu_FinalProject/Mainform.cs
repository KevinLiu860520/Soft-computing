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

namespace R08546002YCLiu_FinalProject
{
    public partial class Mainform : Form
    {
        BeetleSwarmOptimizationSolver BSOSolver;
        BeetleSwarmAntennaeSearchSolver BSASSolver;
        BeetleAntennaeSearchSolver BASSolver;
        ParticalSwamOptimizationSolver PSOSolver;
        RealNumberGASolver GASolver;
        COPBenchmark theProblem;

        public Mainform()
        {
            InitializeComponent();
            btnCreateSolver.Enabled = false;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
            cbxUpdate.Checked = true;
            ckxShowSolutions.Checked = true;
            rbtnPSO.Enabled = false;
            rbtnGA.Enabled = false;
            rbtnBAS.Enabled = false;
            rbtnBSAS.Enabled = false;
            rbtnBSO.Enabled = false;
            rbtnCompareAll.Enabled = false;
            rbtnExecuteTime.Enabled = false;
            rbtnIterationLimit.Enabled = false;
            nudCPUtime.Enabled = false;
            nudIterationLimit.Enabled = false;
            labSD.Visible = false;
            nudSD.Visible = false;
            labCV.Visible = false;
            nudCV.Visible = false;
            ltbCompareResult.Visible = false;
            chtCompareCV.Visible = false;
        }
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            theProblem = COPBenchmark.LoadAProblemFromAFile();
            if (theProblem == null) return;
            theProblem.DisplayOnPanel(spcMain.Panel1);
            theProblem.DisplayObjectiveGraphics(tabObjective);
            #region 解決開高維檔案出錯問題
            if (PSOSolver != null)
            {
                if (PSOSolver.Solutions[0].Length >= theProblem.Dimension)
                {
                    theProblem.DisplaySolutionsOnGraphics(PSOSolver.Solutions);
                }
                else
                {
                    theProblem.DisplayObjectiveGraphics(tabObjective);
                }
            }
            if (GASolver != null)
            {
                if (GASolver.Chromosomes[0].Length >= theProblem.Dimension)
                {
                    theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
                }
                else
                {
                    theProblem.DisplayObjectiveGraphics(tabObjective);
                }
            }
            if (BASSolver != null)
            {
                if (BASSolver.Solutions.Length >= theProblem.Dimension)
                {
                    theProblem.DisplaySolutionsOnGraphics(BAS_Solutions);
                }
                else
                {
                    theProblem.DisplayObjectiveGraphics(tabObjective);
                }
            }
            if (BSASSolver != null)
            {
                if (BSASSolver.Solutions[0].Length >= theProblem.Dimension)
                {
                    theProblem.DisplaySolutionsOnGraphics(BSASSolver.Solutions);
                }
                else
                {
                    theProblem.DisplayObjectiveGraphics(tabObjective);
                }
            }
            if (BSOSolver != null)
            {
                if (BSOSolver.Solutions[0].Length >= theProblem.Dimension)
                {
                    theProblem.DisplaySolutionsOnGraphics(BSOSolver.Solutions);
                }
                else
                {
                    theProblem.DisplayObjectiveGraphics(tabObjective);
                }
            }
            #endregion 
            btnCreateSolver.Enabled = true;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
            rbtnPSO.Enabled = true;
            rbtnGA.Enabled = true;
            rbtnBAS.Enabled = true;
            rbtnBSAS.Enabled = true;
            rbtnBSO.Enabled = true;
            rbtnCompareAll.Enabled = true;
            rbtnExecuteTime.Enabled = true;
            rbtnIterationLimit.Enabled = true;
            nudIterationLimit.Enabled = true;
            ltbCompareResult.Items.Clear();
            ltbSolutions.Items.Clear();
            chtCompare.Series[0].Points.Clear();
            chtCompare.Series[1].Points.Clear();
            chtCompare.Series[2].Points.Clear();
            chtCompare.Series[3].Points.Clear();
            chtCompare.Series[4].Points.Clear();
            chtCompareCV.Series[0].Points.Clear();
            chtCompareCV.Series[1].Points.Clear();
            chtCompareCV.Series[2].Points.Clear();
            chtCompareCV.Series[3].Points.Clear();
            chtCompareCV.Series[4].Points.Clear();
        }

        private void btnCreateSolver_Click(object sender, EventArgs e)
        {
            if (rbtnPSO.Checked)
            {
                OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                      OptimizationType.Minimization : OptimizationType.Maximization;

                PSOSolver = new ParticalSwamOptimizationSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                theGrid.SelectedObject = PSOSolver;
            }
            else if (rbtnGA.Checked)
            {
                GeneticAlgorithmLibrary.OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                    GeneticAlgorithmLibrary.OptimizationType.Minimization : GeneticAlgorithmLibrary.OptimizationType.Maximization;

                GASolver = new RealNumberGASolver(theProblem.Dimension, type,
                        theProblem.GetObjectiveValue, theProblem.LowerBound, theProblem.UpperBound);
                theGrid.SelectedObject = GASolver;
            }
            else if (rbtnBAS.Checked)
            {
                OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                      OptimizationType.Minimization : OptimizationType.Maximization;

                BASSolver = new BeetleAntennaeSearchSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                theGrid.SelectedObject = BASSolver;
            }
            else if (rbtnBSAS.Checked)
            {
                OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                      OptimizationType.Minimization : OptimizationType.Maximization;

                BSASSolver = new BeetleSwarmAntennaeSearchSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                theGrid.SelectedObject = BSASSolver;
            }
            else if (rbtnBSO.Checked)
            {
                OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                      OptimizationType.Minimization : OptimizationType.Maximization;

                BSOSolver = new BeetleSwarmOptimizationSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                theGrid.SelectedObject = BSOSolver;
            }
            else if (rbtnCompareAll.Checked)
            {
                OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                    OptimizationType.Minimization : OptimizationType.Maximization;
                GeneticAlgorithmLibrary.OptimizationType gtype = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                    GeneticAlgorithmLibrary.OptimizationType.Minimization : GeneticAlgorithmLibrary.OptimizationType.Maximization;

                PSOSolver = new ParticalSwamOptimizationSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                GASolver = new RealNumberGASolver(theProblem.Dimension, gtype,
                        theProblem.GetObjectiveValue, theProblem.LowerBound, theProblem.UpperBound);
                BASSolver = new BeetleAntennaeSearchSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                BSASSolver = new BeetleSwarmAntennaeSearchSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
                BSOSolver = new BeetleSwarmOptimizationSolver(theProblem.Dimension, type,
                    theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);
            }
            btnReset.Enabled = true;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;

        }
        private void btnNewProblem_Click(object sender, EventArgs e)
        {
            COPBenchmark newProblem = COPBenchmark.CreateANewProblemAndShowEditor();
        }

        double [][]BAS_Solutions;
        void OneArraytoTwoArray(double[] oneD)
        {
            BAS_Solutions = new double[1][];
            BAS_Solutions[0] = new double[theProblem.Dimension];
            for (int i = 0; i < theProblem.Dimension;i++)
            {
                BAS_Solutions[0][i] = oneD[i];
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ltbSolutions.Items.Clear();
            ltbCompareResult.Items.Clear();
            MainChart.Series[0].Points.Clear();
            MainChart.Series[1].Points.Clear();
            MainChart.Series[2].Points.Clear();
            if (rbtnPSO.Checked)
            {
                rtbSoFarTheBestSolution.Clear();
                PSOSolver.Reset();
                progressbar.Maximum = PSOSolver.IterationLimit;
                theProblem.DisplaySolutionsOnGraphics(PSOSolver.Solutions);
                theGrid.SelectedObject = PSOSolver;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            }
            else if (rbtnGA.Checked)
            {
                rtbSoFarTheBestSolution.Clear();
                GASolver.Reset();
                progressbar.Maximum = GASolver.IterationLimit;
                theProblem.DisplaySolutionsOnGraphics(GASolver.Chromosomes);
                theGrid.SelectedObject = GASolver;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            }
            else if (rbtnBAS.Checked)
            {
                rtbSoFarTheBestSolution.Clear();
                BASSolver.Reset();
                progressbar.Maximum = BASSolver.IterationLimit;
                OneArraytoTwoArray(BASSolver.Solutions);
                theProblem.DisplaySolutionsOnGraphics(BAS_Solutions);
                theGrid.SelectedObject = BASSolver;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            }
            else if (rbtnBSAS.Checked)
            {
                rtbSoFarTheBestSolution.Clear();
                BSASSolver.Reset();
                progressbar.Maximum = BSASSolver.IterationLimit;
                theProblem.DisplaySolutionsOnGraphics(BSASSolver.Solutions);
                theGrid.SelectedObject = BSASSolver;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            }
            else if (rbtnBSO.Checked)
            {
                rtbSoFarTheBestSolution.Clear();
                BSOSolver.Reset();
                progressbar.Maximum = BSOSolver.IterationLimit;
                theProblem.DisplaySolutionsOnGraphics(BSOSolver.Solutions);
                theGrid.SelectedObject = BSOSolver;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            }
            else if(rbtnCompareAll.Checked)
            {
                ltbSolutions.Items.Clear();
                if(Convert.ToInt32(nudCV.Value) == 1)
                {
                    chtCompare.Series[0].Points.Clear();
                    chtCompare.Series[1].Points.Clear();
                    chtCompare.Series[2].Points.Clear();
                    chtCompare.Series[3].Points.Clear();
                    chtCompare.Series[4].Points.Clear();
                }
                else
                {
                    chtCompareCV.Series[0].Points.Clear();
                    chtCompareCV.Series[1].Points.Clear();
                    chtCompareCV.Series[2].Points.Clear();
                    chtCompareCV.Series[3].Points.Clear();
                    chtCompareCV.Series[4].Points.Clear();
                }
                PSOSolver.NumberOfParticles = Convert.ToInt32(nudSD.Value);
                PSOSolver.Reset();
                GASolver.PopulationSize = Convert.ToInt32(nudSD.Value);
                GASolver.Reset();
                BASSolver.Reset();
                BSOSolver.NumberOfBeetles = Convert.ToInt32(nudSD.Value);
                BSOSolver.Reset();
                BSASSolver.NumberOfBeetles = Convert.ToInt32(nudSD.Value);
                BSASSolver.Reset();
            }                
            labMessage.Text = "Time Spent";
            progressbar.Value = 0;
            progressbar.Step = 1;
            if (rbtnIterationLimit.Checked)
            {
                if (nudCV.Value != 1)
                {
                    btnRunOneIteration.Enabled = false;
                }
                else
                {
                    btnRunOneIteration.Enabled = true;
                }
            }
            btnRunEnd.Enabled = true;          
        }
        protected void AddPointIntoChart()
        {
            if (rbtnPSO.Checked)
            {
                MainChart.Series[0].Points.AddXY(PSOSolver.IterationCount, PSOSolver.IterationAverageObj);
                MainChart.Series[1].Points.AddXY(PSOSolver.IterationCount, PSOSolver.IterationBestObj);
                MainChart.Series[2].Points.AddXY(PSOSolver.IterationCount, PSOSolver.SoFarTheBestObjective);
            }
            else if (rbtnGA.Checked)
            {
                MainChart.Series[0].Points.AddXY(GASolver.IterationCount, GASolver.IterationAverageObjective);
                MainChart.Series[1].Points.AddXY(GASolver.IterationCount, GASolver.IterationBestObjective);
                MainChart.Series[2].Points.AddXY(GASolver.IterationCount, GASolver.SoFarTheBestObjectiveValue);
            }
            else if (rbtnBAS.Checked)
            {
                MainChart.Series[1].Points.AddXY(BASSolver.IterationCount, BASSolver.IterationBestObj);
                MainChart.Series[2].Points.AddXY(BASSolver.IterationCount, BASSolver.SoFarTheBestObjective);
            }
            else if (rbtnBSAS.Checked)
            {
                MainChart.Series[0].Points.AddXY(BSASSolver.IterationCount, BSASSolver.IterationAverageObj);
                MainChart.Series[1].Points.AddXY(BSASSolver.IterationCount, BSASSolver.IterationBestObj);
                MainChart.Series[2].Points.AddXY(BSASSolver.IterationCount, BSASSolver.SoFarTheBestObjective);
            }
            else if (rbtnBSO.Checked)
            {
                MainChart.Series[0].Points.AddXY(BSOSolver.IterationCount, BSOSolver.IterationAverageObj);
                MainChart.Series[1].Points.AddXY(BSOSolver.IterationCount, BSOSolver.IterationBestObj);
                MainChart.Series[2].Points.AddXY(BSOSolver.IterationCount, BSOSolver.SoFarTheBestObjective);
            }
            else if (rbtnCompareAll.Checked)
            {
                chtCompare.Series[0].Points.AddXY(PSOSolver.IterationCount, PSOSolver.SoFarTheBestObjective);
                chtCompare.Series[1].Points.AddXY(GASolver.IterationCount, GASolver.SoFarTheBestObjectiveValue);
                chtCompare.Series[2].Points.AddXY(BASSolver.IterationCount, BASSolver.SoFarTheBestObjective);
                chtCompare.Series[3].Points.AddXY(BSOSolver.IterationCount, BSOSolver.SoFarTheBestObjective);
                chtCompare.Series[4].Points.AddXY(BSASSolver.IterationCount, BSASSolver.SoFarTheBestObjective);
            }
        }
        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            progressbar.Maximum = Convert.ToInt32(nudIterationLimit.Value);
            ltbSolutions.Items.Clear();
            if (rbtnPSO.Checked)
            {
                PSOSolver.RunOneIteratioin();
                AddPointIntoChart();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(PSOSolver.Solutions);
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < PSOSolver.NumberOfParticles; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in PSOSolver.Solutions[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                    }
                }
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {PSOSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    if (i != theProblem.Dimension - 1)
                    {
                        rtbSoFarTheBestSolution.Text += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                    }
                    else
                    {
                        rtbSoFarTheBestSolution.Text += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                    }
                }
            }
            else if (rbtnGA.Checked)
            {
                GASolver.RunOneIteration();
                AddPointIntoChart();
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
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {GASolver.SoFarTheBestObjectiveValue.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    if (i != theProblem.Dimension - 1)
                    {
                        rtbSoFarTheBestSolution.Text += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                    }
                    else
                    {
                        rtbSoFarTheBestSolution.Text += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                    }
                }
            }
            else if (rbtnBAS.Checked)
            {
                BASSolver.RunOneIteratioin();
                AddPointIntoChart();
                //display solution on graphics
                OneArraytoTwoArray(BASSolver.Solutions);
                theProblem.DisplaySolutionsOnGraphics(BAS_Solutions);
                if (ckxShowSolutions.Checked == true)
                {
                    string Solutions = "";
                    foreach (int variables in BASSolver.Solutions)
                    {
                        Solutions += $"{variables.ToString("0.00")} ";
                    }
                    ltbSolutions.Items.Add($"Solution = {Solutions} ");
                }
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {BASSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    if (i != theProblem.Dimension - 1)
                    {
                        rtbSoFarTheBestSolution.Text += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                    }
                    else
                    {
                        rtbSoFarTheBestSolution.Text += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                    }
                }
            }
            else if (rbtnBSAS.Checked)
            {
                BSASSolver.RunOneIteratioin();
                AddPointIntoChart();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(BSASSolver.Temp_solutions);
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < BSASSolver.NumberOfBeetles; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in BSASSolver.Temp_solutions[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                    }
                }
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {BSASSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    if (i != theProblem.Dimension - 1)
                    {
                        rtbSoFarTheBestSolution.Text += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                    }
                    else
                    {
                        rtbSoFarTheBestSolution.Text += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                    }
                }
            }
            else if (rbtnBSO.Checked)
            {
                BSOSolver.RunOneIteratioin();
                AddPointIntoChart();
                //display solution on graphics
                theProblem.DisplaySolutionsOnGraphics(BSOSolver.Solutions);
                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < BSOSolver.NumberOfBeetles; i++)
                    {
                        string Solutions = "";
                        foreach (int variables in BSOSolver.Solutions[i])
                        {
                            Solutions += $"{variables.ToString("0.00")} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                    }
                }
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {BSOSolver.SoFarTheBestObjective.ToString("0.0000")}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < theProblem.Dimension; i++)
                {
                    if (i != theProblem.Dimension - 1)
                    {
                        rtbSoFarTheBestSolution.Text += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                    }
                    else
                    {
                        rtbSoFarTheBestSolution.Text += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                    }
                }
            }
            else if (rbtnCompareAll.Checked)
            {
                PSOSolver.RunOneIteratioin();
                GASolver.RunOneIteration();
                BASSolver.RunOneIteratioin();
                BSOSolver.RunOneIteratioin();
                BSASSolver.RunOneIteratioin();
                AddPointIntoChart();
                if (ckxShowSolutions.Checked == true)
                {
                    string PSOSoFarTheBestObjective = "";
                    string GASoFarTheBestObjective = "";
                    string BASSoFarTheBestObjective = "";
                    string BSOSoFarTheBestObjective = "";
                    string BSASSoFarTheBestObjective = "";
                    for (int i = 0; i < theProblem.Dimension; i++)
                    {
                        if (i != theProblem.Dimension - 1)
                        {
                            PSOSoFarTheBestObjective += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            GASoFarTheBestObjective += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            BASSoFarTheBestObjective += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            BSOSoFarTheBestObjective += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            BSASSoFarTheBestObjective += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                        }
                        else
                        {
                            PSOSoFarTheBestObjective += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            GASoFarTheBestObjective += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            BASSoFarTheBestObjective += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            BSOSoFarTheBestObjective += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            BSASSoFarTheBestObjective += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                        }
                    }
                    ltbSolutions.Items.Add($"PSO Solver :");
                    ltbSolutions.Items.Add($"So Far The Best Objective Value = {PSOSolver.SoFarTheBestObjective}");
                    ltbSolutions.Items.Add($"So Far The Best Solution = {PSOSoFarTheBestObjective}");
                    ltbSolutions.Items.Add("");
                    ltbSolutions.Items.Add($"GA Solver :");
                    ltbSolutions.Items.Add($"So Far The Best Objective Value = {GASolver.SoFarTheBestObjectiveValue}");
                    ltbSolutions.Items.Add($"So Far The Best Solution = {GASoFarTheBestObjective}");
                    ltbSolutions.Items.Add("");
                    ltbSolutions.Items.Add($"BAS Solver :");
                    ltbSolutions.Items.Add($"So Far The Best Objective Value = {BASSolver.SoFarTheBestObjective}");
                    ltbSolutions.Items.Add($"So Far The Best Solution = {BASSoFarTheBestObjective}");
                    ltbSolutions.Items.Add("");
                    ltbSolutions.Items.Add($"BSO Solver :");
                    ltbSolutions.Items.Add($"So Far The Best Objective Value = {BSOSolver.SoFarTheBestObjective}");
                    ltbSolutions.Items.Add($"So Far The Best Solution = {BSOSoFarTheBestObjective}");
                    ltbSolutions.Items.Add("");
                    ltbSolutions.Items.Add($"BSAS Solver :");
                    ltbSolutions.Items.Add($"So Far The Best Objective Value = {BSASSolver.SoFarTheBestObjective}");
                    ltbSolutions.Items.Add($"So Far The Best Solution = {BSASSoFarTheBestObjective}");
                }
            }
            progressbar.PerformStep();
        }
        private void btnRunEnd_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            Cursor = Cursors.WaitCursor;
            if (rbtnIterationLimit.Checked)
            {
                if (rbtnPSO.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            progressbar.Value = PSOSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (PSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                    else
                    {
                        do
                        {
                            progressbar.Value = PSOSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                        }
                        while (PSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                }
                else if (rbtnGA.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            progressbar.Value = GASolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (GASolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                    else
                    {
                        do
                        {
                            progressbar.Value = GASolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                        }
                        while (GASolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                }
                else if (rbtnBAS.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            progressbar.Value = BASSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (BASSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                    else
                    {
                        do
                        {
                            progressbar.Value = BASSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                        }
                        while (BASSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)) ; 
                    }
                }
                else if (rbtnBSAS.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            progressbar.Value = BSASSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (BSASSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                    else
                    {
                        do
                        {
                            progressbar.Value = BSASSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                        }
                        while (BSASSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                    }
                }
                else if (rbtnBSO.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            progressbar.Value = BSOSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text)); 
                    }
                    else
                    {
                        do
                        {
                            progressbar.Value = BSOSolver.IterationCount;
                            btnRunOneIteration_Click(null, null);
                        }
                        while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                    }
                }
                else if (rbtnCompareAll.Checked)
                {
                    if (Convert.ToInt32(nudCV.Value) == 1)
                    {
                        OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                            OptimizationType.Minimization : OptimizationType.Maximization;
                        string[] methods = new string[] { "PSO Solver", "GA Solver", "BAS Solver", "BSO Solver", "BSAS Solver" };
                        double[] objective = new double[5];
                        int bestPosition = -1;
                        if (cbxUpdate.Checked)
                        {
                            do
                            {
                                progressbar.Value = BSOSolver.IterationCount;
                                btnRunOneIteration_Click(null, null);
                                chtCompare.Update();
                            }
                            while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                        }
                        else
                        {
                            do
                            {
                                progressbar.Value = BSOSolver.IterationCount;
                                btnRunOneIteration_Click(null, null);
                            }
                            while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                        }
                        string[] sofarthebest = new string[] { "", "", "", "", "" };
                        for (int i = 0; i < theProblem.Dimension; i++)
                        {
                            if (i != theProblem.Dimension - 1)
                            {
                                sofarthebest[0] += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[1] += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[2] += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[3] += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[4] += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            }
                            else
                            {
                                sofarthebest[0] += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[1] += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[2] += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[3] += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[4] += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            }
                        }
                        objective[0] = PSOSolver.SoFarTheBestObjective; objective[1] = GASolver.SoFarTheBestObjectiveValue;
                        objective[2] = BASSolver.SoFarTheBestObjective; objective[3] = BSOSolver.SoFarTheBestObjective; objective[4] = BSASSolver.SoFarTheBestObjective;
                        if (type == OptimizationType.Minimization)
                        {
                            double TheBestObjective = double.MaxValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] < TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double TheBestObjective = double.MinValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] > TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        ltbCompareResult.Font = new Font("Consolas", 12, FontStyle.Bold);
                        ltbCompareResult.ForeColor = Color.Red;
                        ltbCompareResult.Items.Add($"The best method is = {methods[bestPosition]}");
                        ltbCompareResult.Items.Add($"Its best objective value is = { objective[bestPosition]}");
                        ltbCompareResult.Items.Add($"Its best solution is = { sofarthebest[bestPosition]}");
                    }
                    else //Cross Validation
                    {
                        ltbSolutions.Items.Clear();
                        ltbCompareResult.Items.Clear();
                        OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                            OptimizationType.Minimization : OptimizationType.Maximization;
                        string[] methods = new string[] {"PSO Solver", "GA Solver", "BAS Solver", "BSO Solver", "BSAS Solver" };
                        double[] objective = new double[5];
                        int bestPosition = -1;
                        int MeanbestPosition = -1;
                        int PSO_bestPosition = -1;
                        int GA_bestPosition = -1;
                        int BAS_bestPosition = -1;
                        int BSO_bestPosition = -1;
                        int BSAS_bestPosition = -1;
                        int CV_iteration = 1;
                        // store solution and objective
                        double[] PSO_CV_Objective = new double[Convert.ToInt32(nudCV.Text)];
                        double[] GA_CV_Objective = new double[Convert.ToInt32(nudCV.Text)];
                        double[] BAS_CV_Objective = new double[Convert.ToInt32(nudCV.Text)];
                        double[] BSO_CV_Objective = new double[Convert.ToInt32(nudCV.Text)];
                        double[] BSAS_CV_Objective = new double[Convert.ToInt32(nudCV.Text)];
                        double[][] PSO_CV_Solution = new double[Convert.ToInt32(nudCV.Text)][];
                        double[][] GA_CV_Solution = new double[Convert.ToInt32(nudCV.Text)][];
                        double[][] BAS_CV_Solution = new double[Convert.ToInt32(nudCV.Text)][];
                        double[][] BSO_CV_Solution = new double[Convert.ToInt32(nudCV.Text)][];
                        double[][] BSAS_CV_Solution = new double[Convert.ToInt32(nudCV.Text)][];
                        double PSO_Mean = 0; double PSO_Std = 0;
                        double GA_Mean = 0; double GA_Std = 0;
                        double BAS_Mean = 0; double BAS_Std = 0;
                        double BSO_Mean = 0; double BSO_Std = 0;
                        double BSAS_Mean = 0; double BSAS_Std = 0;
                        double[] Mean_compare = new double[5];

                        for (int i = 0;i< Convert.ToInt32(nudCV.Text); i++)
                        {
                            PSO_CV_Solution[i] = new double[theProblem.Dimension];
                            GA_CV_Solution[i] = new double[theProblem.Dimension];
                            BAS_CV_Solution[i] = new double[theProblem.Dimension];
                            BSO_CV_Solution[i] = new double[theProblem.Dimension];
                            BSAS_CV_Solution[i] = new double[theProblem.Dimension];
                        }

                        progressbar.Maximum = Convert.ToInt32(nudCV.Text);
                        progressbar.Minimum = 0;
                        progressbar.Value = 0;
                        progressbar.Step = 1;
                        if (cbxUpdate.Checked)
                        {
                            do
                            {
                                PSOSolver.Reset();
                                GASolver.Reset();
                                BASSolver.Reset();
                                BSOSolver.Reset();
                                BSASSolver.Reset();
                                do
                                {
                                    PSOSolver.RunOneIteratioin();
                                    GASolver.RunOneIteration();
                                    BASSolver.RunOneIteratioin();
                                    BSOSolver.RunOneIteratioin();
                                    BSASSolver.RunOneIteratioin();
                                }
                                while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                                if (BSOSolver.IterationCount == Convert.ToInt32(nudIterationLimit.Text))
                                {
                                    chtCompareCV.Series[0].Points.AddXY(CV_iteration, PSOSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[1].Points.AddXY(CV_iteration, GASolver.SoFarTheBestObjectiveValue);
                                    chtCompareCV.Series[2].Points.AddXY(CV_iteration, BASSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[3].Points.AddXY(CV_iteration, BSOSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[4].Points.AddXY(CV_iteration, BSASSolver.SoFarTheBestObjective);
                                    PSO_CV_Objective[CV_iteration-1] = PSOSolver.SoFarTheBestObjective;
                                    GA_CV_Objective[CV_iteration-1] = GASolver.SoFarTheBestObjectiveValue;
                                    BAS_CV_Objective[CV_iteration-1] = BASSolver.SoFarTheBestObjective;
                                    BSO_CV_Objective[CV_iteration-1] = BSOSolver.SoFarTheBestObjective;
                                    BSAS_CV_Objective[CV_iteration-1] = BSASSolver.SoFarTheBestObjective;
                                    for(int i = 0; i < theProblem.Dimension; i++)
                                    {
                                        PSO_CV_Solution[CV_iteration-1][i] = PSOSolver.SoFarTheBestSolution[i];
                                        GA_CV_Solution[CV_iteration-1][i] = GASolver.SoFarTheBestSolution[i];
                                        BAS_CV_Solution[CV_iteration-1][i] = BASSolver.SoFarTheBestSolution[i];
                                        BSO_CV_Solution[CV_iteration-1][i] = BSOSolver.SoFarTheBestSolution[i];
                                        BSAS_CV_Solution[CV_iteration-1][i] = BSASSolver.SoFarTheBestSolution[i];
                                    }
                                    PSO_Mean += PSOSolver.SoFarTheBestObjective;
                                    GA_Mean += GASolver.SoFarTheBestObjectiveValue;
                                    BAS_Mean += BASSolver.SoFarTheBestObjective;
                                    BSO_Mean += BSOSolver.SoFarTheBestObjective;
                                    BSAS_Mean += BSASSolver.SoFarTheBestObjective;
                                }
                                progressbar.PerformStep();
                                CV_iteration++;
                                chtCompareCV.Update();
                            } while (CV_iteration <= Convert.ToInt32(nudCV.Value));
                        }
                        else
                        {
                            do
                            {
                                PSOSolver.Reset();
                                GASolver.Reset();
                                BASSolver.Reset();
                                BSOSolver.Reset();
                                BSASSolver.Reset();
                                do
                                {
                                    PSOSolver.RunOneIteratioin();
                                    GASolver.RunOneIteration();
                                    BASSolver.RunOneIteratioin();
                                    BSOSolver.RunOneIteratioin();
                                    BSASSolver.RunOneIteratioin();
                                }
                                while (BSOSolver.IterationCount < Convert.ToInt32(nudIterationLimit.Text));
                                if (BSOSolver.IterationCount == Convert.ToInt32(nudIterationLimit.Text))
                                {
                                    chtCompareCV.Series[0].Points.AddXY(CV_iteration, PSOSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[1].Points.AddXY(CV_iteration, GASolver.SoFarTheBestObjectiveValue);
                                    chtCompareCV.Series[2].Points.AddXY(CV_iteration, BASSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[3].Points.AddXY(CV_iteration, BSOSolver.SoFarTheBestObjective);
                                    chtCompareCV.Series[4].Points.AddXY(CV_iteration, BSASSolver.SoFarTheBestObjective);
                                    PSO_CV_Objective[CV_iteration] = PSOSolver.SoFarTheBestObjective;
                                    GA_CV_Objective[CV_iteration] = GASolver.SoFarTheBestObjectiveValue;
                                    BAS_CV_Objective[CV_iteration] = BASSolver.SoFarTheBestObjective;
                                    BSO_CV_Objective[CV_iteration] = BSOSolver.SoFarTheBestObjective;
                                    BSAS_CV_Objective[CV_iteration] = BSASSolver.SoFarTheBestObjective;
                                    for (int i = 0; i < theProblem.Dimension; i++)
                                    {
                                        PSO_CV_Solution[CV_iteration][i] = PSOSolver.SoFarTheBestSolution[i];
                                        GA_CV_Solution[CV_iteration][i] = GASolver.SoFarTheBestSolution[i];
                                        BAS_CV_Solution[CV_iteration][i] = BASSolver.SoFarTheBestSolution[i];
                                        BSO_CV_Solution[CV_iteration][i] = BSOSolver.SoFarTheBestSolution[i];
                                        BSAS_CV_Solution[CV_iteration][i] = BSASSolver.SoFarTheBestSolution[i];
                                    }
                                    PSO_Mean += PSOSolver.SoFarTheBestObjective;
                                    GA_Mean += GASolver.SoFarTheBestObjectiveValue;
                                    BAS_Mean += BASSolver.SoFarTheBestObjective;
                                    BSO_Mean += BSOSolver.SoFarTheBestObjective;
                                    BSAS_Mean += BSASSolver.SoFarTheBestObjective;
                                }
                                progressbar.PerformStep();
                                CV_iteration++;
                            } while (CV_iteration <= Convert.ToInt32(nudCV.Value));
                        }
                        // CV mean
                        PSO_Mean = PSO_Mean / PSO_CV_Objective.Length;
                        GA_Mean = GA_Mean / GA_CV_Objective.Length;
                        BAS_Mean = BAS_Mean / BAS_CV_Objective.Length;
                        BSO_Mean = BSO_Mean / BSO_CV_Objective.Length;
                        BSAS_Mean = BSAS_Mean / BSAS_CV_Objective.Length;
                        // CV std
                        for(int i =0;i< PSO_CV_Objective.Length; i++)
                        {
                            PSO_Std += Math.Pow(PSO_CV_Objective[i] - PSO_Mean, 2);
                            GA_Std += Math.Pow(GA_CV_Objective[i] - GA_Mean, 2);
                            BAS_Std += Math.Pow(BAS_CV_Objective[i] - BAS_Mean, 2);
                            BSO_Std += Math.Pow(BSO_CV_Objective[i] - BSO_Mean, 2);
                            BSAS_Std += Math.Pow(BSAS_CV_Objective[i] - BSAS_Mean, 2);
                        }
                        PSO_Std = Math.Sqrt(PSO_Std/ PSO_CV_Objective.Length);
                        GA_Std = Math.Sqrt(GA_Std / GA_CV_Objective.Length);
                        BAS_Std = Math.Sqrt(BAS_Std / BAS_CV_Objective.Length);
                        BSO_Std = Math.Sqrt(BSO_Std / BSO_CV_Objective.Length);
                        BSAS_Std = Math.Sqrt(BSAS_Std / BSAS_CV_Objective.Length);
                        #region Find individual method best obj and itss solution
                        // PSO
                        if (type == OptimizationType.Minimization)
                        {
                            double PSO_theBestObjective = double.MaxValue;
                            for (int i = 0; i < PSO_CV_Objective.Length; i++)
                            {
                                if (PSO_CV_Objective[i] < PSO_theBestObjective)
                                {
                                    PSO_theBestObjective = PSO_CV_Objective[i];
                                    PSO_bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double PSO_theBestObjective = double.MinValue;
                            for (int i = 0; i < PSO_CV_Objective.Length; i++)
                            {
                                if (PSO_CV_Objective[i] > PSO_theBestObjective)
                                {
                                    PSO_theBestObjective = PSO_CV_Objective[i];
                                    PSO_bestPosition = i;
                                }
                            }
                        }
                        // GA
                        if (type == OptimizationType.Minimization)
                        {
                            double GA_theBestObjective = double.MaxValue;
                            for (int i = 0; i < GA_CV_Objective.Length; i++)
                            {
                                if (GA_CV_Objective[i] < GA_theBestObjective)
                                {
                                    GA_theBestObjective = GA_CV_Objective[i];
                                    GA_bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double GA_theBestObjective = double.MinValue;
                            for (int i = 0; i < GA_CV_Objective.Length; i++)
                            {
                                if (GA_CV_Objective[i] > GA_theBestObjective)
                                {
                                    GA_theBestObjective = GA_CV_Objective[i];
                                    GA_bestPosition = i;
                                }
                            }
                        }
                        // BAS
                        if (type == OptimizationType.Minimization)
                        {
                            double BAS_theBestObjective = double.MaxValue;
                            for (int i = 0; i < BAS_CV_Objective.Length; i++)
                            {
                                if (BAS_CV_Objective[i] < BAS_theBestObjective)
                                {
                                    BAS_theBestObjective = BAS_CV_Objective[i];
                                    BAS_bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double BAS_theBestObjective = double.MinValue;
                            for (int i = 0; i < BAS_CV_Objective.Length; i++)
                            {
                                if (BAS_CV_Objective[i] > BAS_theBestObjective)
                                {
                                    BAS_theBestObjective = BAS_CV_Objective[i];
                                    BAS_bestPosition = i;
                                }
                            }
                        }
                        // BSO
                        if (type == OptimizationType.Minimization)
                        {
                            double BSO_theBestObjective = double.MaxValue;
                            for (int i = 0; i < BSO_CV_Objective.Length; i++)
                            {
                                if (BSO_CV_Objective[i] < BSO_theBestObjective)
                                {
                                    BSO_theBestObjective = BSO_CV_Objective[i];
                                    BSO_bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double BSO_theBestObjective = double.MinValue;
                            for (int i = 0; i < BSO_CV_Objective.Length; i++)
                            {
                                if (BSO_CV_Objective[i] > BSO_theBestObjective)
                                {
                                    BSO_theBestObjective = BSO_CV_Objective[i];
                                    BSO_bestPosition = i;
                                }
                            }
                        }
                        // BSAS
                        if (type == OptimizationType.Minimization)
                        {
                            double BSAS_theBestObjective = double.MaxValue;
                            for (int i = 0; i < BSAS_CV_Objective.Length; i++)
                            {
                                if (BSAS_CV_Objective[i] < BSAS_theBestObjective)
                                {
                                    BSAS_theBestObjective = BSAS_CV_Objective[i];
                                    BSAS_bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double BSAS_theBestObjective = double.MinValue;
                            for (int i = 0; i < BSO_CV_Objective.Length; i++)
                            {
                                if (BSAS_CV_Objective[i] > BSAS_theBestObjective)
                                {
                                    BSAS_theBestObjective = BSAS_CV_Objective[i];
                                    BSAS_bestPosition = i;
                                }
                            }
                        }
                        #endregion
                        objective[0] = PSO_CV_Objective[PSO_bestPosition]; objective[1] = GA_CV_Objective[GA_bestPosition];
                        objective[2] = BAS_CV_Objective[BAS_bestPosition]; objective[3] = BSO_CV_Objective[BSO_bestPosition]; objective[4] = BSAS_CV_Objective[BSAS_bestPosition];
                        Mean_compare[0] = PSO_Mean; Mean_compare[1] = GA_Mean; Mean_compare[2] = BAS_Mean; Mean_compare[3] = BSO_Mean; Mean_compare[4] = BSAS_Mean;
                        string[] sofarthebest = new string[] { "", "", "", "", "" };
                        for (int i = 0; i < theProblem.Dimension; i++)
                        {
                            if (i != theProblem.Dimension - 1)
                            {
                                sofarthebest[0] += $"{PSO_CV_Solution[PSO_bestPosition][i].ToString("0.0000")}, ";
                                sofarthebest[1] += $"{GA_CV_Solution[PSO_bestPosition][i].ToString("0.0000")}, ";
                                sofarthebest[2] += $"{BAS_CV_Solution[PSO_bestPosition][i].ToString("0.0000")}, ";
                                sofarthebest[3] += $"{BSO_CV_Solution[PSO_bestPosition][i].ToString("0.0000")}, ";
                                sofarthebest[4] += $"{BSAS_CV_Solution[PSO_bestPosition][i].ToString("0.0000")}, ";
                            }
                            else
                            {
                                sofarthebest[0] += $"{PSO_CV_Solution[PSO_bestPosition][i].ToString("0.0000")} ";
                                sofarthebest[1] += $"{GA_CV_Solution[PSO_bestPosition][i].ToString("0.0000")} ";
                                sofarthebest[2] += $"{BAS_CV_Solution[PSO_bestPosition][i].ToString("0.0000")} ";
                                sofarthebest[3] += $"{BSO_CV_Solution[PSO_bestPosition][i].ToString("0.0000")} ";
                                sofarthebest[4] += $"{BSAS_CV_Solution[PSO_bestPosition][i].ToString("0.0000")} ";
                            }
                        }
                        // Method of sofarthebest Objective Compare
                        if (type == OptimizationType.Minimization)
                        {
                            double TheBestObjective = double.MaxValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] < TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double TheBestObjective = double.MinValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] > TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        // Method of Mean sofarthebest Objective Compare
                        if (type == OptimizationType.Minimization)
                        {
                            double MeanTheBestObjective = double.MaxValue;
                            for (int i = 0; i < Mean_compare.Length; i++)
                            {
                                if (Mean_compare[i] < MeanTheBestObjective)
                                {
                                    MeanTheBestObjective = Mean_compare[i];
                                    MeanbestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double MeanTheBestObjective = double.MinValue;
                            for (int i = 0; i < Mean_compare.Length; i++)
                            {
                                if (Mean_compare[i] > MeanTheBestObjective)
                                {
                                    MeanTheBestObjective = Mean_compare[i];
                                    MeanbestPosition = i;
                                }
                            }
                        }
                        if (ckxShowSolutions.Checked == true)
                        {
                            ltbSolutions.Items.Clear();
                            ltbCompareResult.Font = new Font("Consolas", 12, FontStyle.Bold);
                            ltbCompareResult.ForeColor = Color.Red;
                            ltbCompareResult.Items.Add($"The best method is = {methods[bestPosition]}");
                            ltbCompareResult.Items.Add($"Its best objective value is = {objective[bestPosition]}");
                            ltbCompareResult.Items.Add($"Its best solution is = {sofarthebest[bestPosition]}");
                            ltbCompareResult.Items.Add("");
                            ltbCompareResult.Items.Add($"The best method of mean is = {methods[MeanbestPosition]}");
                            ltbCompareResult.Items.Add($"Its best mean objective value is = {Mean_compare[MeanbestPosition]}");

                            ltbSolutions.Items.Add("-------------------------- Below is the best solution and objevtive with each method --------------------------");
                            ltbSolutions.Items.Add($"PSO Solver :");
                            ltbSolutions.Items.Add($"Average of So Far The Best Objective Value = {PSO_Mean}");
                            ltbSolutions.Items.Add($"Standard deviation of So Far The Best Objective Value = {PSO_Std}");
                            ltbSolutions.Items.Add($"The Best Objective Value = {PSO_CV_Objective[PSO_bestPosition]}");
                            ltbSolutions.Items.Add($"The Best Solution = {sofarthebest[0]}");
                            ltbSolutions.Items.Add("");
                            ltbSolutions.Items.Add($"GA Solver :");
                            ltbSolutions.Items.Add($"Average of So Far The Best Objective Value = {GA_Mean}");
                            ltbSolutions.Items.Add($"Standard deviation of So Far The Best Objective Value = {GA_Std}");
                            ltbSolutions.Items.Add($"The Best Objective Value = {GA_CV_Objective[GA_bestPosition]}");
                            ltbSolutions.Items.Add($"The Best Solution = {sofarthebest[1]}");
                            ltbSolutions.Items.Add("");
                            ltbSolutions.Items.Add($"BAS Solver :");
                            ltbSolutions.Items.Add($"Average of So Far The Best Objective Value = {BAS_Mean}");
                            ltbSolutions.Items.Add($"Standard deviation of So Far The Best Objective Value = {BAS_Std}");
                            ltbSolutions.Items.Add($"The Best Objective Value = {BAS_CV_Objective[BAS_bestPosition]}");
                            ltbSolutions.Items.Add($"The Best Solution = {sofarthebest[2]}");
                            ltbSolutions.Items.Add("");
                            ltbSolutions.Items.Add($"BSO Solver :");
                            ltbSolutions.Items.Add($"Average of So Far The Best Objective Value = {BSO_Mean}");
                            ltbSolutions.Items.Add($"Standard deviation of So Far The Best Objective Value = {BSO_Std}");
                            ltbSolutions.Items.Add($"The Best Objective Value = {BSO_CV_Objective[BSO_bestPosition]}");
                            ltbSolutions.Items.Add($"The Best Solution = {sofarthebest[3]}");
                            ltbSolutions.Items.Add("");
                            ltbSolutions.Items.Add($"BSAS Solver :");
                            ltbSolutions.Items.Add($"Average of So Far The Best Objective Value = {BSAS_Mean}");
                            ltbSolutions.Items.Add($"Standard deviation of So Far The Best Objective Value = {BSAS_Std}");
                            ltbSolutions.Items.Add($"The Best Objective Value = {BSAS_CV_Objective[BSAS_bestPosition]}");
                            ltbSolutions.Items.Add($"The Best Solution = {sofarthebest[4]}");
                        }
                    }
                }
            }
            else if (rbtnExecuteTime.Checked)
            {
                progressbar.Maximum = Convert.ToInt32(nudCPUtime.Value);
                int ExecuteTime;
                if (rbtnPSO.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Value));
                    }
                    else
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                }
                else if (rbtnGA.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                    else
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                }
                else if (rbtnBAS.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                    else
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                }
                else if (rbtnBSAS.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                    else
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                }
                else if (rbtnBSO.Checked)
                {
                    if (cbxUpdate.Checked)
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                            MainChart.Update();
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                    else
                    {
                        do
                        {
                            DateTime cultime = DateTime.Now;
                            TimeSpan difference = cultime - startTime;
                            ExecuteTime = int.Parse(difference.Seconds.ToString());
                            progressbar.Step = ExecuteTime;
                            progressbar.PerformStep();
                            btnRunOneIteration_Click(null, null);
                        }
                        while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                    }
                }
                else if (rbtnCompareAll.Checked)
                {
                    if (Convert.ToInt32(nudCV.Value) == 1)
                    {
                        OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ?
                            OptimizationType.Minimization : OptimizationType.Maximization;
                        string[] methods = new string[] { "PSO Solver", "GA Solver", "BAS Solver", "BSO Solver", "BSAS Solver" };
                        double[] objective = new double[5];
                        int bestPosition = -1;
                        if (cbxUpdate.Checked)
                        {
                            do
                            {
                                DateTime cultime = DateTime.Now;
                                TimeSpan difference = cultime - startTime;
                                ExecuteTime = int.Parse(difference.Seconds.ToString());
                                progressbar.Step = ExecuteTime;
                                progressbar.PerformStep();
                                btnRunOneIteration_Click(null, null);
                                chtCompare.Update();
                            }
                            while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                        }
                        else
                        {
                            do
                            {
                                DateTime cultime = DateTime.Now;
                                TimeSpan difference = cultime - startTime;
                                ExecuteTime = int.Parse(difference.Seconds.ToString());
                                progressbar.Step = ExecuteTime;
                                progressbar.PerformStep();
                                btnRunOneIteration_Click(null, null);
                            }
                            while (Convert.ToInt32(ExecuteTime) < Convert.ToInt32(nudCPUtime.Text));
                        }
                        string[] sofarthebest = new string[] { "", "", "", "", "" };
                        for (int i = 0; i < theProblem.Dimension; i++)
                        {
                            if (i != theProblem.Dimension - 1)
                            {
                                sofarthebest[0] += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[1] += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[2] += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[3] += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                                sofarthebest[4] += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")}, ";
                            }
                            else
                            {
                                sofarthebest[0] += $"{PSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[1] += $"{GASolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[2] += $"{BASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[3] += $"{BSOSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                                sofarthebest[4] += $"{BSASSolver.SoFarTheBestSolution[i].ToString("0.0000")} ";
                            }
                        }
                        objective[0] = PSOSolver.SoFarTheBestObjective; objective[1] = GASolver.SoFarTheBestObjectiveValue;
                        objective[2] = BASSolver.SoFarTheBestObjective; objective[3] = BSOSolver.SoFarTheBestObjective; objective[4] = BSASSolver.SoFarTheBestObjective;
                        if (type == OptimizationType.Minimization)
                        {
                            double TheBestObjective = double.MaxValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] < TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        else
                        {
                            double TheBestObjective = double.MinValue;
                            for (int i = 0; i < objective.Length; i++)
                            {
                                if (objective[i] > TheBestObjective)
                                {
                                    TheBestObjective = objective[i];
                                    bestPosition = i;
                                }
                            }
                        }
                        ltbCompareResult.Font = new Font("Consolas", 12, FontStyle.Bold);
                        ltbCompareResult.ForeColor = Color.Red;
                        ltbCompareResult.Items.Add($"The best method is = {methods[bestPosition]}");
                        ltbCompareResult.Items.Add($"Its best objective value is = { objective[bestPosition]}");
                        ltbCompareResult.Items.Add($"Its best solution is = { sofarthebest[bestPosition]}");
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Cross Validation is not suitable for this stop condition choose.\nPlease select Stop Condition Choose of Iteration while CV number larger than 1.","See the note",MessageBoxButtons.OK,MessageBoxIcon.Error);                      
                        return;
                    }
                }
            }
            Cursor = Cursors.Default;
            DateTime endTime = DateTime.Now;
            TimeSpan delta = endTime - startTime;
            labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            if (Convert.ToInt32(nudCV.Value) > 1)
            {
                MessageBox.Show("Cross Validations have finished !!");
                return;
            }
            MessageBox.Show("Execution finished !!");
            btnRunEnd.Enabled = false;
            btnRunOneIteration.Enabled = false;
        }

        private void Solvers_CheckedChanged(object sender, EventArgs e)
        {
            btnCreateSolver.Enabled = true;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
            theGrid.SelectedObject = null;
            labMessage.Text = "Time Spent";
            if (rbtnCompareAll.Checked)
            {
                ltbSolutions.Items.Clear();
                chtCompare.Series[0].Points.Clear();
                chtCompare.Series[1].Points.Clear();
                chtCompare.Series[2].Points.Clear();
                chtCompare.Series[3].Points.Clear();
                chtCompare.Series[4].Points.Clear();
                theProblem.DisplayObjectiveGraphics(tabObjective);
                tabChart.SelectedTab = tabCompare;
                chtCompare.Series[0].Name = "PSO";
                chtCompare.Series[1].Name = "GA";
                chtCompare.Series[2].Name = "BAS";
                chtCompare.Series[3].Name = "BSO";
                chtCompare.Series[4].Name = "BSAS";
                rtbSoFarTheBestSolution.Text = "請看左下Solution Info，可以看到各方法的當前最好解。";
                rtbSoFarTheBestSolution.Font = new Font("Consolas",12,FontStyle.Bold);
                rtbSoFarTheBestSolution.ForeColor = Color.Blue;
                labSoFarTheShortestLength.Text = "";
                labSoFarTheBestSolution.Text = "";
                tabDisplay.SelectedTab = tabSolutionInfo;
                labSD.Visible = true;
                nudSD.Visible = true;
                labCV.Visible = true;
                nudCV.Visible = true;
                ltbCompareResult.Visible = true;
            }
            else
            {
                ltbSolutions.Items.Clear();
                MainChart.Series[0].Points.Clear();
                MainChart.Series[1].Points.Clear();
                MainChart.Series[2].Points.Clear();
                theProblem.DisplayObjectiveGraphics(tabObjective);
                tabChart.SelectedTab = tabMethod;
                labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
                labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
                MainChart.Series[0].Name = "Iteration Average";
                MainChart.Series[1].Name = "Iteration Best";
                MainChart.Series[2].Name = "So Far The Best";
                rtbSoFarTheBestSolution.Clear();
                rtbSoFarTheBestSolution.Font = new Font("Consolas", 10, FontStyle.Regular);
                rtbSoFarTheBestSolution.ForeColor = Color.Black;
                tabDisplay.SelectedTab = tabObjective;
                labSD.Visible = false;
                nudSD.Visible = false;
                labCV.Visible = false;
                nudCV.Visible = false;
                ltbCompareResult.Visible = false;
            }
        }

        private void StopCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIterationLimit.Checked)
            {
                nudIterationLimit.Enabled = true;
                nudCPUtime.Enabled = false;
            }
            else if (rbtnExecuteTime.Checked)
            {
                btnRunOneIteration.Enabled = false;
                nudIterationLimit.Enabled = false;
                nudCPUtime.Enabled = true;
                if(rbtnCompareAll.Checked)
                    MessageBox.Show("It is only for Run to end and Cross Validation equal 1.", "Friendly notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("It is only for Run to end.", "Friendly notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void nudCV_ValueChanged(object sender, EventArgs e)
        {
            if(nudCV.Value == 1)
            {
                chtCompareCV.Visible = false;
                chtCompare.Visible = true;
            }
            else
            {
                chtCompareCV.Visible = true;
                chtCompare.Visible = false;
            }
        }
    }
}
