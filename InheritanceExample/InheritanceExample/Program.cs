using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            Console.WriteLine("Default values");
            Console.WriteLine("Id:"+dev.Id);
            Console.WriteLine("name:"+dev.Name);
            Console.WriteLine("salary:"+dev.Salary);
            Console.WriteLine("project"+dev.Project);
            Console.WriteLine("domain:"+dev.Domain);
            Console.ReadKey();  
        }
    }
}
