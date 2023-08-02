namespace ST_Company.Models
{
    public class Office
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //Navigation Property
        public List<Employee> Employees { get; set; }
    }
}
