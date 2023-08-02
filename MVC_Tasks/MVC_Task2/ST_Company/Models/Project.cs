namespace ST_Company.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public List<Emp_Project> emp_Projects { get; set; }
    }
}
