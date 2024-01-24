using System.Data;

namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            #region 1
            //var linkResult = from item in numbers
            //                 where item % 2 == 0
            //                 select item;
            #endregion

            #region 2

            //var result1 = from linq in numbers
            //              where linq % 2 == 0
            //              where linq % 3 == 0
            //              select linq;

            #endregion

            #region 3

            #endregion
            //var result2 = numbers.Where(x => x % 2 == 0).Count();
            //Console.WriteLine(result2);
            //Console.WriteLine();

            //query syntax
            //1
            //Select1();

            //2
            // Select2();

            //3
            //SelectMany1();

            //4
            //SelectMany2();

            //5
            SelectMany3();




        }
        static void Select1()
        {
            var resultData = (from item in Emp.Employees()
                              select item.ID).ToList();

            foreach (var item in resultData)
            {
                Console.WriteLine($"id:{item}");
            }

            var data = Emp.Employees().Select(emp => emp.ID).ToList();

            foreach (var item in data)
            {
                Console.WriteLine("id:" + item);
            }
        }
        static void Select2()
        {
            //query
            var result = (from emp in Emp.Employees()
                          select new Emp()
                          {
                              firstName = emp.firstName,
                              lastName = emp.lastName,
                              Salary = emp.Salary
                          });

            foreach (var item in result)
            {
                Console.WriteLine($"FirstName:{item.firstName}, LastName:{item.lastName}, Salary:{item.Salary}");
            }
            // method
            var result2 = Emp.Employees().Select(emp => new Emp()
            {
                firstName = emp.firstName,
                lastName = emp.lastName,
                Salary = emp.Salary,

            }).ToArray();
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine($"FirstName:{item.firstName}, LastName:{item.lastName}, Salary:{item.Salary}");
            }
        }
        static void SelectMany1()
        {// query syntax
            List<string> strings = new List<string>() { "Shohboz", "Xurramov" };

            var result = (from item in strings
                          from item2 in item
                          select item2).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            // method
            Console.WriteLine("Func");
            var result1 = strings.SelectMany(item => item.ToList());

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }
        static void SelectMany2()
        {
            // query
            var result1 = (from item1 in Emp.Employees()
                           from item2 in item1.programming
                           select item2).ToList();
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            // method
            Console.WriteLine("Select many");

            var result2 = Emp.Employees().SelectMany(x => x.programming).ToList();

            foreach (var item in result2)
            { Console.WriteLine(item); }
        }
        static void SelectMany3()
        {
            var result1 = Emp.Employees().SelectMany(emp => emp.programming,
                (emp, program) => new
                {
                    EmplyeName = emp.firstName + " " + emp.lastName,
                    Program = program
                }).ToList();
            foreach (var item in result1)
            {
                Console.WriteLine(item.EmplyeName + "=>" + item.Program);
            }
            // query
            Console.WriteLine();
            Console.WriteLine("Query->");
            var result2 = (from item1 in Emp.Employees()
                           from program in item1.programming
                           select new
                           {
                               EmployeName = item1.firstName + " " + item1.lastName,
                               Programming = program
                           }).ToList();
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.EmployeName}=> {item.Programming}");
            }
        }
    }
}
