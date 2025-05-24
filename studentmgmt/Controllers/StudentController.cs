using Microsoft.AspNetCore.Mvc;
using studentmgmt.Models;
using System.Collections.Generic;

namespace studentmgmt.Controllers
{
    public class StudentController : Controller
    {
        // Static list to store students (in a real app, use a database)
        private static List<Student> students = new List<Student>
        {
            new Student { StudentID = 1, FullName = "Sarah Johnson", Department = "CSE", CGPA = 3.75f },
            new Student { StudentID = 2, FullName = "Ahmed Hossain", Department = "EEE", CGPA = 3.60f },
            new Student { StudentID = 3, FullName = "Tanisha Rahman", Department = "BBA", CGPA = 3.85f }
        };

        // GET: Student
        public IActionResult Index()
        {
            return View(students);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // Generate a new StudentID
                student.StudentID = students.Count > 0 ? students.Max(s => s.StudentID) + 1 : 1;
                
                // Add the student to the list
                students.Add(student);
                
                // Redirect to success page
                return View("Success", student);
            }
            
            // If validation fails, return to the form
            return View(student);
        }
    }
}