using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Laptop
    {
        String brand;
        String name;
        int price;
        int memory;

        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public String Name
        {
            get;
            set;
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Memory
        {
            get { return memory; }
                    set { memory = value; }
        }
    }

    class TestLaptop
    {
        static void Main(string[] args)
        {
            Laptop p = new Laptop();
            p.Brand = "Apple";
            p.Name = "Macbook";
            p.Price = 1344556;
            p.Memory = 64;

            Console.WriteLine(p.Brand);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Memory);
        }
    }
}
