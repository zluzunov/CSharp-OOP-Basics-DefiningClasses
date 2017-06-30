using System;

public class Program
{
    static void Main()
    {
        Company company = new Company();

        int employess = int.Parse(Console.ReadLine());

        for (int i = 0; i < employess; i++)
        {
            company.AddMember(Console.ReadLine());
        }

        string topDepartment = company.GetTopDepartmentBySalary();
        company.PrintDepartment(topDepartment, "Highest Average Salary");

    }
}


