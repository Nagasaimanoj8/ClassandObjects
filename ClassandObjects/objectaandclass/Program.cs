using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectaandclass
{
    internal class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(101, "Sonoo", 890000f);
            e2.insert(102, "Mahesh", 490000f);
            e1.display();
            e2.display();
        }
    }
}
