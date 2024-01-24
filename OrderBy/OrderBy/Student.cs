using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student() { Id = 1001,Name ="Abdulla", Gender = "Male", Branch ="Tuman", Age=21},
                new Student() { Id = 1002,Name ="Liza", Gender = "Fmale", Branch ="Shahar", Age=18},
                new Student() { Id = 1002,Name ="Jack", Gender = "Male", Branch ="Tuman", Age=24},
                new Student() { Id = 1001,Name ="Gule", Gender = "Fmale", Branch ="Viloyat", Age=19},
                new Student() { Id = 1005,Name ="Ali", Gender = "Male", Branch ="Tuman", Age=23},
            };
            return students;

            //return new List<Student>()
            //{
            //    new Student() {}
            //};
        }
    }
}
