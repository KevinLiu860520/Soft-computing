using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R08546002YCLiuAss06
{
    public enum DeFuzzificationType {COA, BOA, MOM, SOM, LOM}
    public interface IFuzzyInferencing
    {
        void ConstructSystem(DataGridView dgv);
        double CrispInCrispOutInferencing(double[] conditions);
    }
    class MamdaniFuzzySystem : IFuzzyInferencing
    {
        MamdaniIfThenFuzzyRule[] rules;
        DeFuzzificationType defuzzification = DeFuzzificationType.COA;
        public bool ISCut { get; set; } = true;
        public DeFuzzificationType Defuzzification { get => defuzzification; set => defuzzification = value; }

        public void ConstructSystem(DataGridView dgv)
        {
            rules = new MamdaniIfThenFuzzyRule[dgv.Rows.Count];
            FuzzySet output;
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgv.Columns.Count - 1];
                for (int c = 0; c < dgv.Columns.Count - 1; c++)
                {
                    inputs[c] = (FuzzySet)dgv.Rows[r].Cells[c].Value;
                }
                output = (FuzzySet)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value;
                rules[r] = new MamdaniIfThenFuzzyRule(inputs, output);
            }
        }
        public double CrispInCrispOutInferencing(double[] conditions)
        {
            FuzzySet resultFS = null;
            foreach (MamdaniIfThenFuzzyRule ifr in rules)
            {
                if(resultFS == null)
                   resultFS = ifr.CrispInFuzzyOutInferencing(conditions,ISCut);
                else
                    resultFS = resultFS | ifr.CrispInFuzzyOutInferencing(conditions,ISCut);
            }
            switch(defuzzification)
            {
                case DeFuzzificationType.BOA:
                    return resultFS.BOACrispValue;
                case DeFuzzificationType.MOM:
                    return resultFS.MOMCrispValue;
                case DeFuzzificationType.SOM:
                    return resultFS.SOMCrispValue;
                case DeFuzzificationType.LOM:
                    return resultFS.LOMCrispValue;
                default:
                    return resultFS.COACrispValue;
            }
        }
    }
    class SugenoFuzzySystem : IFuzzyInferencing
    {
        SugenoIfThenRule[] rules;
        public bool ISAverage { get; set; } = true;
        public void ConstructSystem(DataGridView dgv)
        {
            rules = new SugenoIfThenRule[dgv.Rows.Count];
            int output;
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                FuzzySet[] inputs = new FuzzySet[dgv.Columns.Count - 1];
                for (int c = 0; c < dgv.Columns.Count - 1; c++)
                {
                    inputs[c] = (FuzzySet)dgv.Rows[r].Cells[c].Value;
                }
                output = (int)dgv.Rows[r].Cells[dgv.Columns.Count - 1].Value;
                rules[r] = new SugenoIfThenRule(inputs, output);
            }
        }

        public double CrispInCrispOutInferencing(double[] conditions)
        {
            double StrengthSum = 0, OutputSum = 0;

            for (int i = 0; i < rules.Length; i++)
            {
                double output = rules[i].FuzzyInFuzzyOutInferencing(conditions, out double strength);
                StrengthSum += strength;
                OutputSum += output;
            }
            if (ISAverage) return OutputSum / StrengthSum;
            else return OutputSum;
        }
    }
    class TsukamotoFuzzySystem : IFuzzyInferencing
    {
        MamdaniIfThenFuzzyRule[] rules;
        public bool IsWeightedAverage { get; set; } = false;

        public void ConstructSystem(DataGridView dgv)
        {
            throw new NotImplementedException();
        }

        public double CrispInCrispOutInferencing(double[] conditions)
        {
            throw new NotImplementedException();
            //if (IsWeightedAverage)
            //    else
        }
    }
}
