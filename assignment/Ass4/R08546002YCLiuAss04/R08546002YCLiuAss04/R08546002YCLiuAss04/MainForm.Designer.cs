namespace R08546002YCLiuAss00
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.thetree = new System.Windows.Forms.TreeView();
            this.thegrid = new System.Windows.Forms.PropertyGrid();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionSelection = new System.Windows.Forms.ComboBox();
            this.btnCreateFuzzySet = new System.Windows.Forms.Button();
            this.UnaryOperatorSelect = new System.Windows.Forms.ComboBox();
            this.btnCreateUnaryOperatedFS = new System.Windows.Forms.Button();
            this.labFirstFS = new System.Windows.Forms.Label();
            this.labSecondFS = new System.Windows.Forms.Label();
            this.Tnorm = new System.Windows.Forms.CheckBox();
            this.Snorm = new System.Windows.Forms.CheckBox();
            this.BinaryTnormOperatorSelect = new System.Windows.Forms.ComboBox();
            this.BinarySnormOperatorSelect = new System.Windows.Forms.ComboBox();
            this.btnCreateTnorm = new System.Windows.Forms.Button();
            this.btnCreateSnorm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUniverse.Location = new System.Drawing.Point(12, 3);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(139, 79);
            this.btnCreateUniverse.TabIndex = 0;
            this.btnCreateUniverse.Text = "Create Universe";
            this.btnCreateUniverse.UseVisualStyleBackColor = true;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(172, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(141, 80);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // thetree
            // 
            this.thetree.Location = new System.Drawing.Point(12, 88);
            this.thetree.Name = "thetree";
            this.thetree.Size = new System.Drawing.Size(301, 317);
            this.thetree.TabIndex = 2;
            this.thetree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.thetree_AfterSelect);
            // 
            // thegrid
            // 
            this.thegrid.Location = new System.Drawing.Point(319, 8);
            this.thegrid.Name = "thegrid";
            this.thegrid.Size = new System.Drawing.Size(381, 397);
            this.thegrid.TabIndex = 3;
            this.thegrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.thegrid_PropertyValueChanged);
            // 
            // Mainchart
            // 
            this.Mainchart.BackColor = System.Drawing.Color.DarkGray;
            this.Mainchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Mainchart.Legends.Add(legend1);
            this.Mainchart.Location = new System.Drawing.Point(0, 0);
            this.Mainchart.Name = "Mainchart";
            this.Mainchart.Size = new System.Drawing.Size(1591, 454);
            this.Mainchart.TabIndex = 4;
            this.Mainchart.Text = "chart1";
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
            this.FunctionSelection.Size = new System.Drawing.Size(255, 27);
            this.FunctionSelection.TabIndex = 5;
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(20, 71);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(255, 109);
            this.btnCreateFuzzySet.TabIndex = 6;
            this.btnCreateFuzzySet.Text = "Create Fuzzy Set";
            this.btnCreateFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateFuzzySet.Click += new System.EventHandler(this.btnCreateFuzzySet_Click);
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
            this.UnaryOperatorSelect.Size = new System.Drawing.Size(255, 27);
            this.UnaryOperatorSelect.TabIndex = 7;
            // 
            // btnCreateUnaryOperatedFS
            // 
            this.btnCreateUnaryOperatedFS.Location = new System.Drawing.Point(20, 76);
            this.btnCreateUnaryOperatedFS.Name = "btnCreateUnaryOperatedFS";
            this.btnCreateUnaryOperatedFS.Size = new System.Drawing.Size(255, 117);
            this.btnCreateUnaryOperatedFS.TabIndex = 8;
            this.btnCreateUnaryOperatedFS.Text = "Create \r\nUnary Operator\r\n";
            this.btnCreateUnaryOperatedFS.UseVisualStyleBackColor = true;
            this.btnCreateUnaryOperatedFS.Click += new System.EventHandler(this.btnCreateUnaryOperatedFS_Click);
            // 
            // labFirstFS
            // 
            this.labFirstFS.AutoSize = true;
            this.labFirstFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labFirstFS.Location = new System.Drawing.Point(10, 36);
            this.labFirstFS.Name = "labFirstFS";
            this.labFirstFS.Size = new System.Drawing.Size(310, 22);
            this.labFirstFS.TabIndex = 9;
            this.labFirstFS.Text = "Click to store First Fuzzy Set";
            this.labFirstFS.TextChanged += new System.EventHandler(this.labFirstFS_TextChanged);
            this.labFirstFS.Click += new System.EventHandler(this.labFirstFS_Click);
            // 
            // labSecondFS
            // 
            this.labSecondFS.AutoSize = true;
            this.labSecondFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labSecondFS.Location = new System.Drawing.Point(10, 95);
            this.labSecondFS.Name = "labSecondFS";
            this.labSecondFS.Size = new System.Drawing.Size(320, 22);
            this.labSecondFS.TabIndex = 10;
            this.labSecondFS.Text = "Click to store Second Fuzzy Set";
            this.labSecondFS.TextChanged += new System.EventHandler(this.labSecondFS_TextChanged);
            this.labSecondFS.Click += new System.EventHandler(this.labSecondFS_Click);
            // 
            // Tnorm
            // 
            this.Tnorm.AutoSize = true;
            this.Tnorm.Location = new System.Drawing.Point(14, 144);
            this.Tnorm.Name = "Tnorm";
            this.Tnorm.Size = new System.Drawing.Size(92, 26);
            this.Tnorm.TabIndex = 11;
            this.Tnorm.Text = "T-Norm";
            this.Tnorm.UseVisualStyleBackColor = true;
            this.Tnorm.CheckedChanged += new System.EventHandler(this.Tnorm_CheckedChanged_1);
            // 
            // Snorm
            // 
            this.Snorm.AutoSize = true;
            this.Snorm.Location = new System.Drawing.Point(289, 144);
            this.Snorm.Name = "Snorm";
            this.Snorm.Size = new System.Drawing.Size(92, 26);
            this.Snorm.TabIndex = 12;
            this.Snorm.Text = "S-Norm";
            this.Snorm.UseVisualStyleBackColor = true;
            this.Snorm.CheckedChanged += new System.EventHandler(this.Snorm_CheckedChanged_1);
            // 
            // BinaryTnormOperatorSelect
            // 
            this.BinaryTnormOperatorSelect.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryTnormOperatorSelect.FormattingEnabled = true;
            this.BinaryTnormOperatorSelect.Items.AddRange(new object[] {
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
            "Yager Tnorm"});
            this.BinaryTnormOperatorSelect.Location = new System.Drawing.Point(14, 189);
            this.BinaryTnormOperatorSelect.Name = "BinaryTnormOperatorSelect";
            this.BinaryTnormOperatorSelect.Size = new System.Drawing.Size(204, 27);
            this.BinaryTnormOperatorSelect.TabIndex = 13;
            // 
            // BinarySnormOperatorSelect
            // 
            this.BinarySnormOperatorSelect.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarySnormOperatorSelect.FormattingEnabled = true;
            this.BinarySnormOperatorSelect.Items.AddRange(new object[] {
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
            this.BinarySnormOperatorSelect.Location = new System.Drawing.Point(289, 189);
            this.BinarySnormOperatorSelect.Name = "BinarySnormOperatorSelect";
            this.BinarySnormOperatorSelect.Size = new System.Drawing.Size(204, 27);
            this.BinarySnormOperatorSelect.TabIndex = 14;
            // 
            // btnCreateTnorm
            // 
            this.btnCreateTnorm.Location = new System.Drawing.Point(14, 254);
            this.btnCreateTnorm.Name = "btnCreateTnorm";
            this.btnCreateTnorm.Size = new System.Drawing.Size(204, 140);
            this.btnCreateTnorm.TabIndex = 15;
            this.btnCreateTnorm.Text = "Create T-norm Binary Operator";
            this.btnCreateTnorm.UseVisualStyleBackColor = true;
            this.btnCreateTnorm.Click += new System.EventHandler(this.btnCreateTnorm_Click);
            // 
            // btnCreateSnorm
            // 
            this.btnCreateSnorm.Location = new System.Drawing.Point(289, 254);
            this.btnCreateSnorm.Name = "btnCreateSnorm";
            this.btnCreateSnorm.Size = new System.Drawing.Size(204, 140);
            this.btnCreateSnorm.TabIndex = 16;
            this.btnCreateSnorm.Text = "Create S-norm Binary Operator";
            this.btnCreateSnorm.UseVisualStyleBackColor = true;
            this.btnCreateSnorm.Click += new System.EventHandler(this.btnCreateSnorm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FunctionSelection);
            this.groupBox1.Controls.Add(this.btnCreateFuzzySet);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(706, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnaryOperatorSelect);
            this.groupBox2.Controls.Add(this.btnCreateUnaryOperatedFS);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(706, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 217);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Unary OP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labFirstFS);
            this.groupBox3.Controls.Add(this.labSecondFS);
            this.groupBox3.Controls.Add(this.Tnorm);
            this.groupBox3.Controls.Add(this.btnCreateSnorm);
            this.groupBox3.Controls.Add(this.BinaryTnormOperatorSelect);
            this.groupBox3.Controls.Add(this.BinarySnormOperatorSelect);
            this.groupBox3.Controls.Add(this.btnCreateTnorm);
            this.groupBox3.Controls.Add(this.Snorm);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1038, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 418);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Binary OP";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateUniverse);
            this.splitContainer1.Panel1.Controls.Add(this.thegrid);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.thetree);
            this.splitContainer1.Panel1.Controls.Add(this.Delete);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Mainchart);
            this.splitContainer1.Size = new System.Drawing.Size(1591, 896);
            this.splitContainer1.SplitterDistance = 438;
            this.splitContainer1.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 896);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Assignment#4";
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUniverse;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TreeView thetree;
        private System.Windows.Forms.PropertyGrid thegrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart Mainchart;
        private System.Windows.Forms.ComboBox FunctionSelection;
        private System.Windows.Forms.Button btnCreateFuzzySet;
        private System.Windows.Forms.ComboBox UnaryOperatorSelect;
        private System.Windows.Forms.Button btnCreateUnaryOperatedFS;
        private System.Windows.Forms.Label labFirstFS;
        private System.Windows.Forms.Label labSecondFS;
        private System.Windows.Forms.CheckBox Tnorm;
        private System.Windows.Forms.CheckBox Snorm;
        private System.Windows.Forms.ComboBox BinaryTnormOperatorSelect;
        private System.Windows.Forms.ComboBox BinarySnormOperatorSelect;
        private System.Windows.Forms.Button btnCreateTnorm;
        private System.Windows.Forms.Button btnCreateSnorm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

