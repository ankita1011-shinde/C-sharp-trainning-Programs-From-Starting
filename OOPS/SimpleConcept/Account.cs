using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.SimpleConcept
{
    internal class Account
    {
        string acc_name;
        int acc_no;
        string acc_type;
        int balance;

        public void accept()
        {
           Console.WriteLine("Enter Name: ");
            acc_name = Console.ReadLine();

            Console.WriteLine("Enter acc no: ");
            acc_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter acc type");
            acc_type = Console.ReadLine();

            Console.WriteLine("Enter balance: ");
            balance = Convert.ToInt32(Console.ReadLine());

        }

        public void withdraw()
        {
            Console.WriteLine("Enter withdraw amout");
            int wamt =Convert.ToInt32(Console.ReadLine());

            if (balance < wamt)
                Console.WriteLine("Insufficient balance");
            else
                balance = balance - wamt;
            Console.WriteLine("withdraw successful");
                Console.WriteLine("After withdrawing, balance is: "+balance);
        }

        public void  deposit()
        {
            Console.WriteLine("Enter ammount to be deposit");
            int damt =Convert.ToInt32(Console.ReadLine());
            balance = balance + damt;
            Console.WriteLine("after deposit amt the balance is: "+balance);
        }
        
    }


    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.accept();
            a1.withdraw();
            a1.deposit();
        }
    }
}
