using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Person
    {
        public Person()
        {
            id = 10;
            name = "jsh";
        }
        public int id;
        public string name;
        public string address;
        

        public int num(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public List<string> countries()
        {
            List<string> C = new List<string>() { "india", "america", "canda" };
            return C;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Person p = new Person();
            p.id = 12;
            p.name = "hemanth";
            //p.address = "boston";

            int id = p.id;
            string name = p.name;
            string address = p.address;
            Console.WriteLine("name {0} ,id {1},address {2}",name,id,address);
            Console.ReadLine();
        }
    }
}
