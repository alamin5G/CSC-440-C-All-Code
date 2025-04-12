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
    }
}