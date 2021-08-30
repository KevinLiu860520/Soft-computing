namespace R08546002YCLiu_FinalProject
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.btnNewProblem = new System.Windows.Forms.ToolStripButton();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabMethod = new System.Windows.Forms.TabPage();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.chtCompareCV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtCompare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDisplay = new System.Windows.Forms.TabControl();
            this.tabObjective = new System.Windows.Forms.TabPage();
            this.tabSolutionInfo = new System.Windows.Forms.TabPage();
            this.ltbSolutions = new System.Windows.Forms.ListBox();
            this.ckxShowSolutions = new System.Windows.Forms.CheckBox();
            this.rbtnBSO = new System.Windows.Forms.RadioButton();
            this.rbtnCompareAll = new System.Windows.Forms.RadioButton();
            this.rbtnBAS = new System.Windows.Forms.RadioButton();
            this.rbtnBSAS = new System.Windows.Forms.RadioButton();
            this.rbtnGA = new System.Windows.Forms.RadioButton();
            this.rbtnPSO = new System.Windows.Forms.RadioButton();
            this.btnCreateSolver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRunEnd = new System.Windows.Forms.Button();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.labSoFarTheBestSolution = new System.Windows.Forms.Label();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.labSoFarTheShortestLength = new System.Windows.Forms.Label();
            this.rtbSoFarTheBestSolution = new System.Windows.Forms.RichTextBox();
            this.nudSD = new System.Windows.Forms.NumericUpDown();
            this.labSD = new System.Windows.Forms.Label();
            this.rbtnExecuteTime = new System.Windows.Forms.RadioButton();
            this.rbtnIterationLimit = new System.Windows.Forms.RadioButton();
            this.nudCPUtime = new System.Windows.Forms.NumericUpDown();
            this.nudIterationLimit = new System.Windows.Forms.NumericUpDown();
            this.labStopCondition = new System.Windows.Forms.Label();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcSecond = new System.Windows.Forms.SplitContainer();
            this.spcThird = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.nudCV = new System.Windows.Forms.NumericUpDown();
            this.labCV = new System.Windows.Forms.Label();
            this.ltbCompareResult = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tabCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCompareCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCompare)).BeginInit();
            this.tabDisplay.SuspendLayout();
            this.tabSolutionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPUtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterationLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).BeginInit();
            this.spcSecond.Panel1.SuspendLayout();
            this.spcSecond.Panel2.SuspendLayout();
            this.spcSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).BeginInit();
            this.spcThird.Panel1.SuspendLayout();
            this.spcThird.Panel2.SuspendLayout();
            this.spcThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Purple;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1545, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMessage,
            this.toolStripStatusLabel1,
            this.progressbar,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 736);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1545, 38);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Time Spent";
            // 
            // labMessage
            // 
            this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(1226, 32);
            this.labMessage.Spring = true;
            this.labMessage.Text = "Time Spent";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 32);
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(300, 30);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.btnNewProblem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1545, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(71, 28);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // btnNewProblem
            // 
            this.btnNewProblem.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProblem.Image")));
            this.btnNewProblem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewProblem.Name = "btnNewProblem";
            this.btnNewProblem.Size = new System.Drawing.Size(128, 28);
            this.btnNewProblem.Text = "New Problem";
            this.btnNewProblem.Click += new System.EventHandler(this.btnNewProblem_Click);
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.tabMethod);
            this.tabChart.Controls.Add(this.tabCompare);
            this.tabChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChart.Location = new System.Drawing.Point(0, 0);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(522, 181);
            this.tabChart.TabIndex = 1;
            // 
            // tabMethod
            // 
            this.tabMethod.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabMethod.Controls.Add(this.MainChart);
            this.tabMethod.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMethod.Location = new System.Drawing.Point(4, 25);
            this.tabMethod.Name = "tabMethod";
            this.tabMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMethod.Size = new System.Drawing.Size(514, 152);
            this.tabMethod.TabIndex = 0;
            this.tabMethod.Text = "Methods";
            this.tabMethod.UseVisualStyleBackColor = true;
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Iteration";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Objective";
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(3, 3);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Iteration Average";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Iteration Best";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "So Far The Best";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Series.Add(series3);
            this.MainChart.Size = new System.Drawing.Size(508, 146);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            title1.Name = "Title1";
            this.MainChart.Titles.Add(title1);
            // 
            // tabCompare
            // 
            this.tabCompare.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabCompare.Controls.Add(this.chtCompareCV);
            this.tabCompare.Controls.Add(this.chtCompare);
            this.tabCompare.Location = new System.Drawing.Point(4, 25);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompare.Size = new System.Drawing.Size(514, 154);
            this.tabCompare.TabIndex = 1;
            this.tabCompare.Text = "Compare";
            this.tabCompare.UseVisualStyleBackColor = true;
            // 
            // chtCompareCV
            // 
            this.chtCompareCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chtCompareCV.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Cross Validation Iteration";
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "SoFarTheBestObjective";
            chartArea2.Name = "ChartArea1";
            this.chtCompareCV.ChartAreas.Add(chartArea2);
            this.chtCompareCV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chtCompareCV.Legends.Add(legend2);
            this.chtCompareCV.Location = new System.Drawing.Point(3, 3);
            this.chtCompareCV.Name = "chtCompareCV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "PSO";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "GA";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "BAS";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "BSO";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "BSAS";
            this.chtCompareCV.Series.Add(series4);
            this.chtCompareCV.Series.Add(series5);
            this.chtCompareCV.Series.Add(series6);
            this.chtCompareCV.Series.Add(series7);
            this.chtCompareCV.Series.Add(series8);
            this.chtCompareCV.Size = new System.Drawing.Size(508, 148);
            this.chtCompareCV.TabIndex = 1;
            this.chtCompareCV.Text = "chart1";
            // 
            // chtCompare
            // 
            this.chtCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chtCompare.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Iteration";
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Title = "SoFatTheBestObjective";
            chartArea3.Name = "ChartArea1";
            this.chtCompare.ChartAreas.Add(chartArea3);
            this.chtCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chtCompare.Legends.Add(legend3);
            this.chtCompare.Location = new System.Drawing.Point(3, 3);
            this.chtCompare.Name = "chtCompare";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "PSO";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "GA";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "BAS";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "BSO";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "BSAS";
            this.chtCompare.Series.Add(series9);
            this.chtCompare.Series.Add(series10);
            this.chtCompare.Series.Add(series11);
            this.chtCompare.Series.Add(series12);
            this.chtCompare.Series.Add(series13);
            this.chtCompare.Size = new System.Drawing.Size(508, 148);
            this.chtCompare.TabIndex = 0;
            this.chtCompare.Text = "chart1";
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.tabObjective);
            this.tabDisplay.Controls.Add(this.tabSolutionInfo);
            this.tabDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.Location = new System.Drawing.Point(0, 0);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.SelectedIndex = 0;
            this.tabDisplay.Size = new System.Drawing.Size(522, 490);
            this.tabDisplay.TabIndex = 0;
            // 
            // tabObjective
            // 
            this.tabObjective.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabObjective.Location = new System.Drawing.Point(4, 27);
            this.tabObjective.Name = "tabObjective";
            this.tabObjective.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjective.Size = new System.Drawing.Size(514, 459);
            this.tabObjective.TabIndex = 0;
            this.tabObjective.Text = "Objective";
            this.tabObjective.UseVisualStyleBackColor = true;
            // 
            // tabSolutionInfo
            // 
            this.tabSolutionInfo.Controls.Add(this.ltbSolutions);
            this.tabSolutionInfo.Controls.Add(this.ckxShowSolutions);
            this.tabSolutionInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSolutionInfo.Location = new System.Drawing.Point(4, 27);
            this.tabSolutionInfo.Name = "tabSolutionInfo";
            this.tabSolutionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolutionInfo.Size = new System.Drawing.Size(514, 464);
            this.tabSolutionInfo.TabIndex = 1;
            this.tabSolutionInfo.Text = "Solution Info";
            this.tabSolutionInfo.UseVisualStyleBackColor = true;
            // 
            // ltbSolutions
            // 
            this.ltbSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbSolutions.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltbSolutions.FormattingEnabled = true;
            this.ltbSolutions.HorizontalScrollbar = true;
            this.ltbSolutions.ItemHeight = 20;
            this.ltbSolutions.Location = new System.Drawing.Point(4, 20);
            this.ltbSolutions.Name = "ltbSolutions";
            this.ltbSolutions.ScrollAlwaysVisible = true;
            this.ltbSolutions.Size = new System.Drawing.Size(511, 424);
            this.ltbSolutions.TabIndex = 15;
            // 
            // ckxShowSolutions
            // 
            this.ckxShowSolutions.AutoSize = true;
            this.ckxShowSolutions.Checked = true;
            this.ckxShowSolutions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckxShowSolutions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckxShowSolutions.Location = new System.Drawing.Point(3, 3);
            this.ckxShowSolutions.Name = "ckxShowSolutions";
            this.ckxShowSolutions.Size = new System.Drawing.Size(142, 22);
            this.ckxShowSolutions.TabIndex = 14;
            this.ckxShowSolutions.Text = "Show Solutions";
            this.ckxShowSolutions.UseVisualStyleBackColor = true;
            // 
            // rbtnBSO
            // 
            this.rbtnBSO.AutoSize = true;
            this.rbtnBSO.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBSO.Location = new System.Drawing.Point(312, 3);
            this.rbtnBSO.Name = "rbtnBSO";
            this.rbtnBSO.Size = new System.Drawing.Size(57, 24);
            this.rbtnBSO.TabIndex = 5;
            this.rbtnBSO.Text = "BSO";
            this.rbtnBSO.UseVisualStyleBackColor = true;
            // 
            // rbtnCompareAll
            // 
            this.rbtnCompareAll.AutoSize = true;
            this.rbtnCompareAll.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCompareAll.Location = new System.Drawing.Point(514, 3);
            this.rbtnCompareAll.Name = "rbtnCompareAll";
            this.rbtnCompareAll.Size = new System.Drawing.Size(129, 24);
            this.rbtnCompareAll.TabIndex = 4;
            this.rbtnCompareAll.Text = "Compare All";
            this.rbtnCompareAll.UseVisualStyleBackColor = true;
            this.rbtnCompareAll.CheckedChanged += new System.EventHandler(this.Solvers_CheckedChanged);
            // 
            // rbtnBAS
            // 
            this.rbtnBAS.AutoSize = true;
            this.rbtnBAS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBAS.Location = new System.Drawing.Point(203, 3);
            this.rbtnBAS.Name = "rbtnBAS";
            this.rbtnBAS.Size = new System.Drawing.Size(57, 24);
            this.rbtnBAS.TabIndex = 3;
            this.rbtnBAS.Text = "BAS";
            this.rbtnBAS.UseVisualStyleBackColor = true;
            this.rbtnBAS.CheckedChanged += new System.EventHandler(this.Solvers_CheckedChanged);
            // 
            // rbtnBSAS
            // 
            this.rbtnBSAS.AutoSize = true;
            this.rbtnBSAS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBSAS.Location = new System.Drawing.Point(409, 3);
            this.rbtnBSAS.Name = "rbtnBSAS";
            this.rbtnBSAS.Size = new System.Drawing.Size(66, 24);
            this.rbtnBSAS.TabIndex = 2;
            this.rbtnBSAS.Text = "BSAS";
            this.rbtnBSAS.UseVisualStyleBackColor = true;
            this.rbtnBSAS.CheckedChanged += new System.EventHandler(this.Solvers_CheckedChanged);
            // 
            // rbtnGA
            // 
            this.rbtnGA.AutoSize = true;
            this.rbtnGA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGA.Location = new System.Drawing.Point(103, 3);
            this.rbtnGA.Name = "rbtnGA";
            this.rbtnGA.Size = new System.Drawing.Size(48, 24);
            this.rbtnGA.TabIndex = 1;
            this.rbtnGA.Text = "GA";
            this.rbtnGA.UseVisualStyleBackColor = true;
            this.rbtnGA.CheckedChanged += new System.EventHandler(this.Solvers_CheckedChanged);
            // 
            // rbtnPSO
            // 
            this.rbtnPSO.AutoSize = true;
            this.rbtnPSO.Checked = true;
            this.rbtnPSO.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPSO.Location = new System.Drawing.Point(4, 3);
            this.rbtnPSO.Name = "rbtnPSO";
            this.rbtnPSO.Size = new System.Drawing.Size(57, 24);
            this.rbtnPSO.TabIndex = 0;
            this.rbtnPSO.TabStop = true;
            this.rbtnPSO.Text = "PSO";
            this.rbtnPSO.UseVisualStyleBackColor = true;
            this.rbtnPSO.CheckedChanged += new System.EventHandler(this.Solvers_CheckedChanged);
            // 
            // btnCreateSolver
            // 
            this.btnCreateSolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateSolver.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSolver.Location = new System.Drawing.Point(4, 33);
            this.btnCreateSolver.Name = "btnCreateSolver";
            this.btnCreateSolver.Size = new System.Drawing.Size(307, 39);
            this.btnCreateSolver.TabIndex = 0;
            this.btnCreateSolver.Text = "Create Solver";
            this.btnCreateSolver.UseVisualStyleBackColor = false;
            this.btnCreateSolver.Click += new System.EventHandler(this.btnCreateSolver_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(4, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(307, 38);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRunEnd
            // 
            this.btnRunEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRunEnd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunEnd.Location = new System.Drawing.Point(355, 78);
            this.btnRunEnd.Name = "btnRunEnd";
            this.btnRunEnd.Size = new System.Drawing.Size(304, 38);
            this.btnRunEnd.TabIndex = 16;
            this.btnRunEnd.Text = "Run to End";
            this.btnRunEnd.UseVisualStyleBackColor = false;
            this.btnRunEnd.Click += new System.EventHandler(this.btnRunEnd_Click);
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRunOneIteration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunOneIteration.Location = new System.Drawing.Point(355, 33);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(304, 39);
            this.btnRunOneIteration.TabIndex = 15;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = false;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // labSoFarTheBestSolution
            // 
            this.labSoFarTheBestSolution.AutoSize = true;
            this.labSoFarTheBestSolution.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheBestSolution.Location = new System.Drawing.Point(2, 54);
            this.labSoFarTheBestSolution.Name = "labSoFarTheBestSolution";
            this.labSoFarTheBestSolution.Size = new System.Drawing.Size(202, 19);
            this.labSoFarTheBestSolution.TabIndex = 19;
            this.labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Checked = true;
            this.cbxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdate.Location = new System.Drawing.Point(4, 0);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(256, 24);
            this.cbxUpdate.TabIndex = 17;
            this.cbxUpdate.Text = "Real-time Update Progress";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            // 
            // labSoFarTheShortestLength
            // 
            this.labSoFarTheShortestLength.AutoSize = true;
            this.labSoFarTheShortestLength.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheShortestLength.Location = new System.Drawing.Point(2, 27);
            this.labSoFarTheShortestLength.Name = "labSoFarTheShortestLength";
            this.labSoFarTheShortestLength.Size = new System.Drawing.Size(218, 19);
            this.labSoFarTheShortestLength.TabIndex = 18;
            this.labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            // 
            // rtbSoFarTheBestSolution
            // 
            this.rtbSoFarTheBestSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSoFarTheBestSolution.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSoFarTheBestSolution.Location = new System.Drawing.Point(0, 0);
            this.rtbSoFarTheBestSolution.Name = "rtbSoFarTheBestSolution";
            this.rtbSoFarTheBestSolution.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbSoFarTheBestSolution.Size = new System.Drawing.Size(671, 25);
            this.rtbSoFarTheBestSolution.TabIndex = 20;
            this.rtbSoFarTheBestSolution.Text = "";
            // 
            // nudSD
            // 
            this.nudSD.Location = new System.Drawing.Point(203, 84);
            this.nudSD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSD.Name = "nudSD";
            this.nudSD.Size = new System.Drawing.Size(91, 25);
            this.nudSD.TabIndex = 8;
            this.nudSD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labSD
            // 
            this.labSD.AutoSize = true;
            this.labSD.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSD.Location = new System.Drawing.Point(7, 89);
            this.labSD.Name = "labSD";
            this.labSD.Size = new System.Drawing.Size(144, 20);
            this.labSD.TabIndex = 7;
            this.labSD.Text = "# of population";
            // 
            // rbtnExecuteTime
            // 
            this.rbtnExecuteTime.AutoSize = true;
            this.rbtnExecuteTime.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExecuteTime.Location = new System.Drawing.Point(340, 33);
            this.rbtnExecuteTime.Name = "rbtnExecuteTime";
            this.rbtnExecuteTime.Size = new System.Drawing.Size(165, 24);
            this.rbtnExecuteTime.TabIndex = 6;
            this.rbtnExecuteTime.Text = "Execute Time(s)";
            this.rbtnExecuteTime.UseVisualStyleBackColor = true;
            // 
            // rbtnIterationLimit
            // 
            this.rbtnIterationLimit.AutoSize = true;
            this.rbtnIterationLimit.Checked = true;
            this.rbtnIterationLimit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIterationLimit.Location = new System.Drawing.Point(5, 33);
            this.rbtnIterationLimit.Name = "rbtnIterationLimit";
            this.rbtnIterationLimit.Size = new System.Drawing.Size(165, 24);
            this.rbtnIterationLimit.TabIndex = 5;
            this.rbtnIterationLimit.TabStop = true;
            this.rbtnIterationLimit.Text = "Iteration Limit";
            this.rbtnIterationLimit.UseVisualStyleBackColor = true;
            this.rbtnIterationLimit.CheckedChanged += new System.EventHandler(this.StopCondition_CheckedChanged);
            // 
            // nudCPUtime
            // 
            this.nudCPUtime.Location = new System.Drawing.Point(540, 32);
            this.nudCPUtime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCPUtime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCPUtime.Name = "nudCPUtime";
            this.nudCPUtime.Size = new System.Drawing.Size(91, 25);
            this.nudCPUtime.TabIndex = 4;
            this.nudCPUtime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudIterationLimit
            // 
            this.nudIterationLimit.Location = new System.Drawing.Point(203, 32);
            this.nudIterationLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIterationLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIterationLimit.Name = "nudIterationLimit";
            this.nudIterationLimit.Size = new System.Drawing.Size(91, 25);
            this.nudIterationLimit.TabIndex = 2;
            this.nudIterationLimit.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // labStopCondition
            // 
            this.labStopCondition.AutoSize = true;
            this.labStopCondition.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStopCondition.Location = new System.Drawing.Point(3, 7);
            this.labStopCondition.Name = "labStopCondition";
            this.labStopCondition.Size = new System.Drawing.Size(207, 20);
            this.labStopCondition.TabIndex = 1;
            this.labStopCondition.Text = "Stop Condition Chooses";
            // 
            // theGrid
            // 
            this.theGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theGrid.Location = new System.Drawing.Point(0, 0);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(671, 464);
            this.theGrid.TabIndex = 2;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 61);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.spcMain.Panel2.Controls.Add(this.spcSecond);
            this.spcMain.Size = new System.Drawing.Size(1545, 675);
            this.spcMain.SplitterDistance = 344;
            this.spcMain.TabIndex = 5;
            // 
            // spcSecond
            // 
            this.spcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSecond.Location = new System.Drawing.Point(0, 0);
            this.spcSecond.Name = "spcSecond";
            // 
            // spcSecond.Panel1
            // 
            this.spcSecond.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spcSecond.Panel1.Controls.Add(this.spcThird);
            // 
            // spcSecond.Panel2
            // 
            this.spcSecond.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.spcSecond.Panel2.Controls.Add(this.splitContainer8);
            this.spcSecond.Size = new System.Drawing.Size(1197, 675);
            this.spcSecond.SplitterDistance = 522;
            this.spcSecond.TabIndex = 0;
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
            this.spcThird.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spcThird.Panel1.Controls.Add(this.tabChart);
            // 
            // spcThird.Panel2
            // 
            this.spcThird.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.spcThird.Panel2.Controls.Add(this.tabDisplay);
            this.spcThird.Size = new System.Drawing.Size(522, 675);
            this.spcThird.SplitterDistance = 181;
            this.spcThird.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.splitContainer9);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer8.Panel2.Controls.Add(this.ltbCompareResult);
            this.splitContainer8.Panel2.Controls.Add(this.theGrid);
            this.splitContainer8.Size = new System.Drawing.Size(671, 675);
            this.splitContainer8.SplitterDistance = 207;
            this.splitContainer8.TabIndex = 0;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.btnCreateSolver);
            this.splitContainer9.Panel1.Controls.Add(this.btnReset);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnBSO);
            this.splitContainer9.Panel1.Controls.Add(this.btnRunEnd);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnPSO);
            this.splitContainer9.Panel1.Controls.Add(this.btnRunOneIteration);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnCompareAll);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnGA);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnBAS);
            this.splitContainer9.Panel1.Controls.Add(this.rbtnBSAS);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.splitContainer10);
            this.splitContainer9.Size = new System.Drawing.Size(671, 207);
            this.splitContainer9.SplitterDistance = 44;
            this.splitContainer9.TabIndex = 0;
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.labSoFarTheBestSolution);
            this.splitContainer10.Panel1.Controls.Add(this.labSoFarTheShortestLength);
            this.splitContainer10.Panel1.Controls.Add(this.cbxUpdate);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(671, 159);
            this.splitContainer10.SplitterDistance = 25;
            this.splitContainer10.TabIndex = 0;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            this.splitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.rtbSoFarTheBestSolution);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.nudCV);
            this.splitContainer11.Panel2.Controls.Add(this.labCV);
            this.splitContainer11.Panel2.Controls.Add(this.nudSD);
            this.splitContainer11.Panel2.Controls.Add(this.labStopCondition);
            this.splitContainer11.Panel2.Controls.Add(this.labSD);
            this.splitContainer11.Panel2.Controls.Add(this.nudIterationLimit);
            this.splitContainer11.Panel2.Controls.Add(this.rbtnExecuteTime);
            this.splitContainer11.Panel2.Controls.Add(this.nudCPUtime);
            this.splitContainer11.Panel2.Controls.Add(this.rbtnIterationLimit);
            this.splitContainer11.Size = new System.Drawing.Size(671, 130);
            this.splitContainer11.SplitterDistance = 25;
            this.splitContainer11.TabIndex = 0;
            // 
            // nudCV
            // 
            this.nudCV.Location = new System.Drawing.Point(540, 84);
            this.nudCV.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCV.Name = "nudCV";
            this.nudCV.Size = new System.Drawing.Size(91, 25);
            this.nudCV.TabIndex = 10;
            this.nudCV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCV.ValueChanged += new System.EventHandler(this.nudCV_ValueChanged);
            // 
            // labCV
            // 
            this.labCV.AutoSize = true;
            this.labCV.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCV.Location = new System.Drawing.Point(340, 89);
            this.labCV.Name = "labCV";
            this.labCV.Size = new System.Drawing.Size(153, 20);
            this.labCV.TabIndex = 9;
            this.labCV.Text = "Cross Validation";
            // 
            // ltbCompareResult
            // 
            this.ltbCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbCompareResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltbCompareResult.FormattingEnabled = true;
            this.ltbCompareResult.HorizontalScrollbar = true;
            this.ltbCompareResult.ItemHeight = 20;
            this.ltbCompareResult.Location = new System.Drawing.Point(0, 0);
            this.ltbCompareResult.Name = "ltbCompareResult";
            this.ltbCompareResult.ScrollAlwaysVisible = true;
            this.ltbCompareResult.Size = new System.Drawing.Size(671, 464);
            this.ltbCompareResult.TabIndex = 16;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1545, 774);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Mainform";
            this.Text = "Final Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabChart.ResumeLayout(false);
            this.tabMethod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tabCompare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtCompareCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCompare)).EndInit();
            this.tabDisplay.ResumeLayout(false);
            this.tabSolutionInfo.ResumeLayout(false);
            this.tabSolutionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPUtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterationLimit)).EndInit();
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcSecond.Panel1.ResumeLayout(false);
            this.spcSecond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).EndInit();
            this.spcSecond.ResumeLayout(false);
            this.spcThird.Panel1.ResumeLayout(false);
            this.spcThird.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).EndInit();
            this.spcThird.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripStatusLabel labMessage;
        private System.Windows.Forms.Button btnCreateSolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.ToolStripButton btnNewProblem;
        private System.Windows.Forms.TabControl tabDisplay;
        private System.Windows.Forms.TabPage tabObjective;
        private System.Windows.Forms.TabPage tabSolutionInfo;
        private System.Windows.Forms.RichTextBox rtbSoFarTheBestSolution;
        private System.Windows.Forms.Label labSoFarTheBestSolution;
        private System.Windows.Forms.Label labSoFarTheShortestLength;
        private System.Windows.Forms.Button btnRunOneIteration;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRunEnd;
        private System.Windows.Forms.PropertyGrid theGrid;
        private System.Windows.Forms.ListBox ltbSolutions;
        private System.Windows.Forms.CheckBox ckxShowSolutions;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.RadioButton rbtnCompareAll;
        private System.Windows.Forms.RadioButton rbtnBAS;
        private System.Windows.Forms.RadioButton rbtnBSAS;
        private System.Windows.Forms.RadioButton rbtnGA;
        private System.Windows.Forms.RadioButton rbtnPSO;
        private System.Windows.Forms.RadioButton rbtnBSO;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabMethod;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCompare;
        private System.Windows.Forms.NumericUpDown nudCPUtime;
        private System.Windows.Forms.NumericUpDown nudIterationLimit;
        private System.Windows.Forms.Label labStopCondition;
        private System.Windows.Forms.RadioButton rbtnExecuteTime;
        private System.Windows.Forms.RadioButton rbtnIterationLimit;
        private System.Windows.Forms.NumericUpDown nudSD;
        private System.Windows.Forms.Label labSD;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcSecond;
        private System.Windows.Forms.SplitContainer spcThird;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.NumericUpDown nudCV;
        private System.Windows.Forms.Label labCV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCompareCV;
        private System.Windows.Forms.ListBox ltbCompareResult;
    }
}

