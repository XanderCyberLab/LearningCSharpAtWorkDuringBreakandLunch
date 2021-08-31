using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearningCSharpAtWorkDuringBreakandLunch
/*
Constructors are special method to create objects.It allows to set default values as soon as 
object is created. Making it easier to read and more flexible code. 
Syntax is senstive
It must have the same name as the class name    
*/
{
    class Constructors
    {
        int exampleConstructor;
        string exampleName;
        public Constructors(int num)
        {
            exampleConstructor = num;
        }
        public Constructors(int num, string name)
        {
            exampleConstructor = num;
            exampleName = name;
        }
        public static void MainTest(string[] args)
        {
            Constructors testCons = new Constructors(10);
            Constructors testName = new Constructors(10, "Wishmaster");
            System.Diagnostics.Debug.WriteLine(testName.exampleName);                
         
        }
    }
}
