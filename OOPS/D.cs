using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class D
    {
        //5
        public int Id;
        public string Name;
        public string Address;
        public string Dept;

        public void Display(int id, string name, string address, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Dept = dept;

            Console.WriteLine(Id + Name + Address + Dept);

        }
        static void Main()
        {
            D disp = new D();
            disp.Display(123, "hemant", " boston", " software");
            Console.ReadLine();
        }
    }
}
