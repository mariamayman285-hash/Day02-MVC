namespace Day02_MVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MgrName { get; set; }       //in .net 8 everything in a class even strings are required (so we need to add nullable operator)

        //el navigation properties
        public List<Teacher> Teachers { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}
