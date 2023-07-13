namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teachers teacher = new Teachers("15","Ahmed","Hamed",21,"Tanta",20000,"English");
            Students student= new Students("19", "Mohamed", "Mamdoh", 21, "Tanta",4,1);

            Console.WriteLine(teacher.Print());
            Console.WriteLine("///////////////////////////////////");
            Console.WriteLine(student.Print());

        }
    }
}