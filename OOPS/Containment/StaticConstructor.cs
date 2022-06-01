using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{
    //Static constructor dosen't required to create an object,it is executed only at once.
    //it is used to innitialize the static variable.
    class  StaticConstructor
    {
        static int a ;
        int b;

        public StaticConstructor()
        {
            Console.WriteLine("in default");
        }
        static StaticConstructor()
        {
            Console.WriteLine("in static: ");
            a = 10;
            
            Console.WriteLine(a);
        }
    }

    class TestStatic
    {
        static void Main(string[] args)
        {
            StaticConstructor sc = new StaticConstructor();
            StaticConstructor sc1 = new StaticConstructor();


        }
    }
}
