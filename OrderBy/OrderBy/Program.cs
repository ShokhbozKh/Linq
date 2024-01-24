namespace OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //OrderBy1();

            //2
            // OrderBy2();

            //3
            //OrderBy3();

            //4
            ThenBy1();
            //descending ascending

        }
        static void OrderBy1()
        {
            List<int> numbers = new List<int>() { 1, 3, 2, 5, 9, 8, 7, 5, 0, 0, 2, 22, 11, -2, -7, 1 };

            var orderBy1 = (from item in numbers
                            orderby item
                            select item).ToList();
            foreach (var item in orderBy1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMETHOD");

            var result = numbers.OrderBy(x => x).ToList();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

        }
        static void OrderBy2()
        {
            var resultQ = (from item in Student.GetStudents()
                           select item.Branch).ToList();
            foreach (var item in resultQ)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n---Method\n");

            var resultM = Student.GetStudents().OrderBy(x => x.Age).ToList();

            foreach (var item in resultM)
            {
                Console.WriteLine(item.Age + " " + item.Name);
            }
        }

        static void OrderBy3()
        {
            var resultQ = (from item in Student.GetStudents()
                           orderby item.Age descending
                           select item).ToList();
            foreach (var item in resultQ)
            {
                Console.Write(item.Age + " ");
            }
            Console.WriteLine("\n---Method\n");

            var resultM = Student.GetStudents().OrderByDescending(x => x.Age).ToList();

            foreach (var item in resultM)
            {
                Console.WriteLine(item.Age + " " + item.Name);
            }

        }
        static void ThenBy1()
        {
            var resultQ = (from item in Student.GetStudents()
                           orderby item.Age descending
                           orderby item.Name
                           orderby item.Id

                           select item).ToList();
            foreach (var item in resultQ)
            {
                Console.Write(item.Age + " ");
            }
            Console.WriteLine("\n---Method\n");

            var resultM = Student.GetStudents()
                .OrderBy(x => x.Age)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var item in resultM)
            {
                Console.WriteLine(item.Age + " " + item.Name);
            }
        }
    }
}
