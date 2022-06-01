using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{

    class Book
    {
        string bookname;
        int price;
        Story story1 = new Story();

        public Book()
        { 
        }

        public Book(string bookname, int price, Story story1)
        {
            this.Bookname = bookname;
            this.Price = price;
            this.Story1 = story1;
        }

        public string Bookname { get => bookname; set => bookname = value; }
        public int Price { get => price; set => price = value; }
        internal Story Story1 { get => story1; set => story1 = value; }
    }

    class Story
    {
        string storyname;
        int numOfchartr;

    public Story()
        {

        }

        public Story(string storyname,int numOfchartr)
        {
            this.Storyname = storyname;
            this.NumOfchartr = numOfchartr;
        }

        public string Storyname { get => storyname; set => storyname = value; }
        public int NumOfchartr { get => numOfchartr; set => numOfchartr = value; }
    }

    class BootTest
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Bookname = "Jungle Book";
            b.Price = 50;
            b.Story1.Storyname = "The Rabit & tortoise";
            b.Story1.NumOfchartr = 2;

            Console.WriteLine(b.Bookname);
            Console.WriteLine(b.Price);
            Console.WriteLine(b.Story1.Storyname);
            Console.WriteLine(b.Story1.NumOfchartr);

            Book b2 = new Book();
            Console.WriteLine("Enter bookname, price,storyname,numof charater");
            b2.Bookname= Console.ReadLine();
            b2.Price = Convert.ToInt32(Console.ReadLine());
            b2.Story1.Storyname=Console.ReadLine();
            b2.Story1.NumOfchartr= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(b2.Bookname);
            Console.WriteLine(b2.Price);
            Console.WriteLine(b2.Story1.Storyname);
            Console.WriteLine(b2.Story1.NumOfchartr);


        }
    }
}
