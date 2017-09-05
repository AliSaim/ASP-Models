using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tut1.Models;

namespace Tut1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

			ViewBag.Message = " This is a message from the test controlller with Index action";

			/*
			List<string> listOfFriends = new List<string>();
			listOfFriends.Add("Dom");
			listOfFriends.Add("Jeff");
			listOfFriends.Add("Sam");
			listOfFriends.Add("Ballin");

			ViewBag.bagOflistOfFriends = listOfFriends;

			*/
			List <Employee> employeeList = new List<Employee>();
			Employee employee = new Employee();
			employeeList.Add(new Employee { EmployeeID = 1, Name = "Ali", Department = "IT" });
			employeeList.Add(new Employee { EmployeeID = 2, Name = "Dom", Department = "Testing" });
			employeeList.Add(new Employee { EmployeeID = 3, Name = "Jeff", Department = "HR" });
			employeeList.Add(new Employee { EmployeeID = 4, Name = "Mingming", Department = "Developer" });

			return View(employeeList);
        }
    }
}