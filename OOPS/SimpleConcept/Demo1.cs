using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
      // in static method u cant call instance method
      //  in instance method/variable----- we can call static method directly 

    internal class Demo1
    {
        public void greet()
        {
            Console.WriteLine("Good morning");
        }

        public int Add(int a,int b)
        {   greet();
            int c = a + b;
            return c;
        }

        static public void m3()
        {
            Console.WriteLine(" method m3");
        }
        static public void m4()
        {
            m3();
            Console.WriteLine(" method m4");
        }

    }

    class TestDemo
    {
        static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();

            d1.greet();
            d1.Add(1,2);
            Demo1.m3();
            Demo1.m4();

        }
    }
}
