using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Voter
    {

        long Adharcard;
        string VoterName;
        string VoterCasted;


        public void SetAdharcard(long card)
        {
            Adharcard = card;
        }

       
        public long getAdharcard()
        {
            return Adharcard;
        }

        public void SetVoterName(string nm)
        {
            VoterName = nm;
        }
        public string getVoterName()
        {
            return VoterName;
        }

        public void SetVoterCasted(string cast)
        {
            VoterCasted = cast;
        }
        public string getVoterCasted()
        {
            return VoterCasted;
        }

    }
        class TestVoter
        {
            static void Main(string[] args)
            {
            Voter v1 = new Voter();

            Console.WriteLine("Enter Adharcard number, name,voten given");

            long card= Convert.ToInt64(Console.ReadLine());
            v1.SetAdharcard(card);

           long l= v1.getAdharcard();

            string nm = Console.ReadLine();
            v1.SetVoterName(nm);
            string n=v1.getVoterName();

            string cast = Console.ReadLine();
            v1.SetVoterCasted(nm);
            string c = v1.getVoterCasted();



        }
        }

    
}
