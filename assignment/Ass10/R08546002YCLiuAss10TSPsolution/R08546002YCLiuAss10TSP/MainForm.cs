using System;
using GeneticAlgorithmLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSPBenchmark;

namespace R08546002YCLiuAss10TSP
{
    public partial class MainForm : Form
    {
        AntColonySystemForTSP theACSSolver;
        PermutationGASolver thePermutationSolver;
        //TSPBenchmarkProblem theProblem;

        public MainForm()
        {
            InitializeComponent();
            btnCreateACSSolver.Enabled = false;
            btnCreateGA.Enabled = false;
            rbtnGeneralGA.Checked = true;
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
            cbxUpdate.Checked = true;
        }
        private void btnOpenTSP_Click(object sender, EventArgs e)
        {
            theACSSolver = null;
            int status = TSPBenchmarkProblem.ImportATSPFile(true, true);
            tabCityRoute.Refresh();
            labShortestLength.Text = $"Known shortest length:\n{TSPBenchmarkProblem.OptimumObjective:0.00}";
            rtbData.Clear();
            rtbData.Text = TSPBenchmarkProblem.FileContents;
            labTitle.Text = "Title : " + TSPBenchmarkProblem.Name;
            labNumberOfCities.Text = "Number Of Cities : " + TSPBenchmarkProblem.NumberOfCities;
            labShortestLength.Text = "Shortest Length : " + TSPBenchmarkProblem.OptimumObjective;
            TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(tabCityRoute.CreateGraphics(),
                    tabCityRoute.Width, tabCityRoute.Height, TSPBenchmarkProblem.GetGreedyShortestRoute());

            btnCreateACSSolver.Enabled = true;
            btnCreateGA.Enabled = true;
            btnReset.Enabled = false;
        }
        private void tabCityRoute_Paint(object sender, PaintEventArgs e)
        {
            TSPBenchmarkProblem.DrawCitesAndARoute(e.Graphics, tabCityRoute.Width,
                tabCityRoute.Height, null);
            if (theACSSolver != null)
                TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics, tabCityRoute.Width,
                    tabCityRoute.Height, theACSSolver.SoFarTheBestSolution);
        }
        private void btnCreateACSSolver_Click(object sender, EventArgs e)
        {
            thePermutationSolver = null;
            theACSSolver = new AntColonySystemForTSP(TSPBenchmarkProblem.NumberOfCities,
                TSPBenchmarkProblem.ComputeRouteLength, TSPBenchmarkProblem.FromToDistanceMatrix);
            theGrid.SelectedObject = theACSSolver;
            btnReset.Enabled = true;
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ltbPheromone.Items.Clear();
            ltbSolutions.Items.Clear();
            Mainchart.Series[0].Points.Clear();
            Mainchart.Series[1].Points.Clear();
            Mainchart.Series[2].Points.Clear();
            rtbSoFarTheBestSolution.Clear();
            if (tabMethod.SelectedTab == tabACSMethod)
            {
                theACSSolver.Reset();
                progressbar.Maximum = theACSSolver.IterationLimit;
                theGrid.SelectedObject = theACSSolver;
            }
            else if(tabMethod.SelectedTab == tabGAMethod)
            {
                if (rbtnGeneralGA.Checked)
                {
                    thePermutationSolver.Reset();
                    theGrid.SelectedObject = thePermutationSolver;
                }
            }
            btnRunOneIteration.Enabled = true;
            btnRunEnd.Enabled = true;
            labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            labSoFarTheBestSolution.Text = "So Far The Best Solution : ";
            labMessage.Text = "Time Spent";
            progressbar.Minimum = 0;
            progressbar.Value = 0;
            progressbar.Step = 1;
        }
        private void btnCreateGA_Click(object sender, EventArgs e)
        {
            if (rbtnGeneralGA.Checked)
            {
                theACSSolver = null;
                thePermutationSolver = new PermutationGASolver(TSPBenchmarkProblem.NumberOfCities, GeneticAlgorithmLibrary.OptimizationType.Minimization, TSPBenchmarkProblem.ComputeObjectiveValue);
                theGrid.SelectedObject = thePermutationSolver;
                thePermutationSolver.GeneBasedMutation = false;
                btnReset.Enabled = true;
                btnRunOneIteration.Enabled = false;
                btnRunEnd.Enabled = false;
            }
        }
        protected void AddPointIntoChart()
        {
            //ACS
            if (tabMethod.SelectedTab == tabACSMethod)
            {
                Mainchart.Series[0].Points.AddXY(theACSSolver.IterationCount, theACSSolver.IterationAverageObjective);
                Mainchart.Series[1].Points.AddXY(theACSSolver.IterationCount, theACSSolver.IterationBestObjective);
                Mainchart.Series[2].Points.AddXY(theACSSolver.IterationCount, theACSSolver.SoFarTheBestObjective);
            }
            //Permutation GA 
            else if (tabMethod.SelectedTab == tabGAMethod)
            {
                Mainchart.Series[0].Points.AddXY(thePermutationSolver.IterationCount, thePermutationSolver.IterationAverageObjective);
                Mainchart.Series[1].Points.AddXY(thePermutationSolver.IterationCount, thePermutationSolver.IterationBestObjective);
                Mainchart.Series[2].Points.AddXY(thePermutationSolver.IterationCount, thePermutationSolver.SoFarTheBestObjectiveValue);
            }
        }
        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            if (tabMethod.SelectedTab == tabACSMethod)
            {
                ltbPheromone.Items.Clear();
                ltbSolutions.Items.Clear();
                theACSSolver.RunOneIteration();
                AddPointIntoChart();
                if (ckxShowPheromone.Checked == true)
                {
                    for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                    {
                        string Pheromone = "";
                        for (int j = 0; j < TSPBenchmarkProblem.NumberOfCities; j++)
                        {
                            Pheromone += $"{theACSSolver.pheromoneMap[i, j].ToString("#0.0000")} ";
                        }
                        ltbPheromone.Items.Add($"{Pheromone}");
                    }
                }

                if (ckxShowSolutions.Checked == true)
                {
                    for (int i = 0; i < theACSSolver.NumberOfAnts; i++)
                    {
                        string Solutions = "";
                        foreach (int cities in theACSSolver.solutions[i])
                        {
                            Solutions += $"{cities.ToString()} ";
                        }
                        ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                    }
                }
                tabCityRoute.Refresh();
                progressbar.PerformStep();    
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theACSSolver.SoFarTheBestObjective}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                {
                    rtbSoFarTheBestSolution.Text += $"{theACSSolver.SoFarTheBestSolution[i]} ";
                }
            }
            else if (tabMethod.SelectedTab == tabGAMethod)
            {
                if (rbtnGeneralGA.Checked)
                {
                    ltbSolutions.Items.Clear();
                    thePermutationSolver.RunOneIterarion();
                    AddPointIntoChart();
                    if (ckxShowSolutions.Checked == true)
                    {
                        for (int i = 0; i < thePermutationSolver.PopulationSize; i++)
                        {
                            string Solutions = "";
                            foreach (int cities in thePermutationSolver.chromosomes[i])
                            {
                                Solutions += $"{cities.ToString()} ";
                            }
                            ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                        }
                    }
                }
                tabCityRoute.Refresh();
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {thePermutationSolver.SoFarTheBestObjectiveValue}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                {
                    rtbSoFarTheBestSolution.Text += $"{thePermutationSolver.SoFarTheBestSolution[i]} ";
                }
            }
        }

        private void btnRunEnd_Click(object sender, EventArgs e)
        {
            if (theACSSolver != null)
            {
                if (cbxUpdate.Checked)
                {
                    DateTime startTime = DateTime.Now;
                    do
                    {
                        btnRunOneIteration_Click(null, null);
                        AddPointIntoChart();
                        Mainchart.Update();
                        progressbar.PerformStep();
                    }
                    while (theACSSolver.IterationCount < theACSSolver.IterationLimit);

                    string GABestSolution;
                    GABestSolution = new string(new char[] { });
                    theACSSolver.RunOneIteration();
                    if (ckxShowPheromone.Checked == true)
                    {
                        for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                        {
                            string Pheromone = "";
                            for (int j = 0; j < TSPBenchmarkProblem.NumberOfCities; j++)
                            {
                                Pheromone += $"{theACSSolver.pheromoneMap[i, j].ToString("0.0000")} ";
                            }
                            ltbPheromone.Items.Add($"{Pheromone}");
                        }
                        ltbPheromone.Refresh();
                    }

                    if (ckxShowSolutions.Checked == true)
                    {
                        for (int i = 0; i < theACSSolver.NumberOfAnts; i++)
                        {
                            string Solutions = "";
                            foreach (int cities in theACSSolver.solutions[i])
                            {
                                Solutions += $"{cities.ToString()} ";
                            }
                            ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                        }
                        ltbSolutions.Refresh();
                    }
                    tabCityRoute.Refresh();
                    labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theACSSolver.SoFarTheBestObjective}";
                    rtbSoFarTheBestSolution.Text = "";
                    for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                    {
                        rtbSoFarTheBestSolution.Text += $"{theACSSolver.SoFarTheBestSolution[i]} ";
                    }
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
                        AddPointIntoChart();
                    }
                    while (theACSSolver.IterationCount < theACSSolver.IterationLimit);

                    string GABestSolution;
                    GABestSolution = new string(new char[] { });
                    theACSSolver.RunOneIteration();
                    if (ckxShowPheromone.Checked == true)
                    {
                        for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                        {
                            string Pheromone = "";
                            for (int j = 0; j < TSPBenchmarkProblem.NumberOfCities; j++)
                            {
                                Pheromone += $"{theACSSolver.pheromoneMap[i, j].ToString("0.0000")} ";
                            }
                            ltbPheromone.Items.Add($"{Pheromone}");
                        }
                        
                    }

                    if (ckxShowSolutions.Checked == true)
                    {
                        for (int i = 0; i < theACSSolver.NumberOfAnts; i++)
                        {
                            string Solutions = "";
                            foreach (int cities in theACSSolver.solutions[i])
                            {
                                Solutions += $"{cities.ToString()} ";
                            }
                            ltbSolutions.Items.Add($"{i.ToString("0000")} solution = {Solutions} ");
                        }
                       
                    }
                    tabCityRoute.Refresh();
                    labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {theACSSolver.SoFarTheBestObjective}";
                    rtbSoFarTheBestSolution.Text = "";
                    for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                    {
                        rtbSoFarTheBestSolution.Text += $"{theACSSolver.SoFarTheBestSolution[i]} ";
                    }
                    DateTime endTime = DateTime.Now;
                    TimeSpan delta = endTime - startTime;
                    labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
                }
            }
            else if (thePermutationSolver != null)
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnRunOneIteration_Click(null, null);
                    AddPointIntoChart();
                    Mainchart.Update();
                }
                while (thePermutationSolver.IterationCount < thePermutationSolver.IterationLimit);
                tabCityRoute.Refresh();
                //Objective and Solution
                tabCityRoute.Refresh();
                labSoFarTheShortestLength.Text = $"So Far The Shortest Length : {thePermutationSolver.SoFarTheBestObjectiveValue}";
                rtbSoFarTheBestSolution.Text = "";
                for (int i = 0; i < TSPBenchmarkProblem.NumberOfCities; i++)
                {
                    rtbSoFarTheBestSolution.Text += $"{thePermutationSolver.SoFarTheBestSolution[i]} ";
                }
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            MessageBox.Show("Local Optimum Found!!");
            btnRunOneIteration.Enabled = false;
            btnRunEnd.Enabled = false;
        }

        private void tabMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMethod.SelectedTab == tabACSMethod)
            {
                btnCreateACSSolver.Enabled = true;
                btnCreateGA.Enabled = false;
                rbtnGeneralGA.Checked = true;
                btnReset.Enabled = false;
                btnRunOneIteration.Enabled = false;
                btnRunEnd.Enabled = false;
                cbxUpdate.Checked = true;
            }
            else if (tabMethod.SelectedTab == tabGAMethod)
            {
                btnCreateACSSolver.Enabled = false;
                btnCreateGA.Enabled = false;
                rbtnGeneralGA.Checked = true;
                btnReset.Enabled = false;
                btnRunOneIteration.Enabled = false;
                btnRunEnd.Enabled = false;
                cbxUpdate.Checked = true;
            }
        }
    }
}
