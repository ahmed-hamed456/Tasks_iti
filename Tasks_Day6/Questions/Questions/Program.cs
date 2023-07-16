namespace Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ_Question question = new MCQ_Question(1, "What is your nationality?", 10);
            question.Answers=new string[] { "Egyptian", "German", "Japanese" };
            question.Show();

            //T_or_f_Questions question1 = new T_or_f_Questions(1,"Are you Egyptian?",10);
            //question1.Show();   
        }
    }
}