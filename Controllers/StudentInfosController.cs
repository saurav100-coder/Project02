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
            List<StudentInfo> studentInfos = new List<StudentInfo>();
            studentInfos.Add(new StudentInfo());
            return View(studentInfos);
        } 
        [HttpPost]
        public IActionResult Create(List<StudentInfo> studentInfos)
        {
            _context.AddRange(studentInfos);
            _context.SaveChanges();
            //Count();
            return RedirectToAction("Index");
        }
        
    }
}
