using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class InputandOutput
    {
        public static void Keystrokes()
        {
            Console.WriteLine("Hit any key");
            int x = Console.Read();
            System.Diagnostics.Debug.WriteLine(Convert.ToChar(x));//Convert.ToChar(x) convert key press to actual key
        }
    }
}
