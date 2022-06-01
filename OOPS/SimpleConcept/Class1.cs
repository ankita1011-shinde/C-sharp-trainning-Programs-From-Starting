using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Car
    {
        string name, colour, model, brand;

        static void Main(string[] args)
        {
            Car c1= new Car();
            Car c2 = new Car();

            c1.name = "Honda city";
            c1.colour = "White";
            c1.model = "Disel";
            c1.brand = "Honda";

            c2.name = "$ Matic";
            c2.colour = "Black";
            c2.model = "Disel";
            c2.brand = "Meredes";

            Console.WriteLine(c1);
            Console.WriteLine($"name: {c1.name}, colour: {c1.colour}, modle: {c1.model}, brand: {c1.brand}");
            Console.WriteLine($"name: {c2.name},colour: {c2.colour}, modle: {c2.model}, brand: {c2.brand}");
        }
    }
}
