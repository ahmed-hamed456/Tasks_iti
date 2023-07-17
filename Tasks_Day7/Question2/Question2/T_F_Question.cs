using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class T_F_Question :Question
    {
        public T_F_Question() : this(0, "", 0) { }

        public T_F_Question(int num, string body, int mark) : base(num, body, mark) { }
        public override string ToString()
        {
            return$"The Number Of Question : {num}\n" +
                  $"The Mark Of Question is : {mark}\n" +
                  $"The Body Of Question is : {body} (T or f)";
        }

        public override bool Equals(object? obj)
        {
            T_F_Question question = (T_F_Question)obj;
            return this.Num == question.Num && this.Body == question.Body && this.Mark == question.Mark;
        }
    }
}
