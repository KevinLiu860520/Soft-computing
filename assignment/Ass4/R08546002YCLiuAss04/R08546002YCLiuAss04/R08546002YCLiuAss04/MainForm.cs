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

namespace R08546002YCLiuAss00
{
    public partial class MainForm : Form // inherit Form
    {

        public MainForm() // set initial value to some items
        {
            InitializeComponent();
            FunctionSelection.SelectedIndex = 0; // show Gaussion Function to be selected
            UnaryOperatorSelect.SelectedIndex = 0;
            BinaryTnormOperatorSelect.SelectedIndex = 0;
            BinarySnormOperatorSelect.SelectedIndex = 0;
            Delete.Enabled = false;
            FunctionSelection.Enabled = false;
            btnCreateSnorm.Enabled = false;
            btnCreateTnorm.Enabled = false;
            btnCreateFuzzySet.Enabled = false;
            btnCreateUnaryOperatedFS.Enabled = false;
            UnaryOperatorSelect.Enabled = false;
            BinaryTnormOperatorSelect.Enabled = false;
            BinarySnormOperatorSelect.Enabled = false;
            Tnorm.Enabled = false;
            Snorm.Enabled = false;
        }


        Series SelectedSeries = null; // default the hightline
        private void thetree_AfterSelect(object sender, TreeViewEventArgs e) // something happened after select 
        {
            thegrid.SelectedObject = thetree.SelectedNode.Tag; // show selectednode information to the grid

            if (thetree.SelectedNode.Level != 0) // if selectednode is Fuzzy set, below happened
            {
                btnCreateFuzzySet.Enabled = false;
                FunctionSelection.Enabled = false;
                btnCreateUnaryOperatedFS.Enabled = true;
                UnaryOperatorSelect.Enabled = true;
            }
            else // if selectednode is Universe, below happened
            {
                btnCreateFuzzySet.Enabled = true;
                FunctionSelection.Enabled = true;
                btnCreateUnaryOperatedFS.Enabled = false;
                btnCreateSnorm.Enabled = false;
                btnCreateTnorm.Enabled = false;
                BinaryTnormOperatorSelect.Enabled = false;
                UnaryOperatorSelect.Enabled = false;
                Tnorm.Enabled = false;
                Snorm.Enabled = false;
            }

            if (thetree.SelectedNode.Level == 1)  //fuzzy set level = 1
            {
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
            if (thetree.SelectedNode.Level == 0)
            {
                thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title;
            }
            else if (thetree.SelectedNode.Level == 1)
            {
                thetree.SelectedNode.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
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
                aFS.ShowSeriers = true;

                thetree.ExpandAll(); // expand tree
                thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            }
            thetree_AfterSelect(null, null); // enforce execute
        }

        private void btnCreateUniverse_Click(object sender, EventArgs e)
        {
            Universe uobj;
            uobj = new Universe(Mainchart); //set local variable
            // uobj.Title = "XXXXX";
            // Add a node  to treeview
            TreeNode aNode = new TreeNode(uobj.Title);
            aNode.Tag = uobj;
            thetree.Nodes.Add(aNode); // add another universe
            thetree.SelectedNode = aNode;
            thegrid.SelectedObject = uobj;
            thetree.Focus();
            Delete.Enabled = true;
            btnCreateFuzzySet.Enabled = true;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode.Level == 0) // if you select universal
            {
                foreach (TreeNode node in thetree.SelectedNode.Nodes) // select the node's subnodes
                {
                    Series f = ((FuzzySet)node.Tag).TheSeries; // select its Series
                    Mainchart.Series.Remove(f);
                }
                ChartArea u = ((Universe)thetree.SelectedNode.Tag).TheArea; // select its chartarea
                Mainchart.ChartAreas.Remove(u);
            }
            else if (thetree.SelectedNode.Level == 1) // if you select fuzzyset
            {
                Series f = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries; // select its Series
                Mainchart.Series.Remove(f); // delete the series in chart
            }
            thetree.Nodes.Remove(thetree.SelectedNode); // delete which you select ub thetree
            if (thetree.SelectedNode == null)
            {
                Delete.Enabled = false;
                btnCreateFuzzySet.Enabled = false;
                FunctionSelection.Enabled = false;
                BinaryTnormOperatorSelect.Enabled = false;
                BinarySnormOperatorSelect.Enabled = false;
                btnCreateTnorm.Enabled = false;
                btnCreateSnorm.Enabled = false;
                Tnorm.Enabled = false;
                Snorm.Enabled = false;
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
            newFs.ShowSeriers = true;

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
        private void Tnorm_CheckedChanged_1(object sender, EventArgs e)// state and change when choose T-norm or not
        {
            if (Tnorm.Checked == true)
            {
                BinaryTnormOperatorSelect.Enabled = true;
                BinarySnormOperatorSelect.Enabled = false;
                Snorm.Checked = false;
                Snorm.ForeColor = Color.DimGray;
                btnCreateTnorm.Enabled = true;
                btnCreateSnorm.Enabled = false;
            }
            else
            {
                if (Snorm.Checked == true)
                {
                    BinaryTnormOperatorSelect.Enabled = false;
                    BinarySnormOperatorSelect.Enabled = true;
                    Snorm.ForeColor = Color.Black;
                    Tnorm.Checked = false;
                    Tnorm.ForeColor = Color.DimGray;
                    btnCreateTnorm.Enabled = false;
                    btnCreateSnorm.Enabled = true;
                }
                else
                {
                    Tnorm.ForeColor = Color.Black;
                    Snorm.ForeColor = Color.Black;
                    btnCreateTnorm.Enabled = false;
                    btnCreateSnorm.Enabled = false;
                    BinaryTnormOperatorSelect.Enabled = false;
                    BinarySnormOperatorSelect.Enabled = false;
                }
            }
        }
        private void Snorm_CheckedChanged_1(object sender, EventArgs e)// state and change when choose S-norm or not
        {
            if (Snorm.Checked == true)
            {
                BinaryTnormOperatorSelect.Enabled = false;
                BinarySnormOperatorSelect.Enabled = true;
                Tnorm.Checked = false;
                Tnorm.ForeColor = Color.DimGray;
                btnCreateTnorm.Enabled = false;
                btnCreateSnorm.Enabled = true;
            }
            else
            {
                if (Tnorm.Checked == true)
                {
                    BinaryTnormOperatorSelect.Enabled = true;
                    BinarySnormOperatorSelect.Enabled = false;
                    Tnorm.ForeColor = Color.Black;
                    Snorm.Checked = false;
                    Snorm.ForeColor = Color.DimGray;
                    btnCreateTnorm.Enabled = true;
                    btnCreateSnorm.Enabled = false;
                }
                else
                {
                    Tnorm.ForeColor = Color.Black;
                    Snorm.ForeColor = Color.Black;
                    btnCreateTnorm.Enabled = false;
                    btnCreateSnorm.Enabled = false;
                    BinaryTnormOperatorSelect.Enabled = false;
                    BinarySnormOperatorSelect.Enabled = false;
                }
            }
        }

        private void btnCreateTnorm_Click(object sender, EventArgs e)
        {
            if (!(thetree.SelectedNode.Tag is FuzzySet)) return;
            FuzzySet fs = (FuzzySet)thetree.SelectedNode.Tag;
            FuzzySet First = (FuzzySet)labFirstFS.Tag;
            FuzzySet Second = (FuzzySet)labSecondFS.Tag;
            BinaryFSOperator op = null;
            FuzzySet newFs;
            switch (BinarySnormOperatorSelect.SelectedIndex)
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
                    op = new MaximumOperator();
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
            }
            newFs = new BinaryOperatedFuzzySet(First, Second, op);

            // Add a subnode to selected node 
            TreeNode cNode = new TreeNode(newFs.Title); // treenode title = FunctionName + count
            cNode.Tag = newFs;
            thetree.SelectedNode.Parent.Nodes.Add(cNode);
            thetree.SelectedNode = cNode;
            newFs.ShowSeriers = true;

            thetree.ExpandAll(); // expand tree
            thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            thetree_AfterSelect(null, null);

            labFirstFS.Text = "Click to store First Fuzzy Set";
            labSecondFS.Text = "Click to store Second Fuzzy Set";
            BinarySnormOperatorSelect.Enabled = false;
            btnCreateSnorm.Enabled = false;
            Snorm.Enabled = false;
            BinaryTnormOperatorSelect.Enabled = false;
            btnCreateTnorm.Enabled = false;
            Tnorm.Enabled = false;
            Tnorm.Checked = false;
            labFirstFS.Tag = null;
            labSecondFS.Tag = null;
        }
        private void btnCreateSnorm_Click(object sender, EventArgs e)
        {
            if (!(thetree.SelectedNode.Tag is FuzzySet)) return;
            FuzzySet fs = (FuzzySet)thetree.SelectedNode.Tag;
            FuzzySet First = (FuzzySet)labFirstFS.Tag;
            FuzzySet Second = (FuzzySet)labSecondFS.Tag;
            BinaryFSOperator op = null;
            FuzzySet newFs;

            switch (BinaryTnormOperatorSelect.SelectedIndex)
            {
                case 0:// negate
                       // newFs = !fs;
                    op = new AlgebraicSumOperator();
                    break;
                case 1: // value cut
                        // newFs = -fs;
                    op = new BoundedSumOperator();
                    break;
                case 2:
                    op = new DombiSnormOperator();
                    break;
                case 3:
                    op = new DoubisandPradeSnormOperator();
                    break;
                case 4:
                    op = new DrasticSumOperator();
                    break;
                case 5:
                    op = new EinsteinSumOperator();
                    break;
                case 6:
                    op = new FrankSnormOperator();
                    break;
                case 7:
                    op = new HamacherSumOperator();
                    break;
                case 8:
                    op = new MinimumOperator();
                    break;
                case 9:
                    op = new SugenoSnormOperator();
                    break;
                case 10:
                    op = new YagerSnormOperator();
                    break;
                case 11:
                    op = new SubstractOperator();
                    break;
            }
            newFs = new BinaryOperatedFuzzySet(First, Second, op);

            // Add a subnode to selected node 
            TreeNode cNode = new TreeNode(newFs.Title); // treenode title = FunctionName + count
            cNode.Tag = newFs;
            thetree.SelectedNode.Parent.Nodes.Add(cNode);
            newFs.ShowSeriers = true;
            thetree.SelectedNode = cNode;
            thetree.ExpandAll(); // expand tree
            thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            thetree_AfterSelect(null, null);

            labFirstFS.Text = "Click to store First Fuzzy Set";
            labSecondFS.Text = "Click to store Second Fuzzy Set";
            BinaryTnormOperatorSelect.Enabled = false;
            btnCreateTnorm.Enabled = false;
            Tnorm.Enabled = false;
            BinarySnormOperatorSelect.Enabled = false;
            btnCreateSnorm.Enabled = false;
            Snorm.Enabled = false;
            Snorm.Checked = false;
            labFirstFS.Tag = null;
            labSecondFS.Tag = null;
        }
        private void labFirstFS_TextChanged(object sender, EventArgs e)// if label changed, you can choose what BinaryOperator you would like to create
        {
            if (labFirstFS.Tag != null && labSecondFS.Tag != null)
            {
                Tnorm.Enabled = true;
                Snorm.Enabled = true;
            }
        }

        private void labSecondFS_TextChanged(object sender, EventArgs e)// if label changed, you can choose what BinaryOperator you would like to create
        {
            if (labFirstFS.Tag != null && labSecondFS.Tag != null)
            {
                Tnorm.Enabled = true;
                Snorm.Enabled = true;
            }
        }
    }
}

