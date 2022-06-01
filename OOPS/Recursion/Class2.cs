using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Recursion
{
    class Class2
    {
        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = Factorial(n - 1);
                return n* ans;
            }
        }
        static void Main(string[] args)
        {
            int r = Factorial(3);
        }
    }
}
