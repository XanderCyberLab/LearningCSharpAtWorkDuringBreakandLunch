using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class FunctionTypes
    {   
        // 3 Different Functions
        int addingtwonumbers(int a, int b) { return a + b; }
        int addingthreenumbers(int a, int b, int c) { return a + b + c; }
        int addingfournumbers(int a, int b, int c, int d) { return a + b + c + d; }
        // Overloading with one function
        int addingnumbers (int a, int b) { return a + b; }
        int addingnumbers(int a, int b, int c) { return a + b + c; }
        int addingnumbers(int a, int b, int c, int d) { return a + b + c + d; }

        public static void Func()
        {
            Func<int, int, int> multiply = (x, y) => { return x * y; }; 
            System.Diagnostics.Debug.WriteLine(multiply(3, 2));
            // Func Delegates, Parameters(Last type is type that be returned), Lamba Expression and Multiplies
        }
        // Types of Overloading. Use best for running same operation with multiple inputs
        void Overloading() { }
        void Overloading(int number) { }
        void Overloading(int number, int number2) { }
        void Overloading(string word1, string word2) { }
        void Overloading(string word, int number) { }
        void Overloading(int number, string word) { }

        public static void InfiniteParams(params string[] words)
        {
            foreach(string word in words) // Interate
            {
                System.Diagnostics.Debug.WriteLine(word);
            }
        }

        //public static void Main(string[] args)
        //{

        //    InfiniteParams();
        //    InfiniteParams("Wishmaster");
        //    InfiniteParams("Wishmaster", "Akunin");
        //    InfiniteParams("Wishmaster", "Akunin", "Is the Best");
        //}


    }

}
