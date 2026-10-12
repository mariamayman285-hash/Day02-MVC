using System.ComponentModel.DataAnnotations.Schema;

namespace Day02_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public decimal? MinDegree { get; set; }

        //foreign key + annotation just in case
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //navigation properties
        public List<Teacher> Teachers { get; set; }
        public Department Department { get; set; }
        public List<StuCrsRes> StuCrsReses { get; set; }



    }
}
