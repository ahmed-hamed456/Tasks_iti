namespace Class_with_constractor_Students_
{
        internal class Program
        {
            
            static void Main(string[] args)
            {
                Student student1 = new Student();
                Student student2 = new Student();
                Student student3 = new Student();
                Student student4 = new Student();
                Student student5 = new Student();
                Student student6 = new Student();
                Student student7 = new Student();
                Student student8 = new Student();
                Student student9 = new Student();
                Student student10 = new Student();




            Student[] students = new Student[2];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"Inter The National Id for the student{i + 1} : ");
                students[i].Ssn = (Console.ReadLine());
                Console.WriteLine($"Inter Your name for the student{i + 1} : ");
                students[i].Name = (Console.ReadLine());
                Console.WriteLine($"Inter Your Age for the student{i + 1}:");
                students[i].Age = (int.Parse(Console.ReadLine()));
                Console.WriteLine($"Inter Your Address for the student{i + 1}:");
                students[i].Address = (Console.ReadLine());

                Console.WriteLine(students[i].print());

            }

        }

        }

    }