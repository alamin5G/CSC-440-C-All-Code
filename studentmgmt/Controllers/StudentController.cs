using Microsoft.AspNetCore.Mvc;
using studentmgmt.Models;
using System.Collections.Generic;

namespace studentmgmt.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { StudentID = 1, FullName = "Sarah Johnson", Department = "CSE", CGPA = 3.75f },
                new Student { StudentID = 2, FullName = "Ahmed Hossain", Department = "EEE", CGPA = 3.60f },
                new Student { StudentID = 3, FullName = "Tanisha Rahman", Department = "BBA", CGPA = 3.85f }
            };

            // Pass the list of students to the view
            return View(students);
        }
    }
}