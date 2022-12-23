using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algro
{
    public partial class form1 : Form
    {

        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        int[] array = new int[6];

        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void lblinsertion_Click(object sender, EventArgs e)
        {

            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            num3 = int.Parse(txt3.Text);
            num4 = int.Parse(txt4.Text);
            num5 = int.Parse(txt5.Text);
            num6 = int.Parse(txt6.Text);

            // declare an array
            array = new int[] { num1, num2, num3, num4, num5, num6 };

            // insertion methode algo
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                var key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                    array[j + 1] = key;
                }

            }
            //print the result

            string sorted_array = string.Join(",", array);
            label4.Text = sorted_array;




        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            array = new int[6];
            label4.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";



        }








        private void lblmerge_Click(object sender, EventArgs e)
        {


            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            num3 = int.Parse(txt3.Text);
            num4 = int.Parse(txt4.Text);
            num5 = int.Parse(txt5.Text);
            num6 = int.Parse(txt6.Text);
            


            // declare an array
            int[] numbers = new int[] { num1, num2, num3, num4, num5, num6 };

           
            //call mergeSort method
            mergeSort(numbers, 0, numbers.Length - 1);

            //print result

            string sorted_array = string.Join(",", numbers);
            label4.Text = sorted_array;


           
        }
        /* MergerSort Algorithm will divide the array
            1st parameter is the array to sort, 2nd is the starting index(usually 0),
            the 3rd is the upperbound of the array(which is usually the last index)
            example:- a numbers array with 5 indexs would be mergeSort(numbers, 0, numbers.Length - 1)
            *******THIS METHOD WILL NOT WORK WITHOUT THE MERGE METHOD********
        */
        public void mergeSort(int[] sortArray, int lower, int upper)
        {
            int middle;
            if (upper == lower)
                return;
            else
            {
                middle = (lower + upper) / 2;
                mergeSort(sortArray, lower, middle);
                mergeSort(sortArray, middle + 1, upper);
                Merge(sortArray, lower, middle + 1, upper);
            }
        }
        // Merge method will merge subarrays together incrementally
        // ******THIS METHOD WILL NOT WORK WITHOUT THE MERGESORT METHOD********
        public void Merge(int[] sortArray, int lower, int middle, int upper)
        {
            int[] temp = new int[sortArray.Length];
            int lowEnd = middle - 1;
            int low = lower;
            int n = upper - lower + 1;

            while ((lower <= lowEnd) && (middle <= upper))
            {
                if (sortArray[lower] <= sortArray[middle])
                {
                    temp[low] = sortArray[lower];
                    low++;
                    lower++;
                }
                else
                {
                    temp[low] = sortArray[middle];
                    low++;
                    middle++;
                }
            }
            while (lower <= lowEnd)
            {
                temp[low] = sortArray[lower];
                low++;
                lower++;
            }
            while (middle <= upper)
            {
                temp[low] = sortArray[middle];
                low++;
                middle++;
            }
            for (int i = 0; i < n; i++)
            {
                sortArray[upper] = temp[upper];
                upper--;
            }




        }   
     }
}
