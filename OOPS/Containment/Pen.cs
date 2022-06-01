using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{
     class Pen
    {
        int cap_length;
        string brand;
        Refill rf = new Refill();
        

        public Pen()
        {

        }
        public Pen(int cap_length, string brand, Refill rf)
        {
            this.cap_length = cap_length;
           this. brand = brand;
           this. rf = rf;

        }
        public int Cap_Length { get =>cap_length; set =>cap_length = value; }
        public string Brand { get =>brand; set =>brand = value; }
            
        public Refill Rf{ get => rf; set => rf = value; }
    }
    class Refill
    {
        string ink_colr;
        int length;
        Nib n1 = new Nib();

        public Refill()
        {

        }
        public Refill(string ink_colr, int length,Nib n1)
        {
          this.  ink_colr = ink_colr;
          this.  length = length;
          this.  n1 = n1;
        }

        public string Ink_colr { get => ink_colr;set=> ink_colr = value; }
        public int Length { get => length; set => length = value; }
        public Nib N1 { get => n1; set => n1 = value; }
    }
    class Nib
    {
        string material;
        double width;

        public Nib()
        {

        }
        public Nib(string material,double width)
        {
          this.  material = material;
           this. width = width;
           
        }
        public string Material { get => material; set => material = value; }
        public double Width { get => width; set => width = value; }
    }

    class PenTest
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.Cap_Length = 2;
            p1.Brand = "cello";
           p1.Rf.Ink_colr = "Black";
           p1.Rf.Length = 4;
            p1.Rf.N1.Material = "plastic";
            p1.Rf.N1.Width = 0.2;

            Console.WriteLine(p1.Cap_Length);
            Console.WriteLine(p1.Brand);
            Console.WriteLine(p1.Rf.Ink_colr);
            Console.WriteLine(p1.Rf.Length);
            Console.WriteLine(p1.Rf.N1.Material);
            Console.WriteLine(p1.Rf.N1.Width);
;
        }
    }
}
