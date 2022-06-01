using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Class1
    {
        //1,3,7,15,31

        static void Main(string[] args)
        {   
            int n=6; 
            int a = 1;
            for(int i=1;i<n;i++)

            {
                Console.WriteLine(a);
                a = (a * 2) + 1;
            }
        }
    }
   
}
