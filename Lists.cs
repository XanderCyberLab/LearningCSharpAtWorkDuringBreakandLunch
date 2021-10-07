using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Lists
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 7, 8, 2, 4, 6, 8 };

        public static void Main(string[] args)
        {

            numbers.Insert(0, 101);
            Debug.WriteLine("Index of element 101 is: " + numbers.BinarySearch(101));
            
            foreach(int i in numbers)
                {
                Debug.WriteLine(i);
                } 
            //numbers.Capacity = 10;
            //numbers.Add(20);
            //List<int> subList = new List<int>() { 12, 14 };
            //numbers.AddRange(subList);
            //numbers.Sort();
            //Debug.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));
            //Debug.WriteLine(numbers.Contains(3));
            //Debug.WriteLine(numbers.Contains(100));
            //Debug.WriteLine(numbers.Contains(14));

        }
        

    }

}
