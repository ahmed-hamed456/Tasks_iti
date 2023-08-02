using Microsoft.EntityFrameworkCore;

namespace ST_Company.Models
{
    public class Company_Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Emp_Project> EmpProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company_ST;Trusted_Connection=True;TrustServerCertificate=True") ;
        }
    }
}
