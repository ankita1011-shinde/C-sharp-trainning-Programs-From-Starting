using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Pen
    {
        string brand, colour;
        int price;

        public Pen()
        {
            Console.WriteLine("I have one pen");
        }
        public Pen(string brand,string colour,int price)
        {
            brand = brand;
            colour = colour;    
            price = price;  
            Console.WriteLine( "para");
        }
        public void Setbrand(string brand)
        {
            this.brand = brand; 
        }

        public string getbrand()
        {
            return this.brand; 
        }

        public void Setcolour(string colour)
        {
            this.colour = colour;
        }

        public string getcolour()
        {
            return this.colour;
        }

        public void Setprice(int price)
        {
            this.price = price;
        }

        public int getprice()
        {
            return this.price;
        }
    }

    class PenTest
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();



            Console.WriteLine("Enter  Brand of pen: ");
            string brand = Console.ReadLine();
            p.Setbrand(brand);

            Console.WriteLine("Enter  colour of pen: ");
            string colour = Console.ReadLine();
            p.Setcolour(colour);

            Console.WriteLine("Enter price of pen: ");
            int price =Convert.ToInt32(Console.ReadLine());
            p.Setprice(price);

            

            Console.WriteLine(p.getbrand() );
            Console.WriteLine(p.getcolour()); 
            Console.WriteLine(p.getprice());



            Pen p1 = new Pen();
             p1.Setbrand("cello");
            p1.Setcolour("blue");
            p1.Setprice(10);

            Console.WriteLine(p1.getbrand());
            Console.WriteLine(p1.getcolour());
            Console.WriteLine(p1.getprice());
            Pen p3 = new Pen("cello", "white", 5);
        }
    }
}
