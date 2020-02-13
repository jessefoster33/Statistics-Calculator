//Assignment 3: Statistics Calculator
//
//Author: Jesse Foster
// Dec 12, 2019
//
//Purpose: Load and display number values, calculate and display different math functions and histogram, and allow for editing and saving. 
//
//Description: This application will allow the user to load a text file and display the text. Users will be able to calculate the mean, median,
//range, maximum and minimum numbers and display these values as well as a histogram displaying the frequency that numbers appear within certain
//value ranges. The user will be able to make changes to the values in the application as long as they are valid numbers and save them as a new file.
//The user will be able to reset the calculator as well. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// remember to return this from a console app to a windows form app!

namespace Statistics_Calculator_Assignment_3
{
    public partial class StatisticsCalculatorForm : Form
    {
        private int[] dataSet;                           //place this instance variable here so that it can be accessed properly (when it was just in the load button,
                                                         //other parts of the program would not be able to access this variable when needed; why private?

        private int[] dataSet2;                         //first part of building copy array that references the original for Array.Sort

        private int arraySize;                          //variable declared to store the value of the first line in loaded file and will set the size of the dataSet array
                                                        //refactored from being inside load button to public class to allow to be accessed by saveButton as well

        private int frequencyCount1     = 0;            //these are the variables used for the histogramTextbox
        private int frequencyCount2     = 0;
        private int frequencyCount3     = 0;
        private int frequencyCount4     = 0;
        private int frequencyCount5     = 0;
        private int frequencyCount6     = 0;
        private int frequencyCount7     = 0;
        private int frequencyCount8     = 0;
        private int frequencyCount9     = 0;
        private int frequencyCount10    = 0;

        private string frequencyStars0 = " ";
        private string frequencyStars1 = "  **********";
        private string frequencyStars2 = "  *******************";
        private string frequencyStars3 = "  ********************************";    
        private string frequencyStars4 = "  ************************************************";

        private string rating1;
        private string rating2;
        private string rating3;
        private string rating4;
        private string rating5;
        private string rating6;
        private string rating7;
        private string rating8;
        private string rating9;
        private string rating10;


        public StatisticsCalculatorForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            // create and display the open file dialog
            OpenFileDialog ofd = new OpenFileDialog();

            // if user didn't press ok, give up
            // if they did press ok, enable calculate button

            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            try
            {
                datasetTextbox.Clear();                         //reset all values when loading new file to do new calculations
                minValueTextbox.Clear();
                maxValueTextbox.Clear();
                meanTextbox.Clear();
                medianTextbox.Clear();
                rangeTextbox.Clear();
                histogramTextbox.Clear();

                frequencyCount1 = 0;                            //resets all histogram frequency values
                frequencyCount2 = 0;
                frequencyCount3 = 0;
                frequencyCount4 = 0;
                frequencyCount5 = 0;
                frequencyCount6 = 0;
                frequencyCount7 = 0;
                frequencyCount8 = 0;
                frequencyCount9 = 0;
                frequencyCount10 = 0;


                //open the file here

                StreamReader inputFile = new StreamReader(ofd.FileName);

               //you should pull the first number of the file here to set the size of the array:

              

               arraySize = int.Parse(inputFile.ReadLine());        //This reads the first line and converts it from a string to a number

               dataSet = new int[arraySize];                       //Declares an array variable (not the array). [arraySize] reference means that the array size will be pulled from the first read line in the file

               dataSet2 = dataSet;                                 //second half of building copy array reference
                
               
                
                for (int i = 0; i < arraySize; i++)                 //counter loop that will start array at index value of 0 that indicates array size, and pulls all values until file ends 
                {
                    dataSet[i] = int.Parse(inputFile.ReadLine());

                    if (arraySize < 0)                              //error message will appear if there are not enough data samples

                    {
                        MessageBox.Show($"Data does not contain enough samples.");
                        return;
                    }

                    if (dataSet[i] < 0 || dataSet[i] > 99)
                    {
                        MessageBox.Show($"Data must not contain values less than 0 or greater than 99.");
                        return;
                    }
                        
                }

                Console.WriteLine(arraySize);                  //check to see if the number on index 0 is being read to set the array size

                for (int i = 0; i < arraySize; i++)           //check to see if dataSet array is pulled. Note that C# console output doesn't know how to
                {                                             //display an array by just referencing the array variable; you need to duplicate the loop
                    Console.WriteLine(dataSet[i]);            //to actually show the values loaded into the array on a console
                }
                    
                foreach (int i in dataSet)                     // this foreach loop is referencing each index value being referenced by i in the dataSet array variable that contains each value
                {
                    datasetTextbox.AppendText(i.ToString());  // the reason to use AppendText instead of Text is because Text would only refer to the last value that
                                                              // i refers to. AppendText will show and add each line as the counter loop progresses above to pull all values
                    if (datasetTextbox.Text.Length > 0)
                    {
                        datasetTextbox.AppendText(Environment.NewLine); //this will break a new line for each value. 
                                                                        //If you don't have breaks, all the numbers will jumble together in one line  
                    }
                }

                inputFile.Close();                          //closes the loaded file when program is done with it; prevents potential errors later on
  
            }

