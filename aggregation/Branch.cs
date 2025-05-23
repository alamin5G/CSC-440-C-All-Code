class Branch {
    public string name;
    public string location;
    public List<Employee> employees = new List<Employee>();

  

    public Branch(string name, string location) {
        this.name = name;
        this.location = location;
    }

    public Branch(Employee employee, string name, string location) {
        this.name = name;
        this.location = location;
        employees.Add(employee);
    }

    public void setName(string name) {
        this.name = name;
    }

    public void AddEmployee(Employee employee) {
        employees.Add(employee);
    }
    public void RemoveEmployee(Employee employee) {
        employees.Remove(employee);
    }

    public override string ToString() {
        return $"Branch Name: {name}, Location: {location}, Employees: {employees.Count}";
    }
}