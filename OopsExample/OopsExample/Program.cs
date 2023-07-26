using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            Console.WriteLine("enter employee one details");
            employee.Register();
            Console.WriteLine("enter employee two details");
            employee2.Register();
            Console.WriteLine("employee one details");
            employee.Display();
            Console.WriteLine("employee two details");
            employee2.Display();
            Console.ReadKey();
        }
    }
}
