using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class T_or_f_Questions : Question
    {
        public T_or_f_Questions() : this(0,"",0) { }

        public T_or_f_Questions(int num,string body,int mark) :base(num,body,mark){ }
        public override void Show()
        {
            Console.WriteLine($"The Number Of Question : {num}\n" +
                              $"The Mark Of Question is : {mark}\n"+
                              $"The Body Of Question is : {body} (T or f)");
        }
    }
}
