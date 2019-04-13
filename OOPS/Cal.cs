using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Cal
    {
        
        //10
        public string GetFullName(string firstname,string lastname)
        {
            string Fullname = firstname + lastname;
            return Fullname;
        }
        //8
        public int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public int div(int a, int b)
        {
            int c = a/b;
            return c;
        }
        static void Main()
        {
            Cal c = new Cal();
            int a = c.Add(2, 3);
            int b = c.div(10, 2);
            int e =c.Mul(2, 3);
            int d = c.Sub(2,3);
            Console.WriteLine("add{0}  sub{1}  div{2}  mul{3}", a, d, b, e);
            Console.ReadLine();
        }
    }
}
