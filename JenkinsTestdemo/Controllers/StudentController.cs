using JenkinsTestdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsTestdemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stud = new List<Student>
                 {
                    new Student { RollNo=1, StudFirstName="Anuj", StudLastName="Gupta" },
                    new Student { RollNo=2, StudFirstName="Priyanka", StudLastName="Lad" }
                 };

            ViewData.Model = stud;
            return View();
        }
    }
}