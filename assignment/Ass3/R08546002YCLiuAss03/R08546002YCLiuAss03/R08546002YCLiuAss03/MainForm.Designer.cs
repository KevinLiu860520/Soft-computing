namespace R08546002YCLiuAss03
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.thetree = new System.Windows.Forms.TreeView();
            this.Mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCreateFuzzySet = new System.Windows.Forms.Button();
            this.FunctionSelection = new System.Windows.Forms.ComboBox();
            this.thegrid = new System.Windows.Forms.PropertyGrid();
            this.DeleteUniversal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUniverse.Location = new System.Drawing.Point(12, 20);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(172, 52);
            this.btnCreateUniverse.TabIndex = 0;
            this.btnCreateUniverse.Text = "Create Universe";
            this.btnCreateUniverse.UseVisualStyleBackColor = true;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // thetree
            // 
            this.thetree.HideSelection = false;
            this.thetree.Location = new System.Drawing.Point(12, 78);
            this.thetree.Name = "thetree";
            this.thetree.Size = new System.Drawing.Size(350, 220);
            this.thetree.TabIndex = 1;
            this.thetree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.thetree_AfterSelect);
            // 
            // Mainchart
            // 
            this.Mainchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainchart.BackColor = System.Drawing.Color.DarkGray;
            this.Mainchart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            legend3.Name = "Legend1";
            this.Mainchart.Legends.Add(legend3);
            this.Mainchart.Location = new System.Drawing.Point(12, 304);
            this.Mainchart.Name = "Mainchart";
            this.Mainchart.Size = new System.Drawing.Size(729, 340);
            this.Mainchart.TabIndex = 5;
            this.Mainchart.Text = "chart1";
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(400, 49);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(341, 41);
            this.btnCreateFuzzySet.TabIndex = 4;
            this.btnCreateFuzzySet.Text = "CreateFuzzySet";
            this.btnCreateFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateFuzzySet.Click += new System.EventHandler(this.btnCreateFuzzySet_Click);
            // 
            // FunctionSelection
            // 
            this.FunctionSelection.FormattingEnabled = true;
            this.FunctionSelection.Items.AddRange(new object[] {
            "Gaussian Function",
            "Bell Function",
            "Trapezoidal Function",
            "Triangular Function",
            "Sigmoidal Function",
            "Left-right Function"});
            this.FunctionSelection.Location = new System.Drawing.Point(400, 20);
            this.FunctionSelection.Name = "FunctionSelection";
            this.FunctionSelection.Size = new System.Drawing.Size(341, 23);
            this.FunctionSelection.TabIndex = 5;
            // 
            // thegrid
            // 
            this.thegrid.Location = new System.Drawing.Point(400, 96);
            this.thegrid.Name = "thegrid";
            this.thegrid.Size = new System.Drawing.Size(341, 202);
            this.thegrid.TabIndex = 6;
            // 
            // DeleteUniversal
            // 
            this.DeleteUniversal.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUniversal.Location = new System.Drawing.Point(190, 20);
            this.DeleteUniversal.Name = "DeleteUniversal";
            this.DeleteUniversal.Size = new System.Drawing.Size(172, 52);
            this.DeleteUniversal.TabIndex = 7;
            this.DeleteUniversal.Text = "Delete ";
            this.DeleteUniversal.UseVisualStyleBackColor = true;
            this.DeleteUniversal.Click += new System.EventHandler(this.DeleteUniversal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 654);
            this.Controls.Add(this.DeleteUniversal);
            this.Controls.Add(this.thegrid);
            this.Controls.Add(this.FunctionSelection);
            this.Controls.Add(this.btnCreateFuzzySet);
            this.Controls.Add(this.Mainchart);
            this.Controls.Add(this.thetree);
            this.Controls.Add(this.btnCreateUniverse);
            this.Name = "MainForm";
            this.Text = "Assignment#3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mainchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUniverse;
        private System.Windows.Forms.TreeView thetree;
        private System.Windows.Forms.DataVisualization.Charting.Chart Mainchart;
        private System.Windows.Forms.ComboBox FunctionSelection;
        private System.Windows.Forms.Button btnCreateFuzzySet;
        private System.Windows.Forms.PropertyGrid thegrid;
        private System.Windows.Forms.Button DeleteUniversal;
    }
}

