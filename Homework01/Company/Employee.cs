using System;

class Employee : Person
{
    public decimal Salary
    {
        get { return _salary; }
    }

    private string position;

    public string Department
    {
        get { return _department; }
    }

    private string email;
    private readonly decimal _salary;
    private readonly string _department;

    private const string DefaultEmail = "n/a";
    private const int DefaultAge = -1;

    public Employee(string name, decimal salary, string position, string department)
        : this(name, salary, position, department, DefaultAge, DefaultEmail)
    { }

    public Employee(string name, decimal salary, string position, string department, int age)
        : this(name, salary, position, department, age, DefaultEmail)
    { }

    public Employee(string name, decimal salary, string position, string department, string email)
        : this(name, salary, position, department, DefaultAge, email)
    { }

    public Employee(string name, decimal salary, string position, string department, int age, string email) : base(name, age)
    {
        this._salary = salary;
        this.position = position;
        this._department = department;
        this.email = email;
    }

    public new void Print()
    {
        Console.WriteLine($"{this.Name} {this.Salary:f2} {this.email} {this.age}");
    }
}

