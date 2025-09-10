using Microsoft.AspNetCore.Mvc;
using MIDTERM_LAB3_DANIEL_RED.Services;

namespace MIDTERM_LAB3_DANIEL_RED.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
    }
}