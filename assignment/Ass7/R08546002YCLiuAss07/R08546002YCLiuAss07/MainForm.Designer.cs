namespace R08546002YCLiuAss07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labJobsCount = new System.Windows.Forms.Label();
            this.labSetupTimeMatrix = new System.Windows.Forms.Label();
            this.dgvSetupTimeMatrix = new System.Windows.Forms.DataGridView();
            this.labOptimumSolution = new System.Windows.Forms.Label();
            this.labShortestSetupTime = new System.Windows.Forms.Label();
            this.labNumberofJobs = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BrutalForceMethod = new System.Windows.Forms.TabPage();
            this.labBestSolution = new System.Windows.Forms.Label();
            this.labBestObjective = new System.Windows.Forms.Label();
            this.ckxShowDetails = new System.Windows.Forms.CheckBox();
            this.ckxQuickRecursive = new System.Windows.Forms.CheckBox();
            this.btnBrutalForce = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GAMethods = new System.Windows.Forms.TabPage();
            this.Fileinput = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspOpen = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetupTimeMatrix)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.BrutalForceMethod.SuspendLayout();
            this.Fileinput.SuspendLayout();
            this.tspOpen.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labJobsCount);
            this.splitContainer1.Panel1.Controls.Add(this.labSetupTimeMatrix);
            this.splitContainer1.Panel1.Controls.Add(this.dgvSetupTimeMatrix);
            this.splitContainer1.Panel1.Controls.Add(this.labOptimumSolution);
            this.splitContainer1.Panel1.Controls.Add(this.labShortestSetupTime);
            this.splitContainer1.Panel1.Controls.Add(this.labNumberofJobs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 554);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 0;
            // 
            // labJobsCount
            // 
            this.labJobsCount.AutoSize = true;
            this.labJobsCount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJobsCount.Location = new System.Drawing.Point(148, 10);
            this.labJobsCount.Name = "labJobsCount";
            this.labJobsCount.Size = new System.Drawing.Size(65, 23);
            this.labJobsCount.TabIndex = 9;
            this.labJobsCount.Text = "#Jobs";
            // 
            // labSetupTimeMatrix
            // 
            this.labSetupTimeMatrix.AutoSize = true;
            this.labSetupTimeMatrix.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSetupTimeMatrix.Location = new System.Drawing.Point(5, 92);
            this.labSetupTimeMatrix.Name = "labSetupTimeMatrix";
            this.labSetupTimeMatrix.Size = new System.Drawing.Size(163, 22);
            this.labSetupTimeMatrix.TabIndex = 8;
            this.labSetupTimeMatrix.Text = "Setup Time Matrix";
            // 
            // dgvSetupTimeMatrix
            // 
            this.dgvSetupTimeMatrix.AllowUserToAddRows = false;
            this.dgvSetupTimeMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSetupTimeMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetupTimeMatrix.Location = new System.Drawing.Point(6, 118);
            this.dgvSetupTimeMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSetupTimeMatrix.Name = "dgvSetupTimeMatrix";
            this.dgvSetupTimeMatrix.RowHeadersWidth = 51;
            this.dgvSetupTimeMatrix.RowTemplate.Height = 31;
            this.dgvSetupTimeMatrix.Size = new System.Drawing.Size(420, 432);
            this.dgvSetupTimeMatrix.TabIndex = 7;
            // 
            // labOptimumSolution
            // 
            this.labOptimumSolution.AutoSize = true;
            this.labOptimumSolution.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOptimumSolution.ForeColor = System.Drawing.Color.Red;
            this.labOptimumSolution.Location = new System.Drawing.Point(5, 59);
            this.labOptimumSolution.Name = "labOptimumSolution";
            this.labOptimumSolution.Size = new System.Drawing.Size(165, 22);
            this.labOptimumSolution.TabIndex = 6;
            this.labOptimumSolution.Text = "Optimum Solution :";
            // 
            // labShortestSetupTime
            // 
            this.labShortestSetupTime.AutoSize = true;
            this.labShortestSetupTime.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShortestSetupTime.Location = new System.Drawing.Point(3, 37);
            this.labShortestSetupTime.Name = "labShortestSetupTime";
            this.labShortestSetupTime.Size = new System.Drawing.Size(184, 22);
            this.labShortestSetupTime.TabIndex = 5;
            this.labShortestSetupTime.Text = "Shortest Setup Time : ";
            // 
            // labNumberofJobs
            // 
            this.labNumberofJobs.AutoSize = true;
            this.labNumberofJobs.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumberofJobs.ForeColor = System.Drawing.Color.Navy;
            this.labNumberofJobs.Location = new System.Drawing.Point(3, 12);
            this.labNumberofJobs.Name = "labNumberofJobs";
            this.labNumberofJobs.Size = new System.Drawing.Size(153, 22);
            this.labNumberofJobs.TabIndex = 4;
            this.labNumberofJobs.Text = "Number of Jobs : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BrutalForceMethod);
            this.tabControl1.Controls.Add(this.GAMethods);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 554);
            this.tabControl1.TabIndex = 2;
            // 
            // BrutalForceMethod
            // 
            this.BrutalForceMethod.Controls.Add(this.labBestSolution);
            this.BrutalForceMethod.Controls.Add(this.labBestObjective);
            this.BrutalForceMethod.Controls.Add(this.ckxShowDetails);
            this.BrutalForceMethod.Controls.Add(this.ckxQuickRecursive);
            this.BrutalForceMethod.Controls.Add(this.btnBrutalForce);
            this.BrutalForceMethod.Controls.Add(this.richTextBox1);
            this.BrutalForceMethod.Location = new System.Drawing.Point(4, 27);
            this.BrutalForceMethod.Name = "BrutalForceMethod";
            this.BrutalForceMethod.Padding = new System.Windows.Forms.Padding(3);
            this.BrutalForceMethod.Size = new System.Drawing.Size(715, 523);
            this.BrutalForceMethod.TabIndex = 0;
            this.BrutalForceMethod.Text = "Brutal Force Method";
            this.BrutalForceMethod.UseVisualStyleBackColor = true;
            // 
            // labBestSolution
            // 
            this.labBestSolution.AutoSize = true;
            this.labBestSolution.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBestSolution.ForeColor = System.Drawing.Color.Navy;
            this.labBestSolution.Location = new System.Drawing.Point(426, 51);
            this.labBestSolution.Name = "labBestSolution";
            this.labBestSolution.Size = new System.Drawing.Size(153, 20);
            this.labBestSolution.TabIndex = 9;
            this.labBestSolution.Text = "Best Solution : ";
            // 
            // labBestObjective
            // 
            this.labBestObjective.AutoSize = true;
            this.labBestObjective.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBestObjective.ForeColor = System.Drawing.Color.Navy;
            this.labBestObjective.Location = new System.Drawing.Point(426, 2);
            this.labBestObjective.Name = "labBestObjective";
            this.labBestObjective.Size = new System.Drawing.Size(162, 20);
            this.labBestObjective.TabIndex = 8;
            this.labBestObjective.Text = "Best Objective : ";
            // 
            // ckxShowDetails
            // 
            this.ckxShowDetails.AutoSize = true;
            this.ckxShowDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckxShowDetails.Location = new System.Drawing.Point(211, 52);
            this.ckxShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.ckxShowDetails.Name = "ckxShowDetails";
            this.ckxShowDetails.Size = new System.Drawing.Size(126, 22);
            this.ckxShowDetails.TabIndex = 7;
            this.ckxShowDetails.Text = "Show Details";
            this.ckxShowDetails.UseVisualStyleBackColor = true;
            // 
            // ckxQuickRecursive
            // 
            this.ckxQuickRecursive.AutoSize = true;
            this.ckxQuickRecursive.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckxQuickRecursive.Location = new System.Drawing.Point(211, 3);
            this.ckxQuickRecursive.Margin = new System.Windows.Forms.Padding(4);
            this.ckxQuickRecursive.Name = "ckxQuickRecursive";
            this.ckxQuickRecursive.Size = new System.Drawing.Size(150, 22);
            this.ckxQuickRecursive.TabIndex = 6;
            this.ckxQuickRecursive.Text = "Quick Recursive";
            this.ckxQuickRecursive.UseVisualStyleBackColor = true;
            // 
            // btnBrutalForce
            // 
            this.btnBrutalForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrutalForce.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrutalForce.Location = new System.Drawing.Point(6, 3);
            this.btnBrutalForce.Name = "btnBrutalForce";
            this.btnBrutalForce.Size = new System.Drawing.Size(184, 74);
            this.btnBrutalForce.TabIndex = 0;
            this.btnBrutalForce.Text = "Get All Solutions";
            this.btnBrutalForce.UseVisualStyleBackColor = false;
            this.btnBrutalForce.Click += new System.EventHandler(this.btnBrutalForce_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 447);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // GAMethods
            // 
            this.GAMethods.Location = new System.Drawing.Point(4, 27);
            this.GAMethods.Name = "GAMethods";
            this.GAMethods.Padding = new System.Windows.Forms.Padding(3);
            this.GAMethods.Size = new System.Drawing.Size(715, 523);
            this.GAMethods.TabIndex = 1;
            this.GAMethods.Text = "GA Methods";
            this.GAMethods.UseVisualStyleBackColor = true;
            // 
            // Fileinput
            // 
            this.Fileinput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Fileinput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Fileinput.Location = new System.Drawing.Point(0, 0);
            this.Fileinput.Name = "Fileinput";
            this.Fileinput.Size = new System.Drawing.Size(1157, 27);
            this.Fileinput.TabIndex = 0;
            this.Fileinput.Text = "menuStrip1";
            this.Fileinput.Click += new System.EventHandler(this.tspOpen_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
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
            // tspOpen
            // 
            this.tspOpen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tspOpen.Location = new System.Drawing.Point(0, 27);
            this.tspOpen.Name = "tspOpen";
            this.tspOpen.Size = new System.Drawing.Size(1157, 27);
            this.tspOpen.Stretch = true;
            this.tspOpen.TabIndex = 0;
            this.tspOpen.Text = "Open";
            this.tspOpen.Click += new System.EventHandler(this.tspOpen_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AccessibleName = "";
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 24);
            this.toolStripButton1.Text = "Open";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "*aop";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMessage,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Tag = "123";
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labMessage
            // 
            this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(1142, 19);
            this.labMessage.Spring = true;
            this.labMessage.Text = "Time Spent";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(158, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 633);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tspOpen);
            this.Controls.Add(this.Fileinput);
            this.MainMenuStrip = this.Fileinput;
            this.Name = "MainForm";
            this.Text = "Assignment#7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetupTimeMatrix)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.BrutalForceMethod.ResumeLayout(false);
            this.BrutalForceMethod.PerformLayout();
            this.Fileinput.ResumeLayout(false);
            this.Fileinput.PerformLayout();
            this.tspOpen.ResumeLayout(false);
            this.tspOpen.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip Fileinput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip tspOpen;
        private System.Windows.Forms.Button btnBrutalForce;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labMessage;
        private System.Windows.Forms.Label labSetupTimeMatrix;
        private System.Windows.Forms.DataGridView dgvSetupTimeMatrix;
        private System.Windows.Forms.Label labOptimumSolution;
        private System.Windows.Forms.Label labShortestSetupTime;
        private System.Windows.Forms.Label labNumberofJobs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BrutalForceMethod;
        private System.Windows.Forms.Label labBestSolution;
        private System.Windows.Forms.Label labBestObjective;
        private System.Windows.Forms.CheckBox ckxShowDetails;
        private System.Windows.Forms.CheckBox ckxQuickRecursive;
        private System.Windows.Forms.TabPage GAMethods;
        private System.Windows.Forms.Label labJobsCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

