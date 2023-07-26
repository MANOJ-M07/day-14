using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //read and write example
            /* Customer customer = new Customer();
             Console.WriteLine("***Default Values***");
             Console.WriteLine($"Customer Id: {customer.Id} Name: {customer.Name} membershipEndDate: {customer.MEndDate}");

             Console.WriteLine("enter customer id");
             customer.Id = int.Parse( Console.ReadLine() );
             Console.WriteLine("enter customer name");
             customer.Name = Console.ReadLine();
             Console.WriteLine("enter the membership end date");
             customer.MEndDate = DateTime.Parse( Console.ReadLine() );
             Console.WriteLine("Stored record as follows!!!");
             Console.WriteLine($"Customer Id: {customer.Id} Name: {customer.Name} membershipEndDate: {customer.MEndDate}");*/


            //read only 
            /*
                        Customer customer=new Customer(12,"raj", new DateTime(day:09,month:09,year:2022));
                        Console.WriteLine("customer Details as follows");
                        Console.WriteLine($"Customer Id: {customer.Id} Name: {customer.Name} membershipEndDate: {customer.MEndDate}");*/

            //Console.WriteLine("enter customer id");
            //customer.Id = int.Parse(Console.ReadLine()); CompilerError gives u error



            //write only
            Customer customer = new Customer(12, "raj", new DateTime(day: 09, month: 09, year: 2022));
            Console.WriteLine("customer Details as follows");
            Console.WriteLine($"Customer Id: {customer.Id} Name: {customer.Name} membershipEndDate: {customer.MEndDate}");
            customer.Comment = "i am delighted with the services";
            customer.ReadComment("admin@123");
            //Console.WriteLine(customer.Comment); write only
            Console.ReadKey();
        }
    }
}
