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
                    new Student { RollNo=1, StudFirstName="Honey", StudLastName="Gupta" },
                    new Student { RollNo=2, StudFirstName="Siddu", StudLastName="Lad" }
                 };

            ViewData.Model = stud;
            return View();
        }
    }
}