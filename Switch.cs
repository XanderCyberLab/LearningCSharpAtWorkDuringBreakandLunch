using System;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    class Switch
    {
        public static void DayofWeek(string[] args)
        {
            int day = 2;

            switch(day)
            {
                case 1:
                    System.Diagnostics.Debug.WriteLine("Monday");
                    break;
                case 2:
                    System.Diagnostics.Debug.WriteLine("Tuesday");
                    break;
                case 3:
                    System.Diagnostics.Debug.WriteLine("Wednesday");
                    break;
                case 4:
                    System.Diagnostics.Debug.WriteLine("Thursday");
                    break;
                case 5:
                    System.Diagnostics.Debug.WriteLine("Friday");
                    break;
                case 6:
                    System.Diagnostics.Debug.WriteLine("Saturday");
                    break;
                case 7:
                    System.Diagnostics.Debug.WriteLine("Sunday");
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("Not Valid Day");
                    break;
            }
        }
    }
}
