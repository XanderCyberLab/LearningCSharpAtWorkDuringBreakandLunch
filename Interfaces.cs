using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Interfaces : IExample
    {
        public static void Main(string[] args)
        {

        }

        public void Example()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }
        public int Exaxmple2()
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
            int Exaxmple2();
            string Example3(string string1, string string2);
        }

    }
}
