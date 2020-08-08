using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step230
{
    class Abc
    {
        public Abc(string x) : this(x, null)
        {
            Console.WriteLine(x + " is cool");
        }
        public Abc(string x, string y)
        {
            var z = y;
            Console.WriteLine("\n{0} {1}", x, z);
        }
    }
}
