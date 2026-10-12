using System.ComponentModel.DataAnnotations.Schema;

namespace Day02_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //foreign key
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //navigation properties
        public Department Department { get; set; }
        public List<StuCrsRes> StuCrsReses { get; set; }
    }
}
