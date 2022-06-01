using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Recursion
{
    //it is a function calling itself again and again,
   class Class1
    {
        public static void M1()
        {
            Console.WriteLine("In M1");
        }
        public static void greet(int c)  //for avoiding recursion
        {
            Console.WriteLine("Good  Morning");
            if (c > 0)
            {
                greet(c - 1);
            }
                Console.WriteLine("Bye greet");
            
        }
        static void Main(string[] args)
        {
            greet(3);
        }
    }
}
