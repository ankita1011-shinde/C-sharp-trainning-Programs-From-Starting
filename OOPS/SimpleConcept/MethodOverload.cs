using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class MethodOverload
    {
        //More than 1 method----having same parameter,number parameter,order of parameter
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition is: "+(a+b));
        }

        public void Add(float a, float b)
        {
            Console.WriteLine("sum :"+(a+b));
        }

        public void Add(double a,double b)
        {
            Console.WriteLine("Add: "+(a+b));
        }
    }

    class TestOverload
    {
        static void Main(string[] args)
        {
            MethodOverload mo = new MethodOverload();
            mo.Add(23, 40);
            mo.Add(2.63, 23.2);
            mo.Add(1.233, 23.2323);
        }
    }
}
