using System;

namespace R08546002YCLiuAss02
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.creatFunction = new System.Windows.Forms.Button();
            this.labPar1 = new System.Windows.Forms.Label();
            this.nudPar1 = new System.Windows.Forms.NumericUpDown();
            this.labPar2 = new System.Windows.Forms.Label();
            this.labPar3 = new System.Windows.Forms.Label();
            this.nudPar2 = new System.Windows.Forms.NumericUpDown();
            this.nudPar3 = new System.Windows.Forms.NumericUpDown();
            this.FunctionSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Xlimit_max = new System.Windows.Forms.NumericUpDown();
            this.Xlimit_min = new System.Windows.Forms.NumericUpDown();
            this.tFormula = new System.Windows.Forms.PictureBox();
            this.bFormula = new System.Windows.Forms.PictureBox();
            this.gFormula = new System.Windows.Forms.PictureBox();
            this.sgFormula = new System.Windows.Forms.PictureBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.TriangularNote = new System.Windows.Forms.Label();
            this.BellNote = new System.Windows.Forms.Label();
            this.GaussianNote = new System.Windows.Forms.Label();
            this.SigmoidNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xlimit_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xlimit_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // theChart
            // 
            this.theChart.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "x_axis range";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Values";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Bisque;
            chartArea1.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Legend name";
            this.theChart.Legends.Add(legend1);
            this.theChart.Location = new System.Drawing.Point(2, 265);
            this.theChart.Name = "theChart";
            this.theChart.Size = new System.Drawing.Size(749, 413);
            this.theChart.TabIndex = 2;
            this.theChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Function Plot";
            title1.Text = "Function Plot";
            this.theChart.Titles.Add(title1);
            this.theChart.UseWaitCursor = true;
            this.theChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // creatFunction
            // 
            this.creatFunction.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatFunction.Location = new System.Drawing.Point(546, 143);
            this.creatFunction.Name = "creatFunction";
            this.creatFunction.Size = new System.Drawing.Size(205, 55);
            this.creatFunction.TabIndex = 3;
            this.creatFunction.Text = "Create Function";
            this.creatFunction.UseVisualStyleBackColor = true;
            this.creatFunction.Click += new System.EventHandler(this.CreatButtonClicked);
            // 
            // labPar1
            // 
            this.labPar1.AutoSize = true;
            this.labPar1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPar1.Location = new System.Drawing.Point(291, 48);
            this.labPar1.Name = "labPar1";
            this.labPar1.Size = new System.Drawing.Size(99, 20);
            this.labPar1.TabIndex = 4;
            this.labPar1.Text = "parameter1";
            this.labPar1.Click += new System.EventHandler(this.nudPar1_Click);
            // 
            // nudPar1
            // 
            this.nudPar1.DecimalPlaces = 2;
            this.nudPar1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPar1.Location = new System.Drawing.Point(400, 46);
            this.nudPar1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPar1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPar1.Name = "nudPar1";
            this.nudPar1.Size = new System.Drawing.Size(120, 25);
            this.nudPar1.TabIndex = 5;
            this.nudPar1.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudPar1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labPar2
            // 
            this.labPar2.AutoSize = true;
            this.labPar2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPar2.Location = new System.Drawing.Point(291, 95);
            this.labPar2.Name = "labPar2";
            this.labPar2.Size = new System.Drawing.Size(99, 20);
            this.labPar2.TabIndex = 6;
            this.labPar2.Text = "parameter2";
            this.labPar2.Click += new System.EventHandler(this.nudPar2_Click);
            // 
            // labPar3
            // 
            this.labPar3.AutoSize = true;
            this.labPar3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPar3.Location = new System.Drawing.Point(291, 142);
            this.labPar3.Name = "labPar3";
            this.labPar3.Size = new System.Drawing.Size(99, 20);
            this.labPar3.TabIndex = 7;
            this.labPar3.Text = "parameter3";
            this.labPar3.Click += new System.EventHandler(this.nudPar3_Click);
            // 
            // nudPar2
            // 
            this.nudPar2.DecimalPlaces = 2;
            this.nudPar2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPar2.Location = new System.Drawing.Point(400, 93);
            this.nudPar2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPar2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPar2.Name = "nudPar2";
            this.nudPar2.Size = new System.Drawing.Size(120, 25);
            this.nudPar2.TabIndex = 8;
            this.nudPar2.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudPar2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudPar3
            // 
            this.nudPar3.DecimalPlaces = 2;
            this.nudPar3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPar3.Location = new System.Drawing.Point(400, 140);
            this.nudPar3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPar3.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPar3.Name = "nudPar3";
            this.nudPar3.Size = new System.Drawing.Size(120, 25);
            this.nudPar3.TabIndex = 9;
            this.nudPar3.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            // 
            // FunctionSelection
            // 
            this.FunctionSelection.FormattingEnabled = true;
            this.FunctionSelection.Items.AddRange(new object[] {
            "Triangular Function",
            "Bell Function",
            "Gaussian Function",
            "Sigmoidal Function"});
            this.FunctionSelection.Location = new System.Drawing.Point(25, 55);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(170, 26);
            this.FunctionSelection.TabIndex = 10;
            this.FunctionSelection.SelectedIndexChanged += new System.EventHandler(this.FunctionSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Function ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(291, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Function Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(291, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "X Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "To :";
            // 
            // Xlimit_max
            // 
            this.Xlimit_max.Location = new System.Drawing.Point(400, 230);
            this.Xlimit_max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Xlimit_max.Name = "Xlimit_max";
            this.Xlimit_max.Size = new System.Drawing.Size(120, 25);
            this.Xlimit_max.TabIndex = 17;
            this.Xlimit_max.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Xlimit_min
            // 
            this.Xlimit_min.Location = new System.Drawing.Point(400, 201);
            this.Xlimit_min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Xlimit_min.Name = "Xlimit_min";
            this.Xlimit_min.Size = new System.Drawing.Size(120, 25);
            this.Xlimit_min.TabIndex = 16;
            this.Xlimit_min.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.Xlimit_min.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // tFormula
            // 
            this.tFormula.BackColor = System.Drawing.Color.White;
            this.tFormula.Image = ((System.Drawing.Image)(resources.GetObject("tFormula.Image")));
            this.tFormula.Location = new System.Drawing.Point(12, 95);
            this.tFormula.Name = "tFormula";
            this.tFormula.Size = new System.Drawing.Size(250, 160);
            this.tFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tFormula.TabIndex = 18;
            this.tFormula.TabStop = false;
            this.tFormula.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bFormula
            // 
            this.bFormula.Image = ((System.Drawing.Image)(resources.GetObject("bFormula.Image")));
            this.bFormula.Location = new System.Drawing.Point(12, 95);
            this.bFormula.Name = "bFormula";
            this.bFormula.Size = new System.Drawing.Size(250, 162);
            this.bFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bFormula.TabIndex = 19;
            this.bFormula.TabStop = false;
            // 
            // gFormula
            // 
            this.gFormula.Image = ((System.Drawing.Image)(resources.GetObject("gFormula.Image")));
            this.gFormula.Location = new System.Drawing.Point(12, 95);
            this.gFormula.Name = "gFormula";
            this.gFormula.Size = new System.Drawing.Size(250, 162);
            this.gFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gFormula.TabIndex = 20;
            this.gFormula.TabStop = false;
            // 
            // sgFormula
            // 
            this.sgFormula.Image = ((System.Drawing.Image)(resources.GetObject("sgFormula.Image")));
            this.sgFormula.Location = new System.Drawing.Point(12, 95);
            this.sgFormula.Name = "sgFormula";
            this.sgFormula.Size = new System.Drawing.Size(250, 164);
            this.sgFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sgFormula.TabIndex = 21;
            this.sgFormula.TabStop = false;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(546, 203);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(205, 56);
            this.Refresh.TabIndex = 22;
            this.Refresh.Text = "Initialize Chart";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // TriangularNote
            // 
            this.TriangularNote.AutoSize = true;
            this.TriangularNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TriangularNote.Location = new System.Drawing.Point(543, 14);
            this.TriangularNote.Name = "TriangularNote";
            this.TriangularNote.Size = new System.Drawing.Size(208, 108);
            this.TriangularNote.TabIndex = 23;
            this.TriangularNote.Text = "**Note**\r\nLeftPoint is symbol \"a\".\r\nPeakPoint is symbol \"b\".\r\nRightPoint is symbo" +
    "l \"c\".\r\n\r\nX_min = -100, X_max = 100";
            // 
            // BellNote
            // 
            this.BellNote.AutoSize = true;
            this.BellNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BellNote.Location = new System.Drawing.Point(543, 14);
            this.BellNote.Name = "BellNote";
            this.BellNote.Size = new System.Drawing.Size(208, 108);
            this.BellNote.TabIndex = 24;
            this.BellNote.Text = "**Note**\r\nWidth is symbol \"a\".\r\nSlope is symbol \"b\".\r\nCenter is symbol \"c\".\r\n\r\nX_" +
    "min = -100, X_max = 100\r\n";
            // 
            // GaussianNote
            // 
            this.GaussianNote.AutoSize = true;
            this.GaussianNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GaussianNote.Location = new System.Drawing.Point(541, 14);
            this.GaussianNote.Name = "GaussianNote";
            this.GaussianNote.Size = new System.Drawing.Size(208, 90);
            this.GaussianNote.TabIndex = 25;
            this.GaussianNote.Text = "**Note**\r\nCenter is symbol \"c\".\r\nStd is symbol \"sigma\".\r\n\r\nX_min = -100, X_max = " +
    "100\r\n";
            // 
            // SigmoidNote
            // 
            this.SigmoidNote.AutoSize = true;
            this.SigmoidNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SigmoidNote.Location = new System.Drawing.Point(543, 14);
            this.SigmoidNote.Name = "SigmoidNote";
            this.SigmoidNote.Size = new System.Drawing.Size(208, 108);
            this.SigmoidNote.TabIndex = 26;
            this.SigmoidNote.Text = "**Note**\r\nSlope is symbol \"a\".\r\nCenter is symbol \"c\".\r\n\r\nX_min = -100, X_max = 10" +
    "0\r\n\r\n";
            this.SigmoidNote.Click += new System.EventHandler(this.SigmoidNote_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 690);
            this.Controls.Add(this.SigmoidNote);
            this.Controls.Add(this.GaussianNote);
            this.Controls.Add(this.BellNote);
            this.Controls.Add(this.TriangularNote);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.sgFormula);
            this.Controls.Add(this.gFormula);
            this.Controls.Add(this.bFormula);
            this.Controls.Add(this.tFormula);
            this.Controls.Add(this.Xlimit_max);
            this.Controls.Add(this.Xlimit_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionSelection);
            this.Controls.Add(this.nudPar3);
            this.Controls.Add(this.nudPar2);
            this.Controls.Add(this.labPar3);
            this.Controls.Add(this.labPar2);
            this.Controls.Add(this.nudPar1);
            this.Controls.Add(this.labPar1);
            this.Controls.Add(this.creatFunction);
            this.Controls.Add(this.theChart);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Soft Computing Methods and Applications with C#_Assignment2";
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xlimit_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xlimit_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.Button creatFunction;
        private System.Windows.Forms.Label labPar1;
        private System.Windows.Forms.NumericUpDown nudPar1;
        private System.Windows.Forms.Label labPar2;
        private System.Windows.Forms.Label labPar3;
        private System.Windows.Forms.NumericUpDown nudPar2;
        private System.Windows.Forms.NumericUpDown nudPar3;
        private System.Windows.Forms.ComboBox FunctionSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Xlimit_max;
        private System.Windows.Forms.NumericUpDown Xlimit_min;
        private System.Windows.Forms.PictureBox tFormula;
        private System.Windows.Forms.PictureBox bFormula;
        private System.Windows.Forms.PictureBox gFormula;
        private System.Windows.Forms.PictureBox sgFormula;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label TriangularNote;
        private System.Windows.Forms.Label BellNote;
        private System.Windows.Forms.Label GaussianNote;
        private System.Windows.Forms.Label SigmoidNote;
    }
}

