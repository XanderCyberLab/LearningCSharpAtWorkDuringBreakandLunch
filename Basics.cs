using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Basics
    {
        static void MainBasics(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Alexander Morales created of XanderToolz \"A Digital Toolbox\"");
            RandonEquations();
            SwapTwoIntergers();
            Console.WriteLine("Enter First Number out of 3 for Multiply Equation");
            var firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number out of 3 for Multiply Equation");
            var secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number out of 3 for Multiply Equation");         
            var thirdNumber = Int32.Parse(Console.ReadLine());

            int sum = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        public static float Addition(float a1, float a2)
        {
            return a1 + a2;
        }
        public static float Substract(float a1, float a2)
        {
            return a1 - a2;
        }
        public static float Multiplication(float a1, float a2)
        {
            return a1 * a2;
        }
        public static float Division(float a1, float a2)
        {
            return a1 / a2;
        }
        public static void RandonEquations()
        {
            float sum, sum2, sum3, sum4;
            sum = -1 + 4 * 6;
            sum2 = (35 + 5) % 7;
            sum3 = 14 + -4 * 6 / 11;
            sum4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);                         
        }
        public static void SwapTwoIntergers()
        {
            int c = 0;
            int a = 5;
            int b = 6;
            Console.WriteLine("A = "+a);
            Console.WriteLine("B = "+b);
            c = b;
            b = a;
            a = c;
            Console.WriteLine("A now = "+a);
            Console.WriteLine("B now = "+b);


        }
    }
}
