//read and write example
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;

        public Customer()
        {
            Console.WriteLine("Customer constructor call");
            id = -1;
            name = "not given";
            mEndDate = DateTime.Now;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime MEndDate { get {  return mEndDate; } set {  mEndDate = value; } }
    }
}
*/



//read only example
/*using System;

namespace ConAppProperties
{
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;

        public Customer(int id, string name, DateTime mEndDate)
        {
            Console.WriteLine("Customer constructor call");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;
            
        }

        public int Id { get { return id; }  }
        public string Name { get { return name; }  }
        public DateTime MEndDate { get { return mEndDate; } }
    }
}*/

//write only
using System;

namespace ConAppProperties
{
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;
        string comment;

        public Customer(int id, string name, DateTime mEndDate)
        {
            Console.WriteLine("Customer constructor call");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;

        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public DateTime MEndDate { get { return mEndDate; } }
        public string Comment { set {  comment=value; } }

        public void ReadComment(string passCode)
        {
            if (passCode == "admin!123")
            {
                Console.WriteLine("comment is:"+comment);
            }
        }
    }
}