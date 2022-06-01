using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Stock
    {
        int openingprice;
        float closingprice;
        string stockname;


        public Stock()
        {
            Console.WriteLine("I am in Default contructor");

        }

        public void Setopeningprice(int op)
        {
            openingprice = op;
        }
        public int getopeningprice()
        {
            return openingprice;
        }

        public void Setclosingprice(float cp)
        {
            closingprice = cp;
        }
        public float getclosingprice()
        {
            return closingprice;
        }
        public void Setstockname(string snm)
        {
            stockname = snm;
        }
        public string gestockname()
        {
            return stockname;
        }
    }

    class  TestStock
    {
        static void Main(string[] args)
        {
            Stock s1 = new Stock();

            Console.WriteLine( "Enter stock openeing price ");
            int op = Convert.ToInt32(Console.ReadLine());
            s1.Setopeningprice(op);

            Console.WriteLine("Enter stock closing price ");
            float cp = Convert.ToInt32(Console.ReadLine());
            s1.Setclosingprice(cp);

            Console.WriteLine("Enter stock name ");
            string snm = Console.ReadLine();
            s1.Setstockname(snm);

            Console.WriteLine(s1.getopeningprice());
            Console.WriteLine(s1.getclosingprice());
            Console.WriteLine(s1.gestockname());
        }
    }
}
