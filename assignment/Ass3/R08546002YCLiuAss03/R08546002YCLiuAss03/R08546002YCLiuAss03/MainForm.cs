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

namespace R08546002YCLiuAss03
{
    public partial class MainForm : Form // inherit Form
    {
        public MainForm()
        {
            InitializeComponent();
            FunctionSelection.SelectedIndex = 0; // show Gaussion Function to be selected
        }

        private void thetree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            thegrid.SelectedObject = thetree.SelectedNode.Tag;  // show fuzzyset in the grid which be selected
        }
        private void btnCreateFuzzySet_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode == null) // if thetree is empty show below messagebox and return or will show error
                MessageBox.Show("You should create universal first!!");
            if (thetree.SelectedNode == null) return; 
            if (thetree.SelectedNode.Level != 0) return;  // we select Universal (Level 0) to create fuzzy set
            FuzzySet aFS = null; // set aFS == null
            Universe selecteU;
            if(thetree.SelectedNode.Tag is Universe) // if thetree you choose is universe
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
                }
                // Add a subnode to selected node 
                TreeNode cNode = new TreeNode(aFS.Title); // treenode title = FunctionName + count
                cNode.Tag = aFS;
                thetree.SelectedNode.Nodes.Add(cNode);

                aFS.ShowSeriers = true;
              
                thetree.ExpandAll(); // expand tree
                thetree.Focus(); // focus on universal, you can create fuzzyset continously.
            }   
        }

        private void thegrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // This is I try to change the thetree tag name, however, 
            // below code are not error but I cannot use it in my form  
            if (thetree.SelectedNode.Level == 0) // if select Universal Level 
                thetree.SelectedNode.Text = ((Universe)thetree.SelectedNode.Tag).Title; // change name which you tag in grid'title and thetree text in the meantime

            else if (thetree.SelectedNode.Level == 1) // if select Fuzzy Level
                thetree.SelectedNode.Text = ((FuzzySet)thetree.SelectedNode.Tag).Title;
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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUniversal_Click(object sender, EventArgs e)
        {
            if (thetree.SelectedNode == null) // thetree is empty show below messageBox
            {
                MessageBox.Show("There are nothing can be deleted !!");
            }
            else
            {
                int subnode = thetree.SelectedNode.GetNodeCount(true);
                if (thetree.Nodes.Count == 1 && subnode > 0) 
                // because I delete the last one and create it will show the previous one result
                // so I set this setting to let user delete fuzzyset first and the delete universal
                {
                    MessageBox.Show("You have to delete all fuzzy set and then you can delete this universal!!");
                    return;
                }
                else if (thetree.SelectedNode.Level == 0) // if you select universal
                {    
                    ChartArea u = ((Universe)thetree.SelectedNode.Tag).TheArea; // select its chartarea
                    Mainchart.ChartAreas.Remove(u); // delete the charearea                 
                }
                else if (thetree.SelectedNode.Level == 1) // if you select fuzzyset
                {
                    Series f = ((FuzzySet)thetree.SelectedNode.Tag).TheSeries; // select its Series
                    Mainchart.Series.Remove(f); // delete the series in chart
                }
                thetree.Nodes.Remove(thetree.SelectedNode); // delete which you select ub thetree

            }
        }
    }
}
