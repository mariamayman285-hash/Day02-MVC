using System.ComponentModel.DataAnnotations.Schema;

namespace Day02_MVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        //foreign keys
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //navigation properties
        public Department? Department { get; set; }
        public Course Course { get; set; }
    }
}
