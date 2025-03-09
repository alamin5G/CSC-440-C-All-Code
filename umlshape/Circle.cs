using System;


class Circle: Shape{
    private double radius;

    public Circle(){
       // radius = 1.0;
    }

    public double Radius{
        get { return radius;}
        set { radius = value;}
    }

    public override double CalculateArea(){
        return Math.PI * radius * radius;
    }
}