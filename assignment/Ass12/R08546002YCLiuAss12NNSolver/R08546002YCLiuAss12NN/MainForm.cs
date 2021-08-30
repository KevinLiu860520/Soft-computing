using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R08546002YCLiuAss12NN
{
    public partial class MainForm : Form
    {
        BackPropagationMLP MLPslover;
        int[] hiddenLayerNeuronNumbers;
        int hiddenlayer = 1;
        public MainForm()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnTrainAnEpoch.Enabled = false;
            btnTrainToEnd.Enabled = false;
            btnClassificationTest.Enabled = false;

            object[] pars = new object[] { ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true };   
            MethodInfo setStyleMethodPanel = typeof(Panel).GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);  //為物件位階非類別位階|未開放  
            setStyleMethodPanel.Invoke(spcThird.Panel2, pars);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            labDataset.Text = "Data set: " + dlgOpen.SafeFileName;
            MLPslover = new BackPropagationMLP();
            MLPslover.ReadInDataSet(sr, MLPslover.TrainingRatio);
            theGrid.SelectedObject = MLPslover;
            sr = new StreamReader(dlgOpen.FileName);
            rtbDataInfomation.Text = sr.ReadToEnd();
            btnReset.Enabled = true;
            spcThird.Panel2.Refresh();
            chartRMSE.Series[0].Points.Clear();
        }
        private void nudHiddenNumbers_ValueChanged(object sender, EventArgs e)
        {
            if (nudHiddenNumbers.Value == 0)
            {
                MessageBox.Show("Hidden layer needs to larger than 0.");
                nudHiddenNumbers.Value = 1;
                return;
            }
            if (Convert.ToInt32(nudHiddenNumbers.Value) - lstHiddenNeuronNumber.Items.Count > 0)
            {
                int AddNumber = Convert.ToInt32(nudHiddenNumbers.Value) - lstHiddenNeuronNumber.Items.Count;
                for (int i =0; i< AddNumber; i++)
                {
                    lstHiddenNeuronNumber.Items.Add("3");
                }
                hiddenlayer++;
            }
            if (Convert.ToInt32(nudHiddenNumbers.Value) - lstHiddenNeuronNumber.Items.Count < 0)
            {
                int DeleteNumber = lstHiddenNeuronNumber.Items.Count - Convert.ToInt32(nudHiddenNumbers.Value);
                for (int i = 0; i < DeleteNumber; i++)
                {
                    lstHiddenNeuronNumber.Items.RemoveAt(lstHiddenNeuronNumber.Items.Count - 1);                   
                }
                hiddenlayer--;
            }
            hiddenLayerNeuronNumbers = new int[hiddenlayer];
            for (int i = 0; i < hiddenlayer; i++)
            {
                hiddenLayerNeuronNumbers[i] = Convert.ToInt32(lstHiddenNeuronNumber.Items[i]);
            }
            if (MLPslover == null) return;// Real-time observe the change after tune nudHiddenNumbers
            MLPslover.ConfigureNeuralNetwork(hiddenLayerNeuronNumbers);
            spcThird.Panel2.Refresh();
            btnTrainAnEpoch.Enabled = false;
            btnTrainToEnd.Enabled = false;
        }
        private void nudNeuronNumbers_ValueChanged(object sender, EventArgs e)
        {
            if (lstHiddenNeuronNumber.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select one hidden layer.");
                nudNeuronNumbers.Value = 3;
                return;
            }   
            lstHiddenNeuronNumber.Items[lstHiddenNeuronNumber.SelectedIndex] = nudNeuronNumbers.Value;
            hiddenLayerNeuronNumbers = new int[hiddenlayer];
            for (int i = 0; i < hiddenlayer; i++)
            {
                hiddenLayerNeuronNumbers[i] = Convert.ToInt32(lstHiddenNeuronNumber.Items[i]);
            }
            if (MLPslover == null) return; // Real-time observe the change after tune nudNeuronNumbers 
            MLPslover.ConfigureNeuralNetwork(hiddenLayerNeuronNumbers);
            spcThird.Panel2.Refresh();
        }
        private void spcThird_Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (MLPslover != null)
                MLPslover.DrawMLP(e.Graphics, e.ClipRectangle);
        }
        private void btnReset_Click(object sender, EventArgs e) // Combine configure and reset weight
        {
            hiddenlayer = Convert.ToInt32(nudHiddenNumbers.Value);
            hiddenLayerNeuronNumbers = new int[hiddenlayer];
            for (int i = 0; i < hiddenlayer; i++)
            {
                hiddenLayerNeuronNumbers[i] = Convert.ToInt32(lstHiddenNeuronNumber.Items[i]);
            }
            MLPslover.ConfigureNeuralNetwork(hiddenLayerNeuronNumbers);
            MLPslover.Reset();
            chartRMSE.Series[0].Points.Clear();

            labRMSE.Text = $"RMSE = ";
            labCorrectness.Text = $"Correcteness =";
            labConfusionMatrix.Text = "Confusion Matrix :";
            labMessage.Text = "Time Spent";

            progressBar.Maximum = MLPslover.EpochLimit;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            progressBar.Step = 1;

            btnTrainAnEpoch.Enabled = true;
            btnTrainToEnd.Enabled = true;
            spcThird.Panel2.Refresh();
        }

        private void btnTrainAnEpoch_Click(object sender, EventArgs e)
        {
            MLPslover.TrainAnEpoch();
            chartRMSE.Series[0].Points.AddXY(MLPslover.EpochCount, MLPslover.RootMeanSquareError);
            labRMSE.Text = $"RMSE = {MLPslover.RootMeanSquareError}";
            spcThird.Panel2.Refresh();
            btnClassificationTest.Enabled = true;
            progressBar.PerformStep();
        }

        private void btnTrainToEnd_Click(object sender, EventArgs e)
        {
            if (chxAnimateRMSEChart.Checked == true)
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnTrainAnEpoch_Click(null, null);
                    chartRMSE.Update();
                }
                while (MLPslover.EpochCount < MLPslover.EpochLimit);
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
                labRMSE.Text = "RMSE = " + MLPslover.RootMeanSquareError;
            }
            else
            {
                DateTime startTime = DateTime.Now;
                do
                {
                    btnTrainAnEpoch_Click(null, null);
                }
                while (MLPslover.EpochCount < MLPslover.EpochLimit);
                DateTime endTime = DateTime.Now;
                TimeSpan delta = endTime - startTime;
                labMessage.Text = $"Start at : {startTime} End at : {endTime} Time Spent : {delta}";
                labRMSE.Text = "RMSE = " + MLPslover.RootMeanSquareError;
            }
            btnClassificationTest.Enabled = true;
            btnTrainAnEpoch.Enabled = false;
            btnTrainToEnd.Enabled = false;
        }
        private void btnClassificationTest_Click(object sender, EventArgs e)
        {
            float Correctness = MLPslover.TestingClassification(out int[,] confusingTable);
            labCorrectness.Text = "Correctness = " + Correctness;
            labConfusionMatrix.Text = "Confusion Matrix :\n";
            for (int i = 0; i < MLPslover.TargetDimension; i++)
            {
                for (int j = 0; j < MLPslover.TargetDimension; j++)
                {
                    labConfusionMatrix.Text += $" {confusingTable[i, j]} ";
                }
                labConfusionMatrix.Text += "\n" + " ";
            }
            btnClassificationTest.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            spcThird.Panel2.Refresh(); // change form size also can see clear
        }
    }
}