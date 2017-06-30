using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{
    static void Main()
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();

        DateModifier dates = new DateModifier(date1,date2);

        Console.WriteLine(dates.GetDifference());
    }
}


