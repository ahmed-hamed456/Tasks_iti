namespace Class_with_Constractor
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("9561561", "Ahmed", 21);
            Student student3 = new Student("8741562", "Mohamed", 19);


            Console.WriteLine("Inter The National Id : ");
            student1.Ssn = Console.ReadLine();
            Console.WriteLine("Inter Your name : ");
            student1.Name = Console.ReadLine();
            Console.WriteLine("Inter Your Age :");
            student1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Inter Your Address :");
            student1.Address = Console.ReadLine();

            Console.WriteLine(student2.print());
        }

    }

}