using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string name;
    public int age;

    public Person()
        :this("No name", 1)
    {
        
    }

    public Person(int age)
        :this("No name", age)
    {
        
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    public void Print()
    {
        Console.WriteLine($"{this.name} - {this.age}");
    }


}
