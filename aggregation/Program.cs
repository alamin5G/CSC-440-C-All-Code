using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public Student(string name)
    {
        Name = name;
    }
}

public class Classroom
{
    public string RoomName { get; set; }
    public List<Student> Students { get; set; }

    public Classroom(string roomName)
    {
        RoomName = roomName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating independent Student objects
        Student s1 = new Student("Alice");
        Student s2 = new Student("Bob");

        // Creating a Classroom
        Classroom classroom = new Classroom("Room A");

        // Adding students to the classroom (Aggregation)
        classroom.AddStudent(s1);
        classroom.AddStudent(s2);

        Console.WriteLine($"Classroom: {classroom.RoomName}");
        foreach (var student in classroom.Students)
        {
            Console.WriteLine($"Student: {student.Name}");
        }


        // create branch object
        Branch branch = new Branch("Main Branch", "New York");
        // create employee object
        Employee emp1 = new Employee(1, "John Doe", 30, "Manager");
        Employee emp2 = new Employee(2, "Jane Smith", 25, "Developer");
        // add employees to branch
        branch.AddEmployee(emp1);
        branch.AddEmployee(emp2);
        // display branch information
        Console.WriteLine(branch.ToString());
        // display employee information
        foreach (var emp in branch.employees)
        {
            Console.WriteLine(emp.ToString());
        }
        // create another branch object
        Branch branch2 = new Branch("Secondary Branch", "Los Angeles");
        // create employee object
        Employee emp3 = new Employee(3, "Alice Johnson", 28, "Designer");
        PartTimeEmployee emp4 = new PartTimeEmployee(4, "Bob Brown", 22, "Intern",  20, 35);
        PartTimeEmployee emp5 = new PartTimeEmployee(5, "Charlie Green", 24, "Junior", 15, 40);
        // add employees to branch
        branch2.AddEmployee(emp3);
        branch2.AddEmployee(emp4);
        branch2.AddEmployee(emp5);
        // display branch information
        Console.WriteLine(branch2.ToString());
        // display employee information
        foreach (var emp in branch2.employees)
        {
            Console.WriteLine(emp.ToString());
        }

        
        
        
    }
}