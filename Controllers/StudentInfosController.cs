using Microsoft.AspNetCore.Mvc;
using Project02.Data;
using Project02.Models;

namespace Project02.Controllers
{
    public class StudentInfosController : Controller
    {
        private readonly StudentDbContext _context;
        public StudentInfosController(StudentDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<StudentInfo> studentInfos;
            studentInfos = _context.StudentInfos.ToList();
            return View(studentInfos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            StudentInfo studentInfo = new StudentInfo();
            return View(studentInfo);
        }
        [HttpPost]
        public IActionResult Create(StudentInfo studentInfo)
        {
            _context.Add(studentInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
