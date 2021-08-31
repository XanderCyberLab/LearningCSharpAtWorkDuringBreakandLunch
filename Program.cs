using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Program : Properties

    {
         

        public static void Main(string[] args)
        {

            PropertiesMethod();



        }


        private static void UserProfile()
        {
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();
            System.Diagnostics.Debug.WriteLine(userName);
        }
    }
}
