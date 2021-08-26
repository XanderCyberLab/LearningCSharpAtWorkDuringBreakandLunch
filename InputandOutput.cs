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
        public static void UserNumericInput()
        {
            Console.WriteLine("Please enter a number");
            do
            {
                string userInput = Console.ReadLine();
                int number;

                if (!int.TryParse(userInput, out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered a wrong key");
                    Console.ResetColor();
                    Console.WriteLine("Please enter a number");
                }
                else
                {
                    Console.WriteLine("Thanks for your number");    
                }

            } while (true);
        }
    }
}
