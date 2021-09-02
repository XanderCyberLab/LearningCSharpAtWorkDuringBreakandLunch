using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Program 

    {
        static async Task CookMeat() //Asynchronous Functions
        {
            Debug.WriteLine("Cook Meat");
        }
        static async Task CookVegetatables()
        {
            Debug.WriteLine("Cook Vegetables");
        }
        static async Task CookSoup()
        {
            Debug.WriteLine("Cook Soup");
        }
        static async Task CookJuviasFood()
        {
            Debug.WriteLine("Cook food for Juvia");
        }
        static async void MakeDinner()
        {
            await CookMeat();
            await CookVegetatables();
            await CookSoup();
            await CookJuviasFood();
        }
        static void Printmessage(string message = "Hello World")
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
      
        public static void Mainsub(string[] args)
        {
            MakeDinner();
  
                

            //Printmessage();
            //Printmessage("Hello Texas");

        }


        private static void UserProfile()
        {
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();
            System.Diagnostics.Debug.WriteLine(userName);
        }

        //Console.WriteLine("Enter first digit?");
        //    string firstNum = Console.ReadLine();
        //Console.WriteLine("Enter second digit?");
        //    string secondNum = Console.ReadLine();
        //Console.WriteLine("You two numbers are " + firstNum);
    }
}
