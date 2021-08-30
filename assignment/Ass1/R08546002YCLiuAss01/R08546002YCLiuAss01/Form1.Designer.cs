namespace R08546002YCLiuAss01
{
    partial class Assignment1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textCenter1 = new System.Windows.Forms.TextBox();
            this.gFunctionButtom = new System.Windows.Forms.Button();
            this.gFunction_C = new System.Windows.Forms.Label();
            this.tFunction_Sigma = new System.Windows.Forms.Label();
            this.textCenter2 = new System.Windows.Forms.TextBox();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textLeft2 = new System.Windows.Forms.TextBox();
            this.tFunction_B = new System.Windows.Forms.Label();
            this.tFunction_A = new System.Windows.Forms.Label();
            this.textLeft1 = new System.Windows.Forms.TextBox();
            this.textLeft3 = new System.Windows.Forms.TextBox();
            this.tFunction_C = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRight3 = new System.Windows.Forms.TextBox();
            this.bFunction_C = new System.Windows.Forms.Label();
            this.textRight2 = new System.Windows.Forms.TextBox();
            this.bFunction_B = new System.Windows.Forms.Label();
            this.bFunction_A = new System.Windows.Forms.Label();
            this.textRight1 = new System.Windows.Forms.TextBox();
            this.tFunctionButtom = new System.Windows.Forms.Button();
            this.bFunctionButtom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.SuspendLayout();
            // 
            // textCenter1
            // 
            this.textCenter1.Location = new System.Drawing.Point(373, 48);
            this.textCenter1.Name = "textCenter1";
            this.textCenter1.Size = new System.Drawing.Size(100, 25);
            this.textCenter1.TabIndex = 1;
            this.textCenter1.Text = "5.0";
            this.textCenter1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gFunctionButtom
            // 
            this.gFunctionButtom.ForeColor = System.Drawing.Color.Red;
            this.gFunctionButtom.Location = new System.Drawing.Point(316, 164);
            this.gFunctionButtom.Name = "gFunctionButtom";
            this.gFunctionButtom.Size = new System.Drawing.Size(157, 32);
            this.gFunctionButtom.TabIndex = 2;
            this.gFunctionButtom.Text = "Draw g Function";
            this.gFunctionButtom.UseVisualStyleBackColor = true;
            this.gFunctionButtom.Click += new System.EventHandler(this.gFunctionButtom_Click);
            // 
            // gFunction_C
            // 
            this.gFunction_C.AutoSize = true;
            this.gFunction_C.ForeColor = System.Drawing.Color.Red;
            this.gFunction_C.Location = new System.Drawing.Point(313, 51);
            this.gFunction_C.Name = "gFunction_C";
            this.gFunction_C.Size = new System.Drawing.Size(16, 15);
            this.gFunction_C.TabIndex = 3;
            this.gFunction_C.Text = "C";
            // 
            // tFunction_Sigma
            // 
            this.tFunction_Sigma.AutoSize = true;
            this.tFunction_Sigma.ForeColor = System.Drawing.Color.Red;
            this.tFunction_Sigma.Location = new System.Drawing.Point(313, 95);
            this.tFunction_Sigma.Name = "tFunction_Sigma";
            this.tFunction_Sigma.Size = new System.Drawing.Size(43, 15);
            this.tFunction_Sigma.TabIndex = 4;
            this.tFunction_Sigma.Text = "Sigma";
            this.tFunction_Sigma.Click += new System.EventHandler(this.label2_Click);
            // 
            // textCenter2
            // 
            this.textCenter2.Location = new System.Drawing.Point(373, 92);
            this.textCenter2.Name = "textCenter2";
            this.textCenter2.Size = new System.Drawing.Size(100, 25);
            this.textCenter2.TabIndex = 5;
            this.textCenter2.Text = "1.0";
            // 
            // theChart
            // 
            chartArea2.AxisX.Title = "x axis_range";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Values";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea2);
            this.theChart.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            legend2.Name = "Legend1";
            legend2.Title = "line name";
            legend2.TitleBackColor = System.Drawing.Color.White;
            this.theChart.Legends.Add(legend2);
            this.theChart.Location = new System.Drawing.Point(57, 207);
            this.theChart.Name = "theChart";
            this.theChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "t_Function";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.LegendText = "g_Function";
            series5.Name = "g_Function";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "b_Function";
            this.theChart.Series.Add(series4);
            this.theChart.Series.Add(series5);
            this.theChart.Series.Add(series6);
            this.theChart.Size = new System.Drawing.Size(696, 231);
            this.theChart.TabIndex = 6;
            this.theChart.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Function Plot";
            this.theChart.Titles.Add(title2);
            this.theChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textLeft2
            // 
            this.textLeft2.Location = new System.Drawing.Point(113, 92);
            this.textLeft2.Name = "textLeft2";
            this.textLeft2.Size = new System.Drawing.Size(100, 25);
            this.textLeft2.TabIndex = 11;
            this.textLeft2.Text = "4.0";
            // 
            // tFunction_B
            // 
            this.tFunction_B.AutoSize = true;
            this.tFunction_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tFunction_B.Location = new System.Drawing.Point(54, 96);
            this.tFunction_B.Name = "tFunction_B";
            this.tFunction_B.Size = new System.Drawing.Size(16, 15);
            this.tFunction_B.TabIndex = 10;
            this.tFunction_B.Text = "B";
            this.tFunction_B.Click += new System.EventHandler(this.tFunction_B_Click_1);
            // 
            // tFunction_A
            // 
            this.tFunction_A.AutoSize = true;
            this.tFunction_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tFunction_A.Location = new System.Drawing.Point(54, 52);
            this.tFunction_A.Name = "tFunction_A";
            this.tFunction_A.Size = new System.Drawing.Size(17, 15);
            this.tFunction_A.TabIndex = 9;
            this.tFunction_A.Text = "A";
            this.tFunction_A.Click += new System.EventHandler(this.tFunction_A_Click_1);
            // 
            // textLeft1
            // 
            this.textLeft1.Location = new System.Drawing.Point(113, 48);
            this.textLeft1.Name = "textLeft1";
            this.textLeft1.Size = new System.Drawing.Size(100, 25);
            this.textLeft1.TabIndex = 7;
            this.textLeft1.Text = "3.0";
            // 
            // textLeft3
            // 
            this.textLeft3.Location = new System.Drawing.Point(113, 133);
            this.textLeft3.Name = "textLeft3";
            this.textLeft3.Size = new System.Drawing.Size(100, 25);
            this.textLeft3.TabIndex = 13;
            this.textLeft3.Text = "5.0";
            // 
            // tFunction_C
            // 
            this.tFunction_C.AutoSize = true;
            this.tFunction_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tFunction_C.Location = new System.Drawing.Point(54, 137);
            this.tFunction_C.Name = "tFunction_C";
            this.tFunction_C.Size = new System.Drawing.Size(16, 15);
            this.tFunction_C.TabIndex = 12;
            this.tFunction_C.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(68, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "t Function";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(326, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "g Function";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(608, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "b Function";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textRight3
            // 
            this.textRight3.Location = new System.Drawing.Point(653, 133);
            this.textRight3.Name = "textRight3";
            this.textRight3.Size = new System.Drawing.Size(100, 25);
            this.textRight3.TabIndex = 21;
            this.textRight3.Text = "5.0";
            // 
            // bFunction_C
            // 
            this.bFunction_C.AutoSize = true;
            this.bFunction_C.ForeColor = System.Drawing.Color.Blue;
            this.bFunction_C.Location = new System.Drawing.Point(594, 137);
            this.bFunction_C.Name = "bFunction_C";
            this.bFunction_C.Size = new System.Drawing.Size(16, 15);
            this.bFunction_C.TabIndex = 20;
            this.bFunction_C.Text = "C";
            // 
            // textRight2
            // 
            this.textRight2.Location = new System.Drawing.Point(653, 92);
            this.textRight2.Name = "textRight2";
            this.textRight2.Size = new System.Drawing.Size(100, 25);
            this.textRight2.TabIndex = 19;
            this.textRight2.Text = "4.0";
            // 
            // bFunction_B
            // 
            this.bFunction_B.AutoSize = true;
            this.bFunction_B.ForeColor = System.Drawing.Color.Blue;
            this.bFunction_B.Location = new System.Drawing.Point(594, 96);
            this.bFunction_B.Name = "bFunction_B";
            this.bFunction_B.Size = new System.Drawing.Size(16, 15);
            this.bFunction_B.TabIndex = 18;
            this.bFunction_B.Text = "B";
            // 
            // bFunction_A
            // 
            this.bFunction_A.AutoSize = true;
            this.bFunction_A.ForeColor = System.Drawing.Color.Blue;
            this.bFunction_A.Location = new System.Drawing.Point(594, 52);
            this.bFunction_A.Name = "bFunction_A";
            this.bFunction_A.Size = new System.Drawing.Size(17, 15);
            this.bFunction_A.TabIndex = 17;
            this.bFunction_A.Text = "A";
            // 
            // textRight1
            // 
            this.textRight1.Location = new System.Drawing.Point(653, 48);
            this.textRight1.Name = "textRight1";
            this.textRight1.Size = new System.Drawing.Size(100, 25);
            this.textRight1.TabIndex = 16;
            this.textRight1.Text = "3.0";
            // 
            // tFunctionButtom
            // 
            this.tFunctionButtom.Location = new System.Drawing.Point(57, 164);
            this.tFunctionButtom.Name = "tFunctionButtom";
            this.tFunctionButtom.Size = new System.Drawing.Size(156, 32);
            this.tFunctionButtom.TabIndex = 23;
            this.tFunctionButtom.Text = "Draw t Function";
            this.tFunctionButtom.UseVisualStyleBackColor = true;
            this.tFunctionButtom.Click += new System.EventHandler(this.tFunctionButtom_Click);
            // 
            // bFunctionButtom
            // 
            this.bFunctionButtom.ForeColor = System.Drawing.Color.Blue;
            this.bFunctionButtom.Location = new System.Drawing.Point(597, 164);
            this.bFunctionButtom.Name = "bFunctionButtom";
            this.bFunctionButtom.Size = new System.Drawing.Size(156, 32);
            this.bFunctionButtom.TabIndex = 24;
            this.bFunctionButtom.Text = "Draw b Function";
            this.bFunctionButtom.UseVisualStyleBackColor = true;
            this.bFunctionButtom.Click += new System.EventHandler(this.bFunctionButtom_Click);
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bFunctionButtom);
            this.Controls.Add(this.tFunctionButtom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textRight3);
            this.Controls.Add(this.bFunction_C);
            this.Controls.Add(this.textRight2);
            this.Controls.Add(this.bFunction_B);
            this.Controls.Add(this.bFunction_A);
            this.Controls.Add(this.textRight1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLeft3);
            this.Controls.Add(this.tFunction_C);
            this.Controls.Add(this.textLeft2);
            this.Controls.Add(this.tFunction_B);
            this.Controls.Add(this.tFunction_A);
            this.Controls.Add(this.textLeft1);
            this.Controls.Add(this.theChart);
            this.Controls.Add(this.textCenter2);
            this.Controls.Add(this.tFunction_Sigma);
            this.Controls.Add(this.gFunction_C);
            this.Controls.Add(this.gFunctionButtom);
            this.Controls.Add(this.textCenter1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "Assignment1";
            this.Text = "Assignment1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textCenter1;
        private System.Windows.Forms.Button gFunctionButtom;
        private System.Windows.Forms.Label gFunction_C;
        private System.Windows.Forms.Label tFunction_Sigma;
        private System.Windows.Forms.TextBox textCenter2;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.TextBox textLeft2;
        private System.Windows.Forms.Label tFunction_B;
        private System.Windows.Forms.Label tFunction_A;
        private System.Windows.Forms.TextBox textLeft1;
        private System.Windows.Forms.TextBox textLeft3;
        private System.Windows.Forms.Label tFunction_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRight3;
        private System.Windows.Forms.Label bFunction_C;
        private System.Windows.Forms.TextBox textRight2;
        private System.Windows.Forms.Label bFunction_B;
        private System.Windows.Forms.Label bFunction_A;
        private System.Windows.Forms.TextBox textRight1;
        private System.Windows.Forms.Button tFunctionButtom;
        private System.Windows.Forms.Button bFunctionButtom;
    }
}

