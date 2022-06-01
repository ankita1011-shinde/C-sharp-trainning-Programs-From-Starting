using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{
    internal class Order
    {
        int orderid;
        string orderdate;
        string address;
        string mobile;
        Customer customer1 = new Customer();

        public Order()
        {

        }

        public Order(int orderid,string orderdate,string address,string mobile)
        {
            this.Orderid = orderid;
            this.Orderdate = orderdate;
            this.Address = address;
            this.Mobile = mobile;
            this.Customer1 = customer1;
        }
        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public string Address { get => address; set => address = value; }
        public string Mobile { get => Mobile; set => mobile = value; }
        public Customer Customer1 { get => customer1;set => customer1 = value; }


        
    }
    class  Customer
    {
        string item;
        string itemdetails;
        int price;


        public Customer()
        {

        }

        public Customer(string item,string itemdetails,int price)
        {
            this.Item = item;
            this.Itemdetails = itemdetails;
            this.Price = price;
        }

        public string Item { get => item; set => item = value; }
        public string Itemdetails { get => itemdetails; set => itemdetails = value; }
        public int Price { get => price; set => price = value; }
    }
    class Ordertest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.Orderid = 1434;
            o1.Orderdate = "06/3/2022";
            o1.Address = "mumbai,2134";
            o1.Customer1.Item = "Bag";
            o1.Customer1.Itemdetails = "medium in size,black in color";
            o1.Customer1.Price = 1000;


            Console.WriteLine(o1.Orderid);
            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.Address);
            Console.WriteLine(o1.Customer1.Item);
            Console.WriteLine(o1.Customer1.Itemdetails);
            Console.WriteLine(o1.Customer1.Price);
        }
    }
}
