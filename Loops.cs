using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Loops  // 3 States Initialization , Condition, Increment
    {
        public static void ForLoop()
        {   
            for(int x = 0; x <= 10; x++)
            {
                System.Diagnostics.Debug.WriteLine(x);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine(i);
            //}
        }
        public static void ForLoop2()
        {
            string example = "abc";
            for (int i = example.Length - 1; i >=0; i--)//example.Length = 3 but # start at 0 so you minue one(0,1,2 = 3 units)
            {
                System.Diagnostics.Debug.WriteLine(example[i]);
            }
        }
        public static void ForLoop3()
        {
            int i = 0;
            for(; ;) //This shows we can use a for loop without any statements
            {
                if(i < 4)
                {
                    System.Diagnostics.Debug.WriteLine(i.ToString());
                    i++;
                }
            }
        }
        public static void NestedLoops()
        {
            for (int i = 0; i < 5; i++) 
            {
                for (int z = 0; z < 5; z++) 
                {
                    System.Diagnostics.Debug.WriteLine("i = " + i.ToString() + " z = " + z.ToString()) ;
                }
            }
        }
        public static void LoopChallenge()
            
        {
            int x = 0;
                for (int i = 0; i < 100; i++)
                {
                    x += i;
                }

            System.Diagnostics.Debug.WriteLine(x);          
                
        }
        public static void WhileLoops()
        {
            int i = 0;
            while (i < 5)
            {
                System.Diagnostics.Debug.WriteLine(i.ToString());
                i++;
            }
        }
        public static void WhileLoopChallenge()
        {
            int x = 3;
                while(x > 0)
            {
                System.Diagnostics.Debug.WriteLine(x);
                x-=1;
            }
        }
    }
}

