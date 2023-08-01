namespace Company.Models
{
    public class SampleData
    {
        public static List<Employee> Employees { get; set; }
        static SampleData()
        {
            Employees = new List<Employee>()
            {
                new Employee() {ID=1,Name="Ahmed",Age=21,Salary=20000,Address="Tanta",Email="ahmed@gamil.com"},
                new Employee() { ID = 2, Name = "Mamdoh", Age = 23, Salary = 2000, Address = "Alex", Email = "Mamdoh@gamil.com" },
                new Employee() {ID=3,Name="Salah",Age=21,Salary=3500,Address="Cario",Email="Salah@gamil.com"},
                new Employee() {ID=4,Name="Raslan",Age=21,Salary=4500,Address="Tanta",Email="Raslan@gamil.com"},
                new Employee() {ID=5,Name="Salma",Age=21,Salary=9800,Address="Alex",Email="Salma@gamil.com"},
            };

        }
    }
}
