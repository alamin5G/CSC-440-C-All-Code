using System;

class Rectangle: Shape{
    private double width;
    private double length;

    public Rectangle(){
        // width = 1.0;
        // length = 1.0;
    }

    public double Width{
        get { return width;}
        set { width = value;}
    }

    public double Length{
        get { return length;}
        set { length = value;}
    }

    public override double CalculateArea(){
        return width * length;
    }

}