using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class MCQ_Question : Question
    {
        private string[] answers;

        public MCQ_Question() : this(0, "", 0) { }
        public MCQ_Question(int num, string body, int mark) : base(num, body, mark) { Console.WriteLine("Salah"); }

        public string[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        public override string ToString()
        {
            return$"The Number Of Question : {num}\n" +
                  $"The Body Of Question is : {body}\n" +
                  $"The Mark Of Question is : {mark}";
            Console.WriteLine();
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"The Answer{i + 1} is : " + Answers[i] + "\n");
            }
        }

        public override bool Equals(object? obj)
        {
            MCQ_Question question= (MCQ_Question)obj;
            return this.num==question.num &&this.body==question.body&&this.mark==question.mark;
        }
    }
}
