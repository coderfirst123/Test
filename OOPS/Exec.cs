using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Exec
    {
       //5
        public void Display(int a,string b,string c,string d)
        {
            Console.WriteLine("id " + a);
            Console.WriteLine("name " + b);
            Console.WriteLine("address " + c);
            Console.WriteLine("dept " + d);
        }
        //1
        public static void Main()
        {
            Employee emp = new Employee();
            int id = emp.Id = 123;
            string Name = emp.name = "hemanth";
            string Address = emp.address = "boston";
            string Dept = emp.dept = "software";
            Exec e = new Exec();
            e.Display(id, Name, Address, Dept);
            Console.ReadLine();
        }
    }
}
