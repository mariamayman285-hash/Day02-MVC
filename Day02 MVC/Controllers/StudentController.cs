using Day02_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day02_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> studentsList = studentBL.GetAll();
            return View("ShowAll",studentsList);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student student = studentBL.GetById(id);
            return View("ShowDetails",student);
        }
    }
}
