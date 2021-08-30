using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R08546002YCLiuAss05
{
    public partial class MainForm : Form // inherit Form
    {

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
                if (SelectedSeries != null)
                {
                    SelectedSeries.BorderWidth = 2;
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

            }
            if (thetree.SelectedNode.Level == 2)  //fuzzy set level = 2
            {
                thetree.SelectedNode.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                ChosenInput.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
                btnCreateUniverse.Enabled = false;
                btnAddrule.Enabled = true;
                FunctionSelectGroup.Enabled = false;
                Delete.Enabled = true;
                UnarySelectGroup.Enabled = true;
                //Series have somthing
                if (((FuzzySet)thetree.SelectedNode.Tag).TheSeries != null)  //Series cannot be null
                {
                    if (SelectedSeries != null)  //previou line initialize
                    {
                        SelectedSeries.BorderWidth = 1;
                    }
                    ((FuzzySet)thetree.SelectedNode.Tag).TheSeries.BorderWidth = 8; // selectednode's line get width
                    SelectedSeries = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries;  //above series be highlight
                }
            }
        }
        private void thegrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) // change title by selected title
        {
            //selected is a universe
            if (thetree.SelectedNode.Tag is Universe)
            {
                thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                ChosenInput.Text = ((Universe)thetree.SelectedNode.Tag).Title;
                //rules and condition colomns name changed
                dgvRules.Columns[thetree.SelectedNode.Index].HeaderText = ((Universe)thetree.SelectedNode.Tag).Title;
                dgvCondition.Columns[thetree.SelectedNode.Index].HeaderText = ((Universe)thetree.SelectedNode.Tag).Title;
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
                    case 9: // two-side Gaussian
                        aFS = new TwoSideGaussianFussySet(selecteU);
                        break;
                    case 10: // two-side Pi
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
                }

                // add columns two data grid views
                //DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                //col.Tag = uobj;
                //dgvRules.Columns.Add(col);
                //dgvRules.Columns.Add(uobj.Title, uobj.Title);
                //dgvCondition.Columns.Add(uobj.Title, uobj.Title);
                //if (dgvCondition.Rows.Count < 1) dgvCondition.Rows.Add();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode.Level == 1) // if you select universal
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
            else if (thetree.SelectedNode.Level == 2) // if you select fuzzyset
            {
                Series f = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries; // select its Series
                Mainchart.Series.Remove(f); // delete the series in chart
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
                        //記得防錯
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

        private void btnInference_Click(object sender, EventArgs e)
        {
            // create if-then rules
            IfThenFuzzyRule[] allRules = new IfThenFuzzyRule[dgvRules.Rows.Count];
            FuzzySet output;
            for (int r = 0; r < dgvRules.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgvRules.Columns.Count - 1];
                for (int c = 0; c < dgvRules.Columns.Count - 1; c++)
                {
                    inputs[c] = (FuzzySet)dgvRules.Rows[r].Cells[c].Value;
                }
                output = (FuzzySet)dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value;
                allRules[r] = new IfThenFuzzyRule(inputs, output);
            }
            // condition
            FuzzySet[] conditions = new FuzzySet[dgvCondition.Columns.Count];
            for (int i = 0; i < dgvCondition.Columns.Count; i++)
            {
                conditions[i] = (FuzzySet)dgvCondition.Rows[0].Cells[i].Tag;
            }

            // set contents of conditions
            FuzzySet resultingFS = null;
            foreach (IfThenFuzzyRule rule in allRules)
            {
                if (resultingFS == null)
                {
                    resultingFS = rule.FuzzyInFuzzyOutInferencing(conditions);
                }
                else
                {
                    resultingFS = resultingFS | rule.FuzzyInFuzzyOutInferencing(conditions); // 用|聯集起來
                }
                // show the final fs
                resultingFS.ShowSeries = true;
                resultingFS.TheChartType = SeriesChartType.Area;
                resultingFS.TheSeries.Color = Color.DarkGray;
            }
            
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
    }  
}

