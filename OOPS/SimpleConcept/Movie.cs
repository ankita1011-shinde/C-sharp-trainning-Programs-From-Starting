using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Movie
    {

        String moviename,director, producer, f_Actor, m_Actor;
        int rating;

        public void SetMovieName(string nm)
        {
            moviename = nm; 
        }
        public string getMovieName()
        {
            return moviename;
        }

        public void Setdirector(string dir)
        {
            director = dir;
        }
        public string getdirector()
        {
            return director;
        }

        public void Setproducer(string pr)
        {
            producer = pr;
        }
        public string getproducer()
        {
            return producer;
        }

        public void Setf_Actor(string f)
        {
            f_Actor = f;
        }
        public string getf_Actor()
        {
            return f_Actor;
        }

        public void Setm_Actor(string m)
        {
            m_Actor = m;
        }
        public string getm_Actor()
        {
            return m_Actor;
        }

        public void Setrating(int r)
        {
            rating = r;
        }
        public int getrating()
        {
            return rating;
        }
       

        public Movie()
        {
            Console.WriteLine("Hello EveryOne");
        }


    }

    class Test
    {
        static void Main(string[] args)
        {

            Movie m1 = new Movie();

            Console.WriteLine("Enter  moviename,director, producer, f_Actor, m_Actor, rating");
            
           
            string nm =Console.ReadLine();
            m1.SetMovieName(nm);

            string dir = Console.ReadLine();
            m1.Setdirector(dir);

            string pr = Console.ReadLine();
            m1.Setproducer(pr);
           
            string f = Console.ReadLine();
            m1.Setf_Actor(f);

            string m= Console.ReadLine();
            m1.Setm_Actor(m);

            int r = Convert.ToInt32(Console.ReadLine());    
            m1.Setrating(r);

            string a = m1.getMovieName();
            string d= m1.getdirector();
           string p= m1.getproducer();
           string fa= m1.getf_Actor(); 
           string ma= m1.getm_Actor();
           int rt= m1.getrating();


        }
    }
}
