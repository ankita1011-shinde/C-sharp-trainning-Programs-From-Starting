using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{
    internal class Flat
    {
        int flatno;
        string buildingname;
        Member memberojb = new Member();


    public Flat()
        {

        }

        public Flat(int flatno, string buildingname, Member memberojb)
        {
            this.Flatno = flatno;
            this.Buildingname = buildingname;
            this.Memberojb = memberojb;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Member Memberojb { get => memberojb; set => memberojb = value; }
    }

    class Member
    {
        string membername;
        char gengder;
        int age;
        string profession;

       

        public Member(string membername, char gengder, int age, string profession)
        {
            this.Membername = membername;
            this.Gengder = gengder;
            this.Age = age;
            this.Profession = profession;
        }
        public Member()
        {

        }
        public string Membername { get => membername; set => membername = value; }
        public char Gengder { get => gengder; set => gengder = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
    }

    class FlatTest
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            Console.WriteLine("Enter flatno, bldname, member name , gender , age, profession");
            f1.Flatno = Convert.ToInt32(Console.ReadLine());
            f1.Buildingname = Console.ReadLine();
            f1.Memberojb.Membername = Console.ReadLine();
            f1.Memberojb.Gengder = Convert.ToChar(Console.ReadLine());
            f1.Memberojb.Age = Convert.ToInt32(Console.ReadLine());
            f1.Memberojb.Profession = Console.ReadLine();

            Console.WriteLine("Flat num: "+f1.Flatno);
            Console.WriteLine("Building name: "+f1.Buildingname);
            Console.WriteLine("Member name: "+f1.Memberojb.Membername);
            Console.WriteLine("Gender: "+f1.Memberojb.Gengder);
            Console.WriteLine("Age is: "+f1.Memberojb.Age);
            Console.WriteLine("Profession: "+f1.Memberojb.Profession);

           
        }
    }
}
