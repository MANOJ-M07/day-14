using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPropetiesExampleFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer();

            Console.WriteLine("enter tax");
            Customer.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine("***customer one***");
            Console.WriteLine("enter id");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("customer details");
            Console.WriteLine("ID: " +customer.Id+"\nName:"+customer.Name);

            Console.WriteLine("***customer two***");
            Console.WriteLine("enter id");
            customer2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            customer2.Name = Console.ReadLine();
            Console.WriteLine("customer details");
            Console.WriteLine("ID: " + customer2.Id + "\nName:" + customer2.Name);
            Console.ReadKey();  
        }
    }
}
