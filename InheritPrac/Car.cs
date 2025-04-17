class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
        Console.WriteLine("Car constructor called");
    }

    public override void DisplayInfo() 
    {
        base.DisplayInfo(); // Call the base class method
        Console.WriteLine($"Doors: {NumberOfDoors}");
    }
}