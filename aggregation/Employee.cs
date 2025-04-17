class Employee
{
    protected int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public Employee(int id, string name, int age, string position)
    {
        Id = id;
        Name = name;
        Age = age;
        Position = position;
    }

    public override string ToString()
    {
        return $"id: {Id}, Name: {Name}, Age: {Age}, Position: {Position}";
    }
}
