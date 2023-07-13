using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
    public class Teachers : School
    {
        private int sallary;
        private string subjects;

        public Teachers()
        {
            Id = "0";
            Fname = "Admin";
            Lname = "Admin";
            Age = 0;
            Address = "Cairo";
            sallary= 0;
            subjects = "Math-Arabic";
        }

        public Teachers(string id, string fname, string lname, int age, string address,int sallary,string subjects)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
            this.Address = address;
            this.Sallary = sallary;
            this.Subjects = subjects;
        }
        public int Sallary
        {
            get { return sallary; }
            set { sallary = value; }
        }
        public string Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public string Print()
        {
            return $"Id = {Id}\n" +
                   $"The First_Name is : {Fname} \n" +
                   $"The Last_Name is : {Lname}\n" +
                   $"Your Age is : {Age}\n" +
                   $"Your Address is :{Address}\n" +
                   $"Your Sallay is :{Sallary}\n" +
                   $"Your Sibjects are :{Subjects}";
        }

    }
}