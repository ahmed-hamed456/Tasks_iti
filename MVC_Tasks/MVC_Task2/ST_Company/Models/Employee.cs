using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST_Company.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("office")]
        [Display(Name="Office")]
        public int? Office_id { get; set; }

        //Navigation Property
        public Office? office { get; set; }
        public List<Emp_Project> emp_Projects { get; set; }
    }
}
