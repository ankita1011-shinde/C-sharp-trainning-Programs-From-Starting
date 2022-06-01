using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
             //Properties used in c# only.....not in java..
    internal class Country
    {
        string country_name;
        int numOfstate;
        int numOflanguage;
        string capital;

        public string CountryName
        {
            get;
            set;
}
        public int NumOfstate
        {
            get { return numOfstate;}
            set { numOfstate = value; }
        }
        public int NumOflanguage
        {
            get { return numOflanguage;}
            set { numOflanguage = value; }
        }
        public string Capital
        {
            get { return capital;}
            set { capital = value; }
        }
    }
    class TestCountry
    {
        static void Main(string[] args)
        {
            Country c = new Country();
            c.CountryName = "India";
            c.NumOfstate = 28;
            c.NumOflanguage = 1267;
            c.Capital = "Delhi";

            Console.WriteLine(c.CountryName);
            Console.WriteLine(c.NumOfstate);
            Console.WriteLine(c.NumOflanguage);
            Console.WriteLine(c.Capital);


        }
    }

}
