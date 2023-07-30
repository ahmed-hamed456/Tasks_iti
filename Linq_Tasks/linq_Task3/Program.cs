using System.Collections.Generic;

namespace linq_Task3
{
    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID = 1,
                FirstName = "ALi",
                LastName = "Mohammed",
                Subjects = new List<Subject>()
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()
            {
                ID = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new List<Subject>()
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 34, Name = "XL" },
                    new Subject() { Code = 25, Name = "35" }
                }
            },
            new Student()
            {
                ID = 3,
                FirstName = "Yara",
                LastName ="Yousef",
                Subjects= new List<Subject>()
                {
                    new Subject(){Code=22,Name="F"},
                    new Subject(){Code=25,Name="15"}
                 }
             },
             new Student()
             {
                 ID=1,
                 FirstName="Ali",
                 LastName="Ali",
                 Subjects=new List<Subject>()
                 {
                     new Subject(){Code=33,Name="UML"}
                 }
             }
        };

            var query = students.OrderByDescending(s => s.FirstName)
                               .ThenBy(s => s.LastName)
                               .Select(s => new { s.FirstName, s.LastName });

            foreach (var student in query)
            {
                Console.WriteLine($"First Name: {student.FirstName}, Last Name: {student.LastName}");
            }
        
    }
}
}