using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("enployee Constructor!!");
            id = -1;
            name = "not given";
            salary = 0.0;

        }
        public int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string name;

        public string Name
        {    
            get { return name; }
            set { name = value; }
        }
        public double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
