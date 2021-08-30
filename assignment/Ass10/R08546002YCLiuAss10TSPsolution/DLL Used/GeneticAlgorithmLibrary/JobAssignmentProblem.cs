using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAssignmentProblemGASlover
{
    public class JobAssignmentProblem
    {
        int numberOfJobs;
        double[,] setupTimes;
        string fileName;
        public double[,] SetupTimes { get => setupTimes; }
        public int NumberOfJobs { get => numberOfJobs; set => numberOfJobs = value; }

        public void OpenFile(string path)
        {
            fileName = path;
            StreamReader sr = new StreamReader(fileName);
            string str;
            string[] items;
            char[] sep = { ' ' };
            str = sr.ReadLine();
            numberOfJobs = Convert.ToInt32(str);
            setupTimes = new double[numberOfJobs, numberOfJobs];
            for(int r = 0; r< numberOfJobs; r++)
            {
                str = sr.ReadLine();
                items = str.Split(sep,StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < numberOfJobs; c++)
                {
                    setupTimes[r, c] = Convert.ToDouble(items[c]);
                }                 
            }                
            sr.Close();
        }
        // For brute force method and Permutation GA
        Random randomizer = new Random();
        public double GetObjectiveValue(int[] ass)
        {
            List<int> replicated_list = new List<int>();
            replicated_list.Clear();
            double total = 0;
            for(int c = 0; c< NumberOfJobs; c++)
            {
                if (ass[c] < 0)
                {
                    for (int i = 0; i < NumberOfJobs; i++)
                    {
                        ass[i] = randomizer.Next(NumberOfJobs);   

                        for (int j = 0; j < i; j++)
                        {
                            while (ass[j] == ass[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                            {
                                j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                                ass[i] = randomizer.Next(NumberOfJobs);   //重新產生，存回陣列，亂數產生的範圍是1~9
                            }
                        }
                    }
                }
                else
                    replicated_list.Add(ass[c]);
                total += setupTimes[ass[c], c];
            }
            return total;
        }
        public double Penalty { set; get; } = 100;
        //function overloaded
        public double GetTotalSetupTimeForAnAssignment(byte[] ass)
        {
            double total = 0;

            for (int i = 0; i < numberOfJobs; i++)
            {
                for (int j = 0; j < numberOfJobs; j++)
                {
                    total += ass[i * numberOfJobs + j] * setupTimes[i, j];
                }
            }
            return total + ViolationCount(ass) * Convert.ToDouble(Penalty);
        }
        public int ViolationCount(byte[] solution)
        {
            int violationcount = 0;
            for (int i = 0; i < numberOfJobs; i++)
            {
                int columnCount = 0;
                int rowCount = 0;
                for (int j = 0; j < numberOfJobs; j++)
                {
                    columnCount += solution[i + numberOfJobs * j];
                    rowCount += solution[i * numberOfJobs + j];
                }
                if (columnCount == 0)
                    violationcount++;
                else
                    violationcount += (columnCount - 1);
                if (rowCount == 0)
                    violationcount++;
                else
                    violationcount += (rowCount - 1);
            }
            return violationcount;
        }
        public double GetTotalSetupTimeForAnAssignment7(int[] ass)
        {
            double total = 0;
            for (int c = 0; c < NumberOfJobs; c++)
            {
                total += setupTimes[ass[c], c];
            }
            return total;
        }
    }
}
