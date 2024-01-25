using System.Data.SqlTypes;

namespace distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Distinct1();
            //2
            //Distinct2();

            //except
            //Excipt1();

            Excipt2();

        }

        static void Excipt2()
        {


        }
        static void Excipt1()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 77 };
            List<int> ints = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 0 };

            var result1 = list.Except(ints);

            var result2 = (from x in list
                           select x).Except(ints);

            foreach (var x in result2)
            {
                Console.WriteLine(x);
            }

        }
        static void Distinct1()
        {
            List<int> list = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9,
            1,2,3,4,5,6,7,8,9,
            1,2,3,4,5,
            1,2,4,5,6,7,8
        };
            // func
            var result = list.Distinct();
            // query
            var result2 = (from item in list
                           select item).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Distinct2()
        {
            List<string> list = new List<string>() { "ali", "ALI", "Vali", "soli", "VALI" };

            var result = list.Distinct(StringComparer.OrdinalIgnoreCase);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

}
