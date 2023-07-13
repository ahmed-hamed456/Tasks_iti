using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string id;
        private string fname;
        private string lname;
        private int age;
        private string address;

        public School()
        {
            id = "0";
            fname = "Admin";
            lname = "Admin";
            age = 0;
            address= "Cairo";
        }

        public School(string id,string fname,string lname,int age,string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.address = address;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; } 
            set { address = value; }
        }

        public string Print()
        {
            return $"Id = {Id}\n" +
                   $"The First_Name is : {Fname} \n" +
                   $"The Last_Name is : {Lname}\n" +
                   $"Your Age is : {Age}\n" +
                   $"Your Address is :{Address}";
        }

    }
}
