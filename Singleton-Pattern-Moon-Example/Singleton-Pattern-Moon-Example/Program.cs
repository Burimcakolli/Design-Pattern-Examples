using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern_Moon_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Singleton---");
            Moon obj1 = Moon.GetInstance();
            Moon obj2 = Moon.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("---Non Singleton---");
            Star obj3 = new Star();
            Star obj4 = new Star();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());

            //Press CTRL+F5 to run
        }
    }
}
