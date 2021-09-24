using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Arrays
    {
        //string[] strings = new string[] { "a", "b", "c" }; // Create a array with size of array
        public static int[] array = new int[] { 1, 2, 3 };

        public static void Main(string[] args)
        {
            array[0] = 5; // To change array 0 to 5
            //Debug.WriteLine(array.Length); // Returns size of array
            //Debug.WriteLine(array[0]); // Display first array
            Array.Sort(array);
            foreach (int i in array) // Display all arrays in a sorting. Works by numbers and string
            {
                Debug.WriteLine(i);
            }
        }

        //System.Array Right Click on Array Go To Definition to show all interfaces
    }
}


