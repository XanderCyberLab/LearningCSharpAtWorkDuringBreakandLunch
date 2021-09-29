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
        private static void Main(string[] args)
        {
            //Question 1
            Debug.WriteLine(SumTwoPractice(10, 20));
            Debug.WriteLine(SumTwoPractice(24, 26));
            Debug.WriteLine(SumTwoPractice(20, 20));

            //Question 2
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(53));
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(30));
            //Debug.WriteLine(AbsoluteDifferenceBetweenTwoValues(51));

            //Question 3
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(30, 0));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(25, 5));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(20, 30));
            //Debug.WriteLine(CheckTwoIntegersIfReturnTrueIfEqualsOrSumsToThirty(20, 25));

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
    }
}

