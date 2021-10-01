using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Algorithms
    {
        //static int a = 30, b = 25; //Scope through out the Algorithms Class
       
  
        private static void MainAlgo(string[] args)
        {
            //Question 1
            //Debug.WriteLine(SumTwoPractice(10, 20));
            //Debug.WriteLine(SumTwoPractice(24, 26));
            //Debug.WriteLine(SumTwoPractice(20, 20));

            //Question 2
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(53));
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(30));
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(51));

            //Question 3
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(30, 0));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(25, 5));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(20, 30));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(20, 25));

            //Using Void and Calling from Inside / outside the Function  / Scope Methods
            //var Addition = Add2(10, 5); // Call Method from Outside Function
            //Debug.WriteLine(Addition);

            //Add(10, 10); // Call Method from Inside Function

            //var sub = Sub(a, b); // Call Variables from outside of Function, From the Class
            //Debug.WriteLine(sub); //Test

            //Question 4
            //Console.WriteLine(CheckIntergerIfWithinRange(103));
            //Console.WriteLine(CheckIntergerIfWithinRange(90));
            //Console.WriteLine(CheckIntergerIfWithinRange(89));
            //Console.WriteLine(CheckIntergerIfWithinRange(209));

            Console.ReadLine();
            
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static void Add(int a, int b) // Call Method Inside
        {
            int sum = a + b;
            Debug.WriteLine(sum);
        }
        public static int Add2(int a, int b) // Return Method to be used Outside 
        {
            int sum = a + b;
            return sum;
        }
        public static int SumTwoIntegersTripleIfSameValues(int a, int b)
        {
            /* Question 1
            Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, 
            then return triple their sum. 
            Sample Input:
            1, 2
            3, 2
            2, 2
            Expected Output:
            3
            5
            12   
            */
            return a == b ? (a + b) * 3 : a + b;
            /*if(a != b)
            {
                return  (a + b);
            }
            else
            {
                return ((a + b) * 3);
            }*/
        }        
        public static int AbsoluteDifferenceBetweenTwoValues(int n)
            {
            /*
             * Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. Go to the editor
                Sample Input:
                53
                30
                51
                Expected Output:
                6
                21
                0
             */
            int abs = 51;

            if (n > abs)
            {
                return (n - abs) * 3;
            }
            else
            {
                return abs - n;
            }
        }
        public static bool CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(int a, int b)
        {

            /*Question 3
            Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 
            Sample Input:
            30, 0
            25, 5
            20, 30
            20, 25
            Expected Output:
            True
            True
            True
            False
            */
            int c = 30;

            return (a == c) || (b == c) || (a + b == c);        
        }
        public static int SumTwoPractice(int a, int b)
        {
            /*
             * Question 1
            Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, 
            then return triple their sum. 
            Sample Input:
             */
            return a == b ? (a + b) * 3 : a + b;
            //if(a == b)
            //{
            //    return (a + b) * 3;
            //}
            //return a + b;
        } 
        public static bool CheckIntergerIfWithinRange(int a)
        {
            /*Question 4
             * Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. Go to the editor
                Sample Input:
                103
                90
                89
             */
            //return a <= 110 && a >= 90; //Only work One Number not Two
            if (Math.Abs(a - 100) <= 10 || Math.Abs(a - 200) <= 10) //<-- Math.Abs learned something new!
                return true;
            return false;
            
            
        } // Math.Abs <-- !

    }
}

