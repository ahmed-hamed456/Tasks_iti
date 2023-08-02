using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST_Company.Models
{
    [PrimaryKey("emp_id", "proj_id")]
    public class Emp_Project
    {
        [ForeignKey("Employee")]
        public int emp_id { get; set; }

        [ForeignKey("Project")]
        public int? proj_id { get; set; }
        public int? WorkingHours { get; set; }

        //Navigation Property
        public Employee? Employee { get; set; }
        public Project? Project { get; set; }
    }
}
