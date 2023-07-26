/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPropetiesExampleFour
{
    public class Customer
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1) { id = value; }
                else
                {
                    id = -1;
                }
            }
        }

        public string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 6)
                {
                    name = value;
                }
                else
                {
                    name = "invalid";
                }
            }
        }
    }
}
*/

//example-2 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPropetiesExampleFour
{
    public class Customer
    {
        private static double tax;
        public static double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1) { id = value; }
                else
                {
                    id = -1;
                }
            }
        }

        public string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 6)
                {
                    name = value;
                }
                else
                {
                    name = "invalid";
                }
            }
        }
    }
}
