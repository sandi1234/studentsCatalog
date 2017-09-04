using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentsCatalog.Models.Entities;

namespace Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            students.Add(new Student{FirstName = "Rip", LastName = "SvømmeSkole", Age = 18});
            students.Add(new Student{FirstName = "Rap", LastName = "EfterSkole", Age = 28});
            students.Add(new Student{FirstName = "Rup", LastName = "LøbeSkole", Age = 38});

            ViewBag.stud = students;

            return View();
        }

        public IActionResult day2()
        {
            return View();
        }

        public IActionResult mvc(int id)
        {
            ViewBag.number = id;
            return View();
        }
    }
}