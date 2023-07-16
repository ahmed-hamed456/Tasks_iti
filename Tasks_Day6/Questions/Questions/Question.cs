using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public abstract class Question
    {
        protected int num;
        protected string body;
        protected int mark;

        public Question():this(0){}

        public Question(int num) : this(num,"") { }
        public Question(int num,string body) : this(num, body,0) {}
        
        public Question(int num, string body,int mark)
        {
            this.num = num;
            this.body = body;
            this.mark = mark;
        }

        public int Num
        {
            get { return num; }
            set { this.num = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public abstract void Show();
    }
}
