using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.MethodOverriding
{
    //complusary write abstract word in front of class n method
    //cant create object
    //you will have all type of method in abstract class
    //implementation is in that child class
   abstract  class AbstractClass
    {
public void sms()
        {

        }
        abstract public void playgames();
        
    }
    class p
    {
        public void m1()
        {
            Console.WriteLine(  "in m1........");
        }
        public void greet()
        {
            m1();
        }
    }
    class C : p
    {
        public void m2()
        {
            Console.WriteLine("in m2.........");
            m2();
        }
        static void Main(string[] args)
        {
            C c = new C();
            c.m1();

        }
    }
   

}
