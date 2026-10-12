using Day02_MVC.data.DbContexts;

namespace Day02_MVC.Models
{
    public class StudentBL
    {
        UniversityDbContext context = new UniversityDbContext();  //connection object

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return context.Students.FirstOrDefault(s => s.Id == id);
        }
    }
}
