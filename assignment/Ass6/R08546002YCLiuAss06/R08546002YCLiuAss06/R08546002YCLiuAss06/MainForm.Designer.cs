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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input Universe");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Output Universe");
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeleteRule = new System.Windows.Forms.Button();
            this.btnInference = new System.Windows.Forms.Button();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.btnAddrule = new System.Windows.Forms.Button();
            this.IfThenRules = new System.Windows.Forms.TabPage();
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ppgSystem = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdoMamdani = new System.Windows.Forms.RadioButton();
            this.ChosenInput = new System.Windows.Forms.TextBox();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.thetree = new System.Windows.Forms.TreeView();
            this.thegrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.ResolutionValue = new System.Windows.Forms.NumericUpDown();
            this.rbnScale = new System.Windows.Forms.RadioButton();
            this.rbnCut = new System.Windows.Forms.RadioButton();
            this.btnCrispCrispOutInferencing = new System.Windows.Forms.Button();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.threeDplot = new Steema.TeeChart.TChart();
            this.plotcontrol = new Steema.TeeChart.Styles.Surface();
            this.OutputEquations = new System.Windows.Forms.TabPage();
            this.Resolution = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEquations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.IfThenRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.BinarySelectGroup.SuspendLayout();
            this.UnarySelectGroup.SuspendLayout();
            this.FunctionSelectGroup.SuspendLayout();
            this.FuzzySetTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            this.OutputEquations.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteRule
            // 
            this.DeleteRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteRule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRule.Location = new System.Drawing.Point(218, 5);
            this.DeleteRule.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRule.Name = "DeleteRule";
            this.DeleteRule.Size = new System.Drawing.Size(190, 26);
            this.DeleteRule.TabIndex = 9;
            this.DeleteRule.Text = "Delete Rule";
            this.DeleteRule.UseVisualStyleBackColor = false;
            this.DeleteRule.Click += new System.EventHandler(this.DeleteRule_Click);
            // 
            // btnInference
            // 
            this.btnInference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInference.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInference.Location = new System.Drawing.Point(4, 171);
            this.btnInference.Margin = new System.Windows.Forms.Padding(2);
            this.btnInference.Name = "btnInference";
            this.btnInference.Size = new System.Drawing.Size(152, 31);
            this.btnInference.TabIndex = 7;
            this.btnInference.Text = "Inference One Instance";
            this.btnInference.UseVisualStyleBackColor = false;
            this.btnInference.Click += new System.EventHandler(this.btnInference_Click);
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(4, 34);
            this.dgvRules.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.RowTemplate.Height = 27;
            this.dgvRules.Size = new System.Drawing.Size(404, 132);
            this.dgvRules.TabIndex = 5;
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            // 
            // btnAddrule
            // 
            this.btnAddrule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddrule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddrule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddrule.Location = new System.Drawing.Point(4, 5);
            this.btnAddrule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddrule.Name = "btnAddrule";
            this.btnAddrule.Size = new System.Drawing.Size(185, 26);
            this.btnAddrule.TabIndex = 6;
            this.btnAddrule.Text = "Add Rule";
            this.btnAddrule.UseVisualStyleBackColor = false;
            this.btnAddrule.Click += new System.EventHandler(this.btnAddrule_Click);
            // 
            // IfThenRules
            // 
            this.IfThenRules.Controls.Add(this.DeleteGrayArea);
            this.IfThenRules.Controls.Add(this.DeleteRule);
            this.IfThenRules.Controls.Add(this.btnInference);
            this.IfThenRules.Controls.Add(this.dgvRules);
            this.IfThenRules.Controls.Add(this.dgvCondition);
            this.IfThenRules.Controls.Add(this.btnAddrule);
            this.IfThenRules.Location = new System.Drawing.Point(4, 29);
            this.IfThenRules.Margin = new System.Windows.Forms.Padding(2);
            this.IfThenRules.Name = "IfThenRules";
            this.IfThenRules.Padding = new System.Windows.Forms.Padding(2);
            this.IfThenRules.Size = new System.Drawing.Size(409, 538);
            this.IfThenRules.TabIndex = 1;
            this.IfThenRules.Text = "If-Then Rules";
            this.IfThenRules.UseVisualStyleBackColor = true;
            // 
            // DeleteGrayArea
            // 
            this.DeleteGrayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteGrayArea.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGrayArea.Location = new System.Drawing.Point(160, 171);
            this.DeleteGrayArea.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteGrayArea.Name = "DeleteGrayArea";
            this.DeleteGrayArea.Size = new System.Drawing.Size(173, 31);
            this.DeleteGrayArea.TabIndex = 10;
            this.DeleteGrayArea.Text = "Delete GrayArea";
            this.DeleteGrayArea.UseVisualStyleBackColor = false;
            this.DeleteGrayArea.Click += new System.EventHandler(this.DeleteGrayArea_Click);
            // 
            // dgvCondition
            // 
            this.dgvCondition.AllowUserToAddRows = false;
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(4, 203);
            this.dgvCondition.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowHeadersWidth = 51;
            this.dgvCondition.RowTemplate.Height = 27;
            this.dgvCondition.Size = new System.Drawing.Size(329, 138);
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
            this.BinaryOperatorSelect.Location = new System.Drawing.Point(4, 22);
            this.BinaryOperatorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.BinaryOperatorSelect.Name = "BinaryOperatorSelect";
            this.BinaryOperatorSelect.Size = new System.Drawing.Size(394, 27);
            this.BinaryOperatorSelect.TabIndex = 13;
            // 
            // btnCreateBinary
            // 
            this.btnCreateBinary.Location = new System.Drawing.Point(4, 49);
            this.btnCreateBinary.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateBinary.Name = "btnCreateBinary";
            this.btnCreateBinary.Size = new System.Drawing.Size(392, 26);
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
            this.BinarySelectGroup.Location = new System.Drawing.Point(7, 171);
            this.BinarySelectGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BinarySelectGroup.Name = "BinarySelectGroup";
            this.BinarySelectGroup.Padding = new System.Windows.Forms.Padding(2);
            this.BinarySelectGroup.Size = new System.Drawing.Size(398, 81);
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
            this.UnaryOperatorSelect.Location = new System.Drawing.Point(5, 22);
            this.UnaryOperatorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.UnaryOperatorSelect.Name = "UnaryOperatorSelect";
            this.UnaryOperatorSelect.Size = new System.Drawing.Size(394, 27);
            this.UnaryOperatorSelect.TabIndex = 7;
            // 
            // btnCreateUnaryOperatedFS
            // 
            this.btnCreateUnaryOperatedFS.Location = new System.Drawing.Point(5, 49);
            this.btnCreateUnaryOperatedFS.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUnaryOperatedFS.Name = "btnCreateUnaryOperatedFS";
            this.btnCreateUnaryOperatedFS.Size = new System.Drawing.Size(393, 28);
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
            this.labSecondFS.Location = new System.Drawing.Point(7, 289);
            this.labSecondFS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.UnarySelectGroup.Location = new System.Drawing.Point(4, 90);
            this.UnarySelectGroup.Margin = new System.Windows.Forms.Padding(2);
            this.UnarySelectGroup.Name = "UnarySelectGroup";
            this.UnarySelectGroup.Padding = new System.Windows.Forms.Padding(2);
            this.UnarySelectGroup.Size = new System.Drawing.Size(398, 77);
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
            "Two-side Gaussian Function",
            "Two-side Pi Function"});
            this.FunctionSelection.Location = new System.Drawing.Point(4, 22);
            this.FunctionSelection.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(394, 27);
            this.FunctionSelection.TabIndex = 5;
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(4, 49);
            this.btnCreateFuzzySet.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(393, 26);
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
            this.labFirstFS.Location = new System.Drawing.Point(7, 261);
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
            this.FunctionSelectGroup.Location = new System.Drawing.Point(5, 5);
            this.FunctionSelectGroup.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionSelectGroup.Name = "FunctionSelectGroup";
            this.FunctionSelectGroup.Padding = new System.Windows.Forms.Padding(2);
            this.FunctionSelectGroup.Size = new System.Drawing.Size(398, 80);
            this.FunctionSelectGroup.TabIndex = 17;
            this.FunctionSelectGroup.TabStop = false;
            this.FunctionSelectGroup.Text = "Select Function";
            // 
            // FuzzySetTab
            // 
            this.FuzzySetTab.Controls.Add(this.labFirstFS);
            this.FuzzySetTab.Controls.Add(this.btnOpen);
            this.FuzzySetTab.Controls.Add(this.btnSave);
            this.FuzzySetTab.Controls.Add(this.ppgSystem);
            this.FuzzySetTab.Controls.Add(this.FunctionSelectGroup);
            this.FuzzySetTab.Controls.Add(this.labSecondFS);
            this.FuzzySetTab.Controls.Add(this.UnarySelectGroup);
            this.FuzzySetTab.Controls.Add(this.BinarySelectGroup);
            this.FuzzySetTab.Location = new System.Drawing.Point(4, 29);
            this.FuzzySetTab.Margin = new System.Windows.Forms.Padding(2);
            this.FuzzySetTab.Name = "FuzzySetTab";
            this.FuzzySetTab.Padding = new System.Windows.Forms.Padding(2);
            this.FuzzySetTab.Size = new System.Drawing.Size(409, 538);
            this.FuzzySetTab.TabIndex = 0;
            this.FuzzySetTab.Text = "FuzzySet";
            this.FuzzySetTab.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(217, 314);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 37);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 314);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ppgSystem
            // 
            this.ppgSystem.Location = new System.Drawing.Point(362, 261);
            this.ppgSystem.Margin = new System.Windows.Forms.Padding(2);
            this.ppgSystem.Name = "ppgSystem";
            this.ppgSystem.Size = new System.Drawing.Size(40, 51);
            this.ppgSystem.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.FuzzySetTab);
            this.tabControl1.Controls.Add(this.IfThenRules);
            this.tabControl1.Controls.Add(this.OutputEquations);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 571);
            this.tabControl1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer2.Panel1.Controls.Add(this.radioButton2);
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
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(420, 705);
            this.splitContainer2.SplitterDistance = 316;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(206, 11);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 26);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.Text = "Tsukamoto";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(111, 11);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 26);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "Sugeno";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdoMamdani
            // 
            this.rdoMamdani.AutoSize = true;
            this.rdoMamdani.Checked = true;
            this.rdoMamdani.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMamdani.Location = new System.Drawing.Point(5, 11);
            this.rdoMamdani.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMamdani.Name = "rdoMamdani";
            this.rdoMamdani.Size = new System.Drawing.Size(101, 26);
            this.rdoMamdani.TabIndex = 21;
            this.rdoMamdani.TabStop = true;
            this.rdoMamdani.Text = "Mamdani";
            this.rdoMamdani.UseVisualStyleBackColor = true;
            this.rdoMamdani.Click += new System.EventHandler(this.rdoMamdani_Click);
            // 
            // ChosenInput
            // 
            this.ChosenInput.BackColor = System.Drawing.Color.Silver;
            this.ChosenInput.Cursor = System.Windows.Forms.Cursors.No;
            this.ChosenInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChosenInput.Location = new System.Drawing.Point(205, 39);
            this.ChosenInput.Margin = new System.Windows.Forms.Padding(2);
            this.ChosenInput.Name = "ChosenInput";
            this.ChosenInput.Size = new System.Drawing.Size(210, 25);
            this.ChosenInput.TabIndex = 20;
            this.ChosenInput.Text = "Chosen Input";
            this.ChosenInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateUniverse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUniverse.Location = new System.Drawing.Point(2, 39);
            this.btnCreateUniverse.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(135, 39);
            this.btnCreateUniverse.TabIndex = 0;
            this.btnCreateUniverse.Text = "Create \r\nUniverse";
            this.btnCreateUniverse.UseVisualStyleBackColor = false;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Delete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(142, 39);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(59, 39);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // thetree
            // 
            this.thetree.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thetree.Location = new System.Drawing.Point(2, 80);
            this.thetree.Margin = new System.Windows.Forms.Padding(2);
            this.thetree.Name = "thetree";
            treeNode1.Name = "Input";
            treeNode1.Text = "Input Universe";
            treeNode2.Name = "Output";
            treeNode2.Text = "Output Universe";
            this.thetree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.thetree.Size = new System.Drawing.Size(200, 234);
            this.thetree.TabIndex = 2;
            this.thetree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.thetree_AfterSelect);
            // 
            // thegrid
            // 
            this.thegrid.Location = new System.Drawing.Point(204, 64);
            this.thegrid.Margin = new System.Windows.Forms.Padding(2);
            this.thegrid.Name = "thegrid";
            this.thegrid.Size = new System.Drawing.Size(210, 250);
            this.thegrid.TabIndex = 3;
            this.thegrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.thegrid_PropertyValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.threeDplot);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.rbnScale);
            this.splitContainer1.Panel2.Controls.Add(this.rbnCut);
            this.splitContainer1.Panel2.Controls.Add(this.btnCrispCrispOutInferencing);
            this.splitContainer1.Panel2.Controls.Add(this.Mainchart);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 705);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Resolution);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.ResolutionValue);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.chartController1);
            this.panel1.Location = new System.Drawing.Point(549, 427);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 274);
            this.panel1.TabIndex = 10;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(16, 185);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(64, 27);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "LOM";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(16, 154);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(64, 27);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "SOM";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(16, 123);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(64, 27);
            this.radioButton5.TabIndex = 29;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "MOM";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(16, 92);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 27);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "BOA";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(16, 67);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 27);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "COA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.threeDplot;
            this.chartController1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 249);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(150, 25);
            this.chartController1.TabIndex = 26;
            this.chartController1.Text = "chartController1";
            // 
            // ResolutionValue
            // 
            this.ResolutionValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionValue.Location = new System.Drawing.Point(16, 32);
            this.ResolutionValue.Margin = new System.Windows.Forms.Padding(2);
            this.ResolutionValue.Name = "ResolutionValue";
            this.ResolutionValue.Size = new System.Drawing.Size(125, 31);
            this.ResolutionValue.TabIndex = 9;
            this.ResolutionValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // rbnScale
            // 
            this.rbnScale.AutoSize = true;
            this.rbnScale.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnScale.Location = new System.Drawing.Point(11, 517);
            this.rbnScale.Margin = new System.Windows.Forms.Padding(2);
            this.rbnScale.Name = "rbnScale";
            this.rbnScale.Size = new System.Drawing.Size(86, 27);
            this.rbnScale.TabIndex = 8;
            this.rbnScale.TabStop = true;
            this.rbnScale.Text = "Scale";
            this.rbnScale.UseVisualStyleBackColor = true;
            // 
            // rbnCut
            // 
            this.rbnCut.AutoSize = true;
            this.rbnCut.Checked = true;
            this.rbnCut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCut.Location = new System.Drawing.Point(11, 486);
            this.rbnCut.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnCrispCrispOutInferencing.Location = new System.Drawing.Point(2, 619);
            this.btnCrispCrispOutInferencing.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrispCrispOutInferencing.Name = "btnCrispCrispOutInferencing";
            this.btnCrispCrispOutInferencing.Size = new System.Drawing.Size(92, 82);
            this.btnCrispCrispOutInferencing.TabIndex = 5;
            this.btnCrispCrispOutInferencing.Text = "All Crisp Values Inferencing";
            this.btnCrispCrispOutInferencing.UseVisualStyleBackColor = true;
            this.btnCrispCrispOutInferencing.Click += new System.EventHandler(this.btnCrispCrispOutInferencing_Click);
            // 
            // Mainchart
            // 
            this.Mainchart.BackColor = System.Drawing.Color.Coral;
            legend1.Name = "Legend1";
            this.Mainchart.Legends.Add(legend1);
            this.Mainchart.Location = new System.Drawing.Point(2, 2);
            this.Mainchart.Margin = new System.Windows.Forms.Padding(2);
            this.Mainchart.Name = "Mainchart";
            this.Mainchart.Size = new System.Drawing.Size(695, 421);
            this.Mainchart.TabIndex = 4;
            this.Mainchart.Text = "chart1";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "txt";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "txt";
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
            this.threeDplot.Location = new System.Drawing.Point(99, 428);
            this.threeDplot.Name = "threeDplot";
            this.threeDplot.Series.Add(this.plotcontrol);
            this.threeDplot.Size = new System.Drawing.Size(445, 273);
            this.threeDplot.TabIndex = 11;
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
            // OutputEquations
            // 
            this.OutputEquations.Controls.Add(this.AddEquations);
            this.OutputEquations.Controls.Add(this.label1);
            this.OutputEquations.Controls.Add(this.listBox1);
            this.OutputEquations.Location = new System.Drawing.Point(4, 29);
            this.OutputEquations.Name = "OutputEquations";
            this.OutputEquations.Size = new System.Drawing.Size(409, 538);
            this.OutputEquations.TabIndex = 2;
            this.OutputEquations.Text = "Output equations";
            this.OutputEquations.UseVisualStyleBackColor = true;
            // 
            // Resolution
            // 
            this.Resolution.AutoSize = true;
            this.Resolution.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolution.Location = new System.Drawing.Point(12, 7);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(131, 23);
            this.Resolution.TabIndex = 32;
            this.Resolution.Text = "Resolutions";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "0 : Y = 0.1 X + 6.4",
            "1 : Y = - 0.5 X + 4",
            "2 : Y = X - 2",
            "3 : Z = - X + Y + 1",
            "4 : Z = - Y + 3",
            "5 : Z = - X + 3",
            "6 : Z = X + Y + 2"});
            this.listBox1.Location = new System.Drawing.Point(11, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 165);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sugeno Output";
            // 
            // AddEquations
            // 
            this.AddEquations.Location = new System.Drawing.Point(11, 218);
            this.AddEquations.Name = "AddEquations";
            this.AddEquations.Size = new System.Drawing.Size(170, 66);
            this.AddEquations.TabIndex = 2;
            this.AddEquations.Text = "Add Equations";
            this.AddEquations.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 705);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Assignment#6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.IfThenRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.BinarySelectGroup.ResumeLayout(false);
            this.UnarySelectGroup.ResumeLayout(false);
            this.FunctionSelectGroup.ResumeLayout(false);
            this.FuzzySetTab.ResumeLayout(false);
            this.FuzzySetTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResolutionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
            this.OutputEquations.ResumeLayout(false);
            this.OutputEquations.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox ChosenInput;
        private System.Windows.Forms.Button btnCreateUniverse;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TreeView thetree;
        private System.Windows.Forms.PropertyGrid thegrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Mainchart;
        private System.Windows.Forms.RadioButton rdoMamdani;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnCrispCrispOutInferencing;
        private System.Windows.Forms.PropertyGrid ppgSystem;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button DeleteGrayArea;
        private System.Windows.Forms.RadioButton rbnScale;
        private System.Windows.Forms.RadioButton rbnCut;
        private System.Windows.Forms.NumericUpDown ResolutionValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.TChart threeDplot;
        private Steema.TeeChart.Styles.Surface plotcontrol;
        private System.Windows.Forms.TabPage OutputEquations;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.Button AddEquations;
        private System.Windows.Forms.Label label1;
    }
}

