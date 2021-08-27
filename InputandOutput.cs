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
        public static void BackgroundColorChange()
        {
            Console.WriteLine("r = red, b = blue, g = green, w white");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);

            while (userInput != 'z') 
            {
                switch(userInput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
                Console.Clear();
                Console.WriteLine("r = red, b = blue, g = green, w white");
                x = Console.Read();
                userInput = Convert.ToChar(x);

            }
        }
    }
}
