namespace R08546002YCLiuAss05
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
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Input Universe");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Output Universe");
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.DeleteRule = new System.Windows.Forms.Button();
            this.btnInference = new System.Windows.Forms.Button();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.btnAddrule = new System.Windows.Forms.Button();
            this.IfThenRules = new System.Windows.Forms.TabPage();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ChosenInput = new System.Windows.Forms.TextBox();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.thetree = new System.Windows.Forms.TreeView();
            this.thegrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteRule
            // 
            this.DeleteRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteRule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRule.Location = new System.Drawing.Point(306, 6);
            this.DeleteRule.Name = "DeleteRule";
            this.DeleteRule.Size = new System.Drawing.Size(283, 33);
            this.DeleteRule.TabIndex = 9;
            this.DeleteRule.Text = "Delete Rule";
            this.DeleteRule.UseVisualStyleBackColor = false;
            this.DeleteRule.Click += new System.EventHandler(this.DeleteRule_Click);
            // 
            // btnInference
            // 
            this.btnInference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInference.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInference.Location = new System.Drawing.Point(3, 236);
            this.btnInference.Name = "btnInference";
            this.btnInference.Size = new System.Drawing.Size(287, 28);
            this.btnInference.TabIndex = 7;
            this.btnInference.Text = "Inference One Instance";
            this.btnInference.UseVisualStyleBackColor = false;
            this.btnInference.Click += new System.EventHandler(this.btnInference_Click);
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(5, 45);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.RowTemplate.Height = 27;
            this.dgvRules.Size = new System.Drawing.Size(584, 185);
            this.dgvRules.TabIndex = 5;
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            // 
            // btnAddrule
            // 
            this.btnAddrule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddrule.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddrule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddrule.Location = new System.Drawing.Point(5, 6);
            this.btnAddrule.Name = "btnAddrule";
            this.btnAddrule.Size = new System.Drawing.Size(283, 33);
            this.btnAddrule.TabIndex = 6;
            this.btnAddrule.Text = "Add Rule";
            this.btnAddrule.UseVisualStyleBackColor = false;
            this.btnAddrule.Click += new System.EventHandler(this.btnAddrule_Click);
            // 
            // IfThenRules
            // 
            this.IfThenRules.Controls.Add(this.DeleteRule);
            this.IfThenRules.Controls.Add(this.btnInference);
            this.IfThenRules.Controls.Add(this.dgvRules);
            this.IfThenRules.Controls.Add(this.dgvCondition);
            this.IfThenRules.Controls.Add(this.btnAddrule);
            this.IfThenRules.Location = new System.Drawing.Point(4, 25);
            this.IfThenRules.Name = "IfThenRules";
            this.IfThenRules.Padding = new System.Windows.Forms.Padding(3);
            this.IfThenRules.Size = new System.Drawing.Size(627, 415);
            this.IfThenRules.TabIndex = 1;
            this.IfThenRules.Text = "If-Then Rules";
            this.IfThenRules.UseVisualStyleBackColor = true;
            // 
            // dgvCondition
            // 
            this.dgvCondition.AllowUserToAddRows = false;
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(3, 268);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowHeadersWidth = 51;
            this.dgvCondition.RowTemplate.Height = 27;
            this.dgvCondition.Size = new System.Drawing.Size(583, 146);
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
            this.BinaryOperatorSelect.Location = new System.Drawing.Point(19, 28);
            this.BinaryOperatorSelect.Name = "BinaryOperatorSelect";
            this.BinaryOperatorSelect.Size = new System.Drawing.Size(560, 27);
            this.BinaryOperatorSelect.TabIndex = 13;
            // 
            // btnCreateBinary
            // 
            this.btnCreateBinary.Location = new System.Drawing.Point(19, 61);
            this.btnCreateBinary.Name = "btnCreateBinary";
            this.btnCreateBinary.Size = new System.Drawing.Size(559, 32);
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
            this.BinarySelectGroup.Location = new System.Drawing.Point(7, 214);
            this.BinarySelectGroup.Name = "BinarySelectGroup";
            this.BinarySelectGroup.Size = new System.Drawing.Size(585, 101);
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
            this.UnaryOperatorSelect.Location = new System.Drawing.Point(20, 28);
            this.UnaryOperatorSelect.Name = "UnaryOperatorSelect";
            this.UnaryOperatorSelect.Size = new System.Drawing.Size(560, 27);
            this.UnaryOperatorSelect.TabIndex = 7;
            // 
            // btnCreateUnaryOperatedFS
            // 
            this.btnCreateUnaryOperatedFS.Location = new System.Drawing.Point(20, 61);
            this.btnCreateUnaryOperatedFS.Name = "btnCreateUnaryOperatedFS";
            this.btnCreateUnaryOperatedFS.Size = new System.Drawing.Size(560, 29);
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
            this.labSecondFS.Location = new System.Drawing.Point(112, 350);
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
            this.UnarySelectGroup.Location = new System.Drawing.Point(6, 112);
            this.UnarySelectGroup.Name = "UnarySelectGroup";
            this.UnarySelectGroup.Size = new System.Drawing.Size(586, 96);
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
            this.FunctionSelection.Location = new System.Drawing.Point(20, 28);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(559, 27);
            this.FunctionSelection.TabIndex = 5;
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(20, 61);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(559, 33);
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
            this.labFirstFS.Location = new System.Drawing.Point(112, 318);
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
            this.FunctionSelectGroup.Name = "FunctionSelectGroup";
            this.FunctionSelectGroup.Size = new System.Drawing.Size(585, 100);
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
            this.FuzzySetTab.Location = new System.Drawing.Point(4, 25);
            this.FuzzySetTab.Name = "FuzzySetTab";
            this.FuzzySetTab.Padding = new System.Windows.Forms.Padding(3);
            this.FuzzySetTab.Size = new System.Drawing.Size(627, 415);
            this.FuzzySetTab.TabIndex = 0;
            this.FuzzySetTab.Text = "FuzzySet";
            this.FuzzySetTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FuzzySetTab);
            this.tabControl1.Controls.Add(this.IfThenRules);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 444);
            this.tabControl1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.splitContainer2.Size = new System.Drawing.Size(635, 766);
            this.splitContainer2.SplitterDistance = 318;
            this.splitContainer2.TabIndex = 0;
            // 
            // ChosenInput
            // 
            this.ChosenInput.BackColor = System.Drawing.Color.Silver;
            this.ChosenInput.Cursor = System.Windows.Forms.Cursors.No;
            this.ChosenInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChosenInput.Location = new System.Drawing.Point(344, 11);
            this.ChosenInput.Name = "ChosenInput";
            this.ChosenInput.Size = new System.Drawing.Size(286, 25);
            this.ChosenInput.TabIndex = 20;
            this.ChosenInput.Text = "Chosen Input";
            this.ChosenInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateUniverse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUniverse.Location = new System.Drawing.Point(4, 5);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(226, 41);
            this.btnCreateUniverse.TabIndex = 0;
            this.btnCreateUniverse.Text = "Create Universe";
            this.btnCreateUniverse.UseVisualStyleBackColor = false;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Delete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(243, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 41);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // thetree
            // 
            this.thetree.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thetree.Location = new System.Drawing.Point(3, 52);
            this.thetree.Name = "thetree";
            treeNode35.Name = "Input";
            treeNode35.Text = "Input Universe";
            treeNode36.Name = "Output";
            treeNode36.Text = "Output Universe";
            this.thetree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36});
            this.thetree.Size = new System.Drawing.Size(335, 260);
            this.thetree.TabIndex = 2;
            this.thetree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.thetree_AfterSelect);
            // 
            // thegrid
            // 
            this.thegrid.Location = new System.Drawing.Point(344, 52);
            this.thegrid.Name = "thegrid";
            this.thegrid.Size = new System.Drawing.Size(286, 260);
            this.thegrid.TabIndex = 3;
            this.thegrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.thegrid_PropertyValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.Mainchart);
            this.splitContainer1.Size = new System.Drawing.Size(1621, 766);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 11;
            // 
            // Mainchart
            // 
            this.Mainchart.BackColor = System.Drawing.Color.DarkGray;
            this.Mainchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend18.Name = "Legend1";
            this.Mainchart.Legends.Add(legend18);
            this.Mainchart.Location = new System.Drawing.Point(0, 0);
            this.Mainchart.Name = "Mainchart";
            this.Mainchart.Size = new System.Drawing.Size(982, 766);
            this.Mainchart.TabIndex = 4;
            this.Mainchart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 766);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Assignment#5";
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
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
    }
}

