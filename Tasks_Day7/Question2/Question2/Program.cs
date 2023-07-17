namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ_Question question1= new MCQ_Question(10,"What are you nationality?",5);
            MCQ_Question question2 = new MCQ_Question(100, "What are you nationality?", 5);

            Console.WriteLine(question1.Equals(question2));
        }
    }
}