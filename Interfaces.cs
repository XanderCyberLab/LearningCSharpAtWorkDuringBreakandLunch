using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Interfaces : IExample, ISecondExample
    {
        public static void Mainsub(string[] args)
        {
            Debug.WriteLine("Test");
        }

        public void Example()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }
        public int Example2()
        {
            return 1;
        }
        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }


    }
    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }
    interface ISecondExample
    {
    
    }


}
