using System;

abstract class Appliance{
    public abstract void turnOn();
    public virtual void turnOff(){
        Console.WriteLine("Turning off the appliance");
    }
}

public interface IControllable{
    void Control();
}

class WashingMachine : Appliance, IControllable{
    public override void turnOn(){
        Console.WriteLine("Washing machine turning on... ");
    }

    public void Control(){
        Console.WriteLine("Controlling washing machine...");
    }

    public override void turnOff(){
        Console.WriteLine("Washing machine turning off... ");
    }
}

class Program{
    static void Main(string[] args){
        WashingMachine appliance = new WashingMachine();
        appliance.turnOn();
        appliance.Control();
        appliance.turnOff();
    }
}