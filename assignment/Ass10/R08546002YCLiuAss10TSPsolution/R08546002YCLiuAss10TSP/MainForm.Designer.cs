namespace R08546002YCLiuAss10TSP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenTSP = new System.Windows.Forms.Button();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.btnRunEnd = new System.Windows.Forms.Button();
            this.SPCsencond = new System.Windows.Forms.SplitContainer();
            this.labTitle = new System.Windows.Forms.Label();
            this.labShortestLength = new System.Windows.Forms.Label();
            this.labNumberOfCities = new System.Windows.Forms.Label();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.spcThird = new System.Windows.Forms.SplitContainer();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabShow = new System.Windows.Forms.TabControl();
            this.tabCityRoute = new System.Windows.Forms.TabPage();
            this.tabPheromoneSolutions = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ltbPheromone = new System.Windows.Forms.ListBox();
            this.ckxShowPheromone = new System.Windows.Forms.CheckBox();
            this.ltbSolutions = new System.Windows.Forms.ListBox();
            this.ckxShowSolutions = new System.Windows.Forms.CheckBox();
            this.SPCFirst = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabMethod = new System.Windows.Forms.TabControl();
            this.tabACSMethod = new System.Windows.Forms.TabPage();
            this.btnCreateACSSolver = new System.Windows.Forms.Button();
            this.tabGAMethod = new System.Windows.Forms.TabPage();
            this.rbtnTSPGA = new System.Windows.Forms.RadioButton();
            this.btnCreateGA = new System.Windows.Forms.Button();
            this.rbtnGeneralGA = new System.Windows.Forms.RadioButton();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.labSoFarTheBestSolution = new System.Windows.Forms.Label();
            this.labSoFarTheShortestLength = new System.Windows.Forms.Label();
            this.rtbSoFarTheBestSolution = new System.Windows.Forms.RichTextBox();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SPCsencond)).BeginInit();
            this.SPCsencond.Panel1.SuspendLayout();
            this.SPCsencond.Panel2.SuspendLayout();
            this.SPCsencond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).BeginInit();
            this.spcThird.Panel1.SuspendLayout();
            this.spcThird.Panel2.SuspendLayout();
            this.spcThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            this.tabShow.SuspendLayout();
            this.tabPheromoneSolutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPCFirst)).BeginInit();
            this.SPCFirst.Panel1.SuspendLayout();
            this.SPCFirst.Panel2.SuspendLayout();
            this.SPCFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabMethod.SuspendLayout();
            this.tabACSMethod.SuspendLayout();
            this.tabGAMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenTSP
            // 
            this.btnOpenTSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenTSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenTSP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTSP.Location = new System.Drawing.Point(0, 0);
            this.btnOpenTSP.Name = "btnOpenTSP";
            this.btnOpenTSP.Size = new System.Drawing.Size(281, 45);
            this.btnOpenTSP.TabIndex = 0;
            this.btnOpenTSP.Text = "Open TSP";
            this.btnOpenTSP.UseVisualStyleBackColor = false;
            this.btnOpenTSP.Click += new System.EventHandler(this.btnOpenTSP_Click);
            // 
            // theGrid
            // 
            this.theGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theGrid.Location = new System.Drawing.Point(0, 0);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(399, 346);
            this.theGrid.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(7, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 54);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRunOneIteration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunOneIteration.Location = new System.Drawing.Point(124, 4);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(144, 54);
            this.btnRunOneIteration.TabIndex = 4;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = false;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnRunEnd
            // 
            this.btnRunEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRunEnd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunEnd.Location = new System.Drawing.Point(274, 4);
            this.btnRunEnd.Name = "btnRunEnd";
            this.btnRunEnd.Size = new System.Drawing.Size(122, 54);
            this.btnRunEnd.TabIndex = 5;
            this.btnRunEnd.Text = "Run to End";
            this.btnRunEnd.UseVisualStyleBackColor = false;
            this.btnRunEnd.Click += new System.EventHandler(this.btnRunEnd_Click);
            // 
            // SPCsencond
            // 
            this.SPCsencond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPCsencond.Location = new System.Drawing.Point(0, 0);
            this.SPCsencond.Name = "SPCsencond";
            // 
            // SPCsencond.Panel1
            // 
            this.SPCsencond.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SPCsencond.Panel1.Controls.Add(this.labTitle);
            this.SPCsencond.Panel1.Controls.Add(this.labShortestLength);
            this.SPCsencond.Panel1.Controls.Add(this.labNumberOfCities);
            this.SPCsencond.Panel1.Controls.Add(this.rtbData);
            this.SPCsencond.Panel1.Controls.Add(this.btnOpenTSP);
            // 
            // SPCsencond.Panel2
            // 
            this.SPCsencond.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SPCsencond.Panel2.Controls.Add(this.spcThird);
            this.SPCsencond.Size = new System.Drawing.Size(849, 670);
            this.SPCsencond.SplitterDistance = 281;
            this.SPCsencond.TabIndex = 6;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.Navy;
            this.labTitle.Location = new System.Drawing.Point(3, 49);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(55, 22);
            this.labTitle.TabIndex = 7;
            this.labTitle.Text = "Title :";
            // 
            // labShortestLength
            // 
            this.labShortestLength.AutoSize = true;
            this.labShortestLength.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShortestLength.ForeColor = System.Drawing.Color.Navy;
            this.labShortestLength.Location = new System.Drawing.Point(3, 97);
            this.labShortestLength.Name = "labShortestLength";
            this.labShortestLength.Size = new System.Drawing.Size(156, 22);
            this.labShortestLength.TabIndex = 6;
            this.labShortestLength.Text = "Shortest Length : ";
            // 
            // labNumberOfCities
            // 
            this.labNumberOfCities.AutoSize = true;
            this.labNumberOfCities.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumberOfCities.ForeColor = System.Drawing.Color.Navy;
            this.labNumberOfCities.Location = new System.Drawing.Point(3, 71);
            this.labNumberOfCities.Name = "labNumberOfCities";
            this.labNumberOfCities.Size = new System.Drawing.Size(162, 22);
            this.labNumberOfCities.TabIndex = 5;
            this.labNumberOfCities.Text = "Number of Cities : ";
            // 
            // rtbData
            // 
            this.rtbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbData.Location = new System.Drawing.Point(0, 229);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(280, 437);
            this.rtbData.TabIndex = 2;
            this.rtbData.Text = "";
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
            this.spcThird.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.spcThird.Panel1.Controls.Add(this.Mainchart);
            // 
            // spcThird.Panel2
            // 
            this.spcThird.Panel2.Controls.Add(this.tabShow);
            this.spcThird.Size = new System.Drawing.Size(564, 670);
            this.spcThird.SplitterDistance = 321;
            this.spcThird.TabIndex = 0;
            // 
            // Mainchart
            // 
            this.Mainchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Mainchart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea5.AxisX.Title = "Iterations";
            chartArea5.AxisY.Title = "Objective";
            chartArea5.Name = "ChartArea1";
            this.Mainchart.ChartAreas.Add(chartArea5);
            this.Mainchart.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mainchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.Mainchart.Legends.Add(legend5);
            this.Mainchart.Location = new System.Drawing.Point(0, 0);
            this.Mainchart.Name = "Mainchart";
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
            series15.Name = "So Far Best";
            this.Mainchart.Series.Add(series13);
            this.Mainchart.Series.Add(series14);
            this.Mainchart.Series.Add(series15);
            this.Mainchart.Size = new System.Drawing.Size(564, 321);
            this.Mainchart.TabIndex = 22;
            this.Mainchart.Text = "chart1";
            // 
            // tabShow
            // 
            this.tabShow.Controls.Add(this.tabCityRoute);
            this.tabShow.Controls.Add(this.tabPheromoneSolutions);
            this.tabShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabShow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShow.Location = new System.Drawing.Point(0, 0);
            this.tabShow.Name = "tabShow";
            this.tabShow.SelectedIndex = 0;
            this.tabShow.Size = new System.Drawing.Size(564, 345);
            this.tabShow.TabIndex = 0;
            // 
            // tabCityRoute
            // 
            this.tabCityRoute.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCityRoute.Location = new System.Drawing.Point(4, 27);
            this.tabCityRoute.Name = "tabCityRoute";
            this.tabCityRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabCityRoute.Size = new System.Drawing.Size(556, 314);
            this.tabCityRoute.TabIndex = 0;
            this.tabCityRoute.Text = "Cities & Routes";
            this.tabCityRoute.UseVisualStyleBackColor = true;
            this.tabCityRoute.Paint += new System.Windows.Forms.PaintEventHandler(this.tabCityRoute_Paint);
            // 
            // tabPheromoneSolutions
            // 
            this.tabPheromoneSolutions.Controls.Add(this.splitContainer1);
            this.tabPheromoneSolutions.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPheromoneSolutions.Location = new System.Drawing.Point(4, 27);
            this.tabPheromoneSolutions.Name = "tabPheromoneSolutions";
            this.tabPheromoneSolutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPheromoneSolutions.Size = new System.Drawing.Size(556, 314);
            this.tabPheromoneSolutions.TabIndex = 1;
            this.tabPheromoneSolutions.Text = "Pheromone & Solutions";
            this.tabPheromoneSolutions.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ltbPheromone);
            this.splitContainer1.Panel1.Controls.Add(this.ckxShowPheromone);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ltbSolutions);
            this.splitContainer1.Panel2.Controls.Add(this.ckxShowSolutions);
            this.splitContainer1.Size = new System.Drawing.Size(550, 308);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // ltbPheromone
            // 
            this.ltbPheromone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ltbPheromone.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltbPheromone.FormattingEnabled = true;
            this.ltbPheromone.HorizontalScrollbar = true;
            this.ltbPheromone.ItemHeight = 20;
            this.ltbPheromone.Location = new System.Drawing.Point(0, 24);
            this.ltbPheromone.Name = "ltbPheromone";
            this.ltbPheromone.ScrollAlwaysVisible = true;
            this.ltbPheromone.Size = new System.Drawing.Size(265, 284);
            this.ltbPheromone.TabIndex = 12;
            // 
            // ckxShowPheromone
            // 
            this.ckxShowPheromone.AutoSize = true;
            this.ckxShowPheromone.Checked = true;
            this.ckxShowPheromone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckxShowPheromone.Location = new System.Drawing.Point(3, 3);
            this.ckxShowPheromone.Name = "ckxShowPheromone";
            this.ckxShowPheromone.Size = new System.Drawing.Size(157, 24);
            this.ckxShowPheromone.TabIndex = 11;
            this.ckxShowPheromone.Text = "Show Pheromone";
            this.ckxShowPheromone.UseVisualStyleBackColor = true;
            // 
            // ltbSolutions
            // 
            this.ltbSolutions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ltbSolutions.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltbSolutions.FormattingEnabled = true;
            this.ltbSolutions.HorizontalScrollbar = true;
            this.ltbSolutions.ItemHeight = 20;
            this.ltbSolutions.Location = new System.Drawing.Point(0, 24);
            this.ltbSolutions.Name = "ltbSolutions";
            this.ltbSolutions.ScrollAlwaysVisible = true;
            this.ltbSolutions.Size = new System.Drawing.Size(281, 284);
            this.ltbSolutions.TabIndex = 11;
            // 
            // ckxShowSolutions
            // 
            this.ckxShowSolutions.AutoSize = true;
            this.ckxShowSolutions.Checked = true;
            this.ckxShowSolutions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckxShowSolutions.Location = new System.Drawing.Point(0, 3);
            this.ckxShowSolutions.Name = "ckxShowSolutions";
            this.ckxShowSolutions.Size = new System.Drawing.Size(157, 24);
            this.ckxShowSolutions.TabIndex = 10;
            this.ckxShowSolutions.Text = "Show Solutions";
            this.ckxShowSolutions.UseVisualStyleBackColor = true;
            // 
            // SPCFirst
            // 
            this.SPCFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPCFirst.Location = new System.Drawing.Point(0, 0);
            this.SPCFirst.Name = "SPCFirst";
            // 
            // SPCFirst.Panel1
            // 
            this.SPCFirst.Panel1.Controls.Add(this.SPCsencond);
            // 
            // SPCFirst.Panel2
            // 
            this.SPCFirst.Panel2.Controls.Add(this.splitContainer2);
            this.SPCFirst.Size = new System.Drawing.Size(1252, 670);
            this.SPCFirst.SplitterDistance = 849;
            this.SPCFirst.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.theGrid);
            this.splitContainer2.Size = new System.Drawing.Size(399, 670);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cbxUpdate);
            this.splitContainer3.Panel2.Controls.Add(this.btnReset);
            this.splitContainer3.Panel2.Controls.Add(this.btnRunEnd);
            this.splitContainer3.Panel2.Controls.Add(this.btnRunOneIteration);
            this.splitContainer3.Size = new System.Drawing.Size(399, 320);
            this.splitContainer3.SplitterDistance = 214;
            this.splitContainer3.TabIndex = 7;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tabMethod);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(399, 214);
            this.splitContainer4.SplitterDistance = 78;
            this.splitContainer4.TabIndex = 7;
            // 
            // tabMethod
            // 
            this.tabMethod.Controls.Add(this.tabACSMethod);
            this.tabMethod.Controls.Add(this.tabGAMethod);
            this.tabMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMethod.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMethod.Location = new System.Drawing.Point(0, 0);
            this.tabMethod.Name = "tabMethod";
            this.tabMethod.SelectedIndex = 0;
            this.tabMethod.Size = new System.Drawing.Size(399, 78);
            this.tabMethod.TabIndex = 6;
            this.tabMethod.SelectedIndexChanged += new System.EventHandler(this.tabMethod_SelectedIndexChanged);
            // 
            // tabACSMethod
            // 
            this.tabACSMethod.Controls.Add(this.btnCreateACSSolver);
            this.tabACSMethod.Location = new System.Drawing.Point(4, 29);
            this.tabACSMethod.Name = "tabACSMethod";
            this.tabACSMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tabACSMethod.Size = new System.Drawing.Size(391, 45);
            this.tabACSMethod.TabIndex = 0;
            this.tabACSMethod.Text = "ACS Method";
            this.tabACSMethod.UseVisualStyleBackColor = true;
            // 
            // btnCreateACSSolver
            // 
            this.btnCreateACSSolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateACSSolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateACSSolver.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateACSSolver.Location = new System.Drawing.Point(3, 3);
            this.btnCreateACSSolver.Name = "btnCreateACSSolver";
            this.btnCreateACSSolver.Size = new System.Drawing.Size(385, 39);
            this.btnCreateACSSolver.TabIndex = 1;
            this.btnCreateACSSolver.Text = "Create ACS Solver";
            this.btnCreateACSSolver.UseVisualStyleBackColor = false;
            this.btnCreateACSSolver.Click += new System.EventHandler(this.btnCreateACSSolver_Click);
            // 
            // tabGAMethod
            // 
            this.tabGAMethod.Controls.Add(this.rbtnTSPGA);
            this.tabGAMethod.Controls.Add(this.btnCreateGA);
            this.tabGAMethod.Controls.Add(this.rbtnGeneralGA);
            this.tabGAMethod.Location = new System.Drawing.Point(4, 29);
            this.tabGAMethod.Name = "tabGAMethod";
            this.tabGAMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tabGAMethod.Size = new System.Drawing.Size(391, 45);
            this.tabGAMethod.TabIndex = 1;
            this.tabGAMethod.Text = "GA Method";
            this.tabGAMethod.UseVisualStyleBackColor = true;
            // 
            // rbtnTSPGA
            // 
            this.rbtnTSPGA.AutoSize = true;
            this.rbtnTSPGA.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnTSPGA.Location = new System.Drawing.Point(45, 31);
            this.rbtnTSPGA.Name = "rbtnTSPGA";
            this.rbtnTSPGA.Size = new System.Drawing.Size(83, 23);
            this.rbtnTSPGA.TabIndex = 7;
            this.rbtnTSPGA.Text = "TSP GA";
            this.rbtnTSPGA.UseVisualStyleBackColor = true;
            // 
            // btnCreateGA
            // 
            this.btnCreateGA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateGA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateGA.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateGA.Location = new System.Drawing.Point(188, 16);
            this.btnCreateGA.Name = "btnCreateGA";
            this.btnCreateGA.Size = new System.Drawing.Size(159, 35);
            this.btnCreateGA.TabIndex = 6;
            this.btnCreateGA.Text = "Create GA Solver";
            this.btnCreateGA.UseVisualStyleBackColor = false;
            this.btnCreateGA.Click += new System.EventHandler(this.btnCreateGA_Click);
            // 
            // rbtnGeneralGA
            // 
            this.rbtnGeneralGA.AutoSize = true;
            this.rbtnGeneralGA.Checked = true;
            this.rbtnGeneralGA.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnGeneralGA.Location = new System.Drawing.Point(45, 6);
            this.rbtnGeneralGA.Name = "rbtnGeneralGA";
            this.rbtnGeneralGA.Size = new System.Drawing.Size(112, 23);
            this.rbtnGeneralGA.TabIndex = 5;
            this.rbtnGeneralGA.TabStop = true;
            this.rbtnGeneralGA.Text = "General GA";
            this.rbtnGeneralGA.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.labSoFarTheBestSolution);
            this.splitContainer5.Panel1.Controls.Add(this.labSoFarTheShortestLength);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.rtbSoFarTheBestSolution);
            this.splitContainer5.Size = new System.Drawing.Size(399, 132);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 6;
            // 
            // labSoFarTheBestSolution
            // 
            this.labSoFarTheBestSolution.AutoSize = true;
            this.labSoFarTheBestSolution.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheBestSolution.Location = new System.Drawing.Point(2, 19);
            this.labSoFarTheBestSolution.Name = "labSoFarTheBestSolution";
            this.labSoFarTheBestSolution.Size = new System.Drawing.Size(202, 19);
            this.labSoFarTheBestSolution.TabIndex = 4;
            this.labSoFarTheBestSolution.Text = "So Far The Best Solution :  ";
            // 
            // labSoFarTheShortestLength
            // 
            this.labSoFarTheShortestLength.AutoSize = true;
            this.labSoFarTheShortestLength.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSoFarTheShortestLength.Location = new System.Drawing.Point(3, 0);
            this.labSoFarTheShortestLength.Name = "labSoFarTheShortestLength";
            this.labSoFarTheShortestLength.Size = new System.Drawing.Size(218, 19);
            this.labSoFarTheShortestLength.TabIndex = 3;
            this.labSoFarTheShortestLength.Text = "So Far The Shortest Length : ";
            // 
            // rtbSoFarTheBestSolution
            // 
            this.rtbSoFarTheBestSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSoFarTheBestSolution.Location = new System.Drawing.Point(0, 0);
            this.rtbSoFarTheBestSolution.Name = "rtbSoFarTheBestSolution";
            this.rtbSoFarTheBestSolution.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbSoFarTheBestSolution.Size = new System.Drawing.Size(399, 103);
            this.rtbSoFarTheBestSolution.TabIndex = 5;
            this.rtbSoFarTheBestSolution.Text = "";
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Checked = true;
            this.cbxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdate.Location = new System.Drawing.Point(7, 69);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(256, 24);
            this.cbxUpdate.TabIndex = 6;
            this.cbxUpdate.Text = "Real-time Update Progress";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMessage,
            this.progressbar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labMessage
            // 
            this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(1135, 19);
            this.labMessage.Spring = true;
            this.labMessage.Text = "Time Spent";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 17);
            this.progressbar.ToolTipText = "                                                  ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 19);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 695);
            this.Controls.Add(this.SPCFirst);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SPCsencond.Panel1.ResumeLayout(false);
            this.SPCsencond.Panel1.PerformLayout();
            this.SPCsencond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPCsencond)).EndInit();
            this.SPCsencond.ResumeLayout(false);
            this.spcThird.Panel1.ResumeLayout(false);
            this.spcThird.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcThird)).EndInit();
            this.spcThird.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
            this.tabShow.ResumeLayout(false);
            this.tabPheromoneSolutions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SPCFirst.Panel1.ResumeLayout(false);
            this.SPCFirst.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPCFirst)).EndInit();
            this.SPCFirst.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabMethod.ResumeLayout(false);
            this.tabACSMethod.ResumeLayout(false);
            this.tabGAMethod.ResumeLayout(false);
            this.tabGAMethod.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTSP;
        private System.Windows.Forms.PropertyGrid theGrid;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRunOneIteration;
        private System.Windows.Forms.Button btnRunEnd;
        private System.Windows.Forms.SplitContainer SPCsencond;
        private System.Windows.Forms.SplitContainer spcThird;
        private System.Windows.Forms.SplitContainer SPCFirst;
        private System.Windows.Forms.Label labShortestLength;
        private System.Windows.Forms.Label labNumberOfCities;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.DataVisualization.Charting.Chart Mainchart;
        private System.Windows.Forms.TabControl tabShow;
        private System.Windows.Forms.TabPage tabCityRoute;
        private System.Windows.Forms.TabPage tabPheromoneSolutions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ltbPheromone;
        private System.Windows.Forms.CheckBox ckxShowPheromone;
        private System.Windows.Forms.ListBox ltbSolutions;
        private System.Windows.Forms.CheckBox ckxShowSolutions;
        private System.Windows.Forms.TabControl tabMethod;
        private System.Windows.Forms.TabPage tabACSMethod;
        private System.Windows.Forms.TabPage tabGAMethod;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnCreateACSSolver;
        private System.Windows.Forms.RadioButton rbtnTSPGA;
        private System.Windows.Forms.Button btnCreateGA;
        private System.Windows.Forms.RadioButton rbtnGeneralGA;
        private System.Windows.Forms.RichTextBox rtbSoFarTheBestSolution;
        private System.Windows.Forms.Label labSoFarTheBestSolution;
        private System.Windows.Forms.Label labSoFarTheShortestLength;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private System.Windows.Forms.ToolStripStatusLabel labMessage;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

