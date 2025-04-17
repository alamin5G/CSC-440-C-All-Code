class PartTimeEmployee : Employee
{
    public PartTimeEmployee(int id, string name, int age, string pos, double hourlyRate, int hoursWorked) 
    : base(id, name, age, pos)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override string ToString()
    {
        return base.ToString() + $", Hourly Rate: {HourlyRate}, Hours Worked: {HoursWorked}, Salary: {CalculateSalary()}";
    }
   
}