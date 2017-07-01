using System;
using System.Collections.Generic;
using System.Linq;

class Company
{
    private const char DataSeparator = ' ';
    private List<Employee> members;
    private Dictionary<string, decimal> departmentsData;

    public Company()
    {
        members = new List<Employee>();
        departmentsData = new Dictionary<string, decimal>();
    }

    public void AddMember(Employee employee)
    {
        members.Add(employee);
    }

    public void AddMember(string userInput)
    {
        string[] employeeData = userInput.Split(new[] { DataSeparator }, StringSplitOptions.RemoveEmptyEntries);
        Employee employee;

        string name = employeeData[0];
        decimal salary = decimal.Parse(employeeData[1]);
        string position = employeeData[2];
        string department = employeeData[3];

        if (employeeData.Length == 4)
        {
            name = employeeData[0];
            salary = decimal.Parse(employeeData[1]);
            position = employeeData[2];
            department = employeeData[3];

            employee = new Employee(name, salary, position, department);
        }
        else if (employeeData.Length == 5)
        {
            if (employeeData[4].Contains("@"))
            {
                employee = new Employee(name, salary, position, department, employeeData[4]);
            }
            else
            {
                employee = new Employee(name, salary, position, department, int.Parse(employeeData[4]));
            }

        }

        else if (employeeData.Length == 6)
        {
            employee = new Employee(name, salary, position, department, int.Parse(employeeData[5]), employeeData[4]);
        }
        else
        {
            throw new ArgumentException("Incorect user input!");
        }

        this.AddMember(employee);
    }

    public decimal GetAvarageDepartmentSalary(string department)
    {
        return members
            .Where(e => e.Department == department)
            .Select(e => e.Salary)
            .Average();
    }

    private void CalculateDepartmentData()
    {

        foreach (string department in members.Select(e => e.Department).Distinct())
        {
            departmentsData[department] = GetAvarageDepartmentSalary(department);
        }
    }

    public string GetTopDepartmentBySalary()
    {
        CalculateDepartmentData();

        var result = departmentsData
            .Select(d => d.Value)
            .Max(d => d);
        return departmentsData.FirstOrDefault(d => d.Value == result).Key;
    }

    public void PrintDepartment(string departmentName, string criterion = "Department")
    {
        Console.WriteLine($"{criterion}: {departmentName}");
        IEnumerable<Employee> employees = members
            .Where(e => e.Department == departmentName)
            .OrderByDescending(e => e.Salary);
        foreach (Employee employee in employees)
        {
            employee.Print();
        }
    }
}

