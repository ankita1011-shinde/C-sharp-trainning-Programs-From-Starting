using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Account1
    {

       public String custermorname;
        public long accountnum;

        public Account1()
        {
            Console.WriteLine("I am in default constructor");
        }

        public Account1(string nm,long acc)
        {
            custermorname = nm;
            accountnum = acc;
            Console.WriteLine("I am in parameterized constructor");
        }
    }
    class TestAccount1
    {
        static void Main(string[] args)
        {
                Account1 a1 = new Account1();
            Account1 a2 = new Account1("abc",1324354);
        }
    }
}
