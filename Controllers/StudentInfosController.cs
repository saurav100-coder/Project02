using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Nancy.Json;
using Project02.Data;
using Project02.Models;
//using System.Web.Script.Serilization;

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
            //List<StudentInfo> studentInfos = new List<StudentInfo>();
            StudentInfo studentInfos = new StudentInfo();
            return View(studentInfos);
        } 
        [HttpPost]
        public IActionResult Create(StudentInfo studentInfo)
        {
            _context.Add(studentInfo);
            _context.SaveChanges();
            //Count();
            return RedirectToAction("Index");
        }
        //public void Count()
        //{
        //    ViewBag.Count = _context.StudentInfos.Count();
        //}
    }
}
