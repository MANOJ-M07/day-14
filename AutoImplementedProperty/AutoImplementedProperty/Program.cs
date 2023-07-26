using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Rajiv");
            Console.WriteLine("enter id");
            customer.Id = int.Parse(Console.ReadLine());

            /*Console.WriteLine("enter name");
            customer.Name = Console.ReadLine();*/

            Console.WriteLine("enter customer city");
            customer.City = Console.ReadLine();
            Console.WriteLine("enter customer over draft limit");
            customer.ODLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("customer details as follows");
            Console.WriteLine($"ID: {customer.Id} name: {customer.Name}");
            Console.WriteLine($"city: {customer.City} odlimit: {customer.ODLimit}");
            Console.ReadKey();
        }
    }
}
