using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLibrary
{   
   
    public class PermutationGASolver : GeneticAlgorithm<int>
    {
        public enum CrossoverType { OX, PBX, OBX, CX, SEX, PMX}
        public enum MutationType{Inversion, Insertion, Displacement, ReciprocalExchange,Swap}
        int[] temp1;
        [Category("GA setting"), Description("True is Gene-based, False is Chrmosome-based")]
        public bool GeneBasedMutation { get; set; } = false;
        [Category("Permutation GA setting")]
        public CrossoverType CrossoverOperator { set; get; } = CrossoverType.OX;
        [Category("Permutation GA setting")]
        public MutationType MutationOperator { set; get; } = MutationType.Inversion;
        public PermutationGASolver(int numberOfVaribles, OptimizationType type, ObjectiveFunction<int> theMethod)
            : base(numberOfVaribles,type, theMethod)
        {
            temp1 = new int[numberOfVaribles];
        }
        public override bool InitializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
            {
                for (int c = 0; c < numberOfGenes; c++)
                {
                    chromosomes[r][c] = c;
                }
                ShuffleAnIntegerArray(chromosomes[r], numberOfGenes);  //shuffle
            }         
            return true;
        }
        int pos1, pos2, temp;
        List<int> Father_list = new List<int>();
        List<int> Mother_list = new List<int>();
        List<int> temp_list = new List<int>();
        public override void CrossoverAPairOfChildren(int fatherIdx, int motherIdx, int child1Idx, int child2Idx)
        {
            // assign chromosomes[childIdx], ...   
            switch (CrossoverOperator)
            {
                case CrossoverType.OX:
                    Father_list.Clear();
                    Mother_list.Clear();
                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);
                    do
                    {
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos1 == pos2);
                    //swap pos1, pos2 if pos1 > pos2
                    if (pos1 > pos2)
                    {
                        temp = pos1;
                        pos1 = pos2;
                        pos2 = temp;
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        chromosomes[child1Idx][i] = -1;
                        chromosomes[child2Idx][i] = -1;
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i >= pos1 && i < pos2)
                        {
                            chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                            chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
                            Father_list.Add(chromosomes[fatherIdx][i]);
                            Mother_list.Add(chromosomes[motherIdx][i]);
                        }
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (chromosomes[child1Idx][i] == -1)
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (Father_list.Contains(chromosomes[motherIdx][j])) continue;
                                else
                                {
                                    chromosomes[child1Idx][i] = chromosomes[motherIdx][j];
                                    Father_list.Add(chromosomes[motherIdx][j]);
                                    break;
                                }                              
                            }
                        }

                        if (chromosomes[child2Idx][i] == -1)
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (Mother_list.Contains(chromosomes[fatherIdx][j])) continue;
                                else
                                {
                                    chromosomes[child2Idx][i] = chromosomes[fatherIdx][j];
                                    Mother_list.Add(chromosomes[fatherIdx][j]);
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case CrossoverType.PBX:
                    Father_list.Clear();
                    Mother_list.Clear();
                    temp_list.Clear();

                    int NumOfCrossover = randomizer.Next(1, numberOfGenes);
                    int[] pos = new int[NumOfCrossover];

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        chromosomes[child1Idx][i] = -1;
                        chromosomes[child2Idx][i] = -1;
                    }

                    for (int i = 0; i < NumOfCrossover; i++)
                    {
                        do
                        {
                            pos[i] = randomizer.Next(numberOfGenes);
                        }
                        while (temp1.Contains(pos[i]));
                        temp_list.Add(pos[i]);                        
                    }
                    Array.Sort(pos);
                    for (int i = 0; i < NumOfCrossover; i++)
                    {
                        chromosomes[child1Idx][pos[i]] = chromosomes[fatherIdx][pos[i]];
                        chromosomes[child2Idx][pos[i]] = chromosomes[motherIdx][pos[i]];
                        Father_list.Add(chromosomes[fatherIdx][pos[i]]);
                        Mother_list.Add(chromosomes[motherIdx][pos[i]]);
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (chromosomes[child1Idx][i] == -1)
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (Father_list.Contains(chromosomes[motherIdx][j])) continue;
                                else
                                {
                                    chromosomes[child1Idx][i] = chromosomes[motherIdx][j];
                                    Father_list.Add(chromosomes[motherIdx][j]);
                                    break;
                                }                               
                            }
                        }

                        if (chromosomes[child2Idx][i] == -1)
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (Mother_list.Contains(chromosomes[fatherIdx][j])) continue;
                                else
                                {
                                    chromosomes[child2Idx][i] = chromosomes[fatherIdx][j];
                                    Mother_list.Add(chromosomes[fatherIdx][j]);
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case CrossoverType.OBX:                  
                    Father_list.Clear();
                    Mother_list.Clear();
                    int numberOfCrossover = randomizer.Next(numberOfGenes);
                    int[] geneValues = new int[numberOfCrossover];
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        chromosomes[child1Idx][i] = -1;
                        chromosomes[child2Idx][i] = -1;
                    }
                    for (int i = 0; i < numberOfCrossover; i++)
                    {                     
                        do
                        {
                            geneValues[i] = randomizer.Next(numberOfGenes);
                        }
                        while (Father_list.Contains(geneValues[i]));
                        temp_list.Add(geneValues[i]);                  
                    }
                    outerloop: for (int i = 0; i < numberOfCrossover; i++)
                    {
                        if (temp_list.Contains(chromosomes[motherIdx][i]))
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                for (int k = 0; k < numberOfCrossover; j++)
                                {
                                    if (chromosomes[fatherIdx][j] == geneValues[k])
                                    {
                                        chromosomes[child1Idx][i] = geneValues[k];
                                        goto outerloop;
                                    }
                                }
                            }
                        }
                        else
                        {
                            chromosomes[child1Idx][i] = chromosomes[motherIdx][i];
                            continue;
                        }                          
                    }
                    outerloop1: for (int i = 0; i < numberOfCrossover; i++)
                    {
                        if (temp_list.Contains(chromosomes[fatherIdx][i]))
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                for (int k = 0; k < numberOfCrossover; j++)
                                {
                                    if (chromosomes[motherIdx][j] == geneValues[k])
                                    {
                                        chromosomes[child2Idx][i] = geneValues[k];
                                        goto outerloop1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            chromosomes[child2Idx][i] = chromosomes[fatherIdx][i];
                            continue;
                        }
                    }
                    break;
                case CrossoverType.PMX:
                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);
                    do
                    {
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos1 == pos2) ;
                    //swap pos1, pos2 if pos1 > pos2
                    if (pos1 > pos2)
                    {
                        temp = pos1;
                        pos1 = pos2;
                        pos2 = temp;
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        temp1[i] = -1;
                    }

                    for (int i = pos1; i < pos2; i++)
                    {
                        if (chromosomes[fatherIdx][i] == chromosomes[motherIdx][i]) continue;
                        if (temp1[chromosomes[fatherIdx][i]] == -1 && temp1[chromosomes[motherIdx][i]] == -1)
                        {
                            temp1[chromosomes[fatherIdx][i]] = chromosomes[motherIdx][i];
                            temp1[chromosomes[motherIdx][i]] = chromosomes[fatherIdx][i];
                        }
                        else if (temp1[chromosomes[fatherIdx][i]] == -1)
                        {
                            temp1[chromosomes[fatherIdx][i]] = temp1[chromosomes[motherIdx][i]];
                            temp1[temp1[chromosomes[motherIdx][i]]] = chromosomes[fatherIdx][i];
                            temp1[chromosomes[motherIdx][i]] = -2;
                        }
                        else if (temp1[chromosomes[motherIdx][i]] == -1)
                        {
                            temp1[chromosomes[motherIdx][i]] = temp1[chromosomes[fatherIdx][i]];
                            temp1[temp1[chromosomes[fatherIdx][i]]] = chromosomes[motherIdx][i];
                            temp1[chromosomes[fatherIdx][i]] = -2;
                        }
                        else
                        {
                            temp1[temp1[chromosomes[motherIdx][i]]] = temp1[chromosomes[fatherIdx][i]];
                            temp1[temp1[chromosomes[fatherIdx][i]]] = temp1[chromosomes[motherIdx][i]];
                            temp1[chromosomes[fatherIdx][i]] = -3;
                            temp1[chromosomes[motherIdx][i]] = -3;
                        }
                    }

                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i >= pos1 && i < pos2)
                        {
                            chromosomes[child1Idx][i] = chromosomes[motherIdx][i];
                            chromosomes[child2Idx][i] = chromosomes[fatherIdx][i];
                        }
                        else
                        {
                            if (temp1[chromosomes[fatherIdx][i]] < 0)
                                chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                            else chromosomes[child1Idx][i] = temp1[chromosomes[fatherIdx][i]];
                            if (temp1[chromosomes[motherIdx][i]] < 0)
                                chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
                            else chromosomes[child2Idx][i] = temp1[chromosomes[motherIdx][i]];
                        }
                    }
                    break;
                case CrossoverType.CX:
                    temp_list.Clear();
                    int position= randomizer.Next(numberOfGenes);
                    int change_position = position;
                    temp_list.Add(chromosomes[fatherIdx][position]);
                    do
                    {
                        if (temp_list.Contains(chromosomes[motherIdx][change_position]) == false)
                        {
                            temp_list.Add(chromosomes[motherIdx][change_position]);
                            for (int i = 0; i < numberOfGenes; i++)
                            {
                                if (chromosomes[fatherIdx][i] == chromosomes[motherIdx][change_position])
                                {
                                    change_position = i;
                                    break;
                                }
                            }
                        }
                    } while (chromosomes[motherIdx][change_position] != chromosomes[fatherIdx][position]);


                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp_list.Contains(chromosomes[fatherIdx][i]))
                        {
                            chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                            chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
                        }
                        else
                        {
                            chromosomes[child1Idx][i] = chromosomes[motherIdx][i];
                            chromosomes[child2Idx][i] = chromosomes[fatherIdx][i];
                        }
                    }
                    break;
                case CrossoverType.SEX:
                    temp_list.Clear();
                    numberOfCrossover = 4; // define subtour length
                    pos1 = numberOfCrossover - 1; pos2 = pos1 + numberOfCrossover;
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        chromosomes[child1Idx][i] = -1;
                        chromosomes[child2Idx][i] = -1;
                    }
                    for (int i = pos1; i < pos2; i++)
                    {
                        temp_list.Add(chromosomes[fatherIdx][i]);
                    }
                    outerloop2: for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp_list.Contains(chromosomes[fatherIdx][i]))
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                for (int k = 0; k < numberOfCrossover; j++)
                                {
                                    if (temp_list.Contains(chromosomes[motherIdx][j]))
                                    {
                                        chromosomes[child1Idx][i] = chromosomes[motherIdx][j];
                                        goto outerloop2;
                                    }
                                }
                            }
                        }
                        else
                        {
                            chromosomes[child1Idx][i] = chromosomes[fatherIdx][i];
                            continue;
                        }
                    }
                    outerloop3: for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (temp_list.Contains(chromosomes[motherIdx][i]))
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                for (int k = 0; k < numberOfCrossover; j++)
                                {
                                    if (temp_list.Contains(chromosomes[fatherIdx][j]))
                                    {
                                        chromosomes[child2Idx][i] = chromosomes[fatherIdx][j];
                                        goto outerloop3;
                                    }
                                }
                            }
                        }
                        else
                        {
                            chromosomes[child2Idx][i] = chromosomes[motherIdx][i];
                            continue;
                        }
                    }
                    break;
            }
        }

        public override void MutateAChild(int parentIdx, int childIdx)
        {
            for (int i =0; i <numberOfGenes; i++)
                chromosomes[childIdx][i] = chromosomes[parentIdx][i];
            switch (MutationOperator)
            {
                case MutationType.Swap:
                    int pos1 = randomizer.Next(numberOfGenes);
                    int pos2 = randomizer.Next(numberOfGenes);
                    do pos2 = randomizer.Next(numberOfGenes); while (pos2 == pos1);
                    int temp = chromosomes[childIdx][pos1];
                    chromosomes[childIdx][pos1] = chromosomes[childIdx][pos2];
                    chromosomes[childIdx][pos1] = temp;
                    break;
                case MutationType.Inversion:
                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);
                    do pos2 = randomizer.Next(numberOfGenes); while (pos2 == pos1);
                    if (pos1 > pos2)
                    {
                        int position = pos1;
                        pos1 = pos2;
                        pos2 = position;
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i >= pos1 && i < pos2)
                        {
                            chromosomes[childIdx][i] = chromosomes[parentIdx][pos2 - i - 1 + pos1];
                        }
                        else chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                    }
                    break;
                case MutationType.Insertion:
                    pos1 = randomizer.Next(numberOfGenes); // selected position pos2 is insert position
                    pos2 = randomizer.Next(numberOfGenes);
                    do pos2 = randomizer.Next(numberOfGenes); while (pos2 == pos1);
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (pos2 > pos1)
                        {
                            if (i >= pos1 && i < pos2) chromosomes[childIdx][i] = chromosomes[parentIdx][i + 1];
                            else if (i == pos2) chromosomes[childIdx][i] = chromosomes[parentIdx][pos1];
                            else chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                        }
                        else if (pos1 > pos2)
                        {
                            if (i == pos2) chromosomes[childIdx][i] = chromosomes[parentIdx][pos1];
                            else if (i > pos2 && i <= pos1) chromosomes[childIdx][i] = chromosomes[parentIdx][i - 1];
                            else chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                        }
                    }
                    break;
                case MutationType.ReciprocalExchange:
                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);
                    do
                    {
                        pos2 = randomizer.Next(numberOfGenes);
                    }
                    while (pos1 == pos2);
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i == pos1) chromosomes[childIdx][i] = chromosomes[parentIdx][pos2];
                        else if (i == pos2) chromosomes[childIdx][i] = chromosomes[parentIdx][pos1];
                        else chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                    }
                    break;
                case MutationType.Displacement:
                    temp_list.Clear();
                    pos1 = randomizer.Next(numberOfGenes);
                    pos2 = randomizer.Next(numberOfGenes);
                    do
                    {
                        pos2 = randomizer.Next(numberOfGenes);
                    } while (pos2 == pos1);
                    if (pos1 > pos2)
                    {
                        int position = pos1;
                        pos1 = pos2;
                        pos2 = position;
                    }                 
                    for (int i = 0; i < pos2 - pos1; i++)
                    {
                        temp_list.Add(chromosomes[parentIdx][pos1 + i]);
                    }
                    int position1 = randomizer.Next(numberOfGenes);
                    do
                    {
                        position1 = randomizer.Next(numberOfGenes - (pos2 - pos1) + 1);
                    } while (position1 == pos1);
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (pos1 < position1)
                        {
                            if (i < pos1 || i >= position1 + (pos2 - pos1)) chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                            else if (i >= pos1 && i < position1) chromosomes[childIdx][i] = chromosomes[parentIdx][i + (pos2 - pos1)];
                            else
                            {
                                chromosomes[childIdx][i] = temp_list[i - position1];
                            }
                        }
                        else if (pos1 > position1)
                        {
                            if (i >= pos2 || i < position1) chromosomes[childIdx][i] = chromosomes[parentIdx][i];
                            else if (i >= position1 + (pos2 - pos1) && i < pos2) chromosomes[childIdx][i] = chromosomes[parentIdx][i - (pos2 - pos1)];
                            else
                            {
                                chromosomes[childIdx][i] = temp_list[i - position1];
                            }
                        }
                    }
                    break;
            }
        }
    }
}
