using College_Management_System.DATA;
using College_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static College_Management_System.Models.StudentsAttributes;

namespace College_Management_System.Controllers
{
    public class StudentController
    {

        private readonly AppDbSTudentsList _StudentsList;


        public StudentController(AppDbSTudentsList StudentsList)
        {
            _StudentsList = StudentsList;
        }


        [HttpPost]
        public IActionResult Create(Attributes student)
        {
            if (ModelState) 
                
        }



    }
}
