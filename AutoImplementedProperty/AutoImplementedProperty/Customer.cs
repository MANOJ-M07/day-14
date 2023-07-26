using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public double ODLimit { get; set; } 
    }
}
