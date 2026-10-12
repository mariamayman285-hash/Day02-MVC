namespace Day02_MVC.Models
{
    public class StuCrsRes
    {
        //2 foreign keys (composite primary key) // composite key will be defined in DbContexts
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //extra column
        public decimal Grade { get; set; }
    }
}