            catch (Exception excp)
            {
                MessageBox.Show($"File {ofd.FileName} could not be read. {excp.Message}");
                return;

            }

            calculateButton.Enabled = true;             //the calculate button is turned on when numbers are loaded to use
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int minValue        = 0;
            int maxValue        = 0;
            int medianValue     = 0;
            int sum             = 0;
            int numberCount     = 0;

            try
                {

                //first, reference the ARRAY, not the file, then find statistics

                foreach (int i in dataSet)          //references the array here; you've already read and converted the numbers to int in the load button 
                {                                   //remember that i represents index values; the ++ moves to the next value assigned to the index number
                    {
                        sum += i;
                        numberCount++;
                        if (numberCount == 1)
                        {
                            maxValue = i;
                            minValue = i;
                        }
                        else
                            maxValue = Math.Max(i, maxValue);
                            minValue = Math.Min(i, minValue);
                        }
                    
                }

                Array.Copy(dataSet, dataSet2, dataSet.Length);                      //creates a copy of the dataSet array and duplicates data
                    
                Array.Sort(dataSet2);                                               //sorts the values in ascending numerical order

                if (numberCount % 2 == 0)                                           //this means if the index number count is even, divisible by 2, 
                {                                                                   //you need to get the 2 middle values, add them, then divide
                    int middleValue1 = dataSet2[(numberCount / 2) - 1];             //to find the median.
                    int middleValue2 = dataSet2[(numberCount / 2)];
                    medianValue      = (middleValue1 + middleValue2) / 2;
                }
                else                                                                //if numberCount is odd, just find the middle value;
                {
                    medianValue = dataSet2[(numberCount / 2)];
                }

                for (int i = 0; i < dataSet.Length; i++)                            //this is to check if dataSet2 successfully copied data from dataSet array
                {                                             
                    Console.WriteLine(dataSet2[i]);           
                }

                //now it's time the build the histogram

                //can I turn this into a class and just reference it?
                for (int i = 0; i < dataSet.Length; i++)

                {
                    if (dataSet[i] <= 9)
                    {
                        frequencyCount1++;
                    }

                    if (dataSet[i] > 9 && dataSet[i] <= 19)
                    {
                        frequencyCount2++;
                    }

                    if (dataSet[i] >19 && dataSet[i] <= 29)
                    {
                        frequencyCount3++;
                    }

                    if (dataSet[i] >29 && dataSet[i] <= 39)
                    {
                        frequencyCount4++;
                    }

                    if (dataSet[i] > 39 && dataSet[i] <= 49)
                    {
                        frequencyCount5++;
                    }

                    if (dataSet[i] > 49 && dataSet[i] <= 59)
                    {
                        frequencyCount6++;
                    }

                    if (dataSet[i] > 59 && dataSet[i] <= 69)
                    {
                        frequencyCount7++;
                    }

                    if (dataSet[i] > 69 && dataSet[i] <= 79)
                    {
                        frequencyCount8++;
                    }

                    if (dataSet[i] > 79 && dataSet[i] <= 89)
                    {
                        frequencyCount9++;
                    }

                    if (dataSet[i] > 89 && dataSet[i] <= 99)
                    {
                        frequencyCount10++;
                    }

                }

                //Can this be turned into a class method in a seperate file instead to reference?
                
             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount1 == 0)
                    {
                        rating1 = frequencyStars0;
                    }

                    if (frequencyCount1 > 0 && frequencyCount1 <= 3)
                    {
                        rating1 = frequencyStars1;
                    }
                        
