using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticAlgorithmLibrary;

namespace JobAssignmentProblemGASlover
{
    public partial class MainForm : Form
    {
        JobAssignmentProblem theProblem;
        PermutationGASolver thePermutationGA;
        BinaryGASolver theBinaryGA;

        public MainForm()
        {
            InitializeComponent();
            theProblem = new JobAssignmentProblem();
            txbPenalty.Text = theProblem.Penalty.ToString();
            ckxQuickRecursive.Checked = true;
            ckxShowDetails.Checked = true;
            btnBrutalForce.Enabled = false;
            btnCreatePermutationGASolver.Enabled = false;
            btnCreateBinaryGASolver.Enabled = false;
            btnReset.Enabled = false;
            btnRunoneiteration.Enabled = false;
            btnRunEnd.Enabled = false;
        }
        int NumberofJobs;
        double[,] SetupTimes;
        double minimum;
        // Assignment 7
        private void tspOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            theProblem.OpenFile(dlgOpen.FileName);
            for (int r = 0; r < theProblem.NumberOfJobs; r++)
                dgvSetupTimeMatrix.Columns.Add($"Column{r + 1}", $"Job{r + 1}");
            dgvSetupTimeMatrix.Rows.Add(theProblem.NumberOfJobs);
            for (int r = 0; r < theProblem.NumberOfJobs; r++)
                for (int c = 0; c < theProblem.NumberOfJobs; c++)
                    dgvSetupTimeMatrix.Rows[r].Cells[c].Value = theProblem.SetupTimes[r, c];

            btnBrutalForce.Enabled = true;
            btnCreatePermutationGASolver.Enabled = true;
            btnCreateBinaryGASolver.Enabled = true;
            labBestSolution.Text = $"Best Solution :";
            labBestObjective.Text = $"Best Objective :";
            labOptimumSolution.Text = $"Shortest Setup Time :";
            labShortestSetupTime.Text = $"Optimum Solution :";
        }
        int[] assignment;
        bool[] flags;
        string BestAnswerString;
        int cnt = 0;
        private void btnBrutalForce_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Cursor = Cursors.WaitCursor;
            assignment = new int[theProblem.NumberOfJobs];
            flags = new bool[theProblem.NumberOfJobs];
            for (int i = 0; i < flags.Length; i++)
                flags[i] = false;
            Cursor = Cursors.Default;

