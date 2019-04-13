using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS;
namespace OOPS
{
    public class EmpDetails
    {
        
        public static void Main()
        {
            //2
            List<Employee> IstEmployee = new List<Employee>();
            int i = 0;
            do
            {
                
                Employee em = new Employee();
                Console.WriteLine("add id,name,address,dept");
                em.Id = Convert.ToInt32(Console.ReadLine());
                em.name = (Console.ReadLine());
                em.address = (Console.ReadLine());
                em.dept = (Console.ReadLine());
                IstEmployee.Add(em);
                i++;
                foreach (object obj in IstEmployee)
                {

                    Console.WriteLine(em.Id+em.name+em.address+em.dept);
                    //Console.WriteLine("Id : {0},Name : {1} address:{2}",);
                }


            } while (i<3);
            foreach (Employee obj in IstEmployee)
            {

                Console.WriteLine(obj.Id+"  "+obj.name+"  "+obj.address+"  "+obj.dept);
                //Console.WriteLine("Id : {0},Name : {1} address:{2}",);
            }
            //3
            foreach(Employee obj in IstEmployee)
            {
                Console.WriteLine("check if the employe exist in data");
                if(obj.name == "hemanth")
                {
                    Console.WriteLine("yes name exist");
                }
                else
                {
                    Console.WriteLine("no name does not exist");
                }


            }
            //4
            foreach(Employee obj in IstEmployee)
            {
                Console.WriteLine("enter department name");
                string dep = Console.ReadLine();
                if(obj.dept == dep)
                {
                    Console.WriteLine(obj.name + "  " + obj.Id + "  " + obj.address);
                }
            }
            
            Console.ReadLine();


        }
    }
}
