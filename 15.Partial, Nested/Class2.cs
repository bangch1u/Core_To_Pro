using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _15.Partial__Nested
{
    public partial  class Product
    {
        public int Age { get; set; }
        partial void myMethod(string a)
        {
            Console.WriteLine("Heloo" + a);
        }
    }
}
