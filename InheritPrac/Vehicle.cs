class Vehicle{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Console.WriteLine("Vehicle constructor called");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Year: {Year}, Made by: {Make}, Model: {Model}");
    }
}