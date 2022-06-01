using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Employee
    {
        private int id = 1234;
        private string name = "Ankita";
        private int salary = 40000;

        public void display()
        {
            Console.WriteLine("Private Access modifier");
        }



        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.salary);
            emp.display();

        }
    }    

    
}
