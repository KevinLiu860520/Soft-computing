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

namespace R08546002YCLiuAss07
{
    public partial class MainForm : Form
    {
        JobAssignmentProblem theProblem;
        public MainForm()
        {
            InitializeComponent();
            theProblem = new JobAssignmentProblem();
            ckxQuickRecursive.Checked = true;
            ckxShowDetails.Checked = true;
            btnBrutalForce.Enabled = false;
        }

        int NumberofJobs;
        double[,] SetupTimes;
        double minimum;

        private void tspOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            theProblem.OpenFile(dlgOpen.FileName);
            minimum = double.MaxValue;
            dgvSetupTimeMatrix.Columns.Clear();
            dgvSetupTimeMatrix.Rows.Clear();

            char[] seps = new char[3] { ' ', ',', '\t' };
            //read file 開檔案
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            string str = sr.ReadLine();
            NumberofJobs = Convert.ToInt32(str);
            SetupTimes = new double[NumberofJobs, NumberofJobs];
            labJobsCount.Visible = true;
            labJobsCount.Text = Convert.ToString(NumberofJobs);
            for (int i = 0; i < NumberofJobs; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = $"m{i}";
                col.Width = 50;
                dgvSetupTimeMatrix.Columns.Add(col);
                dgvSetupTimeMatrix.Rows.Add();
            }
            //read each line
            for (int i = 0; i < NumberofJobs; i++)
            {
                str = sr.ReadLine();
                string[] items = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < NumberofJobs; j++)
                {
                    SetupTimes[i, j] = Convert.ToDouble(items[j]);
                    dgvSetupTimeMatrix.Rows[i].Cells[j].Value = Convert.ToDouble(items[j]);
                }
            }
            sr.Close();
            btnBrutalForce.Enabled = true;
            labBestSolution.Text = $"Best Solution :";
            labBestObjective.Text = $"Best Objective :";
            labOptimumSolution.Text = $"Shortest Setup Time :";
            labShortestSetupTime.Text = $"Optimum Solution :";
        }

        int []assignment;
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
            labMessage.Text =  $"Start:{startime}  End: {endTime} Time Spent{delta.TotalSeconds} sec";
            MessageBox.Show("Global Optimum Found!!");
        }

        // Recursive Method
        void RecursiveMethod( int id)
        {
            for(int i =0; i < flags.Length; i++)
            {
                if (flags[i]) continue;
                flags[i] = true;
                assignment[id] = i;
                if(id == flags.Length -1)
                {
                    if(ckxShowDetails.Checked == true)
                    {
                        //done for this assigment, evaluate its value
                        string answer = "";
                        foreach (int job in assignment)
                            answer += $"{job}";
                        double objective = theProblem.GetTotalSetupTimeForAnAssignment(assignment);
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
                        double objective = theProblem.GetTotalSetupTimeForAnAssignment(assignment);
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
    }
}
