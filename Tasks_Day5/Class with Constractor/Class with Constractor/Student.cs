using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_with_Constractor;

public class Student
{
    private string ssn;
    private string name;
    private int age;
    private string address;

    public Student()
    {
        ssn = "00000000";
        name = "Admin";
        age = 20;
        address = "Cairo";
    }

    public Student(string ssn, string name, int age)
    {
        this.ssn = ssn;
        this.name = name;
        this.age = age;
    }

    public Student(string ssn, string name, int age, string address)
    {
        this.ssn = ssn;
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public string Ssn
    {
        get { return ssn; }
        set { ssn = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
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

    public string print()
    {
        return $"Your National Id is {Ssn}\n" +
                $"Your Name is {Name}\n" +
                $"Your Age is {Age}\n" +
                $"Your Adress is {Address}\n";
    }
}
