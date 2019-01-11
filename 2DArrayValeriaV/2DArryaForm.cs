using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace _2DArrayValeriaV
{
    public partial class frm2DArray : Form
    {
        public frm2DArray()
        {
            InitializeComponent();
        }

        //Function: CalcAverage
        //Input: int[,]tmpArray, int width, int length
        //Output: double average
        //Description: this function calcualtes the average of all values in the array
        private double CalcAverage(int[,]tmpArray, int width, int length)
        {
            //declare local varaibles
            double average = 0;
            double numOfVal = 0;
            double sum = 0;

            //get the length of the array
            numOfVal = tmpArray.Length;

            //loop through each element in the width
            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                //loop through each element in the length
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    //calculate the sum of the values in the array
                    sum = sum + tmpArray[widthCounter, lengthCounter];
                }


            }
            //calcualte the average
            average = sum / numOfVal;
            //return the average
            return average;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //declare local variable
            int width;
            int length;
            int aRandNum;
            Random generateRandNum = new Random();
            string pieceText = "";

            width = Convert.ToInt16(nudWidth.Value);
            length = Convert.ToInt16(nudLength.Value);
            //create a 2D array
            int[,] randArray = new int[width, length];

            //loop through each element in the width
            for (int widthCounter = 0; widthCounter < width; widthCounter++ )
            {
                //loop through each element in the length
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    //generate a random number
                    aRandNum = generateRandNum.Next(1, 10);
                    //add the random number to the array
                    randArray[widthCounter, lengthCounter] = aRandNum;
                    //display it in the textbox
                    pieceText = pieceText + " " + aRandNum  ;
                }
                //format the string
                pieceText = pieceText + "\r" + "\n";

            }
            //display in the textbox
            txtArray.Text = pieceText;

            double displayValue = CalcAverage(randArray, width, length);
            MessageBox.Show("The average of all numbers is " + displayValue);
            
        }

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