            DateTime startime = DateTime.Now;
            RecursiveMethod(0);
            DateTime endTime = DateTime.Now;
            TimeSpan delta = endTime - startime;
            labMessage.Text = $"Start:{startime}  End: {endTime} Time Spent{delta.TotalSeconds} sec";
            MessageBox.Show("Global Optimum Found!!");
        }
        void RecursiveMethod(int id)
        {
            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i]) continue;
                flags[i] = true;
                assignment[id] = i;
                if (id == flags.Length - 1)
                {
                    if (ckxShowDetails.Checked == true)
                    {
                        //done for this assigment, evaluate its value
                        string answer = "";
                        foreach (int job in assignment)
                            answer += $"{job}";
                        double objective = theProblem.GetTotalSetupTimeForAnAssignment7(assignment);
                        richTextBox1.AppendText($"{cnt++.ToString("NO.000000")} solution = {answer} ,objective= {objective}\n");
                        if (objective < minimum)
                        {
                            minimum = objective;
                            BestAnswerString = "";
                            for (int j = 0; j < NumberofJobs; j++)
                            {
                                BestAnswerString += $"{answer[j]} ";
                            }
                        }
                    }
                    else
                    {
                        //done for this assigment, evaluate its value
                        string answer = "";
                        foreach (int job in assignment)
                            answer += $"{job}";
                        double objective = theProblem.GetTotalSetupTimeForAnAssignment7(assignment);
                        if (objective < minimum)
                        {
                            minimum = objective;
                            BestAnswerString = "";
                            for (int j = 0; j < NumberofJobs; j++)
                            {
                                BestAnswerString += $"{answer[j]} ";
                            }
                        }
                    }
                }
                else
                {
                    RecursiveMethod(id + 1);
                }
                flags[i] = false;
            }
            labBestSolution.Text = $"Best Solution : {BestAnswerString}";
            labBestObjective.Text = $"Best Objective : {minimum}";
            labOptimumSolution.Text = $"Shortest Setup Time : {BestAnswerString}";
            labShortestSetupTime.Text = $"Optimum Solution : {minimum}";
        }
        // Assignment 8 & 9
        private void btnCreateBinaryGASolver_Click(object sender, EventArgs e)
        {
            theBinaryGA = new BinaryGASolver(theProblem.NumberOfJobs * theProblem.NumberOfJobs,
                OptimizationType.Minimization, theProblem.GetTotalSetupTimeForAnAssignment); // cannot run
            propertyGrid1.SelectedObject = theBinaryGA;
            btnReset.Enabled = true;
        }
        private void btnCreatePermutationGASolver_Click(object sender, EventArgs e)
        {
            thePermutationGA = new PermutationGASolver(theProblem.NumberOfJobs,
               OptimizationType.Minimization, theProblem.GetObjectiveValue);
            propertyGrid1.SelectedObject = thePermutationGA;
            btnReset.Enabled = true;
        }
        private void txbPenalty_TextChanged(object sender, EventArgs e)
        {
            theProblem.Penalty = Convert.ToDouble(txbPenalty.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //button
            btnRunoneiteration.Enabled = true;
            btnRunEnd.Enabled = true;
            labGABestSolution.Visible = true;
            labViolations.Text = "Total violations: 0";
            //Chart
            chartGA.Series[0].Points.Clear();
            chartGA.Series[1].Points.Clear();
            chartGA.Series[2].Points.Clear();
            labGABestObjective.Text = $"Best Objective : ";
            labGABestSolution.Text = $"Best Solution : ";
            //Binary GA
            if (rdoBinaryGA.Checked)
            {
                theBinaryGA.Reset();
                propertyGrid1.SelectedObject = theBinaryGA;
            }
            //Permutation GA
            else if (rdoPermutationGA.Checked)
            {
                thePermutationGA.Reset();
                propertyGrid1.SelectedObject = thePermutationGA;
            }
        }
        protected void AddPointIntoChart()
        {
            //binary GA
            if (rdoBinaryGA.Checked)
            {
                chartGA.Series[0].Points.AddXY(theBinaryGA.IterationCount, theBinaryGA.IterationAverageObjective);
                chartGA.Series[1].Points.AddXY(theBinaryGA.IterationCount, theBinaryGA.IterationBestObjective);
                chartGA.Series[2].Points.AddXY(theBinaryGA.IterationCount, theBinaryGA.SoFarTheBestObjectiveValue);
            }
            //Permutation GA 
            else
            {
                chartGA.Series[0].Points.AddXY(thePermutationGA.IterationCount, thePermutationGA.IterationAverageObjective);
                chartGA.Series[1].Points.AddXY(thePermutationGA.IterationCount, thePermutationGA.IterationBestObjective);
                chartGA.Series[2].Points.AddXY(thePermutationGA.IterationCount, thePermutationGA.SoFarTheBestObjectiveValue);
            }
        }

        private void btnRunoneiteration_Click(object sender, EventArgs e)
        {
            //binary GA
            if (rdoBinaryGA.Checked)
            {
                string GABestSolution;
                GABestSolution = new string(new char[] { });
                theBinaryGA.RunOneIterarion();
                //Objective and Solution
                for (int i = 0; i < NumberofJobs * NumberofJobs; i++)
                {
                    GABestSolution += Convert.ToString(theBinaryGA.SoFarTheBestSolution[i]);
                    if ((i + 1) % NumberofJobs == 0) { GABestSolution += "\n"; }
                }
                labViolations.Text = $"Total violations: {Convert.ToString(theProblem.ViolationCount(theBinaryGA.SoFarTheBestSolution))}";
                labGABestObjective.Text = $"Best Objective : {Convert.ToString(theBinaryGA.SoFarTheBestObjectiveValue)}";
                labGABestSolution.Text = $"Best Solution :\n{GABestSolution}";
                AddPointIntoChart();                         
            }
            //Permutation GA 
            else
            {
                thePermutationGA.RunOneIterarion();
                //Objective and Solution
                labGABestObjective.Text = $"Best Objective : {thePermutationGA.SoFarTheBestObjectiveValue}";
                labGABestSolution.Text = $"Best Solution :\n";
                for (int i = 0; i < NumberofJobs; i++)
                {
                    labGABestSolution.Text += thePermutationGA.SoFarTheBestSolution[i] + " ";
                }
                AddPointIntoChart();
            }

        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBinaryGA.Checked)
            {
                thePermutationGA = null;
                btnCreateBinaryGASolver.Visible = true;
                btnCreatePermutationGASolver.Visible = false;
                btnReset.Enabled = false;
                txbPenalty.Visible = true;
                labPenalty.Visible = true;
                labViolations.Visible = true;
            }
            else
            {
                theBinaryGA = null;
                btnCreateBinaryGASolver.Visible = false;
                btnCreatePermutationGASolver.Visible = true;
                btnReset.Enabled = false;
                txbPenalty.Visible = false;
                labPenalty.Visible = false;
                labViolations.Visible = false;
            }
        }

        private void btnRunEnd_Click(object sender, EventArgs e)
        {
            if (theBinaryGA != null)
            {
                DateTime startTime = DateTime.Now;
                do 
                { 
                    btnRunoneiteration_Click(null, null);
                    AddPointIntoChart();
                    chartGA.Update();
                }
                while (theBinaryGA.IterationCount < theBinaryGA.IterationLimit);

                string GABestSolution;
                GABestSolution = new string(new char[] { });
                theBinaryGA.RunOneIterarion();
                //Objective and Solution
                for (int i = 0; i < NumberofJobs * NumberofJobs; i++)
                {
                    GABestSolution += Convert.ToString(theBinaryGA.SoFarTheBestSolution[i]);
                    if ((i + 1) % NumberofJobs == 0) { GABestSolution += "\n"; }
                }
                labViolations.Text = $"Total violations: {Convert.ToString(theProblem.ViolationCount(theBinaryGA.SoFarTheBestSolution))}";
                labGABestObjective.Text = $"Best Objective : {Convert.ToString(theBinaryGA.SoFarTheBestObjectiveValue)}";
                labGABestSolution.Text = $"Best Solution :\n{GABestSolution}";
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            else if (thePermutationGA != null)
            {
                DateTime startTime = DateTime.Now;
                do 
                { 
                    btnRunoneiteration_Click(null, null);
                    AddPointIntoChart();
                    chartGA.Update();
                }
                while (thePermutationGA.IterationCount < thePermutationGA.IterationLimit);
                thePermutationGA.RunOneIterarion();
                //Objective and Solution
                labGABestObjective.Text = $"Best Objective : {thePermutationGA.SoFarTheBestObjectiveValue}";
                labGABestSolution.Text = $"Best Solution :\n";
                for (int i = 0; i < NumberofJobs; i++)
                {
                    labGABestSolution.Text += thePermutationGA.SoFarTheBestSolution[i] + " ";
                }
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
            }
            MessageBox.Show("Local Optimum Found!!");
            btnRunoneiteration.Enabled = false;
            btnRunEnd.Enabled = false;
        }
    }
}
