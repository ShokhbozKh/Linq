using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    public class Emp
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal Salary { get; set; }

        public List<string> programming { get; set; }
        public static List<Emp> Employees()
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){ID = 1, firstName="Jeck", lastName = "Maa", Salary = 60000, programming=new List<string>(){"java","c","c++" } },
                new Emp(){ID = 2, firstName="Ale", lastName = "Sas", Salary = 50000, programming=new List<string>(){ "c#", "c", "c++" } },
                new Emp() { ID = 3, firstName = "MArk", lastName = "Suck", Salary = 80000, programming = new(){ "html", "css", "c#" } },
                new Emp(){ID = 4, firstName="Ilon", lastName = "MAsk", Salary = 40000, programming=new(){"kotlin","python","linq" } },
                new Emp(){ID = 5, firstName="Ali", lastName = "Qushchi", Salary = 70000, programming=new(){"c#","c","c++" } }

            };

            return emps;
        }




    }
}
