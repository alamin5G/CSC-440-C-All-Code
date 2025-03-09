using System;

class Program{
    public static void Main(){
        Circle c = new Circle();
        c.Radius = 2;
        Console.WriteLine("Circle Area: "+c.CalculateArea());

        Rectangle r = new Rectangle();
        r.Width = 5;
        r.Length = 10;
        Console.WriteLine("Rectangle Area: "+r.CalculateArea());

    }
}