                        if (frequencyCount1 > 3 && frequencyCount1 <= 6 )
                    {
                         rating1 = frequencyStars2;
                    }

                        if (frequencyCount1 > 6 && frequencyCount1 <= 10)
                    {
                        rating1 = frequencyStars3;
                    }
                        if (frequencyCount1 > 10)
                    {
                        rating1 = frequencyStars4;
                    }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount2 == 0)
                    {
                        rating2 = frequencyStars0;
                    }

                if (frequencyCount2 > 0 && frequencyCount1 <= 3)
                    {
                        rating2 = frequencyStars1;
                    }

                if (frequencyCount2 > 3 && frequencyCount2 <= 6)
                {
                    rating2 = frequencyStars2;
                }

                if (frequencyCount2 > 6 && frequencyCount2 <= 10)
                {
                    rating2 = frequencyStars3;
                }
                if (frequencyCount1 > 10)
                {
                    rating2 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount3 == 0)
                    {
                        rating3 = frequencyStars0;
                    }

                if (frequencyCount3 > 0 && frequencyCount1 <= 3)
                    {
                        rating3 = frequencyStars1;
                    }

                if (frequencyCount3 > 3 && frequencyCount3 <= 6)
                {
                    rating3 = frequencyStars2;
                }

                if (frequencyCount3 > 6 && frequencyCount3 <= 10)
                {
                    rating3 = frequencyStars3;
                }
                if (frequencyCount3 > 10)
                {
                    rating3 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount4 == 0)
                    {
                        rating4 = frequencyStars0;
                    }

                if (frequencyCount4 > 0 && frequencyCount4 <= 3)
                    {
                        rating4 = frequencyStars1;
                    }

                if (frequencyCount4 > 3 && frequencyCount4 <= 6)
                {
                    rating4 = frequencyStars2;
                }

                if (frequencyCount4 > 6 && frequencyCount4 <= 10)
                {
                    rating4 = frequencyStars3;
                }
                if (frequencyCount4 > 10)
                {
                    rating4 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount5 == 0)
                    {
                        rating5 = frequencyStars0;
                    }

                if (frequencyCount5 > 0 && frequencyCount5 <= 3)
                    {
                        rating5 = frequencyStars1;
                    }

                if (frequencyCount5 > 3 && frequencyCount5 <= 6)
                {
                    rating5 = frequencyStars2;
                }

                if (frequencyCount5 > 6 && frequencyCount5 <= 10)
                {
                    rating5 = frequencyStars3;
                }
                if (frequencyCount5 > 10)
                {
                    rating5 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount6 == 0)
                    {
                        rating6 = frequencyStars0;
                    }

                if (frequencyCount6 > 0 && frequencyCount6 <= 3)
                    {
                        rating6 = frequencyStars1;
                    }

                if (frequencyCount6 > 3 && frequencyCount6 <= 6)
                {
                    rating6 = frequencyStars2;
                }

                if (frequencyCount6 > 6 && frequencyCount6 <= 10)
                {
                    rating6 = frequencyStars3;
                }
                if (frequencyCount6 > 10)
                {
                    rating6 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount7 == 0)
                    {
                        rating7 = frequencyStars0;
                    }

                if (frequencyCount7 > 0 && frequencyCount7 <= 3)
                    {
                        rating7 = frequencyStars1;
                    }

                if (frequencyCount7 > 3 && frequencyCount7 <= 6)
                {
                    rating7 = frequencyStars2;
                }

                if (frequencyCount7 > 6 && frequencyCount7 <= 10)
                {
                    rating7 = frequencyStars3;
                }
                if (frequencyCount7 > 10)
                {
                    rating7 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount8 == 0)
                    {
                        rating8 = frequencyStars0;
                    }

                if (frequencyCount8 > 0 && frequencyCount8 <= 3)
                    {
                        rating8 = frequencyStars1;
                    }

                if (frequencyCount8 > 3 && frequencyCount8 <= 6)
                {
                    rating8 = frequencyStars2;
                }

                if (frequencyCount8 > 6 && frequencyCount8 <= 10)
                {
                    rating8 = frequencyStars3;
                }
                if (frequencyCount8 > 10)
                {
                    rating8 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount9 == 0)
                    {
                        rating9 = frequencyStars0;
                    }

                if (frequencyCount9 > 0 && frequencyCount9 <= 3)
                    {
                        rating9 = frequencyStars1;
                    }

