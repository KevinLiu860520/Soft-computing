using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss06
{
    public partial class MainForm : Form // inherit Form
    {
        MamdaniFuzzySystem mamdani = new MamdaniFuzzySystem();
        SugenoFuzzySystem sugeno = new SugenoFuzzySystem();
        TsukamotoFuzzySystem tsukamoto = new TsukamotoFuzzySystem();

        public MainForm() // set initial value to some items
        {
            InitializeComponent();
            FunctionSelection.SelectedIndex = 0; // show Gaussion Function to be selected
            UnaryOperatorSelect.SelectedIndex = 0;
            BinaryOperatorSelect.SelectedIndex = 0;
            Delete.Enabled = false;
            FunctionSelectGroup.Enabled = false;
            UnarySelectGroup.Enabled = false;
            BinarySelectGroup.Enabled = false;
            DeleteGrayArea.Enabled = false;
            AddEquations.Enabled = false;
            btnAddrule.Enabled = false;
            DeleteRule.Enabled = false;


            rdoMamdani_Click(null, null);
            if (rdoMamdani.Checked)
            {
                tabControl.TabPages.Remove(OutputEquations);  //remove page of output equation
                btnCrispCrispOutInferencing.Enabled = true;
                btnInference.Enabled = true;
                dgvCondition.Enabled = true;
                rbnCut.Enabled = true;
                rbnScale.Enabled = true;
                ResolutionValue.Enabled = true;
                rbnCOA.Enabled = true;
                rbnBOA.Enabled = true;
                rbnMOM.Enabled = true;
                rbnLOM.Enabled = true;
                rbnSOM.Enabled = true;
                rbnCut.Visible = true;
                rbnScale.Visible = true;
                rbnAverage.Visible = false;
                rbnSum.Visible = false;
                rbnCut.Checked = true;
            }
        }


        Series SelectedSeries = null; // default the hightline
        private void thetree_AfterSelect(object sender, TreeViewEventArgs e) // something happened after select 
        {
            thegrid.SelectedObject = thetree.SelectedNode.Tag; // show selectednode information to the grid

            if (thetree.SelectedNode.Level == 0)
            {
                btnCreateUniverse.Enabled = true;
                ChosenInput.Text = thetree.SelectedNode.Text;
                Delete.Enabled = false;
                UnarySelectGroup.Enabled = false;
                AddEquations.Enabled = false;
                //if there is no universe, it is not allowed to add a rule
                if (thetree.SelectedNode.Nodes.Count == 0)
                {
                    btnAddrule.Enabled = false;
                }
                else
                {
                    if (thetree.SelectedNode.Nodes.Count != 0)
                    {
                        btnAddrule.Enabled = true;
                    }
                }
                if (thetree.SelectedNode.Index == 0)
                {
                    btnCreateUniverse.Text = "Create Input Universe";
                }
                if (thetree.SelectedNode.Index == 1)
                {
                    btnCreateUniverse.Text = "Create Output Universe";
                    //only one output universe
                    if (thetree.SelectedNode.Nodes.Count > 0)
                        btnCreateUniverse.Enabled = false;
                }
            }
            if (thetree.SelectedNode.Level == 1)
            {
                thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                ChosenInput.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                btnCreateUniverse.Enabled = false;
                btnAddrule.Enabled = true;
                FunctionSelectGroup.Enabled = true;
                UnarySelectGroup.Enabled = false;
                Delete.Enabled = true;
                if (SelectedSeries != null)
                {
                    SelectedSeries.BorderWidth = 2;
                }
                if (rdoSugeno.Checked && thetree.SelectedNode.Parent.Text == "Output Universe")
                {
                    AddEquations.Enabled = true;
                    btnCreateFuzzySet.Enabled = false;
                    FunctionSelection.Enabled = false;
                }
                else
                {
                    AddEquations.Enabled = false;
                    btnCreateFuzzySet.Enabled = true;
                    FunctionSelection.Enabled = true;
                }
            }
            if (thetree.SelectedNode.Level == 2)  //fuzzy set level = 2
            {
                if (rdoSugeno.Checked && thetree.SelectedNode.Parent.Text == "Output Universe")
                {
                    AddEquations.Enabled = true;
                    btnCreateFuzzySet.Enabled = false;
                    FunctionSelection.Enabled = false;
                }
                btnCreateUniverse.Enabled = false;
                btnAddrule.Enabled = true;
                FunctionSelectGroup.Enabled = false;
                Delete.Enabled = true;
                UnarySelectGroup.Enabled = true; 
                if (rdoSugeno.Checked && thetree.SelectedNode.Parent.Parent.Index == 1)
                {
                    ChosenInput.Text = thetree.SelectedNode.Text;
                    AddEquations.Enabled = true;
                    return;
                }
                else ChosenInput.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                //Series have somthing
                if (((FuzzySet)thetree.SelectedNode.Tag).TheSeries != null)  //Series cannot be null
                {
                    if (SelectedSeries != null)  //previou line initialize
                    {
                        SelectedSeries.BorderWidth = 1;
                    }
                    ((FuzzySet)thetree.SelectedNode.Tag).TheSeries.BorderWidth = 5; // selectednode's line get width
                    SelectedSeries = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries;  //above series be highlight
                }
            }
        }
        private void thegrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) // change title by selected title
        {
            //selected is a universe
            if (thetree.SelectedNode.Tag is Universe)
            {
                if (thetree.SelectedNode.Parent.Index == 0)
                {
                    thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                    ChosenInput.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                    //rules and condition colomns name changed
                    dgvRules.Columns[thetree.SelectedNode.Index].HeaderText = ((Universe)thetree.SelectedNode.Tag).Title;
                    dgvCondition.Columns[thetree.SelectedNode.Index].HeaderText = ((Universe)thetree.SelectedNode.Tag).Title;
                }
                if (thetree.SelectedNode.Parent.Index == 1)
                {
                    thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                    ChosenInput.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                    dgvRules.Columns[dgvRules.ColumnCount - 1].HeaderText = ((Universe)thetree.SelectedNode.Tag).Title;  //
                }
            }
            else if (thetree.SelectedNode.Tag is FuzzySet)
            {
                thetree.SelectedNode.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                ChosenInput.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                //rules and condition cells name changed
                for (int r = 0; r < dgvRules.RowCount; r++)
                {
                    for (int c = 0; c < dgvRules.ColumnCount; c++)
                    {
                        if (dgvRules.Rows[r].Cells[c].Tag == (FuzzySet)thetree.SelectedNode.Tag)
                            dgvRules.Rows[r].Cells[c].Value = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                    }
                }
                for (int r = 0; r < dgvCondition.RowCount; r++)
                {
                    for (int c = 0; c < dgvCondition.ColumnCount; c++)
                    {
                        if (dgvCondition.Rows[r].Cells[c].Tag == (FuzzySet)thetree.SelectedNode.Tag)
                            dgvCondition.Rows[r].Cells[c].Value = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                    }
                }
            }
        }
        private void btnCreateFuzzySet_Click(object sender, EventArgs e)
        {
            /*if (thetree.SelectedNode == null) // if thetree is empty show below messagebox and return or will show error
                MessageBox.Show("You should create universal first!!");
            if (thetree.SelectedNode == null) return;
            if (thetree.SelectedNode.Level != 0) return;  // we select Universal (Level 0) to create fuzzy set*/
            FuzzySet aFS = null; // set aFS == null
            Universe selecteU;
            if (rdoTsukamoto.Checked && thetree.SelectedNode.Parent.Index == 1)
                if (FunctionSelection.SelectedIndex != 4 && FunctionSelection.SelectedIndex != 6 && FunctionSelection.SelectedIndex != 7 && FunctionSelection.SelectedIndex != 9 && FunctionSelection.SelectedIndex != 10)
                {
                    MessageBox.Show("Select a monotonic fuzzy set!");
                    return;
                }
            if (thetree.SelectedNode.Tag is Universe) // if thetree you choose is universe
            {
                selecteU = (Universe)(thetree.SelectedNode.Tag); // which you selected
                switch (FunctionSelection.SelectedIndex) // case of FunctionSelection
                {
                    case 0: // Gaussian
                        aFS = new GaussianFuzzySet(selecteU);
                        break;
                    case 1: // Bell
                        aFS = new BellFuzzySet(selecteU);
                        break;
                    case 2: // Trapezoida
                        aFS = new TrapezoidalFuzzySet(selecteU);
                        break;
                    case 3: // Triangular
                        aFS = new TriangularFuzzySet(selecteU);
                        break;
                    case 4: // Sigmoidal
                        aFS = new SigmoidalFuzzySet(selecteU);
                        break;
                    case 5: // LeftRight
                        aFS = new LeftrightFuzzySet(selecteU);
                        break;
                    case 6: // S Shaped
                        aFS = new S_ShapedFuzzySet(selecteU);
                        break;
                    case 7: // Z Shaped
                        aFS = new Z_ShapedFuzzySet(selecteU);
                        break;
                    case 8: // Pi Shaped
                        aFS = new Pi_ShapedFuzzySet(selecteU);
                        break;
                    case 9: // Stepup
                        aFS = new StepUpFuzzySet(selecteU);
                        break;
                    case 10: // Stepdown
                        aFS = new StepDownFuzzySet(selecteU);
                        break;
                    case 11: // two-side Gaussian
                        aFS = new TwoSideGaussianFussySet(selecteU);
                        break;
                    case 12: // two-side Pi
                        aFS = new TwoSidePi_ShapedFuzzySet(selecteU);
                        break;
                }
                // Add a subnode to selected node 
                TreeNode aNode = new TreeNode(aFS.Title); // treenode title = FunctionName + count
                aNode.Tag = aFS;
                thetree.SelectedNode.Nodes.Add(aNode); // add node in the universe node
                thetree.SelectedNode = aNode; // selcted node be just created node
                aFS.ShowSeries = true;

                thetree.ExpandAll(); // expand tree
                thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            }
            thetree_AfterSelect(null, null); // enforce execute
        }

        private void btnCreateUniverse_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode == null)
            {
                MessageBox.Show("Please create input/ouput universe!");
                return;
            }
            if (thetree.SelectedNode.Level == 0)
            {
                if (thetree.SelectedNode.Text == "Input Universe")
                {

                    Universe uobj = new Universe(Mainchart);
                    TreeNode bNode = new TreeNode(uobj.Title);
                    bNode.Tag = uobj;
                    thegrid.SelectedObject = uobj;
                    thetree.SelectedNode.Nodes.Add(bNode);
                    thetree.ExpandAll();
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.Tag = uobj;
                    if (thetree.Nodes[1].Nodes.Count == 0)
                    {
                        dgvRules.Columns.Add(uobj.Title, uobj.Title);
                    }
                    else
                    {
                        if (thetree.Nodes[1].Nodes.Count != 0)
                        {
                            col.HeaderText = uobj.Title;
                            dgvRules.Columns.Insert(dgvRules.ColumnCount - 1, col);
                        }
                    }
                    col = new DataGridViewTextBoxColumn();
                    col.HeaderText = uobj.Title;
                    col.Tag = uobj;
                    dgvCondition.Columns.Add(col);
                    if (dgvCondition.Rows.Count == 0)
                        dgvCondition.Rows.Add();
                }
                else if (thetree.SelectedNode.Text == "Output Universe")
                {
                    Universe uobj = new Universe(Mainchart);
                    TreeNode bNode = new TreeNode(uobj.Title);
                    bNode.Tag = uobj;
                    thegrid.SelectedObject = uobj;
                    thetree.SelectedNode.Nodes.Add(bNode);
                    thetree.ExpandAll();
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col = new DataGridViewTextBoxColumn();
                    col.HeaderText = uobj.Title;
                    col.Tag = uobj;
                    dgvRules.Columns.Add(col);
                    btnCreateUniverse.Enabled = false;// just one output   
                    if (thetree.SelectedNode.Nodes.Count > 1)
                    {
                        btnCreateUniverse.Enabled = false;
                    }
                }

                // add columns two data grid views
                //DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                //col.Tag = uobj;
                //dgvRules.Columns.Add(col);
                //dgvRules.Columns.Add(uobj.Title, uobj.Title);
                //dgvCondition.Columns.Add(uobj.Title, uobj.Title);
                //if (dgvCondition.Rows.Count < 1) dgvCondition.Rows.Add();
            }
            if (thetree.Nodes[0].Nodes.Count == 1)
            {
                Chart_1D.Visible = true;
                threeDplot.Visible = false;
                text1Dand2D.Visible = true;
                text1Dand2D.Text = "1D I/O Map";
            }
            else if (thetree.Nodes[0].Nodes.Count == 2)
            {
                Chart_1D.Visible = false;
                threeDplot.Visible = true;
                text1Dand2D.Visible = true;
                text1Dand2D.Text = "2D I/O Map";
            }
            else
            {
                Chart_1D.Visible = false;
                threeDplot.Visible = false;
                text1Dand2D.Visible = false;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode.Level == 1) // if you select universal
            {
                if (rdoSugeno.Checked)
                {
                    ChartArea u = ((Universe)thetree.SelectedNode.Tag).TheArea; // select its chartarea
                    Mainchart.ChartAreas.Remove(u);
                    thetree.SelectedNode.Remove();
                    return;
                }
                else
                {
                    foreach (TreeNode node in thetree.SelectedNode.Nodes) // select the node's subnodes
                    {
                        Series f = ((FuzzySet)node.Tag).TheSeries; // select its Series
                        Mainchart.Series.Remove(f);
                    }
                    ChartArea u = ((Universe)thetree.SelectedNode.Tag).TheArea; // select its chartarea
                    Mainchart.ChartAreas.Remove(u);
                    if (thetree.SelectedNode.Parent.Index == 0)  //input universe
                    {
                        for (int i = 0; i < dgvRules.ColumnCount; i++)
                        {
                            if (thetree.SelectedNode.Index == dgvRules.Columns[i].Index)
                                dgvRules.Columns.RemoveAt(i);
                        }
                        for (int i = 0; i < dgvCondition.ColumnCount; i++)
                        {
                            if (thetree.SelectedNode.Index == dgvCondition.Columns[i].Index)
                                dgvCondition.Columns.RemoveAt(i);
                        }
                    }
                    if (thetree.SelectedNode.Parent.Index == 1)  //output universe
                    {
                        dgvRules.Columns.RemoveAt(dgvRules.ColumnCount - 1);
                    }
                }              
            }
            else if (thetree.SelectedNode.Level == 2) // if you select fuzzyset
            {
                if (thetree.SelectedNode.Text == "0 : Y = 0.1 X + 6.4" || thetree.SelectedNode.Text == "1 : Y = - 0.5 X + 4" || thetree.SelectedNode.Text == "2 : Y = X - 2" || thetree.SelectedNode.Text == "3 : Z = -X + Y + 1" ||
                       thetree.SelectedNode.Text == "4 : Z = -Y + 3" || thetree.SelectedNode.Text == "5 : Z = -X + 3" || thetree.SelectedNode.Text == "6 : Z = X + Y + 2")
                {
                    thetree.SelectedNode.Remove();
                    return;
                }
                else
                {
                    Series f = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries; // select its Series
                    Mainchart.Series.Remove(f); // delete the series in chart
                }               
            }
            thetree.Nodes.Remove(thetree.SelectedNode); // delete which you select ub thetree
            if (thetree.SelectedNode.Level == 0)
            {
                Delete.Enabled = false;
                FunctionSelectGroup.Enabled = false;
                UnarySelectGroup.Enabled = false;
                BinarySelectGroup.Enabled = false;
            }
        }
        private void btnCreateUnaryOperatedFS_Click(object sender, EventArgs e)
        {
            if (!(thetree.SelectedNode.Tag is FuzzySet)) return;
            FuzzySet fs = (FuzzySet)thetree.SelectedNode.Tag;
            UnaryFSOperator op = null;
            FuzzySet newFs;
            switch (UnaryOperatorSelect.SelectedIndex)
            {
                case 0:// negate
                    // newFs = !fs;
                    op = new NegateOperator();
                    break;
                case 1: // value cut
                        // newFs = -fs;
                    op = new ValueCutOperator();
                    break;
                case 2:
                    op = new ValueScaleOperator();
                    break;
                case 3:
                    op = new ConcentrationOperator();
                    break;
                case 4:
                    op = new DilationOperator();
                    break;
                case 5:
                    op = new DiminishOperator();
                    break;
                case 6:
                    op = new ExtremelyOperator();
                    break;
                case 7:
                    op = new IntensificationOperator();
                    break;
                case 8:
                    op = new SugenoComplementOperator();
                    break;
                case 9:
                    op = new YagerComplementOperator();
                    break;
            }
            newFs = new UnaryOperatedFuzzySet(fs, op);

            // Add a subnode to selected node 
            TreeNode cNode = new TreeNode(newFs.Title); // treenode title = FunctionName + count
            cNode.Tag = newFs;
            thetree.SelectedNode.Parent.Nodes.Add(cNode);
            thetree.SelectedNode = cNode;
            newFs.ShowSeries = true;

            thetree.ExpandAll(); // expand tree
            thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            thetree_AfterSelect(null, null);
        }

        private void labFirstFS_Click(object sender, EventArgs e) // use label to certain first fuzzy set you choose to create binary 
        {
            if (thetree.SelectedNode != null)
            {
                if (thetree.SelectedNode.Tag is FuzzySet)
                {
                    labFirstFS.Tag = thetree.SelectedNode.Tag;
                    labFirstFS.Text = thetree.SelectedNode.Text;
                }
                else
                {
                    labFirstFS.Tag = null;
                    labFirstFS.Text = "Click to set First Fs";
                }
            }
            else
            {
                return;
            }
        }
        private void labSecondFS_Click(object sender, EventArgs e)// use label to certain second fuzzy set you choose to create binary 
        {
            if (thetree.SelectedNode != null)
            {
                if (thetree.SelectedNode.Tag is FuzzySet)
                {
                    labSecondFS.Tag = thetree.SelectedNode.Tag;
                    labSecondFS.Text = thetree.SelectedNode.Text;
                }
                else // it's not necessary here
                {
                    labSecondFS.Tag = null;
                    labSecondFS.Text = "Click to set Second Fs";
                }
            }
            else
            {
                return;
            }
        }

        private void btnCreateBinary_Click(object sender, EventArgs e)
        {
            if (!(thetree.SelectedNode.Tag is FuzzySet)) return;
            FuzzySet fs = (FuzzySet)thetree.SelectedNode.Tag;
            FuzzySet First = (FuzzySet)labFirstFS.Tag;
            FuzzySet Second = (FuzzySet)labSecondFS.Tag;
            BinaryFSOperator op = null;
            FuzzySet newFs;
            switch (BinaryOperatorSelect.SelectedIndex)
            {
                case 0:// negate
                       // newFs = !fs;
                    op = new AlgebraicProductOperator();
                    break;
                case 1: // value cut
                        // newFs = -fs;
                    op = new BoundedProductOperator();
                    break;
                case 2:
                    op = new DombiTnormOperator();
                    break;
                case 3:
                    op = new DoubisandPradeTnormOperator();
                    break;
                case 4:
                    op = new DrasticProductOperator();
                    break;
                case 5:
                    op = new EinsteinProductOperator();
                    break;
                case 6:
                    op = new FrankTnormOperator();
                    break;
                case 7:
                    op = new HamacherProductOperator();
                    break;
                case 8:
                    op = new IntersectionOperator();
                    break;
                case 9:
                    op = new SugenoTnormOperator();
                    break;
                case 10:
                    op = new YagerTnormOperator();
                    break;
                case 11:
                    op = new SubstractOperator();
                    break;
                case 12:
                    op = new AlgebraicSumOperator();
                    break;
                case 13:
                    op = new BoundedSumOperator();
                    break;
                case 14:
                    op = new DombiSnormOperator();
                    break;
                case 15:
                    op = new DoubisandPradeSnormOperator();
                    break;
                case 16:
                    op = new DrasticSumOperator();
                    break;
                case 17:
                    op = new EinsteinSumOperator();
                    break;
                case 18:
                    op = new FrankSnormOperator();
                    break;
                case 19:
                    op = new HamacherSumOperator();
                    break;
                case 20:
                    op = new UnionOperaotr();
                    break;
                case 21:
                    op = new SugenoSnormOperator();
                    break;
                case 22:
                    op = new YagerSnormOperator();
                    break;
                case 23:
                    op = new SubstractOperator();
                    break;
            }
            newFs = new BinaryOperatedFuzzySet(First, Second, op);
            if (First.TheUniverse.TheArea != Second.TheUniverse.TheArea)
            {
                MessageBox.Show("Chosen two FS should in the same Universe.");
                return;
            }
            // Add a subnode to selected node 
            TreeNode cNode = new TreeNode(newFs.Title); // treenode title = FunctionName + count
            cNode.Tag = newFs;
            thetree.SelectedNode.Parent.Nodes.Add(cNode);
            thetree.SelectedNode = cNode;
            newFs.ShowSeries = true;

            thetree.ExpandAll(); // expand tree
            thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            thetree_AfterSelect(null, null);

            labFirstFS.Text = "Click to store First Fuzzy Set";
            labSecondFS.Text = "Click to store Second Fuzzy Set";
            BinarySelectGroup.Enabled = false;
            labFirstFS.Tag = null;
            labSecondFS.Tag = null;
        }
        private void labFirstFS_TextChanged(object sender, EventArgs e)// if label changed, you can choose what BinaryOperator you would like to create
        {
            if (labFirstFS.Tag != null && labSecondFS.Tag != null)
            {
                BinarySelectGroup.Enabled = true;
            }
        }

        private void labSecondFS_TextChanged(object sender, EventArgs e)// if label changed, you can choose what BinaryOperator you would like to create
        {
            if (labFirstFS.Tag != null && labSecondFS.Tag != null)
            {
                BinarySelectGroup.Enabled = true;
            }
        }

        private void btnAddrule_Click(object sender, EventArgs e)
        {
            if (dgvRules.ColumnCount != 0)
            {
                dgvRules.Rows.Add();
            }
            DeleteRule.Enabled = true;
        }

        private void dgvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guarding condition
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (thetree.SelectedNode.Level == 2)
                {
                    if (thetree.SelectedNode.Parent.Text == dgvRules.Columns[e.ColumnIndex].HeaderText)
                    {
                        //defend
                        DataGridViewCell theCell = dgvRules.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        theCell.Tag = thetree.SelectedNode.Tag;
                        theCell.Value = thetree.SelectedNode.Tag;
                    }
                    else if (thetree.SelectedNode.Parent.Text != dgvRules.Columns[e.ColumnIndex].HeaderText)
                    {
                        MessageBox.Show("Fail Selection. You need to select the fuzzysets which have the same universe name with name of parent node and column!!", "Fail Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

        }

        private void dgvCondition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                //checkout whether a fuzzy set is selected
                if (thetree.SelectedNode.Level == 2)
                {
                    //guarding
                    if (thetree.SelectedNode.Parent.Text == dgvCondition.Columns[e.ColumnIndex].HeaderText)
                    {
                        DataGridViewCell cell = dgvCondition.Rows[e.RowIndex].Cells[e.ColumnIndex];  //Rows：collection->第幾個row(e.RowIndex)
                        FuzzySet fs = (FuzzySet)thetree.SelectedNode.Tag;  //object(cast Fuzzy Set)
                        cell.Tag = fs;
                        cell.Value = fs.Title;  //value放object
                    }
                    else if (thetree.SelectedNode.Parent.Text != dgvCondition.Columns[e.ColumnIndex].HeaderText)
                    {
                        MessageBox.Show("Fail Selection. You need to select the fuzzysets which have the same universe name with name of parent node and column!!", "Fail Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        bool isCut;
        private void btnInference_Click(object sender, EventArgs e)
        {
            if (dgvRules.RowCount == 0 || dgvCondition.RowCount == 0)
            {
                if (MessageBox.Show("Nothing are defined", "Creat Something", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
            }
            for (int row = 0; row < dgvRules.Rows.Count; row++)
            {
                for (int column = 0; column < dgvRules.Columns.Count; column++)
                    if (dgvRules.Rows[row].Cells[column].Value == null)
                    {
                        MessageBox.Show($"[{row},{column}]is not defined.");
                        return;
                    }
            }

            DeleteGrayArea.Enabled = true;
            // create if-then rules
            MamdaniIfThenFuzzyRule[] allRules = new MamdaniIfThenFuzzyRule[dgvRules.Rows.Count];
            FuzzySet output;
            for (int r = 0; r < dgvRules.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgvRules.Columns.Count - 1];
                for (int c = 0; c < dgvRules.Columns.Count - 1; c++)
                {
                    inputs[c] = (FuzzySet)dgvRules.Rows[r].Cells[c].Value;
                }
                output = (FuzzySet)dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value;
                allRules[r] = new MamdaniIfThenFuzzyRule(inputs, output);
            }
            // condition
            FuzzySet[] conditions = new FuzzySet[dgvCondition.Columns.Count];
            for (int i = 0; i < dgvCondition.Columns.Count; i++)
            {
                conditions[i] = (FuzzySet)dgvCondition.Rows[0].Cells[i].Tag;
            }
            //bool isCut; //在外面宣告
            if (cut_rb.Checked)
            {
                isCut = true;
            }
            if (cut_sc.Checked)
            {
                isCut = false;
            }
            // set contents of conditions
            FuzzySet resultingFS = null;
            foreach (MamdaniIfThenFuzzyRule rule in allRules)
            {
                if (resultingFS == null)
                {
                    resultingFS = rule.FuzzyInFuzzyOutInferencing(conditions, isCut);
                }
                else
                {
                    resultingFS = resultingFS | rule.FuzzyInFuzzyOutInferencing(conditions, isCut); // 用|聯集起來
                }
                // show the final fs
                resultingFS.ShowSeries = true;
                resultingFS.TheChartType = SeriesChartType.Area;
                resultingFS.TheSeries.Color = Color.DarkGray;
            }

            DeleteGrayArea.Enabled = true;
            btnInference.Enabled = false;
        }
        private void DeleteRule_Click(object sender, EventArgs e)
        {
            if (dgvRules.RowCount == 0)
            {
                //return;
                DeleteRule.Enabled = false;
            }
            if (dgvRules.RowCount != 0)
            {
                DataGridViewRow r = this.dgvRules.CurrentRow;
                dgvRules.Rows.Remove(r);
            }
        }

        private void rdoMamdani_Click(object sender, EventArgs e)
        {

        }
        private void DeleteGrayArea_Click(object sender, EventArgs e)
        {
            btnInference.Enabled = true;
            if (Mainchart.Series.Count > 0)
            {
                Mainchart.Series.RemoveAt(Mainchart.Series.Count - 1);
            }
            DeleteGrayArea.Enabled = false;
        }

        private void btnCrispCrispOutInferencing_Click(object sender, EventArgs e)
        {
            if (dgvRules.RowCount == 0)
            {
                MessageBox.Show("Add the rules!");
                return;
            }
            // 1D
            if (Chart_1D.Visible)
            {
                int num = (int)ResolutionValue.Value;
                Universe fs1 = (Universe)thetree.Nodes[0].Nodes[0].Tag;
                Universe output = (Universe)thetree.Nodes[1].Nodes[0].Tag;
                Chart_1D.ChartAreas[0].AxisX.Title = fs1.Title;
                Chart_1D.ChartAreas[0].AxisY.Title = output.Title;
                double yy = 0.0;
                double xdelta = (fs1.Maximum - fs1.Minimum) / (num - 1);
                double[] crispconditions = new double[1];
                Chart_1D.Series[0].Points.Clear();
                for (double xx = fs1.Minimum; xx < fs1.Maximum; xx = xx + xdelta)
                {
                    crispconditions[0] = xx;
                    if (rdoMamdani.Checked)
                    {
                        mamdani.ConstructSystem(dgvRules);
                        mamdani.ISCut = rbnCut.Checked;
                        yy = mamdani.CrispInCrispOutInferencing(crispconditions);
                    }
                    else if (rdoSugeno.Checked)
                    {
                        sugeno.ConstructSystem(dgvRules);
                        sugeno.ISAverage = rbnAverage.Checked;
                        yy = sugeno.CrispInCrispOutInferencing(crispconditions);
                    }
                    else
                    {
                        tsukamoto.ConstructSystem(dgvRules);
                        tsukamoto.IsWeightedAverage = rbnAverage.Checked;
                        yy = tsukamoto.CrispInCrispOutInferencing(crispconditions);
                    }
                    Chart_1D.Series[0].Points.AddXY(xx, yy);
                    Chart_1D.Series[0].BorderWidth = 3;
                    Chart_1D.Series[0].LegendText = fs1.Title + "_" + output.Title;
                    Chart_1D.Series[0].XValueType = ChartValueType.Int32;
                }
            }

            else if (threeDplot.Visible)
            {
                int num = (int)ResolutionValue.Value;
                plotcontrol.Clear();
                plotcontrol.IrregularGrid = true;
                plotcontrol.NumXValues = plotcontrol.NumZValues = num;
                Universe fs1 = (Universe)thetree.Nodes[0].Nodes[0].Tag;
                Universe fs2 = (Universe)thetree.Nodes[0].Nodes[1].Tag;
                threeDplot.Axes.Bottom.Title.Text = "Temperature";
                threeDplot.Axes.Left.Title.Text = "Force";

                double yy = 0.0;
                double xdelta = (fs1.Maximum - fs1.Minimum) / (num - 1);
                double zdelta = (fs2.Maximum - fs2.Minimum) / (num - 1);
                //teechart 2D
                double[] crispconditions = new double[2];
                for (double xx = fs1.Minimum; xx < fs1.Maximum; xx = xx + xdelta)
                {
                    for (double zz = fs2.Minimum; zz < fs2.Maximum; zz = zz + zdelta)
                    {
                        crispconditions[0] = xx;
                        crispconditions[1] = zz;
                        if (rdoMamdani.Checked)
                        {
                            mamdani.ConstructSystem(dgvRules);
                            mamdani.ISCut = rbnCut.Checked;
                            yy = mamdani.CrispInCrispOutInferencing(crispconditions);
                        }
                        else if (rdoSugeno.Checked)
                        {
                            sugeno.ConstructSystem(dgvRules);
                            sugeno.ISAverage = rbnAverage.Checked;
                            yy = sugeno.CrispInCrispOutInferencing(crispconditions);
                        }
                        else
                        {
                            tsukamoto.ConstructSystem(dgvRules);
                            tsukamoto.IsWeightedAverage = rbnAverage.Checked;
                            yy = tsukamoto.CrispInCrispOutInferencing(crispconditions);
                        }
                        plotcontrol.Add(xx, yy, zz);
                    }
                }
            }
            for (int row = 0; row < dgvRules.Rows.Count; row++)
            {
                for (int column = 0; column < dgvRules.Columns.Count; column++)
                    if (dgvRules.Rows[row].Cells[column].Value == null)
                    {
                        MessageBox.Show($"[{row},{column}]is not defined.");
                        return;
                    }
            }

            for (int row = 0; row < dgvCondition.Rows.Count; row++)
            {
                if (dgvRules.Rows[0].Cells[row].Value == null)
                {
                    MessageBox.Show($"[0,{row}]is not defined.");
                    return;
                }
            }
        }

        private void MSTInference_Changed(object sender, EventArgs e)
        {
            if (rdoMamdani.Checked)
            {
                tabControl.TabPages.Remove(OutputEquations);  //remove page of output equation
                btnInference.Enabled = true;
                btnCrispCrispOutInferencing.Enabled = true;
                dgvCondition.Enabled = true;
                rbnCut.Enabled = true;
                rbnScale.Enabled = true;
                ResolutionValue.Enabled = true;
                rbnCOA.Enabled = true;
                rbnBOA.Enabled = true;
                rbnMOM.Enabled = true;
                rbnLOM.Enabled = true;
                rbnSOM.Enabled = true;
                rbnCut.Visible = true;
                rbnScale.Visible = true;
                rbnAverage.Visible = false;
                rbnSum.Visible = false;
                cut_rb.Enabled = true;
                cut_sc.Enabled = true;
                DeleteGrayArea.Enabled = false;
                if (thetree.Nodes[1].Nodes.Count > 0)
                {
                    if (thetree.Nodes[1].Nodes[0].Nodes.Count > 0)
                    {
                        if (thetree.Nodes[1].Nodes[0].Nodes[0].Text == "0 : Y = 0.1 X + 6.4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "1 : Y = -0.5 X + 4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "2 : Y = X - 2" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "3 : Z = -X + Y + 1" ||
                        thetree.Nodes[1].Nodes[0].Nodes[0].Text == "4 : Z = -Y + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "5 : Z = -X + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "6 : Z = X + Y + 2")
                        {
                            thetree.Nodes[1].Nodes[0].Nodes[0].Remove();
                        }
                        else
                        {
                            for (int i = 0; i < thetree.Nodes[1].Nodes.Count; i++)
                            {
                                foreach (TreeNode node in thetree.Nodes[1].Nodes[i].Nodes) // select the node's subnodes
                                {
                                    Series f = ((FuzzySet)node.Tag).TheSeries; // select its Series
                                    Mainchart.Series.Remove(f);
                                }
                                ChartArea u = ((Universe)thetree.Nodes[1].Nodes[i].Tag).TheArea; // select its chartarea
                                Mainchart.ChartAreas.Remove(u);
                                thetree.Nodes[1].Nodes[i].Remove();
                            }
                        }
                        for (int i = 0; i < dgvRules.RowCount; i++)
                        {
                            //remove rule output cell
                            dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Tag = null;
                            dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Value = null;
                        }
                    }
                }
            }
            else if (rdoSugeno.Checked)
            {
                tabControl.TabPages.Insert(1, OutputEquations);
                btnInference.Enabled = false;
                btnCrispCrispOutInferencing.Enabled = true;
                DeleteGrayArea.Enabled = false;
                dgvCondition.Enabled = false;
                rbnCut.Enabled = false;
                rbnScale.Enabled = false;
                ResolutionValue.Enabled = false;
                rbnCOA.Enabled = false;
                rbnBOA.Enabled = false;
                rbnMOM.Enabled = false;
                rbnLOM.Enabled = false;
                rbnSOM.Enabled = false;
                rbnCut.Visible = false;
                rbnScale.Visible = false;
                rbnAverage.Visible = true;
                rbnSum.Visible = true;
                cut_rb.Enabled = false;
                cut_sc.Enabled = false;
                rbnAverage.Checked = true;

                if (thetree.Nodes[1].Nodes.Count > 0)
                {
                    if (thetree.Nodes[1].Nodes[0].Nodes.Count > 0)
                    {
                        for (int i = 0; i < thetree.Nodes[1].Nodes.Count; i++)
                        {
                            foreach (TreeNode node in thetree.Nodes[1].Nodes[i].Nodes) // select the node's subnodes
                            {
                                Series f = ((FuzzySet)node.Tag).TheSeries; // select its Series
                                Mainchart.Series.Remove(f);
                                node.Remove();
                            }     
                            
                        }
                    }
                    for (int i = 0; i < dgvRules.RowCount; i++)
                    {
                        //remove rule output cell
                        dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Tag = null;
                        dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Value = null;
                    }
                }
            }
            else if (rdoTsukamoto.Checked)
            {
                tabControl.TabPages.Remove(OutputEquations);
                btnInference.Enabled = false;
                btnCrispCrispOutInferencing.Enabled = true;
                DeleteGrayArea.Enabled = false;
                dgvCondition.Enabled = false;
                rbnCut.Enabled = false;
                rbnScale.Enabled = false;
                ResolutionValue.Enabled = false;
                rbnCOA.Enabled = false;
                rbnBOA.Enabled = false;
                rbnMOM.Enabled = false;
                rbnLOM.Enabled = false;
                rbnSOM.Enabled = false;
                rbnCut.Visible = false;
                rbnScale.Visible = false;
                rbnAverage.Visible = true;
                rbnSum.Visible = true;
                cut_rb.Enabled = false;
                cut_sc.Enabled = false;
                rbnAverage.Checked = true;
                if (thetree.Nodes[1].Nodes.Count > 0)
                {
                    if (thetree.Nodes[1].Nodes[0].Nodes.Count > 0)
                    {
                        if (thetree.Nodes[1].Nodes[0].Nodes[0].Text == "0 : Y = 0.1 X + 6.4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "1 : Y = -0.5 X + 4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "2 : Y = X - 2" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "3 : Z = -X + Y + 1" ||
                        thetree.Nodes[1].Nodes[0].Nodes[0].Text == "4 : Z = -Y + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "5 : Z = -X + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "6 : Z = X + Y + 2")
                        {
                            thetree.Nodes[1].Nodes[0].Nodes[0].Remove();
                        }
                        else
                        {
                            for (int i = 0; i < thetree.Nodes[1].Nodes.Count; i++)
                            {
                                foreach (TreeNode node in thetree.Nodes[1].Nodes[i].Nodes) // select the node's subnodes
                                {
                                    if (thetree.Nodes[1].Nodes[0].Nodes[0].Text == "0 : Y = 0.1 X + 6.4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "1 : Y = -0.5 X + 4" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "2 : Y = X - 2" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "3 : Z = -X + Y + 1" ||
                                         thetree.Nodes[1].Nodes[0].Nodes[0].Text == "4 : Z = -Y + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "5 : Z = -X + 3" || thetree.Nodes[1].Nodes[0].Nodes[0].Text == "6 : Z = X + Y + 2")
                                    {
                                        thetree.Nodes[1].Nodes[0].Nodes[0].Remove();
                                    }
                                    else
                                    {
                                        Series f = ((FuzzySet)node.Tag).TheSeries; // select its Series
                                        Mainchart.Series.Remove(f);
                                        node.Remove();
                                    }                                    
                                }
                            }
                        }
                        for (int i = 0; i < dgvRules.RowCount; i++)
                        {
                            //remove rule output cell
                            dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Tag = null;
                            dgvRules.Rows[i].Cells[dgvRules.Columns.Count - 1].Value = null;
                        }
                    }
                }
            }
        }

        private void DefuzzificationType(object sender, EventArgs e)
        {
            if (rbnCOA.Checked) mamdani.Defuzzification = DeFuzzificationType.COA;
            else if (rbnBOA.Checked) mamdani.Defuzzification = DeFuzzificationType.BOA;
            else if (rbnMOM.Checked) mamdani.Defuzzification = DeFuzzificationType.MOM;
            else if (rbnSOM.Checked) mamdani.Defuzzification = DeFuzzificationType.SOM;
            else if (rbnLOM.Checked) mamdani.Defuzzification = DeFuzzificationType.LOM;
        }

        private void AddEquations_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode.Level == 1)
            {
                // Output universe is selected
                if (thetree.SelectedNode == null) return;
                if (thetree.SelectedNode.Level != 1) return;
                if (SugenoFormula.SelectedItem == null) return;

                if (thetree.Nodes[0].Nodes.Count == 1)
                    if (SugenoFormula.SelectedIndex != 0 && SugenoFormula.SelectedIndex != 1 && SugenoFormula.SelectedIndex != 2)
                    {
                        MessageBox.Show("The selected equation need two inputs!");
                        return;
                    }

                if (thetree.Nodes[0].Nodes.Count == 2)
                    if (SugenoFormula.SelectedIndex != 3 && SugenoFormula.SelectedIndex != 4 && SugenoFormula.SelectedIndex != 5 && SugenoFormula.SelectedIndex != 6)
                    {
                        MessageBox.Show("The selected equation just need one input!");
                        return;
                    }
                string NodeName = null;
                switch (SugenoFormula.SelectedIndex)
                {
                    case 0: // Y=0.1X+6.4
                        NodeName = Convert.ToString(SugenoFormula.Items[0]);
                        break;
                    case 1: // Y=-0.5X+4
                        NodeName = Convert.ToString(SugenoFormula.Items[1]);
                        break;
                    case 2: // Y=X-2
                        NodeName = Convert.ToString(SugenoFormula.Items[2]);
                        break;
                    case 3: // Z=-X+Y+1
                        NodeName = Convert.ToString(SugenoFormula.Items[3]);
                        break;
                    case 4: // Z=-Y+3
                        NodeName = Convert.ToString(SugenoFormula.Items[4]);
                        break;
                    case 5: // Z=-X+3
                        NodeName = Convert.ToString(SugenoFormula.Items[5]);
                        break;
                    case 6: // Y=X+Y+2
                        NodeName = Convert.ToString(SugenoFormula.Items[6]);
                        break;
                }
                TreeNode cNode = new TreeNode(NodeName);
                cNode.Tag = SugenoFormula.SelectedIndex;
                thetree.SelectedNode.Nodes.Add(cNode);
                thetree.SelectedNode = cNode;
                thetree.ExpandAll();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DialogResult ans = dlgSave.ShowDialog();
            if (ans != DialogResult.OK) return; 
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            if (rdoMamdani.Checked) sw.WriteLine($"Model:Mamdani");
            else if (rdoSugeno.Checked) sw.WriteLine($"Model:Sugeno");
            else sw.WriteLine($"Model:Tsukamoto");
            // traverse treeview
            int numUniverse = thetree.Nodes[0].Nodes.Count;
            sw.WriteLine($"NumberOfInputUniverse:{numUniverse}");
            TreeNode univNode;
            Universe univ;
            int numFSs;
            TreeNode fsNode;
            FuzzySet fs;
            for (int i = 0; i < numUniverse; i++)
            {
                univNode = thetree.Nodes[0].Nodes[i];
                univ = (Universe)univNode.Tag;
                univ.SaveFile(sw);

                // report included fuzzy sets
                numFSs = univNode.Nodes.Count;
                sw.WriteLine($"NumberOfFSs:{numFSs}");
                for (int j = 0; j < numFSs; j++)
                {
                    fsNode = univNode.Nodes[j];
                    fs = (FuzzySet)fsNode.Tag;
                    fs.SaveFile(sw);
                }
            }
            // output universe
            sw.WriteLine($"NumberOfInputUniverse:1 ");
            univNode = thetree.Nodes[1].Nodes[0];
            univ = (Universe)univNode.Tag;
            univ.SaveFile(sw);

            // report included fuzzy sets
            numFSs = univNode.Nodes.Count;
            sw.WriteLine($"NumberOfFSs:{numFSs}");
            for (int j = 0; j < numFSs; j++)
            {
                fsNode = univNode.Nodes[j];
                if (rdoSugeno.Checked) 
                {
                    sw.WriteLine($"OriginHashCode:{univNode.Nodes[j].GetHashCode()}");
                    sw.WriteLine($"Title:{fsNode.Text}");
                }
                else
                {
                    fs = (FuzzySet)fsNode.Tag;
                    fs.SaveFile(sw);
                }
            }

            // rule datagridview
            sw.WriteLine($"NumberOfRows:{this.dgvRules.Rows.Count}");
            sw.WriteLine($"NumberOfCols:{this.dgvRules.Columns.Count}");
            foreach (DataGridViewRow dgvr in dgvRules.Rows)
            {
                foreach (DataGridViewCell dgvc in dgvr.Cells)
                {
                    if (dgvc.Value is FuzzySet)
                        sw.WriteLine($"FuzzySetHash:{dgvc.Value.GetHashCode()}");
                    else
                        sw.WriteLine($"EquationID:{dgvc.Value}");
                }
            }
            sw.Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            // dgvRules ColumnAdded
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;

            // unsubscribe columnAdded event
            // dgvRules.ColumnAdded += dgvRules_ColumnAdded;

            string[] items;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            items = sr.ReadLine().Split(':');
            switch (items[1])
            {
                case "Mamdani":
                    rdoMamdani.Checked = true;
                    break;
                case "Sugeno":
                    rdoSugeno.Checked = true;
                    break;
                default:
                    rdoTsukamoto.Checked = true;
                    break;
            }
            // setup tree view
            thetree.Nodes[0].Nodes.Clear();
            thetree.Nodes[1].Nodes.Clear();
            Mainchart.Series.Clear();
            Mainchart.ChartAreas.Clear();
            Mainchart.Legends.Clear();
            Mainchart.Annotations.Clear();

            items = sr.ReadLine().Split(':');
            int numInputUniverse = Convert.ToInt32(items[1]);
            int numFSs;
            TreeNode fsNode;
            FuzzySet fs = null;
            TreeNode univNode;
            Universe univ;
            Dictionary<int, FuzzySet> codeVsFS = new Dictionary<int, FuzzySet>();
            int hash;
            for (int i = 0; i < numInputUniverse; i++)
            {
                univNode = new TreeNode();
                univ = new Universe(this.Mainchart);
                univNode.Tag = univ;
                univ.ReadFile(sr);
                univNode.Text = univ.Title;
                thetree.Nodes[0].Nodes.Add(univNode);

                // deal with included fss
                //sw.WriteLine($"FuzzySetType:{this.GetType().Name}");
                //sw.WriteLine($"OriginHashCode:{this.GetHashCode()}");

                items = sr.ReadLine().Split(':');
                numFSs = Convert.ToInt32(items[1]);
                for (int j = 0; j < numFSs; j++)
                {
                    fsNode = new TreeNode();
                    items = sr.ReadLine().Split(':'); // get fuzzy set type
                    switch (items[1])
                    {
                        case "GaussianFuzzySet":
                            fs = new GaussianFuzzySet(univ);
                            break;
                        case "TriangularFuzzySet":
                            fs = new TriangularFuzzySet(univ);
                            break;
                        case "BellFuzzySet":
                            fs = new BellFuzzySet(univ);
                            break;
                        case "TrapezoidalFuzzySet":
                            fs = new TrapezoidalFuzzySet(univ);
                            break;
                        case "SigmoidalFuzzySet":
                            fs = new SigmoidalFuzzySet(univ);
                            break;
                        case "LeftrightFuzzySet":
                            fs = new LeftrightFuzzySet(univ);
                            break;
                        case "S_ShapedFuzzySet":
                            fs = new S_ShapedFuzzySet(univ);
                            break;
                        case "Z_ShapedFuzzySet":
                            fs = new Z_ShapedFuzzySet(univ);
                            break;
                        case "Pi_ShapedFuzzySet":
                            fs = new Pi_ShapedFuzzySet(univ);
                            break;
                        case "StepUpFuzzySet":
                            fs = new StepUpFuzzySet(univ);
                            break;
                        case "StepDownFuzzySet":
                            fs = new StepDownFuzzySet(univ);
                            break;
                        case "TwoSideGaussianFussySet":
                            fs = new TwoSideGaussianFussySet(univ);
                            break;
                        case "TwoSidePi_ShapedFuzzySet":
                            fs = new TwoSidePi_ShapedFuzzySet(univ);
                            break;
                        case "UnaryOperatedFuzzySet":
                            FuzzySet target;
                            UnaryFSOperator op = null;
                            // sw.WriteLine($"OperatorType:{this.GetType().Name}");
                            items = sr.ReadLine().Split(':'); // get operator type
                            switch (items[1])
                            {
                                case "ValueCutOperator":
                                    op = new ValueCutOperator();
                                    break;
                                case "NegateOperator":
                                    op = new NegateOperator();
                                    break;
                            }
                            op.ReadFile(sr);
                            // get hash code of target FS
                            items = sr.ReadLine().Split(':'); // get operator type
                            int hashCode = Convert.ToInt32(items[1]);
                            target = codeVsFS[hashCode];
                            fs = new UnaryOperatedFuzzySet(target, op);
                            break;
                    }
                    items = sr.ReadLine().Split(':'); // get fuzzy set hash
                    hash = Convert.ToInt32(items[1]);
                    codeVsFS.Add(hash, fs);
                    // let fs read its data
                    fsNode.Tag = fs;
                    fs.ReadFile(sr);
                    fsNode.Text = fs.ToString();
                    univNode.Nodes.Add(fsNode);
                    fs.ShowSeries = true;
                }
            }
            items = sr.ReadLine().Split(':');
            univNode = new TreeNode();
            univ = new Universe(this.Mainchart);
            univNode.Tag = univ;
            univ.ReadFile(sr);
            univNode.Text = univ.Title;
            thetree.Nodes[1].Nodes.Add(univNode);
            items = sr.ReadLine().Split(':');
            numFSs = Convert.ToInt32(items[1]);
            for (int j = 0; j < numFSs; j++)
            {
                fsNode = new TreeNode();
                items = sr.ReadLine().Split(':'); // get fuzzy set type
                switch (items[1])
                {
                    case "GaussianFuzzySet":
                        fs = new GaussianFuzzySet(univ);
                        break;
                    case "TriangularFuzzySet":
                        fs = new TriangularFuzzySet(univ);
                        break;
                    case "BellFuzzySet":
                        fs = new BellFuzzySet(univ);
                        break;
                    case "TrapezoidalFuzzySet":
                        fs = new TrapezoidalFuzzySet(univ);
                        break;
                    case "SigmoidalFuzzySet":
                        fs = new SigmoidalFuzzySet(univ);
                        break;
                    case "LeftrightFuzzySet":
                        fs = new LeftrightFuzzySet(univ);
                        break;
                    case "S_ShapedFuzzySet":
                        fs = new S_ShapedFuzzySet(univ);
                        break;
                    case "Z_ShapedFuzzySet":
                        fs = new Z_ShapedFuzzySet(univ);
                        break;
                    case "Pi_ShapedFuzzySet":
                        fs = new Pi_ShapedFuzzySet(univ);
                        break;
                    case "StepUpFuzzySet":
                        fs = new StepUpFuzzySet(univ);
                        break;
                    case "StepDownFuzzySet":
                        fs = new StepDownFuzzySet(univ);
                        break;
                    case "TwoSideGaussianFussySet":
                        fs = new TwoSideGaussianFussySet(univ);
                        break;
                    case "TwoSidePi_ShapedFuzzySet":
                        fs = new TwoSidePi_ShapedFuzzySet(univ);
                        break;
                }
                items = sr.ReadLine().Split(':'); // get fuzzy set hash
                if (rdoSugeno.Checked)
                {
                    hash = Convert.ToInt32(items[1]);
                    fsNode.Tag = hash;
                    fsNode.Text = items[1] + "_" + items[2];
                    univNode.Nodes.Add(fsNode);
                }
                else
                {
                    hash = Convert.ToInt32(items[1]);
                    codeVsFS.Add(hash, fs);
                    // let fs read its data
                    fsNode.Tag = fs;
                    fs.ReadFile(sr);
                    fsNode.Text = fs.ToString();
                    univNode.Nodes.Add(fsNode);
                    fs.ShowSeries = true;
                }
            }

            // Read in Rules
            this.dgvRules.Rows.Clear();
            this.dgvRules.Columns.Clear();
            foreach (TreeNode tn in thetree.Nodes[0].Nodes)
                this.dgvRules.Columns.Add(tn.Text, tn.Text);
            this.dgvRules.Columns.Add(thetree.Nodes[1].Nodes[0].Text, thetree.Nodes[1].Nodes[0].Text);
            int rows, cols;
            items = sr.ReadLine().Split(':'); // get fuzzy set hash
            rows = Convert.ToInt32(items[1]);
            items = sr.ReadLine().Split(':'); // get fuzzy set hash
            cols = Convert.ToInt32(items[1]);
            int code;
            for (int r = 0; r < rows; r++)
            {
                dgvRules.Rows.Add();
                for (int c = 0; c < cols; c++)
                {
                    items = sr.ReadLine().Split(':'); // get fuzzy set hash
                    if (items[0] == "FuzzySetHash")
                    {
                        code = Convert.ToInt32(items[1]);
                        dgvRules.Rows[r].Cells[c].Value = codeVsFS[code];
                    }
                    else
                    {
                        dgvRules.Rows[r].Cells[c].Value = Convert.ToInt32(items[1]);
                    }
                }
            }
            thetree.ExpandAll();
            sr.Close();
            if (thetree.Nodes[0].Nodes.Count == 1)
            {
                Chart_1D.Visible = true;
                threeDplot.Visible = false;
                text1Dand2D.Visible = true;
                text1Dand2D.Text = "1D I/O Map";
            }
            else if (thetree.Nodes[0].Nodes.Count == 2)
            {
                Chart_1D.Visible = false;
                threeDplot.Visible = true;
                text1Dand2D.Visible = true;
                text1Dand2D.Text = "2D I/O Map";
            }
            else
            {
                Chart_1D.Visible = false;
                threeDplot.Visible = false;
                text1Dand2D.Visible = false;
            }
            if (rdoMamdani.Checked)
            {
                rbnCut.Visible = true;
                rbnScale.Visible = true;
                rbnAverage.Visible = false;
                rbnCut.Checked = true;
                rbnSum.Visible = false;
                rbnBOA.Enabled = true;
                rbnCOA.Enabled = true;
                rbnLOM.Enabled = true;
                rbnMOM.Enabled = true;
                rbnSOM.Enabled = true;
            }
            else
            {
                rbnCut.Visible = false;
                rbnScale.Visible = false;
                rbnAverage.Visible = true;
                rbnAverage.Checked = true;
                rbnSum.Visible = true;
                rbnBOA.Enabled = false;
                rbnCOA.Enabled = false;
                rbnLOM.Enabled = false;
                rbnMOM.Enabled = false;
                rbnSOM.Enabled = false;
            }
            // unsubscribe columnAdded event
            //dgvRules.ColumnAdded += dgvRules_ColumnAdded;
        }
    }
}