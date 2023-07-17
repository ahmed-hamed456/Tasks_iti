using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class MCQ_Question : Question
    {
        private string[] answers;

        public MCQ_Question() : this(0,"", 0) {}
        public MCQ_Question(int num,string body,int mark) : base(num,body,mark) { Console.WriteLine("Salah"); }
        
        public string[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        public override void Show()
        {
            Console.WriteLine($"The Number Of Question : {num}\n" +
                              $"The Body Of Question is : {body}\n" +
                              $"The Mark Of Question is : {mark}");
            Console.WriteLine();
            for (int i=0;i<answers.Length;i++)
            {
                Console.WriteLine($"The Answer{i+1} is : "+Answers[i]+"\n");
            }
        }
    }
}
