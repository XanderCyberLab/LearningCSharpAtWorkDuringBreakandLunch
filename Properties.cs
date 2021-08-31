using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpAtWorkDuringBreakandLunch
{
    /*
     * Properties are not variables It allows us to get and set properties 
     * and have a private property hidden in the room.
     */
    class Properties
    {
        private string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public static void PropertiesMethod()
        {
            Properties propMethod = new Properties();
            propMethod.id = "9000";
            System.Diagnostics.Debug.WriteLine(propMethod.Id);
        }
    }

}
