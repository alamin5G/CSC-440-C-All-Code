using System;
using System.ComponentModel.DataAnnotations;

namespace studentmgmt.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required")]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Full Name must be between 5 and 50 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1980-01-01", "2010-12-31", 
               ErrorMessage = "Date of Birth must be between January 1, 1980 and December 31, 2010")]
        [NoWeekendBirthday(ErrorMessage = "Date of Birth cannot be on a weekend (Saturday or Sunday)")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "CGPA is required")]
        [Range(0, 4.0, ErrorMessage = "CGPA must be between 0 and 4.0")]
        public float CGPA { get; set; }
    }
}