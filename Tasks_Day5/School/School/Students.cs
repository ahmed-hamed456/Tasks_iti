using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Students : School
    {
        private int schoolYear;
        private int n_class;

        public Students()
        {
            Id = "0";
            Fname = "Admin";
            Lname = "Admin";
            Age = 0;
            Address = "Cairo";
            schoolYear= 1;
            n_class= 1;
        }

        public Students(string id, string fname, string lname, int age, string address, int schoolYear,int n_class)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
            this.Address = address;
            this.SchoolYear = schoolYear;
            this.N_class = n_class;
        }

        public int SchoolYear
        {
            get { return schoolYear; }
            set { schoolYear = value; }
        }

         public int N_class
        {
            get { return n_class; }
            set { n_class = value; }
        }

        public string Print()
        {
            return $"Id = {Id}\n" +
                   $"The First_Name is : {Fname} \n" +
                   $"The Last_Name is : {Lname}\n" +
                   $"Your Age is : {Age}\n" +
                   $"Your Address is :{Address}\n" +
                   $"Your SchoolYear is :{SchoolYear}\n" +
                   $"Your NUmber Of Class are :{N_class}";
        }
    }
}

