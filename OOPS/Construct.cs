using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Construct
    {
        //9
        public Construct()
        {
            Console.WriteLine("constructor called");
        }
        public Construct(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main()
        {
            Construct con = new Construct();
            Construct con1 = new Construct(3, 4);
            Console.ReadLine();
        }
    }
}
