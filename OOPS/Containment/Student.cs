using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment

{
   class Student
    {
        int studid;
        string name;
        int percent;
        Batch batch1 = new Batch();
        Address adr = new Address();



        public Student()
        {

        }

        public Student(int studid, string name, int percent, Batch batch1, Address adr)
        {
            this.Studid = studid;
            this.Name = name;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Adr = adr;
        }

        public int Studid { get => studid; set => studid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        internal Batch Batch1 { get => batch1; set => batch1 = value; }
        internal Address Adr { get => adr; set => adr = value; }
    }
    class Batch
    {
        string batchname;
        string subject;

        public Batch()
        {

        }

        public string Batchname { get => batchname; set => batchname = value; }
        public string Subject { get => subject; set => subject = value; }
    }

    class Address
      {
            string street;
            string city;

    public Address()
            {

            }

            public string Street { get => street; set => street = value; }
            public string City { get => city; set => city = value; }
        
    }

    class StudTest
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Studid = 101;
            s.Name = "Ankita";
            s.Percent = 90;
            s.Batch1.Batchname = "Apple";
            s.Batch1.Subject = "C#";
            s.Adr.City = "Mumbai";
            s.Adr.Street = "Meera road";

        }
       
        
        
        
    }
}
