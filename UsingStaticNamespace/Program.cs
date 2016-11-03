using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace UsingStaticNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before C#6.0

            //Console.WriteLine("Hello!! I am Tanvir Ahmad Arjel");
            //Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));

            //After C#6.0

            WriteLine("Hello!! I am Tanvir Ahmad Arjel");
            WriteLine("Square root of 25 is {0}", Sqrt(25));


        }
    }
}
