class Program
{
    static void Main(string[] args)
    {
        //Where1();
        //Where2();
        //descending
        //Where3();
        //then and thenBy
        Where4();

    }
    static void Where4()
    {
        var students = new List<Student>()
        {
            new Student(){id=1,name="Jeck",result=59},
            new Student(){id=2,name="MArk", result=98},
            new Student(){id=3,name="Lisa", result=100}
        };

        var result = from student in students
                     where student.result <= 60
                     select student;
        foreach (var student in result)
        {
            Console.WriteLine(student.name);
        }

    }
    static void Where3()
    {
        var students = new List<Student>()
        {
            new Student(){id=1,name="Jeck",result=59},
            new Student(){id=2,name="MArk", result=98},
            new Student(){id=3,name="Lisa", result=100}
        };

        var result = students.OrderBy(x => x.result).Where(x => x.result >= 60).Select(x => x.name).ToList();
        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        var resultquery = from student in students
                          orderby student.result // usish buyicha saralash
                          where student.result >= 60
                          select student;
        foreach (var student in resultquery)
        {
            Console.WriteLine(student.result + "--" + student.name);
        }
        Console.WriteLine("Descending");

        var resul3 = students.OrderByDescending(x => x.result);
        foreach (var student in resul3)
        {
            Console.WriteLine(student.result);
        }
        Console.WriteLine("query");

        var result4 = from item in students
                      orderby item.result descending // kamayish buyicha saralash
                      where item.result >= 60 // bu shart bajarilsa
                      select item;
        foreach (var item in result4)
        {
            Console.WriteLine(item.result);
        }
    }

    static void Where2()
    {
        List<object> list = new List<object>() { "ali", "Vali", "Soli", 1, 2, 3, 4, 55, 6, true, false, true, false, 'a', 'b' };
        //method
        var result = list.Where(x => x is char).ToArray();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        // method
        var result2 = list.OfType<string>().ToArray();
        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }
        //query
        var result3 = from item in list
                      where item is int
                      select item.ToString();
        foreach (var item in result3)
        { Console.WriteLine(item); }

    }
    static void Where1()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var MethodSyntax = numbers.Where(x => x > 4 && x < 7).ToList();

        var result = (from i in numbers
                      where i > 4 && i < 7
                      select i).ToList();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        // Output: 5, 6
    }
    class Student
    {
        public int id;
        public string? name;
        public int result;
    }
}