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
                    new Student { RollNo=1, StudFirstName="Anuj", StudLastName="Garg" },
                    new Student { RollNo=2, StudFirstName="Jaymin", StudLastName="Gupta" },
                    new Student { RollNo=1, StudFirstName="Kunal", StudLastName="Garg" },
                    new Student { RollNo=2, StudFirstName="Rahul", StudLastName="Gupta" },
                    new Student { RollNo=1, StudFirstName="Jiten", StudLastName="Garg" },
                    new Student { RollNo=2, StudFirstName="Vivek", StudLastName="Gupta" }
                 };

            ViewData.Model = stud;
            return View();
        }
    }
}