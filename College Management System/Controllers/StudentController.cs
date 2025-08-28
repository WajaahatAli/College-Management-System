using College_Management_System.DATA;
using College_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static College_Management_System.Models.Attributes;

namespace College_Management_System.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbSTudentsList _StudentsList;


        public StudentController(AppDbSTudentsList StudentsList)
        {
            _StudentsList = StudentsList;
        }
        //Gets all the students
        public IActionResult Index()
        {

            var students = _StudentsList.attributes.ToList() ;
            return View(students);
        }


        [HttpGet]

        public IActionResult Create()
        {
            ViewData["Title"] = "Create Student";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Attributes student)
        {
            if (ModelState.IsValid)
            {
                _StudentsList.attributes.Add(student);
                _StudentsList.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);


        }



    }
}
