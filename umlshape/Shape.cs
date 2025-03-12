using System;

class Shape{
    private string color;
    private bool filled;
    
    public Shape(){
      //  color = "transparent";
      //  filled = false;
    }

    public string Color{
        get { return color; }
        set { color = value;}
    }

    public bool IsFilled{
        get { return filled; }
        set { filled = value;}
    }

    public virtual double CalculateArea(){
        return 0;
    }
}