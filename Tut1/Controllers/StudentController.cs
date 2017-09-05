using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tut1.Models;

namespace Tut1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
			List<Students> listOfStudents = new List<Students>();
			Students student = new Students();
			listOfStudents.Add(new Students { StudentID = 1, Age = 24, FirstName = "Ali", LastName = "Saim", Program = "Software" });			
			listOfStudents.Add(new Students { StudentID = 2, Age = 24, FirstName = "Dom", LastName = "Lau", Program = "Software" });
			listOfStudents.Add(new Students { StudentID = 3, Age = 24, FirstName = "Jeff", LastName = "Kwon", Program = "Software" });
			listOfStudents.Add(new Students { StudentID = 4, Age = 24, FirstName = "Myo", LastName = "Myo", Program = "Software" });
			listOfStudents.Add(new Students { StudentID = 5, Age = 24, FirstName = "Mingming", LastName = "H", Program = "Math and Business" });

			return View(listOfStudents);
        }
    }
}