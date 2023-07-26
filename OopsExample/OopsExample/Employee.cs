using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    public class Employee
    {
        int id;
        string name;

        public Employee()
        {
            Console.WriteLine("employee Constructor");
            id = -1;
            name = "not given";

        }
        public void Register()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("id:" +id);
            Console.WriteLine("name:"+name);
        }
    }
}
