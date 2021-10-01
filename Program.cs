using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearningCSharpAtWorkDuringBreakandLunch.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SimpleMath.Addition(321.3f, 123.5f));


            BankAccount bankAccount1 = new BankAccount(10f, "Alexander"); //Creating a instance of a class. Define a object
            Console.WriteLine(bankAccount1.Balance);

            BankAccount bankAccount2 = new BankAccount(1000f, "Mashire");

            BankAccount bankAccount3 = new BankAccount(10000f, "Kyohei");

            ChildBankAccount childBankAccount1 = new ChildBankAccount(10f, "Alexis Juvia", "Mashire"); 
            
            //bankAccount1.balance = bankAccount1.AddBalance(100f);

            //Console.WriteLine(bankAccount1.balance);
            Console.WriteLine(bankAccount1.AddBalance(-100f, true));
            Console.WriteLine(bankAccount2.AddBalance(1000f));
            Console.WriteLine(childBankAccount1.AddBalance(1000f));

            //bankAccount1.balance = bankAccount1.WithdrawnBalance(90f);

            //Console.WriteLine("$90 withdrawn from " + bankAccount1.owner +"'s bank account. Remaining Balance: " + bankAccount1.balance);
            //Console.WriteLine(bankAccount1.WithdrawnBalance(90f));
            Console.ReadLine(); //TestTest

        }
    }

    class SimpleMath
    {
        public static float Addition(float a1, float a2)
        {
            return a1 + a2;
        }
        public static float Substract(float a1, float a2)
        {
            return a1 - a2;
        }
        public static float Multiplication(float a1, float a2)
        {
            return a1 * a2;
        }
        public static float Division(float a1, float a2)
        {
            return a1 / a2;
        }

    }
}