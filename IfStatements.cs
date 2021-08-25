using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class IfStatements
    {
        public static void IfandElse()
        {
            int age = 21;
            string gender = "male";
            if (age >= 21)
            {
                if (gender == "female")
                {
                    System.Diagnostics.Debug.WriteLine("It's ladies night and drinks are for free");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("You're able to drink and pay for your own drinks");
                }

            }
            else 
            {
                System.Diagnostics.Debug.WriteLine("You're too young to drink");
            }
        }
    }
}
