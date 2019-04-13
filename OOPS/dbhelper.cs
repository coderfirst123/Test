using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class dbhelper
    {
        //7
        public List<string> Getcountries()
        {
            List<string> countries = new List<string>() { "US", "Canada", "INDIA", "Pakistan" };
            return countries;
        }
        public List<string> GetStates(string country)
        {
            List<string> States = new List<string>();
            switch (country)
            {
                case "US":
                    {
                        States.Add("texas");
                        States.Add("florida");
                        States.Add("dakota");
                        break;
                    }
                case "INDIA":
                    {
                        States.Add("andhra");
                        States.Add("telangana");
                        States.Add("karnataka");
                        break;
                    }
                case "Canada":
                    {
                        States.Add("vancover");
                        States.Add("toronto");
                        States.Add("orlando");
                        break;
                    }
                default:
                    Console.WriteLine("no data");
                    break;             
            }
            return States;               
        }
        public List<string> GetCities(string state)
        {
            List<string> cities = new List<string>();
            switch (state)
            {
                case "Telangana":
                    {
                        cities.Add("hyderabad");
                        cities.Add("nalgonda");
                        cities.Add("khammam");
                        break;
                    }
                case "Andhra":
                    {
                        cities.Add("Nellore");
                        cities.Add("thirupathi");
                        cities.Add("anakapali");
                        break;
                    }
                    break;

            }
            return cities;

        }
            static void Main()
        {
            dbhelper db = new dbhelper();
            db.Getcountries();
            List<string> state =  db.GetStates("US");
            foreach( object obj in state){
                Console.WriteLine(obj);
            }
            db.GetCities("andhra");
            List<string> city = db.GetCities("Andhra");
            foreach(object obj in city)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
