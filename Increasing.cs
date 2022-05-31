using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    internal class Increasing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            //567
            bool isincrease = true;
            bool isdecrease = true;

            int next = n % 10;//7
            n = n / 10;//56

            while(n>0)
            {
                int prev = n % 10; //6

                if(prev>next)
                {
                    isincrease = false;
                }
                if(prev<next)
                {
                    isdecrease= false;
                }

                n = n / 10;
                next = prev;

            }
            if(isdecrease && isincrease)
                Console.WriteLine("All digits are equals in num");
            else if(isincrease)
                Console.WriteLine("Num is increasing");
            else
            Console.WriteLine("Num is Bouncy");

        }
    }
}
