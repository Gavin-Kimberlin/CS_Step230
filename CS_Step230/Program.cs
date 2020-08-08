using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step230
{
    class Program
    {
        static void Main(string[] args)
        {
            const string x = "Sample Text";
            const string y = "Other Sample Text";
            Abc abc = new Abc(x);
            Abc abc1 = new Abc(x, y);
            Console.ReadLine();
        }
    }
}
