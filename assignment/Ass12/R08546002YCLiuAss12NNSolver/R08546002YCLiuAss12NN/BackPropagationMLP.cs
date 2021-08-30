using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R08546002YCLiuAss12NN
{
    public enum ActivationFunction { Logistic, HyperbolicTangent };
    class BackPropagationMLP
    {
        float[][] x; // neuron values
        float[][][] w; // weights
        float[][] e; // epsilon; partial derivative of error with respect to net value.
        int[] n; // numbers of neuron on layers
        int inputDimension; // dimension of input vector
        int inputNumber; // number of instances on the data set
        int numberOfTrainningVectors; // number of instances that are serving as training data
        float[,] originalInputs; // original instances of input vectors (without normalization)
        float[,] inputs; // normalized input vectors
        float[] inputMax; // upper bounds on all components of input vectors
        float[] inputMin; // lower bounds on all components of input vectors
        int inputWidth; // dimension in width for a two-dimensional input vector
        int targetDimension; // dimension of target vector
        float[,] originalTargets; // original instances of target vectors (without normalization)
        float[,] targets; // normalized target vectors
        float[] targetMax; // upper bounds on all components of target vectors
        float[] targetMin; // lower bounds on all components of target vectors.
        int[] vectorIndices; // array of shuffled indices of data instances; the front portion is training vectors;
                             //the rear portion is testing vectors
        bool shuffleEachTrainEachEpoch = false;
        float rootMeanSquareError = 0.0f; // root mean square of error for an epoch of data training
        int layerNumber; // number of neuron layer (including the input layer)
        int epochCount = 0;
        Random randomizer = new Random();
        float learningRate = 0.999f; // learning rate, specified by the user
        float trainingRatio = 0.667f;
        float eta; // step size that specify the update amount on each weight
        float initialEta = 0.7f; // initial step size, specified by the user
        int epochLimit = 200;
        int successedCount = 0;
        // property
        [Category("MLP Setting"), Description("The portion of the data set are used for training.")]
        public float TrainingRatio
        {
            get => trainingRatio;
            set
            {
                if (value > 0 && value <= 1) trainingRatio = value;
            }
        }
        [Category("MLP Setting"), Description("Whether shuffle the training data in each new epoch or not.")]
        public bool ShuffleEachTrainEachEpoch
        {
            get => shuffleEachTrainEachEpoch;
            set
            {
                shuffleEachTrainEachEpoch = value;
            }
        }
        [Category("MLP Setting"), Description("Decide initial learning factor.")]
        public float InitialEta
        {
            get => initialEta;
            set
            {
                if (value > 0 && value <= 1) initialEta = value;
            }
        }
        [Category("MLP Setting"), Description("Learning factor reducing rate.")]
        public float LearningRate
        {
            get => learningRate;
            set
            {
                if (value > 0 && value <= 1) learningRate = value;
            }
        }

        [Category("MLP Setting"), Description("Type of Activation Function.")]
        public ActivationFunction ActivationFunctionType { get; set; } = ActivationFunction.Logistic;
        [Category("MLP Setting"), Description("Upper limit of epoch to stop.")]
        public int EpochLimit
        {
            get => epochLimit;
            set
            {
                if (value > 5) epochLimit = value;
            }
        }
        [Browsable(false)]
        public int EpochCount { get => epochCount; }
        [Browsable(false)]
        public int SuccessedCount { get => successedCount; }
        /// <summary>
        /// Current root mean square after an epoch training.
        /// </summary>
        [Browsable(false)]
        public float RootMeanSquareError { get => rootMeanSquareError; }
        [Browsable(false)]
        public int InputNumber { get => inputNumber; }
        [Browsable(false)]
        public int InputDimension { get => inputDimension; }
        [Browsable(false)]
        public int TargetDimension { get => targetDimension; }
        [Browsable(false)]
        public float[,] OriginalInputs { get => originalInputs; }
        [Browsable(false)]
        public float[,] OriginalOutputs { get => originalTargets; }


        /// <summary>
        /// Read in the data set from the given file stream. Configure the portions of training
        /// and testing data subsets. Original data are stored, bounds on each component of
        /// input vector and target vector are founds, and normalized data set is prepared.
        /// </summary>
        /// <param name="sr">file stream</param>
        /// <param name="trainingRatio">portion of trainning data</param>
        public void ReadInDataSet(StreamReader sr, float trainingRatio)
        {
            char[] separators = new char[] { ',', ' ' };
            string s = sr.ReadLine();
            string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //allocate memory
            inputNumber = Convert.ToInt32(items[0]);
            inputDimension = Convert.ToInt32(items[1]);
            targetDimension = Convert.ToInt32(items[2]);
            inputWidth = Convert.ToInt32(items[3]);
            vectorIndices = new int[inputNumber];
            inputMax = new float[inputDimension];
            inputMin = new float[inputDimension];
            targetMax = new float[targetDimension];
            targetMin = new float[targetDimension];
            originalInputs = new float[inputNumber, inputDimension];
            inputs = new float[inputNumber, inputDimension];
            originalTargets = new float[inputNumber, targetDimension];
            targets = new float[inputNumber, targetDimension];

            //oriignalIput originalTarget
            for (int i = 0; i < inputNumber; i++)
            {
                s = sr.ReadLine();
                items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < inputDimension + targetDimension; j++)
                {
                    if (j < inputDimension)
                        originalInputs[i, j] = Convert.ToSingle(items[j]);
                    else
                        originalTargets[i, j - inputDimension] = Convert.ToSingle(items[j]);
                }
            }
            // find the inputMax inputMin of each column of input for normalize
            for (int j = 0; j < inputDimension; j++)
            {
                inputMax[j] = float.MinValue;
                inputMin[j] = float.MaxValue;
                for (int i = 0; i < inputNumber; i++)
                {
                    if (originalInputs[i, j] > inputMax[j])
                        inputMax[j] = originalInputs[i, j];
                    if (originalInputs[i, j] < inputMin[j])
                        inputMin[j] = originalInputs[i, j];
                }
            }
            // find the targetMax targetMin of each column of output for normalize
            for (int j = 0; j < targetDimension; j++)
            {
                targetMax[j] = float.MinValue;
                targetMin[j] = float.MaxValue;
                for (int i = 0; i < inputNumber; i++)
                {
                    if (originalTargets[i, j] > targetMax[j])
                        targetMax[j] = originalTargets[i, j];
                    if (originalTargets[i, j] < targetMin[j])
                        targetMin[j] = originalTargets[i, j];
                }
            }
            ////normalize input
            //for (int i = 0; i < inputNumber; i++)
            //{
            //    for (int j = 0; j < inputDimension; j++)
            //    {
            //        if (ActivationFunctionType == ActivationFunction.Logistic) // 0-1
            //        {
            //            inputs[i, j] = (originalInputs[i, j] - inputMin[j]) / (inputMax[j] - inputMin[j]);
            //        }
            //        else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent) // -1~1
            //        {
            //            inputs[i, j] = (2 * originalInputs[i, j] - inputMax[j] - inputMin[j]) / (inputMax[j] - inputMin[j]);
            //        }
            //    }
            //    for (int j = 0; j < targetDimension; j++)
            //    {
            //        if (ActivationFunctionType == ActivationFunction.Logistic)
            //        {
            //            targets[i, j] = (originalTargets[i, j] - targetMin[j]) / (targetMax[j] - targetMin[j]);
            //        }
            //        else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
            //        {
            //            targets[i, j] = (2 * originalTargets[i, j] - targetMax[j] - targetMin[j]) / (targetMax[j] - targetMin[j]);
            //        }
            //    }
            //}
        }
        /// <summary>
        /// Configure the topology of the NN with the user specified numbers of hidden
        /// neuorns and layers.
        /// </summary>
        /// <param name="hiddenNeuronNumbers">list of numbers of neurons of hidden layers</param>
        public void ConfigureNeuralNetwork(int[] hiddenNeuronNumbers)
        {
            //normalize input
            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j < inputDimension; j++)
                {
                    if (ActivationFunctionType == ActivationFunction.Logistic) // 0-1
                    {
                        inputs[i, j] = (originalInputs[i, j] - inputMin[j]) / (inputMax[j] - inputMin[j]);
                    }
                    else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent) // -1~1
                    {
                        inputs[i, j] = (2 * originalInputs[i, j] - inputMax[j] - inputMin[j]) / (inputMax[j] - inputMin[j]);
                    }
                }
                for (int j = 0; j < targetDimension; j++)
                {
                    if (ActivationFunctionType == ActivationFunction.Logistic)
                    {
                        targets[i, j] = (originalTargets[i, j] - targetMin[j]) / (targetMax[j] - targetMin[j]);
                    }
                    else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
                    {
                        targets[i, j] = (2 * originalTargets[i, j] - targetMax[j] - targetMin[j]) / (targetMax[j] - targetMin[j]);
                    }
                }
            }
            layerNumber = hiddenNeuronNumbers.Length + 2; //inclide input layer and output layer
            n = new int[layerNumber];
            n[0] = inputDimension + 1; //input layer + bias
            n[layerNumber - 1] = targetDimension + 1; // targer neuron + 1 bias
            //hidden layer
            for (int i = 1; i < layerNumber -1; i++)
            {
                n[i] = hiddenNeuronNumbers[i-1] + 1; // each hidden layer + bias
            }
            // each neuron
            x = new float[layerNumber][];
            for (int i = 0; i < layerNumber; i++)
            {
                // number of neurons in i layer
                x[i] = new float[n[i]];
            }
            // adding bias for each layer
            for (int i = 0; i < layerNumber; i++)
            {
                x[i][0] = 1;
            }
            // weights [ith layer][ith layer's neuron][previous layer's neuron]
            w = new float[layerNumber][][];
            for (int i = 1; i < layerNumber; i++) // w[0] = null
            {
                //# of neuron in ith layer (exclude bias)
                w[i] = new float[n[i]][];
                for (int j = 0; j < n[i]; j++)
                {
                    // # of nodes in previous layer (include bias)
                    w[i][j] = new float[n[i - 1]];
                }
            }
            // error
            e = new float[layerNumber][]; // e[0] is uncapable.
            for (int i = 0; i < layerNumber; i++)
            {
                // # of error terms in i layer (exclude input layer)
                e[i] = new float[n[i]];
            }
        }
        /// <summary>
        /// Randomly shuffle the orders of the data in the data set.
        /// </summary>
        private void RandomizeIndices()
        {
            ShuffleIntegerArray(vectorIndices, inputNumber);
        }
        private void ShuffleIntegerArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
            for (int j = size - 1; j > 0; j--)
            { 
                int pos = randomizer.Next(j + 1);
                int temp = array[pos];
                array[pos] = array[j];
                array[j] = temp;
            }
        }
        /// <summary>
        /// Randomly set values of weights between [-1,1] and randomly shuffle the orders of all
        /// the datum in the data set. Reset value of initial eta and root mean square to 0.0.
        /// </summary>
        public void ResetWeightsAndInitialCondition()
        {
            // initialize weights
            for (int i = 1; i < layerNumber; i++)
            {
                for (int j = 1; j < n[i]; j++)
                {
                    for (int k = 0; k < n[i-1]; k++)
                    {
                        // randomly assign w between -1 and 1.
                        w[i][j][k] = Convert.ToSingle(2 * randomizer.NextDouble() - 1);
                    }
                }
            }

        }
        /// <summary>
        /// Sequentially loop through each training datum of the training data whose indices are
        /// randomly shuffled in vectorIndices[] array, to perform on-line training of the NN.
        /// </summary>
        public void Reset()
        {
            RandomizeIndices();
            ResetWeightsAndInitialCondition();
            numberOfTrainningVectors = Convert.ToInt32(trainingRatio * inputNumber);
            eta = initialEta;
            epochCount = 0;
        }
        public void TrainAnEpoch()
        {
            if (shuffleEachTrainEachEpoch == true)
            {
                ShuffleIntegerArray(vectorIndices, numberOfTrainningVectors); // ensure training set is not equal each time.
            }
            float v = 0.0f;
            float summation = 0.0f;
            float errorSquare = 0.0f;
            float errorSquareSum = 0.0f;
            int layerNumberMinusOne = layerNumber - 1; //last layer index

                
            for (int trainIndex = 0; trainIndex < numberOfTrainningVectors; trainIndex++)
            {
                /// forward computing for all neuro values.               
                for (int l = 0; l < layerNumber; l++)
                {
                    if (l == 0) // input data in layer 0. (exclude bias)
                    {
                        for (int k = 1; k < n[0]; k++)
                        {
                            x[0][k] = inputs[vectorIndices[trainIndex], k - 1];
                        }
                    }
                    else
                    {
                        for (int k = 1; k < n[l]; k++) // k is kth neuron in lth layer. (exclude bias)
                        {
                            v = 0;
                            for (int i = 0; i < n[l - 1]; i++) // w[1][1][0] * x[0][0] = w110 * x00
                            {
                                v += w[l][k][i] * x[l - 1][i];
                            }
                            if (ActivationFunctionType == ActivationFunction.Logistic)
                            {
                                x[l][k] = Convert.ToSingle(1 / (1 + Math.Exp(-v)));
                            }
                            else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
                            {
                                x[l][k] = Convert.ToSingle((Math.Exp(v) - Math.Exp(-v)) / (Math.Exp(v) + Math.Exp(-v)));
                            }
                        }
                    }
                }
                /// compute the epsilon values for neurons on the output layer
                // calculate the last layer errorsquaresum by calculate the difference between each neuron with true ouput
                for (int l = 1; l < n[layerNumberMinusOne]; l++) 
                {
                    errorSquare = Convert.ToSingle(Math.Pow((targets[vectorIndices[trainIndex], l - 1] - x[layerNumberMinusOne][l]), 2));
                    errorSquareSum += errorSquare; // For the last ecaluation RMSE
                }
                //the last layer error
                for (int l = 1; l < n[layerNumberMinusOne]; l++)
                {
                    if (ActivationFunctionType == ActivationFunction.Logistic)
                    {
                        e[layerNumberMinusOne][l] = -2 * (targets[vectorIndices[trainIndex], l - 1] - x[layerNumberMinusOne][l]) * (x[layerNumberMinusOne][l]) * (1 - x[layerNumberMinusOne][l]);
                    }
                    else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
                    {
                        e[layerNumberMinusOne][l] = -2 * ( targets[vectorIndices[trainIndex], l - 1] - x[layerNumberMinusOne][l]) * (1 + x[layerNumberMinusOne][l]) * (1 - x[layerNumberMinusOne][l]);
                    }                 
                }
                /// backward computing for the epsilon values
                for (int layerNow = layerNumberMinusOne - 1; layerNow > 0; layerNow--)
                {
                    // current layer
                    for (int neuronNow = 1; neuronNow < n[layerNow]; neuronNow++)
                    {
                        summation = 0;
                        for (int i = 1; i < n[layerNow + 1]; i++) // next layer
                        {
                            summation += e[layerNow + 1][i] * w[layerNow + 1][i][neuronNow];
                        }
                        if (ActivationFunctionType == ActivationFunction.Logistic)
                        {
                            e[layerNow][neuronNow] = summation * x[layerNow][neuronNow] * (1 - x[layerNow][neuronNow]);
                        }
                        else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
                        {
                            e[layerNow][neuronNow] = summation * (1 + x[layerNow][neuronNow]) * (1 - x[layerNow][neuronNow]);
                        }
                    }
                }
                /// update weights for all weights by using epsilon and neuron values.
                for (int l = 1; l < layerNumber; l++)
                {
                    for (int j = 1; j < n[l]; j++)
                    {
                        for (int k = 0; k < n[l-1]; k++)
                        {
                            w[l][j][k] = w[l][j][k] - eta * e[l][j] * x[l-1][k];
                        }
                    }
                }
            }
            rootMeanSquareError = Convert.ToSingle(Math.Sqrt(errorSquareSum / (numberOfTrainningVectors * targetDimension)));

            /// update step size of the updating amount
            epochCount++;
            eta *= learningRate;
        }
        /// <summary>
        /// Compute the output vector for an input vector. Both vectors are in the raw
        /// format. The input vector is subject to scaling first before forward computing.
        /// Output vector is then scaled back to raw format for recognition.
        /// </summary>
        /// <param name="input">input vector in raw format</param>
        /// <returns>output vector in raw format</returns>
        public float[] ComputeResults(float[] input)
        {
            float[] results = null;
            float v;
            for (int i = 0; i < inputDimension; i++) // input data (just one sample) 
            {
                x[0][i + 1] = input[i];
            }
            for (int j = 1; j < layerNumber; j++)
            {
                for (int k = 1; k < n[j]; k++)
                {
                    v = 0;
                    for (int l = 0; l < n[j - 1]; l++)
                    {
                        v += w[j][k][l] * x[j - 1][l];
                    }
                    if (ActivationFunctionType == ActivationFunction.Logistic)
                    {
                        x[j][k] = Convert.ToSingle(1 / (1 + Math.Exp(-v)));
                    }
                    else if (ActivationFunctionType == ActivationFunction.HyperbolicTangent)
                    {
                        x[j][k] = Convert.ToSingle((Math.Exp(v) - Math.Exp(-v)) / (Math.Exp(v) + Math.Exp(-v)));
                    }                   
                }
            }
            results = x[layerNumber - 1]; // ouput layer
            return results;
        }
        /// <summary>
        /// If the data set is a classification data set, test the data to generate confusing table.
        /// The index of the largest component of the target vector is the targeted class id.
        /// The index of the largest component of the computed output vector is the resulting class id.
        /// If both the targeted class id and the resulting class id are the same, then the test
        /// data is correctly classified.
        /// </summary>
        /// <param name="confusingTable">generated confusing table</param>
        /// <returns>the ratio between the number of correctly classified testing data and the total number of testing data.</returns>
        public float TestingClassification(out int[,] confusingTable)
        {
            confusingTable = new int[targetDimension, targetDimension];
            float[] input = new float[inputDimension];
            float[] output_Computed = new float[targetDimension];
            float[] output_True = new float[targetDimension];
            int successedCount = 0;
            int judgeSample;
            if (trainingRatio == 1) 
                judgeSample = 0;
            else
                judgeSample = numberOfTrainningVectors;

            for (int startID = judgeSample; startID < inputNumber; startID++)
            {
                // compute Result
                for (int j = 0; j < inputDimension; j++)
                {
                    input[j] = inputs[vectorIndices[startID], j];
                }
                output_Computed = ComputeResults(input);
                // True Result
                for (int j = 0; j < targetDimension; j++)
                {
                    output_True[j] =  targets[vectorIndices[startID], j]; //true
                }

                // find target class id
                double targetBest = output_True[0];
                int targetID = 0;
                for (int i = 1; i < targetDimension; i++)
                {
                    if (output_True[i] > targetBest)
                    {
                        targetID = i;
                    }
                }
                targetBest = output_True[targetID]; // true answer

                // find testing data class id
                double PredictionBest = output_Computed[1]; // index = 0 is bias.
                int PredictionID = 1;
                for (int i = 2; i <= targetDimension; i++)
                {
                    if (output_Computed[i] > PredictionBest)
                    {
                        PredictionID = i;
                    }
                }
                PredictionBest = x[layerNumber - 1][PredictionID];
                PredictionID--;

                // compare the id of target and testing data
                confusingTable[targetID, PredictionID]++; // find the position and plus 1.
                if (targetID == PredictionID) // shot plus 1.
                {
                    successedCount++;
                }
            }
            return (float)successedCount / (float)(inputNumber - numberOfTrainningVectors); // accuracy
        }
        public void DrawMLP(Graphics g, Rectangle bound)
        {
            // define rectangle
            if (n == null) return;
            Rectangle rect = Rectangle.Empty; //struct left top is original point.
            //at most 10 circle in each layer
            int diameter = bound.Height / 10;
            int temp = bound.Width / 10;
            if (temp < diameter) diameter = temp;
            rect.Height = rect.Width = diameter;  //for draw circle

            //draw neuron
            Font xFont = new Font("Arial", diameter / 2 * 0.5f);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            int ww = bound.Width / n.Length; //width of each layer
            int xoff = ww / 2; // x-axis's coordinaate begins  
            for (int c = 0; c < n.Length; c++)
            {
                for (int j = 0; j < n[c]; j++)
                {
                    if (j == 0) // bias 
                    {
                        int x1 = xoff + c * ww; // x axis center
                        int h1 = bound.Height / n[c]; // rectengle height / # of neuron
                        int yoff1 = h1 / 2;
                        int y1 = yoff1 + j * h1; //y axis center
                        rect.Width = rect.Height = 8;
                        rect.X = x1 - rect.Width / 2; //center - radius(diameter / 2)
                        rect.Y = y1 - rect.Height / 2; //center - radius(diameter / 2)
                        g.FillEllipse(Brushes.Red, rect);
                        string str = Convert.ToString(Math.Round(x[c][j], 3));
                        g.DrawString($"x{c}{j}" + "\n" + str, xFont, Brushes.Black, x1 - rect.Width / 2, y1 - rect.Height, sf);
                    }
                    else if (j > 0) // exclude bias 
                    {
                        int x1 = xoff + c * ww; // x axis center
                        int h1 = bound.Height / n[c]; // rectengle height / # of neuron
                        int yoff1 = h1 / 2;
                        int y1 = yoff1 + j * h1; //y axis center
                        rect.Height = rect.Width = diameter;
                        rect.X = x1 - rect.Width / 2; //center - radius(diameter / 2)
                        rect.Y = y1 - rect.Height / 2; //center - radius(diameter / 2)
                        g.DrawEllipse(Pens.Black, rect); // edge
                        g.FillEllipse(Brushes.White, rect);
                        string str = Convert.ToString(Math.Round(x[c][j], 3));
                        g.DrawString($"x{c}{j}" + "\n" + str, xFont, Brushes.Black, rect, sf);
                    }
                }
            }

            // draw lines
            Pen myPen = new Pen(Brushes.Gray, 1);
            myPen.Width = 2;
            Font NumFont = new Font("Arial", diameter/2 * 0.4f);
            for (int c = 0; c < n.Length - 1; c++) // layer
            {
                //neuron index
                for (int j = 0; j < n[c]; j++)
                {
                    //next layer
                    for (int k = 1; k < n[c + 1]; k++) // x0 dosen't need to connect
                    {
                        string str = "";
                        int x1 = xoff + c * ww; // x axis center
                        int h1 = bound.Height / n[c]; // rectengle height / # of neuron
                        int yoff1 = h1 / 2;
                        int y1 = yoff1 + j * h1; //y axis center
                        int x2 = xoff + (c + 1) * ww;
                        int h2 = bound.Height / n[c + 1];
                        int yoff2 = h2 / 2;
                        int y2 = yoff2 + k * h2;
                        if(j == 0)
                        {
                            Point p1 = new Point(x1, y1);
                            Point p2 = new Point(x2 , y2);
                            g.DrawLine(myPen, p1, p2);
                        }
                        else
                        {
                            Point p1 = new Point(x1 + rect.Width / 2, y1);
                            Point p2 = new Point(x2 - rect.Width / 2, y2);
                            g.DrawLine(myPen, p1, p2);
                        }                     
                        if (w == null) str = "0";
                        else if (w != null) str = Convert.ToString(Math.Round(w[c + 1][k][j],3));
                        g.DrawString(str, NumFont, Brushes.Red, (x1 * 2 / 3 + x2 / 3), (y1 * 2 / 3 + y2 / 3), sf);
                    }
                }
            }
        }
    }
}
