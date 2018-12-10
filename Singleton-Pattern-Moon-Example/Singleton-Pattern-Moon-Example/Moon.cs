using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Moon_Example
{
    public class Moon
    {
        private static Moon moon;

        private Moon()
        {
            //Here constructor code for Moon creation
        }

        public static Moon GetInstance()
        {
            if (moon == null)
            {
                moon = new Moon();
            }
            return moon;
        }
    }
}