                if (frequencyCount9 > 3 && frequencyCount9 <= 6)
                {
                    rating9 = frequencyStars2;
                }

                if (frequencyCount9 > 6 && frequencyCount9 <= 10)
                {
                    rating9 = frequencyStars3;
                }
                if (frequencyCount9 > 10)
                {
                    rating9 = frequencyStars4;
                }

             for (int i = 0; i < dataSet.Length; i++)

                    if (frequencyCount10 == 0)
                    {
                        rating10 = frequencyStars0;
                    }

                if (frequencyCount10 > 0 && frequencyCount10 <= 3)
                    {
                        rating10 = frequencyStars1;
                    }

                if (frequencyCount10 > 3 && frequencyCount10 <= 6)
                {
                    rating10 = frequencyStars2;
                }

                if (frequencyCount10 > 6 && frequencyCount10 <= 10)
                {
                    rating10 = frequencyStars3;
                }
                if (frequencyCount10 > 10)
                {
                    rating10 = frequencyStars4;
                }
            }

            catch (Exception excp)
            {
                MessageBox.Show($"{excp.Message}");
                return;
            }

                // now you need to have statistics display in the textboxes and enable the write buttons

            minValueTextbox.Text    = minValue.ToString();
            maxValueTextbox.Text    = maxValue.ToString();
            rangeTextbox.Text       = (maxValue-minValue).ToString(); 
            meanTextbox.Text        = ((double)sum / numberCount).ToString("N2");
            medianTextbox.Text      = medianValue.ToString();
            histogramTextbox.Text = $"00 - 09   (   {frequencyCount1.ToString()})" + $"{rating1}" + Environment.NewLine +
                                    $"10 - 19   (   {frequencyCount2.ToString()})" + $"{rating2}" + Environment.NewLine +
                                    $"20 - 29   (   {frequencyCount3.ToString()})" + $"{rating3}" + Environment.NewLine +
                                    $"30 - 39   (   {frequencyCount4.ToString()})" + $"{rating4}" + Environment.NewLine +
                                    $"40 - 49   (   {frequencyCount5.ToString()})" + $"{rating5}" + Environment.NewLine +
                                    $"50 - 59   (   {frequencyCount6.ToString()})" + $"{rating6}" + Environment.NewLine +
                                    $"60 - 69   (   {frequencyCount7.ToString()})" + $"{rating7}" + Environment.NewLine +
                                    $"70 - 79   (   {frequencyCount8.ToString()})" + $"{rating8}" + Environment.NewLine +
                                    $"80 - 89   (   {frequencyCount9.ToString()})" + $"{rating9}" + Environment.NewLine +
                                    $"90 - 99   (   {frequencyCount10.ToString()})" + $"{rating10}";

          
        }

        private void DatasetTextbox_KeyPress(object sender, KeyPressEventArgs e)  
        {
            saveButton.Enabled = true;                                          //saveButton activates when user types anything into dataSetTextbox
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();                          //creates dialog window for save option

            DialogResult result = sfd.ShowDialog();

            if (result != DialogResult.OK)                                      //gives up if user does not select OK
            {
                return;
            }

            try
            {
                StreamWriter outputFile = new StreamWriter(sfd.FileName);       //outputs a new savefile based on user input

                outputFile.WriteLine($"{arraySize}");                           //pulls the first line from the array index to find the array size and output it as first number in text file
                outputFile.WriteLine($"{datasetTextbox.Text}");                 //pulls text values from dataSetTextbox to save to file

                MessageBox.Show($"Please load your new file to calculate new values.");

                outputFile.Close();                                             //always close the file when finished
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Output file {sfd.FileName} was not written. {excp.Message}");
                return;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Array.Clear(dataSet, 0, dataSet.Length);
            Array.Clear(dataSet2, 0, dataSet2.Length);
            datasetTextbox.Clear();
            minValueTextbox.Clear();
            maxValueTextbox.Clear();
            meanTextbox.Clear();
            medianTextbox.Clear();
            rangeTextbox.Clear();
            histogramTextbox.Clear();

            frequencyCount1 = 0;
            frequencyCount2 = 0;
            frequencyCount3 = 0;
            frequencyCount4 = 0;
            frequencyCount5 = 0;
            frequencyCount6 = 0;
            frequencyCount7 = 0;
            frequencyCount8 = 0;
            frequencyCount9 = 0;
            frequencyCount10 = 0;
        }
    }
}