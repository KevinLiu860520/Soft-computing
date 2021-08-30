namespace R08546002YCLiuAss06
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input Universe");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Output Universe");
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DeleteRule = new System.Windows.Forms.Button();
            this.btnInference = new System.Windows.Forms.Button();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.btnAddrule = new System.Windows.Forms.Button();
            this.IfThenRules = new System.Windows.Forms.TabPage();
            this.cut_sc = new System.Windows.Forms.RadioButton();
            this.cut_rb = new System.Windows.Forms.RadioButton();
            this.DeleteGrayArea = new System.Windows.Forms.Button();
            this.dgvCondition = new System.Windows.Forms.DataGridView();
            this.BinaryOperatorSelect = new System.Windows.Forms.ComboBox();
            this.btnCreateBinary = new System.Windows.Forms.Button();
            this.BinarySelectGroup = new System.Windows.Forms.GroupBox();
            this.UnaryOperatorSelect = new System.Windows.Forms.ComboBox();
            this.btnCreateUnaryOperatedFS = new System.Windows.Forms.Button();
            this.labSecondFS = new System.Windows.Forms.Label();
            this.UnarySelectGroup = new System.Windows.Forms.GroupBox();
            this.FunctionSelection = new System.Windows.Forms.ComboBox();
            this.btnCreateFuzzySet = new System.Windows.Forms.Button();
            this.labFirstFS = new System.Windows.Forms.Label();
            this.FunctionSelectGroup = new System.Windows.Forms.GroupBox();
            this.FuzzySetTab = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.OutputEquations = new System.Windows.Forms.TabPage();
            this.AddEquations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SugenoFormula = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.rdoTsukamoto = new System.Windows.Forms.RadioButton();
            this.rdoSugeno = new System.Windows.Forms.RadioButton();
            this.rdoMamdani = new System.Windows.Forms.RadioButton();
            this.ChosenInput = new System.Windows.Forms.TextBox();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.thetree = new System.Windows.Forms.TreeView();
            this.thegrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.text1Dand2D = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resolution = new System.Windows.Forms.Label();
            this.rbnLOM = new System.Windows.Forms.RadioButton();
            this.rbnSOM = new System.Windows.Forms.RadioButton();
            this.ResolutionValue = new System.Windows.Forms.NumericUpDown();
            this.rbnMOM = new System.Windows.Forms.RadioButton();
            this.rbnBOA = new System.Windows.Forms.RadioButton();
            this.rbnCOA = new System.Windows.Forms.RadioButton();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.threeDplot = new Steema.TeeChart.TChart();
            this.plotcontrol = new Steema.TeeChart.Styles.Surface();
            this.rbnCut = new System.Windows.Forms.RadioButton();
            this.btnCrispCrispOutInferencing = new System.Windows.Forms.Button();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbnSum = new System.Windows.Forms.RadioButton();
            this.rbnAverage = new System.Windows.Forms.RadioButton();
            this.rbnScale = new System.Windows.Forms.RadioButton();
            this.Chart_1D = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.IfThenRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.BinarySelectGroup.SuspendLayout();
            this.UnarySelectGroup.SuspendLayout();
            this.FunctionSelectGroup.SuspendLayout();
            this.FuzzySetTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.OutputEquations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_1D)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteRule
            // 
            this.DeleteRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteRule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRule.Location = new System.Drawing.Point(291, 6);
            this.DeleteRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteRule.Name = "DeleteRule";
            this.DeleteRule.Size = new System.Drawing.Size(253, 32);
            this.DeleteRule.TabIndex = 9;
            this.DeleteRule.Text = "Delete Rule";
            this.DeleteRule.UseVisualStyleBackColor = false;
            this.DeleteRule.Click += new System.EventHandler(this.DeleteRule_Click);
            // 
            // btnInference
            // 
            this.btnInference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInference.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInference.Location = new System.Drawing.Point(5, 214);
            this.btnInference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInference.Name = "btnInference";
            this.btnInference.Size = new System.Drawing.Size(203, 39);
            this.btnInference.TabIndex = 7;
            this.btnInference.Text = "Inference One Instance";
            this.btnInference.UseVisualStyleBackColor = false;
            this.btnInference.Click += new System.EventHandler(this.btnInference_Click);
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(5, 42);
            this.dgvRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.RowTemplate.Height = 27;
            this.dgvRules.Size = new System.Drawing.Size(539, 165);
            this.dgvRules.TabIndex = 5;
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            // 
            // btnAddrule
            // 
            this.btnAddrule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddrule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddrule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddrule.Location = new System.Drawing.Point(5, 6);
            this.btnAddrule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddrule.Name = "btnAddrule";
            this.btnAddrule.Size = new System.Drawing.Size(247, 32);
            this.btnAddrule.TabIndex = 6;
            this.btnAddrule.Text = "Add Rule";
            this.btnAddrule.UseVisualStyleBackColor = false;
            this.btnAddrule.Click += new System.EventHandler(this.btnAddrule_Click);
            // 
            // IfThenRules
            // 
            this.IfThenRules.Controls.Add(this.cut_sc);
            this.IfThenRules.Controls.Add(this.cut_rb);
            this.IfThenRules.Controls.Add(this.DeleteGrayArea);
            this.IfThenRules.Controls.Add(this.DeleteRule);
            this.IfThenRules.Controls.Add(this.btnInference);
            this.IfThenRules.Controls.Add(this.dgvRules);
            this.IfThenRules.Controls.Add(this.dgvCondition);
            this.IfThenRules.Controls.Add(this.btnAddrule);
            this.IfThenRules.Location = new System.Drawing.Point(4, 29);
            this.IfThenRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IfThenRules.Name = "IfThenRules";
            this.IfThenRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IfThenRules.Size = new System.Drawing.Size(548, 672);
            this.IfThenRules.TabIndex = 1;
            this.IfThenRules.Text = "If-Then Rules";
            this.IfThenRules.UseVisualStyleBackColor = true;
            // 
            // cut_sc
            // 
            this.cut_sc.AutoSize = true;
            this.cut_sc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cut_sc.Location = new System.Drawing.Point(449, 254);
            this.cut_sc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cut_sc.Name = "cut_sc";
            this.cut_sc.Size = new System.Drawing.Size(75, 24);
            this.cut_sc.TabIndex = 12;
            this.cut_sc.TabStop = true;
            this.cut_sc.Text = "Scale";
            this.cut_sc.UseVisualStyleBackColor = true;
            // 
            // cut_rb
            // 
            this.cut_rb.AutoSize = true;
            this.cut_rb.Checked = true;
            this.cut_rb.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cut_rb.Location = new System.Drawing.Point(449, 215);
            this.cut_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cut_rb.Name = "cut_rb";
            this.cut_rb.Size = new System.Drawing.Size(57, 24);
            this.cut_rb.TabIndex = 11;
            this.cut_rb.TabStop = true;
            this.cut_rb.Text = "Cut";
            this.cut_rb.UseVisualStyleBackColor = true;
            // 
            // DeleteGrayArea
            // 
            this.DeleteGrayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteGrayArea.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGrayArea.Location = new System.Drawing.Point(213, 214);
            this.DeleteGrayArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteGrayArea.Name = "DeleteGrayArea";
            this.DeleteGrayArea.Size = new System.Drawing.Size(231, 39);
            this.DeleteGrayArea.TabIndex = 10;
            this.DeleteGrayArea.Text = "Delete GrayArea";
            this.DeleteGrayArea.UseVisualStyleBackColor = false;
            this.DeleteGrayArea.Click += new System.EventHandler(this.DeleteGrayArea_Click);
            // 
            // dgvCondition
            // 
            this.dgvCondition.AllowUserToAddRows = false;
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(5, 254);
            this.dgvCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowHeadersWidth = 51;
            this.dgvCondition.RowTemplate.Height = 27;
            this.dgvCondition.Size = new System.Drawing.Size(439, 172);
            this.dgvCondition.TabIndex = 8;
            this.dgvCondition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondition_CellClick);
            // 
            // BinaryOperatorSelect
            // 
            this.BinaryOperatorSelect.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryOperatorSelect.FormattingEnabled = true;
            this.BinaryOperatorSelect.Items.AddRange(new object[] {
            "Algerbraic Product",
            "Bounded Product",
            "Dombi Tnorm",
            "Doubisan and Prade Tnorm",
            "Drastic Product",
            "Eintein Product",
            "Frank Tnorm",
            "Hamacher Product",
            "Minimum",
            "Sugeno Tnorm",
            "Substract",
            "Yager Tnorm",
            "Algerbraic Sum",
            "Bounded Sum",
            "Dombi Snorm",
            "Doubisan and Prade Snorm",
            "Drastic Sum",
            "Eintein Sum",
            "Frank Snorm",
            "Hamacher Sum",
            "Maximum",
            "Sugeno Snorm",
            "Substract",
            "Yager Snorm"});
            this.BinaryOperatorSelect.Location = new System.Drawing.Point(5, 28);
            this.BinaryOperatorSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinaryOperatorSelect.Name = "BinaryOperatorSelect";
            this.BinaryOperatorSelect.Size = new System.Drawing.Size(524, 27);
            this.BinaryOperatorSelect.TabIndex = 13;
            // 
            // btnCreateBinary
            // 
            this.btnCreateBinary.Location = new System.Drawing.Point(5, 61);
            this.btnCreateBinary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBinary.Name = "btnCreateBinary";
            this.btnCreateBinary.Size = new System.Drawing.Size(523, 32);
            this.btnCreateBinary.TabIndex = 15;
            this.btnCreateBinary.Text = "Create Binary Operator";
            this.btnCreateBinary.UseVisualStyleBackColor = true;
            this.btnCreateBinary.Click += new System.EventHandler(this.btnCreateBinary_Click);
            // 
            // BinarySelectGroup
            // 
            this.BinarySelectGroup.Controls.Add(this.BinaryOperatorSelect);
            this.BinarySelectGroup.Controls.Add(this.btnCreateBinary);
            this.BinarySelectGroup.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarySelectGroup.Location = new System.Drawing.Point(9, 214);
            this.BinarySelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinarySelectGroup.Name = "BinarySelectGroup";
            this.BinarySelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinarySelectGroup.Size = new System.Drawing.Size(531, 101);
            this.BinarySelectGroup.TabIndex = 19;
            this.BinarySelectGroup.TabStop = false;
            this.BinarySelectGroup.Text = "Select Binary OP";
            // 
            // UnaryOperatorSelect
            // 
            this.UnaryOperatorSelect.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnaryOperatorSelect.FormattingEnabled = true;
            this.UnaryOperatorSelect.Items.AddRange(new object[] {
            "Negate Operator",
            "Value-cut Operator",
            "Value-scale Operator",
            "Concentration Operator",
            "Dilation Operator",
            "Diminisher Operator",
            "Extremely Operator",
            "Intensification Operator",
            "Sugeno\'s complement Operator",
            "Yager\'s complement Operator"});
            this.UnaryOperatorSelect.Location = new System.Drawing.Point(7, 28);
            this.UnaryOperatorSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnaryOperatorSelect.Name = "UnaryOperatorSelect";
            this.UnaryOperatorSelect.Size = new System.Drawing.Size(524, 27);
            this.UnaryOperatorSelect.TabIndex = 7;
            // 
            // btnCreateUnaryOperatedFS
            // 
            this.btnCreateUnaryOperatedFS.Location = new System.Drawing.Point(7, 61);
            this.btnCreateUnaryOperatedFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUnaryOperatedFS.Name = "btnCreateUnaryOperatedFS";
            this.btnCreateUnaryOperatedFS.Size = new System.Drawing.Size(524, 35);
            this.btnCreateUnaryOperatedFS.TabIndex = 8;
            this.btnCreateUnaryOperatedFS.Text = "Create Unary Operator\r\n";
            this.btnCreateUnaryOperatedFS.UseVisualStyleBackColor = true;
            this.btnCreateUnaryOperatedFS.Click += new System.EventHandler(this.btnCreateUnaryOperatedFS_Click);
            // 
            // labSecondFS
            // 
            this.labSecondFS.AutoSize = true;
            this.labSecondFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labSecondFS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSecondFS.Location = new System.Drawing.Point(9, 379);
            this.labSecondFS.Name = "labSecondFS";
            this.labSecondFS.Size = new System.Drawing.Size(351, 23);
            this.labSecondFS.TabIndex = 10;
            this.labSecondFS.Text = "Click to store Second Fuzzy Set";
            this.labSecondFS.TextChanged += new System.EventHandler(this.labSecondFS_TextChanged);
            this.labSecondFS.Click += new System.EventHandler(this.labSecondFS_Click);
            // 
            // UnarySelectGroup
            // 
            this.UnarySelectGroup.Controls.Add(this.UnaryOperatorSelect);
            this.UnarySelectGroup.Controls.Add(this.btnCreateUnaryOperatedFS);
            this.UnarySelectGroup.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnarySelectGroup.Location = new System.Drawing.Point(5, 112);
            this.UnarySelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnarySelectGroup.Name = "UnarySelectGroup";
            this.UnarySelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnarySelectGroup.Size = new System.Drawing.Size(531, 96);
            this.UnarySelectGroup.TabIndex = 18;
            this.UnarySelectGroup.TabStop = false;
            this.UnarySelectGroup.Text = "Select Unary OP";
            // 
            // FunctionSelection
            // 
            this.FunctionSelection.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionSelection.FormattingEnabled = true;
            this.FunctionSelection.Items.AddRange(new object[] {
            "Gaussian Function",
            "Bell Function",
            "Trapezoidal Function",
            "Triangular Function",
            "Sigmoidal Function",
            "Left-right Function",
            "S Shaped Function",
            "Z Shaped Function",
            "Pi Shaped Function",
            "StepUp Function",
            "StepDown Function",
            "Two-side Gaussian Function",
            "Two-side Pi Function"});
            this.FunctionSelection.Location = new System.Drawing.Point(5, 28);
            this.FunctionSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(524, 27);
            this.FunctionSelection.TabIndex = 5;
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(5, 61);
            this.btnCreateFuzzySet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(524, 32);
            this.btnCreateFuzzySet.TabIndex = 6;
            this.btnCreateFuzzySet.Text = "Create Fuzzy Set";
            this.btnCreateFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateFuzzySet.Click += new System.EventHandler(this.btnCreateFuzzySet_Click);
            // 
            // labFirstFS
            // 
            this.labFirstFS.AutoSize = true;
            this.labFirstFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labFirstFS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstFS.Location = new System.Drawing.Point(10, 332);
            this.labFirstFS.Margin = new System.Windows.Forms.Padding(0);
            this.labFirstFS.Name = "labFirstFS";
            this.labFirstFS.Size = new System.Drawing.Size(340, 23);
            this.labFirstFS.TabIndex = 9;
            this.labFirstFS.Text = "Click to store First Fuzzy Set";
            this.labFirstFS.TextChanged += new System.EventHandler(this.labFirstFS_TextChanged);
            this.labFirstFS.Click += new System.EventHandler(this.labFirstFS_Click);
            // 
            // FunctionSelectGroup
            // 
            this.FunctionSelectGroup.Controls.Add(this.FunctionSelection);
            this.FunctionSelectGroup.Controls.Add(this.btnCreateFuzzySet);
            this.FunctionSelectGroup.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionSelectGroup.Location = new System.Drawing.Point(7, 6);
            this.FunctionSelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionSelectGroup.Name = "FunctionSelectGroup";
            this.FunctionSelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionSelectGroup.Size = new System.Drawing.Size(531, 100);
            this.FunctionSelectGroup.TabIndex = 17;
            this.FunctionSelectGroup.TabStop = false;
            this.FunctionSelectGroup.Text = "Select Function";
            // 
            // FuzzySetTab
            // 
            this.FuzzySetTab.Controls.Add(this.labFirstFS);
            this.FuzzySetTab.Controls.Add(this.FunctionSelectGroup);
            this.FuzzySetTab.Controls.Add(this.labSecondFS);
            this.FuzzySetTab.Controls.Add(this.UnarySelectGroup);
            this.FuzzySetTab.Controls.Add(this.BinarySelectGroup);
            this.FuzzySetTab.Location = new System.Drawing.Point(4, 29);
            this.FuzzySetTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FuzzySetTab.Name = "FuzzySetTab";
            this.FuzzySetTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FuzzySetTab.Size = new System.Drawing.Size(548, 672);
            this.FuzzySetTab.TabIndex = 0;
            this.FuzzySetTab.Text = "FuzzySet";
            this.FuzzySetTab.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.FuzzySetTab);
            this.tabControl.Controls.Add(this.IfThenRules);
            this.tabControl.Controls.Add(this.OutputEquations);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(556, 705);
            this.tabControl.TabIndex = 9;
            // 
            // OutputEquations
            // 
            this.OutputEquations.Controls.Add(this.AddEquations);
            this.OutputEquations.Controls.Add(this.label1);
            this.OutputEquations.Controls.Add(this.SugenoFormula);
            this.OutputEquations.Location = new System.Drawing.Point(4, 29);
            this.OutputEquations.Margin = new System.Windows.Forms.Padding(4);
            this.OutputEquations.Name = "OutputEquations";
            this.OutputEquations.Size = new System.Drawing.Size(548, 672);
            this.OutputEquations.TabIndex = 2;
            this.OutputEquations.Text = "Output equations";
            this.OutputEquations.UseVisualStyleBackColor = true;
            // 
            // AddEquations
            // 
            this.AddEquations.Location = new System.Drawing.Point(15, 272);
            this.AddEquations.Margin = new System.Windows.Forms.Padding(4);
            this.AddEquations.Name = "AddEquations";
            this.AddEquations.Size = new System.Drawing.Size(227, 82);
            this.AddEquations.TabIndex = 2;
            this.AddEquations.Text = "Add Equations";
            this.AddEquations.UseVisualStyleBackColor = true;
            this.AddEquations.Click += new System.EventHandler(this.AddEquations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sugeno Output";
            // 
            // SugenoFormula
            // 
            this.SugenoFormula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SugenoFormula.FormattingEnabled = true;
            this.SugenoFormula.ItemHeight = 23;
            this.SugenoFormula.Items.AddRange(new object[] {
            "0 : Y = 0.1 X + 6.4",
            "1 : Y = - 0.5 X + 4",
            "2 : Y = X - 2",
            "3 : Z = - X + Y + 1",
            "4 : Z = - Y + 3",
            "5 : Z = - X + 3",
            "6 : Z = X + Y + 2"});
            this.SugenoFormula.Location = new System.Drawing.Point(15, 44);
            this.SugenoFormula.Margin = new System.Windows.Forms.Padding(4);
            this.SugenoFormula.Name = "SugenoFormula";
            this.SugenoFormula.Size = new System.Drawing.Size(412, 188);
            this.SugenoFormula.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel1.Controls.Add(this.toolstrip);
            this.splitContainer2.Panel1.Controls.Add(this.rdoTsukamoto);
            this.splitContainer2.Panel1.Controls.Add(this.rdoSugeno);
            this.splitContainer2.Panel1.Controls.Add(this.rdoMamdani);
            this.splitContainer2.Panel1.Controls.Add(this.ChosenInput);
            this.splitContainer2.Panel1.Controls.Add(this.btnCreateUniverse);
            this.splitContainer2.Panel1.Controls.Add(this.Delete);
            this.splitContainer2.Panel1.Controls.Add(this.thetree);
            this.splitContainer2.Panel1.Controls.Add(this.thegrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Controls.Add(this.tabControl);
            this.splitContainer2.Size = new System.Drawing.Size(560, 881);
            this.splitContainer2.SplitterDistance = 410;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolstrip
            // 
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(560, 29);
            this.toolstrip.TabIndex = 24;
            this.toolstrip.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(73, 26);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(72, 26);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // rdoTsukamoto
            // 
            this.rdoTsukamoto.AutoSize = true;
            this.rdoTsukamoto.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTsukamoto.Location = new System.Drawing.Point(213, 31);
            this.rdoTsukamoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoTsukamoto.Name = "rdoTsukamoto";
            this.rdoTsukamoto.Size = new System.Drawing.Size(121, 26);
            this.rdoTsukamoto.TabIndex = 23;
            this.rdoTsukamoto.Text = "Tsukamoto";
            this.rdoTsukamoto.UseVisualStyleBackColor = true;
            this.rdoTsukamoto.Click += new System.EventHandler(this.MSTInference_Changed);
            // 
            // rdoSugeno
            // 
            this.rdoSugeno.AutoSize = true;
            this.rdoSugeno.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSugeno.Location = new System.Drawing.Point(116, 31);
            this.rdoSugeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSugeno.Name = "rdoSugeno";
            this.rdoSugeno.Size = new System.Drawing.Size(91, 26);
            this.rdoSugeno.TabIndex = 22;
            this.rdoSugeno.Text = "Sugeno";
            this.rdoSugeno.UseVisualStyleBackColor = true;
            this.rdoSugeno.Click += new System.EventHandler(this.MSTInference_Changed);
            // 
            // rdoMamdani
            // 
            this.rdoMamdani.AutoSize = true;
            this.rdoMamdani.Checked = true;
            this.rdoMamdani.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMamdani.Location = new System.Drawing.Point(9, 31);
            this.rdoMamdani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMamdani.Name = "rdoMamdani";
            this.rdoMamdani.Size = new System.Drawing.Size(101, 26);
            this.rdoMamdani.TabIndex = 21;
            this.rdoMamdani.TabStop = true;
            this.rdoMamdani.Text = "Mamdani";
            this.rdoMamdani.UseVisualStyleBackColor = true;
            this.rdoMamdani.Click += new System.EventHandler(this.MSTInference_Changed);
            // 
            // ChosenInput
            // 
            this.ChosenInput.BackColor = System.Drawing.Color.Silver;
            this.ChosenInput.Cursor = System.Windows.Forms.Cursors.No;
            this.ChosenInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChosenInput.Location = new System.Drawing.Point(276, 61);
            this.ChosenInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChosenInput.Name = "ChosenInput";
            this.ChosenInput.Size = new System.Drawing.Size(279, 25);
            this.ChosenInput.TabIndex = 20;
            this.ChosenInput.Text = "Chosen Input";
            this.ChosenInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateUniverse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUniverse.Location = new System.Drawing.Point(6, 61);
            this.btnCreateUniverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(180, 49);
            this.btnCreateUniverse.TabIndex = 0;
            this.btnCreateUniverse.Text = "Create \r\nUniverse";
            this.btnCreateUniverse.UseVisualStyleBackColor = false;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Delete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(192, 61);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 49);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // thetree
            // 
            this.thetree.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thetree.Location = new System.Drawing.Point(6, 112);
            this.thetree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thetree.Name = "thetree";
            treeNode1.Name = "Input";
            treeNode1.Text = "Input Universe";
            treeNode2.Name = "Output";
            treeNode2.Text = "Output Universe";
            this.thetree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.thetree.Size = new System.Drawing.Size(265, 274);
            this.thetree.TabIndex = 2;
            this.thetree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.thetree_AfterSelect);
            // 
            // thegrid
            // 
            this.thegrid.Location = new System.Drawing.Point(275, 92);
            this.thegrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thegrid.Name = "thegrid";
            this.thegrid.Size = new System.Drawing.Size(280, 294);
            this.thegrid.TabIndex = 3;
            this.thegrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.thegrid_PropertyValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.text1Dand2D);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.rbnCut);
            this.splitContainer1.Panel2.Controls.Add(this.btnCrispCrispOutInferencing);
            this.splitContainer1.Panel2.Controls.Add(this.Mainchart);
            this.splitContainer1.Panel2.Controls.Add(this.rbnSum);
            this.splitContainer1.Panel2.Controls.Add(this.rbnAverage);
            this.splitContainer1.Panel2.Controls.Add(this.rbnScale);
            this.splitContainer1.Panel2.Controls.Add(this.threeDplot);
            this.splitContainer1.Panel2.Controls.Add(this.Chart_1D);
            this.splitContainer1.Size = new System.Drawing.Size(1499, 881);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.TabIndex = 11;
            // 
            // text1Dand2D
            // 
            this.text1Dand2D.AutoSize = true;
            this.text1Dand2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.text1Dand2D.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1Dand2D.Location = new System.Drawing.Point(1, 534);
            this.text1Dand2D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1Dand2D.Name = "text1Dand2D";
            this.text1Dand2D.Size = new System.Drawing.Size(21, 23);
            this.text1Dand2D.TabIndex = 12;
            this.text1Dand2D.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Resolution);
            this.panel1.Controls.Add(this.rbnLOM);
            this.panel1.Controls.Add(this.rbnSOM);
            this.panel1.Controls.Add(this.ResolutionValue);
            this.panel1.Controls.Add(this.rbnMOM);
            this.panel1.Controls.Add(this.rbnBOA);
            this.panel1.Controls.Add(this.rbnCOA);
            this.panel1.Controls.Add(this.chartController1);
            this.panel1.Location = new System.Drawing.Point(732, 534);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 314);
            this.panel1.TabIndex = 10;
            // 
            // Resolution
            // 
            this.Resolution.AutoSize = true;
            this.Resolution.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolution.Location = new System.Drawing.Point(16, 9);
            this.Resolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(131, 23);
            this.Resolution.TabIndex = 32;
            this.Resolution.Text = "Resolutions";
            // 
            // rbnLOM
            // 
            this.rbnLOM.AutoSize = true;
            this.rbnLOM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLOM.Location = new System.Drawing.Point(21, 240);
            this.rbnLOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnLOM.Name = "rbnLOM";
            this.rbnLOM.Size = new System.Drawing.Size(64, 27);
            this.rbnLOM.TabIndex = 31;
            this.rbnLOM.TabStop = true;
            this.rbnLOM.Text = "LOM";
            this.rbnLOM.UseVisualStyleBackColor = true;
            this.rbnLOM.Click += new System.EventHandler(this.DefuzzificationType);
            // 
            // rbnSOM
            // 
            this.rbnSOM.AutoSize = true;
            this.rbnSOM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSOM.Location = new System.Drawing.Point(21, 200);
            this.rbnSOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnSOM.Name = "rbnSOM";
            this.rbnSOM.Size = new System.Drawing.Size(64, 27);
            this.rbnSOM.TabIndex = 30;
            this.rbnSOM.TabStop = true;
            this.rbnSOM.Text = "SOM";
            this.rbnSOM.UseVisualStyleBackColor = true;
            this.rbnSOM.Click += new System.EventHandler(this.DefuzzificationType);
            // 
            // ResolutionValue
            // 
            this.ResolutionValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionValue.Location = new System.Drawing.Point(21, 40);
            this.ResolutionValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResolutionValue.Name = "ResolutionValue";
            this.ResolutionValue.Size = new System.Drawing.Size(167, 31);
            this.ResolutionValue.TabIndex = 9;
            this.ResolutionValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rbnMOM
            // 
            this.rbnMOM.AutoSize = true;
            this.rbnMOM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMOM.Location = new System.Drawing.Point(21, 161);
            this.rbnMOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnMOM.Name = "rbnMOM";
            this.rbnMOM.Size = new System.Drawing.Size(64, 27);
            this.rbnMOM.TabIndex = 29;
            this.rbnMOM.TabStop = true;
            this.rbnMOM.Text = "MOM";
            this.rbnMOM.UseVisualStyleBackColor = true;
            this.rbnMOM.Click += new System.EventHandler(this.DefuzzificationType);
            // 
            // rbnBOA
            // 
            this.rbnBOA.AutoSize = true;
            this.rbnBOA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnBOA.Location = new System.Drawing.Point(21, 122);
            this.rbnBOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnBOA.Name = "rbnBOA";
            this.rbnBOA.Size = new System.Drawing.Size(64, 27);
            this.rbnBOA.TabIndex = 28;
            this.rbnBOA.TabStop = true;
            this.rbnBOA.Text = "BOA";
            this.rbnBOA.UseVisualStyleBackColor = true;
            this.rbnBOA.Click += new System.EventHandler(this.DefuzzificationType);
            // 
            // rbnCOA
            // 
            this.rbnCOA.AutoSize = true;
            this.rbnCOA.Checked = true;
            this.rbnCOA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCOA.Location = new System.Drawing.Point(21, 84);
            this.rbnCOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnCOA.Name = "rbnCOA";
            this.rbnCOA.Size = new System.Drawing.Size(64, 27);
            this.rbnCOA.TabIndex = 27;
            this.rbnCOA.TabStop = true;
            this.rbnCOA.Text = "COA";
            this.rbnCOA.UseVisualStyleBackColor = true;
            this.rbnCOA.Click += new System.EventHandler(this.DefuzzificationType);
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.threeDplot;
            this.chartController1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 289);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(200, 25);
            this.chartController1.TabIndex = 26;
            this.chartController1.Text = "chartController1";
            // 
            // threeDplot
            // 
            // 
            // 
            // 
            this.threeDplot.Aspect.Chart3DPercent = 100;
            this.threeDplot.Aspect.Orthogonal = false;
            this.threeDplot.Aspect.Zoom = 72;
            this.threeDplot.Aspect.ZoomFloat = 72D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.threeDplot.Axes.Depth.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            this.threeDplot.Axes.DepthTop.LabelsAsSeriesTitles = true;
            this.threeDplot.Location = new System.Drawing.Point(148, 533);
            this.threeDplot.Margin = new System.Windows.Forms.Padding(4);
            this.threeDplot.Name = "threeDplot";
            this.threeDplot.Series.Add(this.plotcontrol);
            this.threeDplot.Size = new System.Drawing.Size(580, 314);
            this.threeDplot.TabIndex = 11;
            this.threeDplot.UseWaitCursor = true;
            this.threeDplot.Visible = false;
            // 
            // plotcontrol
            // 
            // 
            // 
            // 
            this.plotcontrol.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.plotcontrol.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.plotcontrol.ColorEach = false;
            this.plotcontrol.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.plotcontrol.MidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plotcontrol.PaletteMin = 0D;
            this.plotcontrol.PaletteStep = 0D;
            this.plotcontrol.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.plotcontrol.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.plotcontrol.Title = "surface1";
            // 
            // 
            // 
            this.plotcontrol.XValues.DataMember = "X";
            // 
            // 
            // 
            this.plotcontrol.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.plotcontrol.ZValues.DataMember = "Z";
            // 
            // rbnCut
            // 
            this.rbnCut.AutoSize = true;
            this.rbnCut.Checked = true;
            this.rbnCut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCut.Location = new System.Drawing.Point(0, 667);
            this.rbnCut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnCut.Name = "rbnCut";
            this.rbnCut.Size = new System.Drawing.Size(64, 27);
            this.rbnCut.TabIndex = 7;
            this.rbnCut.TabStop = true;
            this.rbnCut.Text = "Cut";
            this.rbnCut.UseVisualStyleBackColor = true;
            // 
            // btnCrispCrispOutInferencing
            // 
            this.btnCrispCrispOutInferencing.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrispCrispOutInferencing.Location = new System.Drawing.Point(0, 744);
            this.btnCrispCrispOutInferencing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrispCrispOutInferencing.Name = "btnCrispCrispOutInferencing";
            this.btnCrispCrispOutInferencing.Size = new System.Drawing.Size(146, 101);
            this.btnCrispCrispOutInferencing.TabIndex = 5;
            this.btnCrispCrispOutInferencing.Text = "All Crisp Values Inferencing";
            this.btnCrispCrispOutInferencing.UseVisualStyleBackColor = true;
            this.btnCrispCrispOutInferencing.Click += new System.EventHandler(this.btnCrispCrispOutInferencing_Click);
            // 
            // Mainchart
            // 
            legend1.Name = "Legend1";
            this.Mainchart.Legends.Add(legend1);
            this.Mainchart.Location = new System.Drawing.Point(3, 2);
            this.Mainchart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mainchart.Name = "Mainchart";
            this.Mainchart.Size = new System.Drawing.Size(927, 526);
            this.Mainchart.TabIndex = 4;
            this.Mainchart.Text = "chart1";
            // 
            // rbnSum
            // 
            this.rbnSum.AutoSize = true;
            this.rbnSum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSum.Location = new System.Drawing.Point(0, 705);
            this.rbnSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnSum.Name = "rbnSum";
            this.rbnSum.Size = new System.Drawing.Size(64, 27);
            this.rbnSum.TabIndex = 15;
            this.rbnSum.TabStop = true;
            this.rbnSum.Text = "Sum";
            this.rbnSum.UseVisualStyleBackColor = true;
            // 
            // rbnAverage
            // 
            this.rbnAverage.AutoSize = true;
            this.rbnAverage.Checked = true;
            this.rbnAverage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAverage.Location = new System.Drawing.Point(0, 667);
            this.rbnAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAverage.Name = "rbnAverage";
            this.rbnAverage.Size = new System.Drawing.Size(108, 27);
            this.rbnAverage.TabIndex = 14;
            this.rbnAverage.TabStop = true;
            this.rbnAverage.Text = "Average";
            this.rbnAverage.UseVisualStyleBackColor = true;
            // 
            // rbnScale
            // 
            this.rbnScale.AutoSize = true;
            this.rbnScale.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnScale.Location = new System.Drawing.Point(0, 705);
            this.rbnScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnScale.Name = "rbnScale";
            this.rbnScale.Size = new System.Drawing.Size(86, 27);
            this.rbnScale.TabIndex = 8;
            this.rbnScale.TabStop = true;
            this.rbnScale.Text = "Scale";
            this.rbnScale.UseVisualStyleBackColor = true;
            // 
            // Chart_1D
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.Chart_1D.ChartAreas.Add(chartArea1);
            legend2.Name = "Legend1";
            this.Chart_1D.Legends.Add(legend2);
            this.Chart_1D.Location = new System.Drawing.Point(148, 533);
            this.Chart_1D.Margin = new System.Windows.Forms.Padding(4);
            this.Chart_1D.Name = "Chart_1D";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_1D.Series.Add(series1);
            this.Chart_1D.Size = new System.Drawing.Size(580, 314);
            this.Chart_1D.TabIndex = 13;
            this.Chart_1D.Text = "chart1";
            this.Chart_1D.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.Chart_1D.Visible = false;
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "txt";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 881);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Assignment#6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.IfThenRules.ResumeLayout(false);
            this.IfThenRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.BinarySelectGroup.ResumeLayout(false);
            this.UnarySelectGroup.ResumeLayout(false);
            this.FunctionSelectGroup.ResumeLayout(false);
            this.FuzzySetTab.ResumeLayout(false);
            this.FuzzySetTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.OutputEquations.ResumeLayout(false);
            this.OutputEquations.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_1D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteRule;
        private System.Windows.Forms.Button btnInference;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.Button btnAddrule;
        private System.Windows.Forms.TabPage IfThenRules;
        private System.Windows.Forms.DataGridView dgvCondition;
        private System.Windows.Forms.ComboBox BinaryOperatorSelect;
        private System.Windows.Forms.Button btnCreateBinary;
        private System.Windows.Forms.GroupBox BinarySelectGroup;
        private System.Windows.Forms.ComboBox UnaryOperatorSelect;
        private System.Windows.Forms.Button btnCreateUnaryOperatedFS;
        private System.Windows.Forms.Label labSecondFS;
        private System.Windows.Forms.GroupBox UnarySelectGroup;
        private System.Windows.Forms.ComboBox FunctionSelection;
        private System.Windows.Forms.Button btnCreateFuzzySet;
        private System.Windows.Forms.Label labFirstFS;
        private System.Windows.Forms.GroupBox FunctionSelectGroup;
        private System.Windows.Forms.TabPage FuzzySetTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox ChosenInput;
        private System.Windows.Forms.Button btnCreateUniverse;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TreeView thetree;
        private System.Windows.Forms.PropertyGrid thegrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Mainchart;
        private System.Windows.Forms.RadioButton rdoMamdani;
        private System.Windows.Forms.RadioButton rdoTsukamoto;
        private System.Windows.Forms.RadioButton rdoSugeno;
        private System.Windows.Forms.Button btnCrispCrispOutInferencing;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button DeleteGrayArea;
        private System.Windows.Forms.RadioButton rbnScale;
        private System.Windows.Forms.RadioButton rbnCut;
        private System.Windows.Forms.NumericUpDown ResolutionValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnLOM;
        private System.Windows.Forms.RadioButton rbnSOM;
        private System.Windows.Forms.RadioButton rbnMOM;
        private System.Windows.Forms.RadioButton rbnBOA;
        private System.Windows.Forms.RadioButton rbnCOA;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.TChart threeDplot;
        private Steema.TeeChart.Styles.Surface plotcontrol;
        private System.Windows.Forms.TabPage OutputEquations;
        private System.Windows.Forms.ListBox SugenoFormula;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.Button AddEquations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cut_sc;
        private System.Windows.Forms.RadioButton cut_rb;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_1D;
        private System.Windows.Forms.Label text1Dand2D;
        private System.Windows.Forms.RadioButton rbnSum;
        private System.Windows.Forms.RadioButton rbnAverage;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Open;
    }
}

