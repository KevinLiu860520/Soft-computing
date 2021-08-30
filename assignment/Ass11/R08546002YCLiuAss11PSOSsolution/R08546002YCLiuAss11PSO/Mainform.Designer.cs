namespace R08546002YCLiuAss11PSO
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcSecond = new System.Windows.Forms.SplitContainer();
            this.spcThird = new System.Windows.Forms.SplitContainer();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabObjective = new System.Windows.Forms.TabPage();
            this.tabSolutionInfo = new System.Windows.Forms.TabPage();
            this.ltbSolutions = new System.Windows.Forms.ListBox();
            this.ckxShowSolutions = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabMethods = new System.Windows.Forms.TabControl();
            this.tabPSO = new System.Windows.Forms.TabPage();
            this.rtbSoFarTheBestSolution = new System.Windows.Forms.RichTextBox();
            this.btnCreatePSOSolver = new System.Windows.Forms.Button();
            this.labSoFarTheBestSolution = new System.Windows.Forms.Label();
            this.btnRunEnd = new System.Windows.Forms.Button();
            this.labSoFarTheShortestLength = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.tabGA = new System.Windows.Forms.TabPage();
            this.rtbGASoFarTheBestSolution = new System.Windows.Forms.RichTextBox();
            this.btnCreateGASolver = new System.Windows.Forms.Button();
            this.labGASoFarTheBestSolution = new System.Windows.Forms.Label();
            this.btnGARunEnd = new System.Windows.Forms.Button();
            this.labGASoFarTheShortestLength = new System.Windows.Forms.Label();
            this.btnGAReset = new System.Windows.Forms.Button();
            this.cbxGAUpdate = new System.Windows.Forms.CheckBox();
            this.btnGARunOneIteration = new System.Windows.Forms.Button();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSolutionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMethods.SuspendLayout();
            this.tabPSO.SuspendLayout();
            this.tabGA.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1166, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 33);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Time Spent";
            // 
            // labMessage
            // 
            this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(947, 27);
            this.labMessage.Spring = true;
            this.labMessage.Text = "Time Spent";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 27);
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.btnNewProblem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(71, 24);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // btnNewProblem
            // 
            this.btnNewProblem.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProblem.Image")));
            this.btnNewProblem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewProblem.Name = "btnNewProblem";
            this.btnNewProblem.Size = new System.Drawing.Size(128, 24);
            this.btnNewProblem.Text = "New Problem";
            this.btnNewProblem.Click += new System.EventHandler(this.btnNewProblem_Click);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 54);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcSecond);
            this.spcMain.Size = new System.Drawing.Size(1166, 645);
            this.spcMain.SplitterDistance = 287;
            this.spcMain.TabIndex = 4;
            // 
            // spcSecond
            // 
            this.spcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSecond.Location = new System.Drawing.Point(0, 0);
            this.spcSecond.Name = "spcSecond";
            // 
            // spcSecond.Panel1
            // 
            this.spcSecond.Panel1.Controls.Add(this.spcThird);
            // 
            // spcSecond.Panel2
            // 
            this.spcSecond.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.spcSecond.Panel2.Controls.Add(this.splitContainer1);
            this.spcSecond.Size = new System.Drawing.Size(875, 645);
            this.spcSecond.SplitterDistance = 445;
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
            this.spcThird.Panel1.Controls.Add(this.MainChart);
            // 
            // spcThird.Panel2
            // 
            this.spcThird.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.spcThird.Panel2.Controls.Add(this.tabControl1);
            this.spcThird.Size = new System.Drawing.Size(445, 645);
            this.spcThird.SplitterDistance = 243;
            this.spcThird.TabIndex = 0;
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea5.AxisX.Title = "Iteration";
            chartArea5.AxisY.Title = "Objective";
            chartArea5.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea5);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.MainChart.Legends.Add(legend5);
            this.MainChart.Location = new System.Drawing.Point(0, 0);
            this.MainChart.Name = "MainChart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Iteration Average";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Iteration Best";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "So Far The Best";
            this.MainChart.Series.Add(series13);
            this.MainChart.Series.Add(series14);
            this.MainChart.Series.Add(series15);
            this.MainChart.Size = new System.Drawing.Size(445, 243);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            title5.Name = "Title1";
            this.MainChart.Titles.Add(title5);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabObjective);
            this.tabControl1.Controls.Add(this.tabSolutionInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabObjective
            // 
            this.tabObjective.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabObjective.Location = new System.Drawing.Point(4, 27);
            this.tabObjective.Name = "tabObjective";
            this.tabObjective.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjective.Size = new System.Drawing.Size(437, 367);
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
            this.tabSolutionInfo.Size = new System.Drawing.Size(437, 367);
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
            this.ltbSolutions.Size = new System.Drawing.Size(434, 344);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.tabMethods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.theGrid);
            this.splitContainer1.Size = new System.Drawing.Size(426, 645);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 18;
            // 
            // tabMethods
            // 
            this.tabMethods.Controls.Add(this.tabPSO);
            this.tabMethods.Controls.Add(this.tabGA);
            this.tabMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMethods.Location = new System.Drawing.Point(0, 0);
            this.tabMethods.Name = "tabMethods";
            this.tabMethods.SelectedIndex = 0;
            this.tabMethods.Size = new System.Drawing.Size(426, 294);
            this.tabMethods.TabIndex = 0;
            // 
            // tabPSO
            // 
            this.tabPSO.Controls.Add(this.rtbSoFarTheBestSolution);
            this.tabPSO.Controls.Add(this.btnCreatePSOSolver);
            this.tabPSO.Controls.Add(this.labSoFarTheBestSolution);
            this.tabPSO.Controls.Add(this.btnRunEnd);
            this.tabPSO.Controls.Add(this.labSoFarTheShortestLength);
            this.tabPSO.Controls.Add(this.btnReset);
            this.tabPSO.Controls.Add(this.cbxUpdate);
            this.tabPSO.Controls.Add(this.btnRunOneIteration);
            this.tabPSO.Location = new System.Drawing.Point(4, 25);
            this.tabPSO.Name = "tabPSO";
            this.tabPSO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSO.Size = new System.Drawing.Size(418, 265);
            this.tabPSO.TabIndex = 0;
            this.tabPSO.Text = "PSO";
            this.tabPSO.UseVisualStyleBackColor = true;
            // 
            // rtbSoFarTheBestSolution
            // 
            this.rtbSoFarTheBestSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSoFarTheBestSolution.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSoFarTheBestSolution.Location = new System.Drawing.Point(6, 213);
            this.rtbSoFarTheBestSolution.Name = "rtbSoFarTheBestSolution";
            this.rtbSoFarTheBestSolution.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbSoFarTheBestSolution.Size = new System.Drawing.Size(404, 104);
            this.rtbSoFarTheBestSolution.TabIndex = 20;
            this.rtbSoFarTheBestSolution.Text = "";
            // 
            // btnCreatePSOSolver
            // 
            this.btnCreatePSOSolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreatePSOSolver.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePSOSolver.Location = new System.Drawing.Point(6, 6);
            this.btnCreatePSOSolver.Name = "btnCreatePSOSolver";
            this.btnCreatePSOSolver.Size = new System.Drawing.Size(390, 30);
            this.btnCreatePSOSolver.TabIndex = 0;
            this.btnCreatePSOSolver.Text = "Create A PSO Solver";
            this.btnCreatePSOSolver.UseVisualStyleBackColor = false;
            this.btnCreatePSOSolver.Click += new System.EventHandler(this.btnCreatePSOSolver_Click);
            // 
            // labSoFarTheBestSolution
            // 
            this.labSoFarTheBestSolution.AutoSize = true;
            this.labSoFarTheBestSolution.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheBestSolution.Location = new System.Drawing.Point(1, 191);
            this.labSoFarTheBestSolution.Name = "labSoFarTheBestSolution";
            this.labSoFarTheBestSolution.Size = new System.Drawing.Size(202, 19);
            this.labSoFarTheBestSolution.TabIndex = 19;
            this.labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            // 
            // btnRunEnd
            // 
            this.btnRunEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunEnd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunEnd.Location = new System.Drawing.Point(6, 112);
            this.btnRunEnd.Name = "btnRunEnd";
            this.btnRunEnd.Size = new System.Drawing.Size(390, 27);
            this.btnRunEnd.TabIndex = 16;
            this.btnRunEnd.Text = "Run to End";
            this.btnRunEnd.UseVisualStyleBackColor = false;
            this.btnRunEnd.Click += new System.EventHandler(this.btnRunEnd_Click);
            // 
            // labSoFarTheShortestLength
            // 
            this.labSoFarTheShortestLength.AutoSize = true;
            this.labSoFarTheShortestLength.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheShortestLength.Location = new System.Drawing.Point(2, 172);
            this.labSoFarTheShortestLength.Name = "labSoFarTheShortestLength";
            this.labSoFarTheShortestLength.Size = new System.Drawing.Size(218, 19);
            this.labSoFarTheShortestLength.TabIndex = 18;
            this.labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(6, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(390, 29);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Checked = true;
            this.cbxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdate.Location = new System.Drawing.Point(6, 145);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(256, 24);
            this.cbxUpdate.TabIndex = 17;
            this.cbxUpdate.Text = "Real-time Update Progress";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunOneIteration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunOneIteration.Location = new System.Drawing.Point(6, 77);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(390, 29);
            this.btnRunOneIteration.TabIndex = 15;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = false;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // tabGA
            // 
            this.tabGA.Controls.Add(this.rtbGASoFarTheBestSolution);
            this.tabGA.Controls.Add(this.btnCreateGASolver);
            this.tabGA.Controls.Add(this.labGASoFarTheBestSolution);
            this.tabGA.Controls.Add(this.btnGARunEnd);
            this.tabGA.Controls.Add(this.labGASoFarTheShortestLength);
            this.tabGA.Controls.Add(this.btnGAReset);
            this.tabGA.Controls.Add(this.cbxGAUpdate);
            this.tabGA.Controls.Add(this.btnGARunOneIteration);
            this.tabGA.Location = new System.Drawing.Point(4, 25);
            this.tabGA.Name = "tabGA";
            this.tabGA.Padding = new System.Windows.Forms.Padding(3);
            this.tabGA.Size = new System.Drawing.Size(418, 265);
            this.tabGA.TabIndex = 1;
            this.tabGA.Text = "GASolver";
            this.tabGA.UseVisualStyleBackColor = true;
            // 
            // rtbGASoFarTheBestSolution
            // 
            this.rtbGASoFarTheBestSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGASoFarTheBestSolution.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGASoFarTheBestSolution.Location = new System.Drawing.Point(6, 213);
            this.rtbGASoFarTheBestSolution.Name = "rtbGASoFarTheBestSolution";
            this.rtbGASoFarTheBestSolution.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbGASoFarTheBestSolution.Size = new System.Drawing.Size(404, 104);
            this.rtbGASoFarTheBestSolution.TabIndex = 28;
            this.rtbGASoFarTheBestSolution.Text = "";
            // 
            // btnCreateGASolver
            // 
            this.btnCreateGASolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateGASolver.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGASolver.Location = new System.Drawing.Point(6, 6);
            this.btnCreateGASolver.Name = "btnCreateGASolver";
            this.btnCreateGASolver.Size = new System.Drawing.Size(390, 30);
            this.btnCreateGASolver.TabIndex = 21;
            this.btnCreateGASolver.Text = "Create A GA Solver";
            this.btnCreateGASolver.UseVisualStyleBackColor = false;
            this.btnCreateGASolver.Click += new System.EventHandler(this.btnCreateGASolver_Click);
            // 
            // labGASoFarTheBestSolution
            // 
            this.labGASoFarTheBestSolution.AutoSize = true;
            this.labGASoFarTheBestSolution.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGASoFarTheBestSolution.Location = new System.Drawing.Point(1, 191);
            this.labGASoFarTheBestSolution.Name = "labGASoFarTheBestSolution";
            this.labGASoFarTheBestSolution.Size = new System.Drawing.Size(202, 19);
            this.labGASoFarTheBestSolution.TabIndex = 27;
            this.labGASoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            // 
            // btnGARunEnd
            // 
            this.btnGARunEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGARunEnd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGARunEnd.Location = new System.Drawing.Point(6, 112);
            this.btnGARunEnd.Name = "btnGARunEnd";
            this.btnGARunEnd.Size = new System.Drawing.Size(390, 27);
            this.btnGARunEnd.TabIndex = 24;
            this.btnGARunEnd.Text = "Run to End";
            this.btnGARunEnd.UseVisualStyleBackColor = false;
            this.btnGARunEnd.Click += new System.EventHandler(this.btnGARunEnd_Click);
            // 
            // labGASoFarTheShortestLength
            // 
            this.labGASoFarTheShortestLength.AutoSize = true;
            this.labGASoFarTheShortestLength.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGASoFarTheShortestLength.Location = new System.Drawing.Point(2, 172);
            this.labGASoFarTheShortestLength.Name = "labGASoFarTheShortestLength";
            this.labGASoFarTheShortestLength.Size = new System.Drawing.Size(218, 19);
            this.labGASoFarTheShortestLength.TabIndex = 26;
            this.labGASoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            // 
            // btnGAReset
            // 
            this.btnGAReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGAReset.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGAReset.Location = new System.Drawing.Point(6, 42);
            this.btnGAReset.Name = "btnGAReset";
            this.btnGAReset.Size = new System.Drawing.Size(390, 29);
            this.btnGAReset.TabIndex = 22;
            this.btnGAReset.Text = "Reset";
            this.btnGAReset.UseVisualStyleBackColor = false;
            this.btnGAReset.Click += new System.EventHandler(this.btnGAReset_Click);
            // 
            // cbxGAUpdate
            // 
            this.cbxGAUpdate.AutoSize = true;
            this.cbxGAUpdate.Checked = true;
            this.cbxGAUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGAUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGAUpdate.Location = new System.Drawing.Point(6, 145);
            this.cbxGAUpdate.Name = "cbxGAUpdate";
            this.cbxGAUpdate.Size = new System.Drawing.Size(256, 24);
            this.cbxGAUpdate.TabIndex = 25;
            this.cbxGAUpdate.Text = "Real-time Update Progress";
            this.cbxGAUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGARunOneIteration
            // 
            this.btnGARunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGARunOneIteration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGARunOneIteration.Location = new System.Drawing.Point(6, 77);
            this.btnGARunOneIteration.Name = "btnGARunOneIteration";
            this.btnGARunOneIteration.Size = new System.Drawing.Size(390, 29);
            this.btnGARunOneIteration.TabIndex = 23;
            this.btnGARunOneIteration.Text = "Run One Iteration";
            this.btnGARunOneIteration.UseVisualStyleBackColor = false;
            this.btnGARunOneIteration.Click += new System.EventHandler(this.btnGARunOneIteration_Click);
            // 
            // theGrid
            // 
            this.theGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theGrid.Location = new System.Drawing.Point(0, 0);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(426, 347);
            this.theGrid.TabIndex = 2;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 732);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Mainform";
            this.Text = "Assignment#11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSolutionInfo.ResumeLayout(false);
            this.tabSolutionInfo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMethods.ResumeLayout(false);
            this.tabPSO.ResumeLayout(false);
            this.tabPSO.PerformLayout();
            this.tabGA.ResumeLayout(false);
            this.tabGA.PerformLayout();
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
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcSecond;
        private System.Windows.Forms.SplitContainer spcThird;
        private System.Windows.Forms.Button btnCreatePSOSolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.ToolStripButton btnNewProblem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabObjective;
        private System.Windows.Forms.TabPage tabSolutionInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.TabControl tabMethods;
        private System.Windows.Forms.TabPage tabPSO;
        private System.Windows.Forms.TabPage tabGA;
        private System.Windows.Forms.RichTextBox rtbGASoFarTheBestSolution;
        private System.Windows.Forms.Button btnCreateGASolver;
        private System.Windows.Forms.Label labGASoFarTheBestSolution;
        private System.Windows.Forms.Button btnGARunEnd;
        private System.Windows.Forms.Label labGASoFarTheShortestLength;
        private System.Windows.Forms.Button btnGAReset;
        private System.Windows.Forms.CheckBox cbxGAUpdate;
        private System.Windows.Forms.Button btnGARunOneIteration;
    }
}

