namespace R08546002YCLiuAss12NN
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcSecond = new System.Windows.Forms.SplitContainer();
            this.nudNeuronNumbers = new System.Windows.Forms.NumericUpDown();
            this.chxAnimateRMSEChart = new System.Windows.Forms.CheckBox();
            this.nudHiddenNumbers = new System.Windows.Forms.NumericUpDown();
            this.lstHiddenNeuronNumber = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDataset = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneralizedDelta = new System.Windows.Forms.TabPage();
            this.labCorrectness = new System.Windows.Forms.Label();
            this.labRMSE = new System.Windows.Forms.Label();
            this.btnClassificationTest = new System.Windows.Forms.Button();
            this.btnTrainToEnd = new System.Windows.Forms.Button();
            this.btnTrainAnEpoch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.tabDataInfo = new System.Windows.Forms.TabPage();
            this.rtbDataInfomation = new System.Windows.Forms.RichTextBox();
            this.spcThird = new System.Windows.Forms.SplitContainer();
            this.chartRMSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.labConfusionMatrix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).BeginInit();
            this.spcSecond.Panel1.SuspendLayout();
            this.spcSecond.Panel2.SuspendLayout();
            this.spcSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuronNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenNumbers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneralizedDelta.SuspendLayout();
            this.tabDataInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).BeginInit();
            this.spcThird.Panel1.SuspendLayout();
            this.spcThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRMSE)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 27);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcSecond);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.spcMain.Panel2.Controls.Add(this.spcThird);
            this.spcMain.Size = new System.Drawing.Size(1223, 667);
            this.spcMain.SplitterDistance = 493;
            this.spcMain.TabIndex = 0;
            // 
            // spcSecond
            // 
            this.spcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSecond.Location = new System.Drawing.Point(0, 0);
            this.spcSecond.Name = "spcSecond";
            this.spcSecond.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcSecond.Panel1
            // 
            this.spcSecond.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spcSecond.Panel1.Controls.Add(this.nudNeuronNumbers);
            this.spcSecond.Panel1.Controls.Add(this.chxAnimateRMSEChart);
            this.spcSecond.Panel1.Controls.Add(this.nudHiddenNumbers);
            this.spcSecond.Panel1.Controls.Add(this.lstHiddenNeuronNumber);
            this.spcSecond.Panel1.Controls.Add(this.label3);
            this.spcSecond.Panel1.Controls.Add(this.label2);
            this.spcSecond.Panel1.Controls.Add(this.label1);
            this.spcSecond.Panel1.Controls.Add(this.labDataset);
            // 
            // spcSecond.Panel2
            // 
            this.spcSecond.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spcSecond.Panel2.Controls.Add(this.tabControl1);
            this.spcSecond.Size = new System.Drawing.Size(493, 667);
            this.spcSecond.SplitterDistance = 191;
            this.spcSecond.TabIndex = 0;
            // 
            // nudNeuronNumbers
            // 
            this.nudNeuronNumbers.Location = new System.Drawing.Point(335, 145);
            this.nudNeuronNumbers.Name = "nudNeuronNumbers";
            this.nudNeuronNumbers.Size = new System.Drawing.Size(130, 25);
            this.nudNeuronNumbers.TabIndex = 14;
            this.nudNeuronNumbers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNeuronNumbers.ValueChanged += new System.EventHandler(this.nudNeuronNumbers_ValueChanged);
            // 
            // chxAnimateRMSEChart
            // 
            this.chxAnimateRMSEChart.AutoSize = true;
            this.chxAnimateRMSEChart.Checked = true;
            this.chxAnimateRMSEChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxAnimateRMSEChart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxAnimateRMSEChart.Location = new System.Drawing.Point(204, 211);
            this.chxAnimateRMSEChart.Name = "chxAnimateRMSEChart";
            this.chxAnimateRMSEChart.Size = new System.Drawing.Size(174, 22);
            this.chxAnimateRMSEChart.TabIndex = 13;
            this.chxAnimateRMSEChart.Text = "Animate RMSE Chart";
            this.chxAnimateRMSEChart.UseVisualStyleBackColor = true;
            // 
            // nudHiddenNumbers
            // 
            this.nudHiddenNumbers.Location = new System.Drawing.Point(335, 83);
            this.nudHiddenNumbers.Name = "nudHiddenNumbers";
            this.nudHiddenNumbers.Size = new System.Drawing.Size(130, 25);
            this.nudHiddenNumbers.TabIndex = 12;
            this.nudHiddenNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHiddenNumbers.ValueChanged += new System.EventHandler(this.nudHiddenNumbers_ValueChanged);
            // 
            // lstHiddenNeuronNumber
            // 
            this.lstHiddenNeuronNumber.FormattingEnabled = true;
            this.lstHiddenNeuronNumber.ItemHeight = 15;
            this.lstHiddenNeuronNumber.Items.AddRange(new object[] {
            "3"});
            this.lstHiddenNeuronNumber.Location = new System.Drawing.Point(16, 61);
            this.lstHiddenNeuronNumber.Name = "lstHiddenNeuronNumber";
            this.lstHiddenNeuronNumber.Size = new System.Drawing.Size(182, 169);
            this.lstHiddenNeuronNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Neuron Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hidden Layers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hidden Layer Neuron Numbers";
            // 
            // labDataset
            // 
            this.labDataset.AutoSize = true;
            this.labDataset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labDataset.Location = new System.Drawing.Point(12, 14);
            this.labDataset.Name = "labDataset";
            this.labDataset.Size = new System.Drawing.Size(109, 23);
            this.labDataset.TabIndex = 6;
            this.labDataset.Text = "Data set:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneralizedDelta);
            this.tabControl1.Controls.Add(this.tabDataInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneralizedDelta
            // 
            this.tabGeneralizedDelta.Controls.Add(this.labConfusionMatrix);
            this.tabGeneralizedDelta.Controls.Add(this.labCorrectness);
            this.tabGeneralizedDelta.Controls.Add(this.labRMSE);
            this.tabGeneralizedDelta.Controls.Add(this.btnClassificationTest);
            this.tabGeneralizedDelta.Controls.Add(this.btnTrainToEnd);
            this.tabGeneralizedDelta.Controls.Add(this.btnTrainAnEpoch);
            this.tabGeneralizedDelta.Controls.Add(this.btnReset);
            this.tabGeneralizedDelta.Controls.Add(this.theGrid);
            this.tabGeneralizedDelta.Location = new System.Drawing.Point(4, 27);
            this.tabGeneralizedDelta.Name = "tabGeneralizedDelta";
            this.tabGeneralizedDelta.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralizedDelta.Size = new System.Drawing.Size(485, 441);
            this.tabGeneralizedDelta.TabIndex = 0;
            this.tabGeneralizedDelta.Text = "Generalized Delta";
            this.tabGeneralizedDelta.UseVisualStyleBackColor = true;
            // 
            // labCorrectness
            // 
            this.labCorrectness.AutoSize = true;
            this.labCorrectness.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorrectness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labCorrectness.Location = new System.Drawing.Point(257, 215);
            this.labCorrectness.Name = "labCorrectness";
            this.labCorrectness.Size = new System.Drawing.Size(112, 18);
            this.labCorrectness.TabIndex = 6;
            this.labCorrectness.Text = "Correctness =";
            // 
            // labRMSE
            // 
            this.labRMSE.AutoSize = true;
            this.labRMSE.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRMSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labRMSE.Location = new System.Drawing.Point(257, 108);
            this.labRMSE.Name = "labRMSE";
            this.labRMSE.Size = new System.Drawing.Size(56, 18);
            this.labRMSE.TabIndex = 5;
            this.labRMSE.Text = "RMSE =";
            // 
            // btnClassificationTest
            // 
            this.btnClassificationTest.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassificationTest.Location = new System.Drawing.Point(254, 170);
            this.btnClassificationTest.Name = "btnClassificationTest";
            this.btnClassificationTest.Size = new System.Drawing.Size(228, 42);
            this.btnClassificationTest.TabIndex = 4;
            this.btnClassificationTest.Text = "Classification Test";
            this.btnClassificationTest.UseVisualStyleBackColor = true;
            this.btnClassificationTest.Click += new System.EventHandler(this.btnClassificationTest_Click);
            // 
            // btnTrainToEnd
            // 
            this.btnTrainToEnd.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainToEnd.Location = new System.Drawing.Point(254, 63);
            this.btnTrainToEnd.Name = "btnTrainToEnd";
            this.btnTrainToEnd.Size = new System.Drawing.Size(228, 42);
            this.btnTrainToEnd.TabIndex = 3;
            this.btnTrainToEnd.Text = "Train To End";
            this.btnTrainToEnd.UseVisualStyleBackColor = true;
            this.btnTrainToEnd.Click += new System.EventHandler(this.btnTrainToEnd_Click);
            // 
            // btnTrainAnEpoch
            // 
            this.btnTrainAnEpoch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainAnEpoch.Location = new System.Drawing.Point(254, 6);
            this.btnTrainAnEpoch.Name = "btnTrainAnEpoch";
            this.btnTrainAnEpoch.Size = new System.Drawing.Size(228, 42);
            this.btnTrainAnEpoch.TabIndex = 2;
            this.btnTrainAnEpoch.Text = "Train An Epoch";
            this.btnTrainAnEpoch.UseVisualStyleBackColor = true;
            this.btnTrainAnEpoch.Click += new System.EventHandler(this.btnTrainAnEpoch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(248, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // theGrid
            // 
            this.theGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.theGrid.Location = new System.Drawing.Point(3, 54);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(248, 384);
            this.theGrid.TabIndex = 0;
            // 
            // tabDataInfo
            // 
            this.tabDataInfo.Controls.Add(this.rtbDataInfomation);
            this.tabDataInfo.Location = new System.Drawing.Point(4, 27);
            this.tabDataInfo.Name = "tabDataInfo";
            this.tabDataInfo.Size = new System.Drawing.Size(485, 593);
            this.tabDataInfo.TabIndex = 2;
            this.tabDataInfo.Text = "Data Infomation";
            this.tabDataInfo.UseVisualStyleBackColor = true;
            // 
            // rtbDataInfomation
            // 
            this.rtbDataInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDataInfomation.Location = new System.Drawing.Point(0, 0);
            this.rtbDataInfomation.Name = "rtbDataInfomation";
            this.rtbDataInfomation.Size = new System.Drawing.Size(485, 593);
            this.rtbDataInfomation.TabIndex = 0;
            this.rtbDataInfomation.Text = "";
            // 
            // spcThird
            // 
            this.spcThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcThird.Location = new System.Drawing.Point(0, 0);
            this.spcThird.Name = "spcThird";
            this.spcThird.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcThird.Panel1
            // 
            this.spcThird.Panel1.Controls.Add(this.chartRMSE);
            // 
            // spcThird.Panel2
            // 
            this.spcThird.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spcThird_Panel2_Paint);
            this.spcThird.Size = new System.Drawing.Size(726, 667);
            this.spcThird.SplitterDistance = 250;
            this.spcThird.TabIndex = 0;
            // 
            // chartRMSE
            // 
            chartArea1.AxisX.Title = "Epoch";
            chartArea1.AxisY.Title = "RMSE";
            chartArea1.Name = "ChartArea1";
            this.chartRMSE.ChartAreas.Add(chartArea1);
            this.chartRMSE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartRMSE.Legends.Add(legend1);
            this.chartRMSE.Location = new System.Drawing.Point(0, 0);
            this.chartRMSE.Name = "chartRMSE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Epoch RMSE of Errors";
            this.chartRMSE.Series.Add(series1);
            this.chartRMSE.Size = new System.Drawing.Size(726, 250);
            this.chartRMSE.TabIndex = 0;
            this.chartRMSE.Text = "chart1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1223, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(71, 24);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMessage,
            this.progressBar,
            this.toolStripProgressBar2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1223, 28);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Time Spent";
            // 
            // labMessage
            // 
            this.labMessage.ForeColor = System.Drawing.Color.Red;
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(1004, 22);
            this.labMessage.Spring = true;
            this.labMessage.Text = "Time Spent";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 20);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(0, 20);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // labConfusionMatrix
            // 
            this.labConfusionMatrix.AutoSize = true;
            this.labConfusionMatrix.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfusionMatrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labConfusionMatrix.Location = new System.Drawing.Point(257, 265);
            this.labConfusionMatrix.Name = "labConfusionMatrix";
            this.labConfusionMatrix.Size = new System.Drawing.Size(152, 18);
            this.labConfusionMatrix.TabIndex = 7;
            this.labConfusionMatrix.Text = "Confusion Matrix :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 722);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Assignment#12";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcSecond.Panel1.ResumeLayout(false);
            this.spcSecond.Panel1.PerformLayout();
            this.spcSecond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).EndInit();
            this.spcSecond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuronNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenNumbers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneralizedDelta.ResumeLayout(false);
            this.tabGeneralizedDelta.PerformLayout();
            this.tabDataInfo.ResumeLayout(false);
            this.spcThird.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).EndInit();
            this.spcThird.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRMSE)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcSecond;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.CheckBox chxAnimateRMSEChart;
        private System.Windows.Forms.NumericUpDown nudHiddenNumbers;
        private System.Windows.Forms.ListBox lstHiddenNeuronNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDataset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneralizedDelta;
        private System.Windows.Forms.Label labCorrectness;
        private System.Windows.Forms.Label labRMSE;
        private System.Windows.Forms.Button btnClassificationTest;
        private System.Windows.Forms.Button btnTrainToEnd;
        private System.Windows.Forms.Button btnTrainAnEpoch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PropertyGrid theGrid;
        private System.Windows.Forms.TabPage tabDataInfo;
        private System.Windows.Forms.SplitContainer spcThird;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRMSE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labMessage;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.RichTextBox rtbDataInfomation;
        private System.Windows.Forms.NumericUpDown nudNeuronNumbers;
        private System.Windows.Forms.Label labConfusionMatrix;
    }
}

