using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Calculator
    {
        public void add(int a,int b,int c)
        {
          int d= a + b + c;
            Console.WriteLine("Addition is: "+d);
              
        }

        public int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <=n; i++)
            {
                fact = fact * i;
            }
            return fact;

        }

        public bool isprime(int n)
        {
            int flag = 0;
            for (int i = 2; i < n; i++) 
            {
                if(n%2 ==0)
                {
                    flag = 1;

                    break;
                }

            }
            if(flag == 0)
            
                return true;
            else
                return false;
            
            
            
        }

        public string greet(String nm)
        {
            return "Good Afternoon " + nm;
        }

    }

    class TestCalculator
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();

            cl.add(3, 4, 2);
            int f=cl.factorial(5);
           bool b= cl.isprime(6);
            string s=cl.greet("ankita");

            Console.WriteLine($"factorial= {f}");
            Console.WriteLine($"is prime= {b}");
            Console.WriteLine($"msg= {s}");
        }
    }
}
