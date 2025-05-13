using System;
using System.Collections.Generic;

// Base class: Person
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

// Derived class: Student
class Student : Person
{
    private int StudentId;

    public int GetStudentId()
    {
        return StudentId;
    }

    public void SetStudentId(int id)
    {
        StudentId = id;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Student ID: {StudentId}";
    }
}

// Derived class: Teacher
class Teacher : Person
{
    private double Salary;

    public double GetSalary()
    {
        return Salary;
    }

    public void SetSalary(double salary)
    {
        Salary = salary;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Salary: {Salary}";
    }
}

// NotificationService (Delegation with Delegate)
class NotificationService
{
   

    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}

// Course class (Aggregation and Delegation)
class Course
{
    public string CourseName { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    private NotificationService notificationService = new NotificationService();
    public delegate void NotifyDelegate(string message);

    public void NotifyStudents(string message)
    {
        // Using the delegate to send notifications
        NotifyDelegate notify = notificationService.SendNotification;
        notify(message);
    }
}

// Calculator class (Method Overloading)
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create Students
        Student student1 = new Student { Name = "Alice", Age = 20 };
        student1.SetStudentId(101);

        Student student2 = new Student { Name = "Bob", Age = 22 };
        student2.SetStudentId(102);

        // Create Teachers
        Teacher teacher1 = new Teacher { Name = "Dr. Smith", Age = 45 };
        teacher1.SetSalary(50000);

        Teacher teacher2 = new Teacher { Name = "Dr. Johnson", Age = 50 };
        teacher2.SetSalary(55000);

        // Create Course
        Course course = new Course { CourseName = "Computer Science" };
        course.Students.Add(student1);
        course.Students.Add(student2);
        course.Teachers.Add(teacher1);
        course.Teachers.Add(teacher2);

        // Display Course Info
        Console.WriteLine($"Course: {course.CourseName}");
        Console.WriteLine("Students:");
        foreach (var student in course.Students)
        {
            Console.WriteLine(student.GetInfo());
        }

        Console.WriteLine("Teachers:");
        foreach (var teacher in course.Teachers)
        {
            Console.WriteLine(teacher.GetInfo());
        }

        // Notify Students
        course.NotifyStudents("Class will start at 10 AM tomorrow.");

        // Calculator Example
        Calculator calculator = new Calculator();
        Console.WriteLine($"Addition of integers: {calculator.Add(5, 10)}");
        Console.WriteLine($"Addition of doubles: {calculator.Add(5.5, 10.5)}");

        // Exception Handling Example
        try
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            division(a, b);
        }
        catch (MyException e)
        {
            Console.WriteLine("You cannot divide because: " + e.Message);
        }
        finally
        {
            Console.WriteLine("This is the finally block for division.");
        }

        Console.WriteLine("End of program.");
    }

    static void division(int a, int b)
    {
        if (b == 0)
        {
            throw new MyException("Division by zero is not allowed.");
        }
        else
        {
            Console.WriteLine($"The result of {a} / {b} is: " + (a / b));
        }
    }
}

// Custom Exception Class
class MyException : Exception
{
    public MyException(string Message) : base(Message)
    {
    }
}