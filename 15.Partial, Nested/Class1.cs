using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Partial__Nested
{
    public partial class Product
    {
        public string Name { get; set; }
         partial void myMethod(string a);
        public void callMyMethod(string hello)
        {
            myMethod(hello);
        }
       
       
    }
}
